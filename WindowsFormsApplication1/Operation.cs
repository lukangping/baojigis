using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Display;

namespace WindowsFormsApplication1
{
    public partial class mainForm : Form
    {

        private void subMenuDisplayEnterprises_Click(object sender, EventArgs e)
        {
            string layerName = axMapControl1.Map.get_Layer(0).Name;
            IPolygon polygon = constructPolygonGeometry();
            addFeature(layerName, polygon as IGeometry);
            //this.axMapControl1.Extent = polygon.Envelope;
            this.axMapControl1.Refresh();
        }

        private IPoint constructPoint(double x, double y)
        {
            IPoint point = new PointClass();
            point.PutCoords(x, y);
            return point;
        }

        private IPolygon constructPolygonGeometry()
        {
            IGeometryCollection geometryCollection = new PolygonClass();

            IPointCollection pointCollection = new RingClass();
            pointCollection.AddPoint(constructPoint(108, 33), Type.Missing, Type.Missing);
            pointCollection.AddPoint(constructPoint(109, 33), Type.Missing, Type.Missing);
            pointCollection.AddPoint(constructPoint(108.5, 34), Type.Missing, Type.Missing);

            geometryCollection.AddGeometry(pointCollection as IGeometry, Type.Missing, Type.Missing);

            return geometryCollection as IPolygon;
        }

        private void addFeature(string layerName, IGeometry geometry)
        {
            ILayer layer = null;
            for (int i = 0; i < axMapControl1.LayerCount; i++)
            {
                if (axMapControl1.get_Layer(i).Name.ToLower() == layerName)
                {
                    layer = axMapControl1.get_Layer(i);
                    break;
                }
            }

            IFeatureLayer featureLayer = layer as IFeatureLayer;
            IFeatureClass featureClass = featureLayer.FeatureClass;

            IDataset dataset = (IDataset)featureClass;
            IWorkspace workspace = dataset.Workspace;
            //开始空间编辑
            IWorkspaceEdit workspaceEdit = (IWorkspaceEdit)workspace;
            workspaceEdit.StartEditing(true);
            workspaceEdit.StartEditOperation();
            IFeatureBuffer featureBuffer = featureClass.CreateFeatureBuffer();
            IFeatureCursor featureCursor;
            //清除图层原有实体对象
            featureCursor = featureClass.Update(null, true);
            IFeature feature;
            feature = featureCursor.NextFeature();
            while (feature != null)
            {
                featureCursor.DeleteFeature();
                feature = featureCursor.NextFeature();
            }
            //开始插入新的实体对象
            featureCursor = featureClass.Insert(true);
            featureBuffer.Shape = geometry;
            object featureOID = featureCursor.InsertFeature(featureBuffer);
            //保存实体
            featureCursor.Flush();
            //结束空间编辑
            workspaceEdit.StopEditOperation();
            workspaceEdit.StopEditing(true);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(featureCursor);
        }

        private void subMenuDisplayLayers_Click(object sender, EventArgs e)
        {
            //获取Featureclass
            IMap pMap;
            pMap = axMapControl1.Map;
            IFeatureLayer pFeatureLayer;
            IFeatureClass pFeatureClass;
            pFeatureLayer = pMap.get_Layer(0) as IFeatureLayer;
            pFeatureClass = pFeatureLayer.FeatureClass;
            IDataset pDataSet = (IDataset)pFeatureClass;
            IWorkspace pWorkSpace = pDataSet.Workspace;
            IWorkspaceEdit pWorkSpaceEdit = (IWorkspaceEdit)pWorkSpace;
            pWorkSpaceEdit.StartEditing(true);
            pWorkSpaceEdit.StartEditOperation();
            //生成椭圆
            double centerX = Convert.ToDouble("108");
            double centerY = Convert.ToDouble("34");
            double Xmax = Convert.ToDouble(centerX) + Convert.ToDouble("109");
            double Xmin = Convert.ToDouble(centerX) - Convert.ToDouble("107");
            double Ymax = Convert.ToDouble(centerY) + Convert.ToDouble("35");
            double Ymin = Convert.ToDouble(centerY) - Convert.ToDouble("33");
            IEnvelope pEnv = new EnvelopeClass();
            pEnv.XMax = Xmax;
            pEnv.XMin = Xmin;
            pEnv.YMax = Ymax;
            pEnv.YMin = Ymin;
            //创建椭圆
            IConstructEllipticArc pConstructEllipse = new EllipticArcClass();
            pConstructEllipse.ConstructEnvelope(pEnv);
            ITransform2D pTransform = pConstructEllipse as ITransform2D;
            IPoint centerpoint = new PointClass();
            centerpoint.PutCoords(centerX, centerY);
            pTransform.Rotate(centerpoint, Convert.ToDouble("2"));
            IEllipticArc pEArc = new EllipticArcClass();
            pEArc = pTransform as IEllipticArc;
            //转换为ring
            ISegmentCollection pSegColl;
            pSegColl = new RingClass();
            object missing = System.Reflection.Missing.Value;
            pSegColl.AddSegment((ISegment)pEArc, ref missing, ref missing);
            IGeometry pGeo = (IGeometry)pSegColl;
            //将椭圆添加到featureclass中
            try
            {  //在要素集上创建要素缓冲区
                IFeatureBuffer pFeatureBuffer = pFeatureClass.CreateFeatureBuffer();
                //创建一个插入游标，设置为可缓冲类型
                IFeatureCursor pFeatureCusor = pFeatureClass.Insert(true);
                //通过IGeometryCollection接口来创建和编辑椭圆
                IGeometryCollection pGeometryCollection;
                pFeatureBuffer.Shape = new PolygonClass();
                pGeometryCollection = (IGeometryCollection)pFeatureBuffer.Shape;
                pGeometryCollection.AddGeometry(pGeo, ref missing, ref missing);
                //将添加在pGeometryCollection中的椭圆添加到featureclass中
                pFeatureBuffer.Shape = (IGeometry)pGeometryCollection;
                pFeatureCusor.InsertFeature(pFeatureBuffer);
                //将pFeatureBuffer中的空间参考设置为地图的空间参考
                pFeatureBuffer.Shape.SpatialReference = pMap.SpatialReference;
                //保存编辑
                pFeatureCusor.Flush();
                axMapControl1.ActiveView.Extent = pEnv;
                axMapControl1.ActiveView.Refresh();
                pWorkSpaceEdit.StopEditOperation();
                pWorkSpaceEdit.StopEditing(true);
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        private void drawSimpleFillSymbol()
        {

            //简单填充符号
            ISimpleFillSymbol simpleFillSymbol = new SimpleFillSymbolClass();
            simpleFillSymbol.Style = esriSimpleFillStyle.esriSFSSolid;
            simpleFillSymbol.Color = getRGB(255, 0, 0);

            //创建边线符号
            ISimpleLineSymbol simpleLineSymbol = new SimpleLineSymbolClass();
            simpleLineSymbol.Style = esriSimpleLineStyle.esriSLSDashDotDot;
            simpleLineSymbol.Color = getRGB(0, 255, 0);
            simpleLineSymbol.Width = 10;
            ISymbol symbol = simpleLineSymbol as ISymbol;
            symbol.ROP2 = esriRasterOpCode.esriROPNotXOrPen;

            simpleFillSymbol.Outline = simpleLineSymbol;
            //创建面对象
            object Missing = Type.Missing;
            IPolygon polygon = new PolygonClass();
            IPointCollection pointCollection = polygon as IPointCollection;
            IPoint point = new PointClass();
            point.PutCoords(108, 34);
            pointCollection.AddPoint(point, ref Missing, ref Missing);
            point.PutCoords(108, 35);
            pointCollection.AddPoint(point, ref Missing, ref Missing);
            point.PutCoords(109, 35);
            pointCollection.AddPoint(point, ref Missing, ref Missing);
            point.PutCoords(109, 34);
            pointCollection.AddPoint(point, ref Missing, ref Missing);
            polygon.SimplifyPreserveFromTo();
            IActiveView activeView = this.axMapControl1.ActiveView;
            activeView.ScreenDisplay.StartDrawing(activeView.ScreenDisplay.hDC, (short)esriScreenCache.esriNoScreenCache);
            activeView.ScreenDisplay.SetSymbol(simpleFillSymbol as ISymbol);
            activeView.ScreenDisplay.DrawPolygon(polygon as IGeometry);
            activeView.ScreenDisplay.FinishDrawing();

        }

        private void drawSimpleMarkerSymbol()
        {
            ISimpleMarkerSymbol iMarkerSymbol;
            ISymbol iSymbol;
            IRgbColor iRgbColor;
            iMarkerSymbol = new SimpleMarkerSymbol();
            iMarkerSymbol.Style = esriSimpleMarkerStyle.esriSMSCircle;
            iRgbColor = new RgbColor();
            iRgbColor = getRGB(100, 100, 100);
            iMarkerSymbol.Color = iRgbColor;
            iSymbol = (ISymbol)iMarkerSymbol;
            iSymbol.ROP2 = esriRasterOpCode.esriROPNotXOrPen;
            IPoint point1 = new PointClass();
            IPoint point2 = new PointClass();
            point1.PutCoords(108, 35);
            point2.PutCoords(109, 34);
            this.axMapControl1.FlashShape(point1 as IGeometry, 3, 200, iSymbol);
            this.axMapControl1.FlashShape(point2);
        }

        private ISymbol getSymbol(string sServerStylePath, string sGalleryClassName, string symbolName)
        {
            try
            {
                // ServerStyleGallery对象
                IStyleGallery pStyleGaller = new ServerStyleGalleryClass();
                IStyleGalleryStorage pStyleGalleryStorage = pStyleGaller as IStyleGalleryStorage;
                IEnumStyleGalleryItem pEnumStyleGalleryItem = null;
                IStyleGalleryItem pStyleGallerItem = null;
                IStyleGalleryClass pStyleGalleryClass = null;
                // 使用IStyleGalleryStorage接口的AddFile方法加载ServerStyle文件
                pStyleGalleryStorage.AddFile(sServerStylePath);
                // 遍历ServerGallery中的Class
                //（因为IStyleGallery  QI到了 IStyleGalleryStorage ，IStyleGalleryStorage加载了文件后，IStyleGallery中就有内容了）
                for (int i = 0; i < pStyleGaller.ClassCount; i++)
                {
                    pStyleGalleryClass = pStyleGaller.get_Class(i);
                    if (pStyleGalleryClass.Name != sGalleryClassName)
                    {
                        continue;
                    }

                    // 获取EnumStyleGalleryItem对象  ,联系之前Rose的代码段
                    pEnumStyleGalleryItem = pStyleGaller.get_Items(sGalleryClassName, sServerStylePath, "");
                    pEnumStyleGalleryItem.Reset();

                    // 遍历pEnumStyleGalleryItem
                    pStyleGallerItem = pEnumStyleGalleryItem.Next();
                    while (pStyleGallerItem != null)
                    {
                        if (pStyleGallerItem.Name == symbolName)
                        {
                            // 获取符号
                            ISymbol pSymbol = pStyleGallerItem.Item as ISymbol;
                            // 释放Com对象？？
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(pEnumStyleGalleryItem);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(pEnumStyleGalleryItem);
                            return pSymbol;
                        }
                        else
                        {
                        }
                        pStyleGallerItem = pEnumStyleGalleryItem.Next();
                    }
                }
                System.Runtime.InteropServices.Marshal.ReleaseComObject(pEnumStyleGalleryItem);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(pStyleGalleryClass);
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private ISimpleMarkerSymbol getSimpleMarkerSymbol()
        {
            ISimpleMarkerSymbol simpleMarkerSymbol = new SimpleMarkerSymbolClass();
            simpleMarkerSymbol.Style = esriSimpleMarkerStyle.esriSMSDiamond;
            simpleMarkerSymbol.Color = getRGB(0, 115, 76);

            return simpleMarkerSymbol;
        }

        private void load_shapefile()
        {
            //1. 创建工作空间工厂
            IWorkspaceFactory shapefileWorkspaceFactory = new ShapefileWorkspaceFactory();

            //2. 打开shapefile工作空间
            string folder = "D:\\projects\\2014_baojigis\\shp_shanxi";
            string fileName = "city_region.shp";
            IWorkspace workspace = shapefileWorkspaceFactory.OpenFromFile(folder, 0);

            //3. 打开要素类
            IFeatureWorkspace featureWorkspace = workspace as IFeatureWorkspace;
            IFeatureClass featureClass = featureWorkspace.OpenFeatureClass(fileName);

            //4. 创建要素图层
            IFeatureLayer featureLayer = new FeatureLayerClass();

            //5. 关联图层和要素类
            featureLayer.FeatureClass = featureClass;
            featureLayer.Name = featureClass.AliasName;
            ILayer layer = featureLayer as ILayer;

            //6. 添加到地图控件中
            IMap map = axMapControl1.Map;
            map.AddLayer(layer);
            axMapControl1.ActiveView.Refresh();
        }



        private void subMenuOpenMap_Click(object sender, EventArgs e)
        {
            //1. 创建工作空间工厂
            IWorkspaceFactory shapefileWorkspaceFactory = new ShapefileWorkspaceFactory();

            //2. 打开shapefile工作空间
            openFileDialog1.Filter = "shapefile(*.shp)|*.shp";
            openFileDialog1.InitialDirectory = @"D:\projects\2014_baojigis\shp_shanxi\";
            openFileDialog1.Multiselect = true;
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return;

            string path = openFileDialog1.FileName;
            string folder = System.IO.Path.GetDirectoryName(path);
            string fileName = System.IO.Path.GetFileName(path);

            System.Diagnostics.Debug.WriteLine(path);
            System.Diagnostics.Debug.WriteLine(folder);
            System.Diagnostics.Debug.WriteLine(fileName);
            IWorkspace workspace = shapefileWorkspaceFactory.OpenFromFile(folder, 0);

            //3. 打开要素类
            IFeatureWorkspace featureWorkspace = workspace as IFeatureWorkspace;
            IFeatureClass featureClass = featureWorkspace.OpenFeatureClass(fileName);

            //4. 创建要素图层
            IFeatureLayer featureLayer = new FeatureLayerClass();

            //5. 关联图层和要素类
            featureLayer.FeatureClass = featureClass;
            featureLayer.Name = featureClass.AliasName;
            ILayer layer = featureLayer as ILayer;

            //6. 添加到地图控件中
            IMap map = axMapControl1.Map;
            map.AddLayer(layer);
            axMapControl1.ActiveView.Refresh();

        }

    }
}
