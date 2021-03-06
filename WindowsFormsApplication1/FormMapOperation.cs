﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
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
    public partial class FormMapOperation : Form
    {
        string folder = "D:\\projects\\2014_baojigis\\shapefiles";

        public FormMapOperation()
        {
            //加入下面一行的代码，用来解决"ArcGIS version not specified."的异常
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            InitializeComponent();
        }

        private void mapOperation_Load(object sender, EventArgs e)
        {
            load_shapefiles();
            loadEagleEye();
        }

        public void load_shapefiles()
        {
            IMap map = axMapControl1.Map;

            IWorkspaceFactory shapefileWorkspaceFactory = new ShapefileWorkspaceFactory();
            IWorkspace workspace = shapefileWorkspaceFactory.OpenFromFile(folder, 0);
            IFeatureWorkspace featureWorkspace = workspace as IFeatureWorkspace;

            //载入底图要素层
            IFeatureLayer featureLayer = new FeatureLayerClass();
            IFeatureClass featureClass = featureWorkspace.OpenFeatureClass("city_region_wgs1984.shp");
            featureLayer.FeatureClass = featureClass;
            featureLayer.Name = featureClass.AliasName;
            map.AddLayer(featureLayer as ILayer);

            //载入污染企业要素层
            //IFeatureLayer enterpriseFeatureLayer = new FeatureLayerClass();
            //IFeatureClass enterpriseFeatureClass = featureWorkspace.OpenFeatureClass("enterprise_points.shp");
            //enterpriseFeatureLayer.FeatureClass = enterpriseFeatureClass;
            //enterpriseFeatureLayer.Name = enterpriseFeatureClass.AliasName;

            //符号化
            //IGeoFeatureLayer geoFeatureLayer = enterpriseFeatureLayer as IGeoFeatureLayer;
            //geoFeatureLayer.Renderer = getSimpleRender() as IFeatureRenderer;
            //map.AddLayer(enterpriseFeatureLayer as ILayer);

            axMapControl1.ActiveView.Refresh();

            //test shapefile to raster
            //Console.WriteLine("---toRaster---");
            //RasterDatasetOperation rasterDatasetOperation = new RasterDatasetOperation();
            //rasterDatasetOperation.toRasterDataset(featureLayer);
            //Console.WriteLine("---toPointFeature---");
            //rasterDatasetOperation.toFeatureData();
            //Console.WriteLine("---toCreateThieseenPloygon---");
            //rasterDatasetOperation.createThiessenPolygon(featureLayer);
        }

        private ISimpleRenderer getSimpleRender()
        {
            ISimpleRenderer simpleRender = new SimpleRendererClass();

            ISimpleMarkerSymbol simpleMarkerSymbol = new SimpleMarkerSymbolClass();
            simpleMarkerSymbol.Outline = false;
            simpleMarkerSymbol.Color = getRGB(0, 168, 132);
            simpleMarkerSymbol.Size = 10;
            simpleMarkerSymbol.Style = esriSimpleMarkerStyle.esriSMSDiamond;

            simpleRender.Symbol = simpleMarkerSymbol as ISymbol;

            return simpleRender;
        }

        private IRgbColor getRGB(int r, int g, int b)
        {
            IRgbColor pColor;
            pColor = new RgbColorClass();
            pColor.Red = r;
            pColor.Green = g;
            pColor.Blue = b;
            return pColor;
        }

        private void loadEagleEye()
        {
            //当主地图显示控件的地图更换时，鹰眼中的地图也跟随更换
            this.axMapControl2.Map = new MapClass();
            //添加主地图控件中的所有图层到鹰眼控件中
            for (int i = 1; i <= this.axMapControl1.LayerCount; i++)
            {
                this.axMapControl2.AddLayer(this.axMapControl1.get_Layer(this.axMapControl1.LayerCount - i));
            }
            //设置MapControl显示范围至数据的全局范围
            this.axMapControl2.Extent = this.axMapControl1.FullExtent;
            //刷新鹰眼控件地图
            this.axMapControl2.Refresh();
        }

        private void axMapControl1_OnExtentUpdated(object sender, IMapControlEvents2_OnExtentUpdatedEvent e)
        {
            // 得到新范围
            IEnvelope pEnv = (IEnvelope)e.newEnvelope;
            IGraphicsContainer pGra = axMapControl2.Map as IGraphicsContainer;
            IActiveView pAv = pGra as IActiveView;
            //在绘制前，清除axMapControl2中的任何图形元素
            pGra.DeleteAllElements();
            IRectangleElement pRectangleEle = new RectangleElementClass();
            IElement pEle = pRectangleEle as IElement;
            pEle.Geometry = pEnv;
            //设置鹰眼图中的红线框
            IRgbColor pColor = new RgbColorClass();
            pColor.Red = 255;
            pColor.Green = 0;
            pColor.Blue = 0;
            pColor.Transparency = 255;
            //产生一个线符号对象
            ILineSymbol pOutline = new SimpleLineSymbolClass();
            pOutline.Width = 2;
            pOutline.Color = pColor;
            //设置颜色属性
            pColor = new RgbColorClass();
            pColor.Red = 255;
            pColor.Green = 0;
            pColor.Blue = 0;
            pColor.Transparency = 0;
            //设置填充符号的属性
            IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
            pFillSymbol.Color = pColor;
            pFillSymbol.Outline = pOutline;
            IFillShapeElement pFillShapeEle = pEle as IFillShapeElement;
            pFillShapeEle.Symbol = pFillSymbol;
            pGra.AddElement((IElement)pFillShapeEle, 0);
            //刷新
            pAv.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        }

        private void axMapControl2_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            if (this.axMapControl2.Map.LayerCount != 0)
            {
                //按下鼠标左键移动矩形框
                if (e.button == 1)
                {
                    IPoint pPoint = new PointClass();
                    pPoint.PutCoords(e.mapX, e.mapY);
                    IEnvelope pEnvelope = this.axMapControl1.Extent;
                    pEnvelope.CenterAt(pPoint);
                    this.axMapControl1.Extent = pEnvelope;
                    this.axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
                }
                //按下鼠标右键绘制矩形框
                else if (e.button == 2)
                {
                    IEnvelope pEnvelop = this.axMapControl2.TrackRectangle();
                    this.axMapControl1.Extent = pEnvelop;
                    this.axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
                }
            }
        }

        private void axMapControl2_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            //如果不是左键按下就直接返回
            if (e.button != 1) return;
            IPoint pPoint = new PointClass();
            pPoint.PutCoords(e.mapX, e.mapY);
            this.axMapControl1.CenterAt(pPoint);
            this.axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
        }

        public void searchEnterprise(string where)
        {
            IFeatureLayer flyr = (IFeatureLayer)axMapControl1.get_Layer(0);

            IQueryFilter queryFilter = new QueryFilterClass();
            queryFilter.WhereClause = where;

            ISimpleMarkerSymbol simpleMarkerSymbol = new SimpleMarkerSymbolClass();
            simpleMarkerSymbol.Outline = true;
            simpleMarkerSymbol.OutlineColor = getRGB(0, 0, 0);
            simpleMarkerSymbol.Color = getRGB(0, 94, 76);
            simpleMarkerSymbol.Size = 10;
            simpleMarkerSymbol.Style = esriSimpleMarkerStyle.esriSMSDiamond;

            //选取要素集
            IFeatureSelection pFtSelection = flyr as IFeatureSelection;
            pFtSelection.SetSelectionSymbol = true;
            pFtSelection.SelectionSymbol = (ISymbol)simpleMarkerSymbol;
            pFtSelection.SelectFeatures(queryFilter, esriSelectionResultEnum.esriSelectionResultNew, false);

            axMapControl1.ActiveView.Refresh();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string enterpriseName = textBoxSearchName.Text;
            searchEnterprise("Name like '%" + enterpriseName + "%'");
        }

        private void textBoxSearchName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxSearchName.Text=="请输入企业名称")
            {
                textBoxSearchName.Text = ""; 
            }
        }

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuGasAnalyse_Click(object sender, EventArgs e)
        {
            Form newMDIChild = new Form();
            // Set the parent form of the child window.
            //newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            IArray pIDArray;
            IFeatureIdentifyObj pFeatIdObj;
            IIdentifyObj pIdObj;

            IFeatureLayer pLayer = axMapControl1.get_Layer(0) as IFeatureLayer;
            IIdentify pIdentify;
            pIdentify = (IIdentify)axMapControl1.get_Layer(0);
            IEnvelope pEnv;
            IActiveView pActiveView = axMapControl1.ActiveView;
            IMap pMap = axMapControl1.Map;
            pEnv = axMapControl1.TrackRectangle();

            IFeatureClass pFC = pLayer.FeatureClass;
            pLayer.Name = pFC.AliasName;
            ILayerFields pLayerFields = pLayer as ILayerFields;

            if (pEnv.IsEmpty == true)
            {
                tagRECT r;
                r.bottom = e.y + 5;
                r.top = e.y - 5;
                r.left = e.x - 5;
                r.right = e.x + 5;
                pActiveView.ScreenDisplay.DisplayTransformation.TransformRect(pEnv, ref r, 4);
                pEnv.SpatialReference = pActiveView.FocusMap.SpatialReference;
            }
            //pMap.SelectByShape(pEnv, null, false);
            //pActiveView.Refresh();

            pIDArray = pIdentify.Identify(pEnv);
            if (pIDArray != null)
            {
                for (int i = 0; i < pIDArray.Count; i++)
                {
                    pFeatIdObj = (IFeatureIdentifyObj)pIDArray.get_Element(i);
                    pIdObj = (IIdentifyObj)pFeatIdObj;
                    IRowIdentifyObject pRowObj = pFeatIdObj as IRowIdentifyObject;
                    IFeature pFeature = pRowObj.Row as IFeature;

                    //弹出气泡
                    axMapControl1.ActiveView.GraphicsContainer.DeleteAllElements();
                    ITextElement te = createTextElement(e.mapX, e.mapY, pFeature.get_Value(3).ToString());
                    axMapControl1.ActiveView.GraphicsContainer.AddElement(te as IElement, 0);
                    axMapControl1.Refresh(esriViewDrawPhase.esriViewGraphics, null, null);
                    
                    unqiueRender(pFeature, pLayer as IGeoFeatureLayer);
                }
                pEnv = null;

            }
        }

        private IBalloonCallout createBalloonCallout(double x, double y)
        {
            IRgbColor rgb = new RgbColorClass();
            {
                rgb.Red = 255;
                rgb.Green = 255;
                rgb.Blue = 255;

            }
            ISimpleFillSymbol sfs = new SimpleFillSymbolClass();
            {
                sfs.Color = rgb;
                sfs.Style = esriSimpleFillStyle.esriSFSSolid;
            }

            IPoint p = new PointClass();
            {
                p.PutCoords(x, y);
            }

            IBalloonCallout bc = new BalloonCalloutClass();
            {
                bc.Style = esriBalloonCalloutStyle.esriBCSRoundedRectangle;
                bc.Symbol = sfs;
                bc.LeaderTolerance = 5;
                bc.AnchorPoint = p;
            }

            return bc;
        }

        public ITextElement createTextElement(double x, double y, string text)
        {
            IBalloonCallout bc = createBalloonCallout(x, y);

            IRgbColor rgb = new RgbColorClass();
            {
                rgb.Blue = 105;
                rgb.Red = 105;
                rgb.Green = 105;
            }
            ITextSymbol ts = new TextSymbolClass();
            {
                ts.Color = rgb;
            }

            IFormattedTextSymbol fts = ts as IFormattedTextSymbol;
            {
                fts.Background = bc as ITextBackground;
            }
            ts.Size = 9;

            IPoint point = new PointClass();
            {
                double width = axMapControl1.Extent.Width / 18;
                double height = axMapControl1.Extent.Height / 36;
                point.PutCoords(x + width, y + height);
            }

            ITextElement te = new TextElementClass();
            {
                te.Symbol = ts;
                te.Text = text;
            }

            IElement e = te as IElement;
            {
                e.Geometry = point;
            }
            return te;

        }

        public void unqiueRender(IFeature feature, IGeoFeatureLayer layer)
        {
            IUniqueValueRenderer uniqueValueRenderer = new UniqueValueRendererClass();
            uniqueValueRenderer.FieldCount = 1;
            uniqueValueRenderer.set_Field(0, "FID");

            ISimpleMarkerSymbol simpleMarkerSymbol1 = new SimpleMarkerSymbolClass();
            simpleMarkerSymbol1.Outline = false;
            simpleMarkerSymbol1.Color = getRGB(0, 168, 132);
            simpleMarkerSymbol1.Size = 10;
            simpleMarkerSymbol1.Style = esriSimpleMarkerStyle.esriSMSDiamond;
            uniqueValueRenderer.DefaultSymbol = simpleMarkerSymbol1 as ISymbol;
            uniqueValueRenderer.UseDefaultSymbol = true;

            ISimpleMarkerSymbol simpleMarkerSymbol = new SimpleMarkerSymbolClass();
            simpleMarkerSymbol.Outline = true;
            simpleMarkerSymbol.OutlineColor = getRGB(0, 0, 0);
            simpleMarkerSymbol.Color = getRGB(0, 94, 76);
            simpleMarkerSymbol.Size = 10;
            simpleMarkerSymbol.Style = esriSimpleMarkerStyle.esriSMSDiamond;

            uniqueValueRenderer.AddValue(feature.get_Value(0).ToString(), "FID", simpleMarkerSymbol as ISymbol);
            layer.Renderer = uniqueValueRenderer as IFeatureRenderer;

            axMapControl1.ActiveView.Refresh();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void axToolbarControl1_OnMouseDown(object sender, IToolbarControlEvents_OnMouseDownEvent e)
        {

        }

    }
}