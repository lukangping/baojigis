using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;

namespace WindowsFormsApplication1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            //加入下面一行的代码，用来解决"ArcGIS version not specified."的异常
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            InitializeComponent();
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

        private void mainForm_Load(object sender, EventArgs e)
        {
            load_shapefile();
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

       

        private IPolygon constructPolygon(List<IRing> ringList)
        {
            IGeometryCollection pGeometryCollection = new PolygonClass();
            object o = Type.Missing;

            for (int i = 0; i < ringList.Count; i++)
            {
                pGeometryCollection.AddGeometry(ringList[i], ref o, ref o);
            }

            ITopologicalOperator topological = pGeometryCollection as ITopologicalOperator;
            topological.Simplify();

            IPolygon polygon = pGeometryCollection as IPolygon;

            return polygon;
        }

        private void subMenuDisplayEnterprises_Click(object sender, EventArgs e)
        {
            string layerName = axMapControl1.Map.get_Layer(0).Name;
     
            IPolygon polygon = constructPolygonGeometry();
            
            Console.WriteLine(polygon);

            addFeature(layerName, polygon as IGeometry);
            this.axMapControl1.Extent = polygon.Envelope;
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

            Console.WriteLine(featureClass.FeatureType);
            Console.WriteLine(featureClass.FeatureType.ToString());

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
    }
}
