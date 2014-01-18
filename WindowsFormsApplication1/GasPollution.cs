using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Display;
using WindowsFormsApplication1;
using ESRI.ArcGIS.DataSourcesGDB;

namespace SimpleForm
{
    public partial class GasPollution : Form
    {

        string folder = "D:\\projects\\2014_baojigis\\shp_shanxi";
        string tempShapeFieldName = "gasPollutedArea";

        public GasPollution()
        {
            InitializeComponent();
        }

        private void GasPollution_Load(object sender, EventArgs e)
        {
            load_shapefiles();
        }

        public void load_shapefiles()
        {
            IMap map = axMapControl1.Map;

            IWorkspaceFactory shapefileWorkspaceFactory = new ShapefileWorkspaceFactory();
            IWorkspace workspace = shapefileWorkspaceFactory.OpenFromFile(folder, 0);
            IFeatureWorkspace featureWorkspace = workspace as IFeatureWorkspace;

            //载入底图要素层
            IFeatureLayer featureLayer = new FeatureLayerClass();
            IFeatureClass featureClass = featureWorkspace.OpenFeatureClass("city_region.shp");
            featureLayer.FeatureClass = featureClass;
            featureLayer.Name = featureClass.AliasName;
            map.AddLayer(featureLayer as ILayer);

            //载入污染企业要素层
            IFeatureLayer enterpriseFeatureLayer = new FeatureLayerClass();
            IFeatureClass enterpriseFeatureClass = featureWorkspace.OpenFeatureClass("enterprise_points.shp");
            enterpriseFeatureLayer.FeatureClass = enterpriseFeatureClass;
            enterpriseFeatureLayer.Name = enterpriseFeatureClass.AliasName;

            //符号化
            IGeoFeatureLayer geoFeatureLayer = enterpriseFeatureLayer as IGeoFeatureLayer;
            geoFeatureLayer.Renderer = getSimpleRender() as IFeatureRenderer;
            map.AddLayer(enterpriseFeatureLayer as ILayer);

            axMapControl1.ActiveView.Refresh();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            IPoint point = new PointClass();
            point.PutCoords(108, 34);
            CreateVehicleFeature("gas", point, 2, 1, 0);

            IPoint point2 = new PointClass();
            point2.PutCoords(108, 34);
            CreateVehicleFeature("gas2", point2, 1.5, 0.75, 0);
            //drawElliptic();
        }

        public IConstructEllipticArc CreateElliptic(IPoint centerpoint, double longeraxis, double shorteraxis, double angle)
        {
            double centerx = centerpoint.X;
            double centery = centerpoint.Y;
            double Xmax = centerx + longeraxis;
            double Xmin = centerx - longeraxis;
            double Ymax = centery + shorteraxis;
            double Ymin = centery - shorteraxis;
            IEnvelope pEnv = new EnvelopeClass();
            pEnv.XMax = Xmax;
            pEnv.XMin = Xmin;
            pEnv.YMax = Ymax;
            pEnv.YMin = Ymin;
            pEnv.Width = longeraxis * 2;
            pEnv.Height = shorteraxis * 2;
            //借助旋转        
            IConstructEllipticArc pconstructEllipse = new EllipticArcClass();
            pconstructEllipse.ConstructEnvelope(pEnv);
            ITransform2D pTransform = pconstructEllipse as ITransform2D;
            pTransform.Rotate(centerpoint, angle);
            return pconstructEllipse;
        }

        public void CreateVehicleFeature(string layerName, IPoint point, double longeraxis, double shorteraxis, double angle)
        {
            IFeatureWorkspace pvehicleworkspace = CreateEmptyLayerInmemeory("vehicle", null, 0);//建立内存工作空间
            IFeatureClass pvehicleclass = pvehicleworkspace.OpenFeatureClass("vehicle"); //在之前的CreateEmptyLayerInmemeory方法中已经创建了一个名字为“vehicle”的要素集，这里把其打开
            IFeatureLayer pvehiclelayer = new FeatureLayerClass();
            pvehiclelayer.FeatureClass = pvehicleclass;  //把之前创建的shapefile “pvehicleclass：赋值给新创建的layer类pvehiclelayer
            pvehiclelayer.Name = layerName;
            IDataset pdataset = (IDataset)pvehiclelayer; //创建属性表
            IWorkspaceEdit pworkspaceedit = (IWorkspaceEdit)(pdataset.Workspace);
            pworkspaceedit.StartEditing(true); //allows the application to start and stop edit sessions during which the objects in a geodatabase can be updated. An edit session corresponds to a long transaction.
            pworkspaceedit.StartEditOperation();
            IFeature pthisfeature = pvehicleclass.CreateFeature(); //创建要素 Create a new feature, with a system assigned object ID and null property values. 
            //The new feature is by default assigned a unique object ID (OID). 
            //All other fields are initialized to null values if they can be made null and to built-in default values appropriate to the type of the field if they cannot be made null. 
            //Use the IFeature::Store method to actually store this new feature in the database.
            
            ISegmentCollection pSegmentCollection1 = new PolygonClass();

            IConstructEllipticArc pEllipticArc = CreateElliptic(point, longeraxis, shorteraxis, angle);
            pSegmentCollection1.AddSegment((ISegment)pEllipticArc, Type.Missing, Type.Missing);

            pthisfeature.Shape = (IGeometry)pSegmentCollection1; //赋值，把点空间要素赋值给创建的要素集
            pthisfeature.Store();
            pworkspaceedit.StopEditOperation();
            pworkspaceedit.StopEditing(true);

            ILayerEffects pLayerEffects = pvehiclelayer as ILayerEffects;
            pLayerEffects.Transparency = 30;
            axMapControl1.Map.AddLayer(pvehiclelayer);
        }

        private IPoint constructPoint(double x, double y)
        {
            IPoint point = new PointClass();
            point.PutCoords(x, y);
            return point;
        }

        private IFeatureWorkspace CreateEmptyLayerInmemeory(string slayername, ESRI.ArcGIS.Geometry.ISpatialReference pspatialreference, int itype)
        {
            //打开工作空间
            IWorkspaceFactory memoryWorkspaceFactory = new InMemoryWorkspaceFactoryClass();
            IWorkspaceName workspaceName = memoryWorkspaceFactory.Create("", "tempMemoryWorkspace", null, 0);
            IName wsname = (IName)workspaceName;
            IFeatureWorkspace pfeatureworkspace = (IFeatureWorkspace)(wsname.Open()); //打开刚建立的内存空间
            try
            {
                //为esriFieldTypeGeometry类型的字段创建几何定义，包括类型和空间参照 
                IGeometryDef pGeoDef = new GeometryDefClass();     //The geometry definition for the field if IsGeometry is TRUE.
                IGeometryDefEdit pGeoDefEdit = (IGeometryDefEdit)pGeoDef;
                pGeoDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolygon;
               
                ISpatialReferenceFactory3 pspatialRefFac = new SpatialReferenceEnvironmentClass();
                ISpatialReference pspatialRef = pspatialRefFac.CreateGeographicCoordinateSystem((int)esriSRGeoCSType.esriSRGeoCS_WGS1984);//定义的为WGS84的空间地理坐标系
                pspatialRef.SetDomain(-180, 180, -90, 90);//这里一定要加域值的设置！
                pGeoDefEdit.SpatialReference_2 = pspatialRef;

                //设置字段集
                IFields pFields = new FieldsClass();
                IFieldsEdit pFieldsEdit = (IFieldsEdit)pFields;
                //设置字段
                IField pField = new FieldClass();
                IFieldEdit pFieldEdit = (IFieldEdit)pField;
                //创建类型为几何类型的字段0
                pFieldEdit.Name_2 = tempShapeFieldName;
                pFieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;//esriFieldTypeGeometry;
                pFieldEdit.GeometryDef_2 = pGeoDef;
                pFieldsEdit.AddField(pField);

                //创建shapefile
                IFeatureClass pfclass = pfeatureworkspace.CreateFeatureClass(slayername, pFields, null, null, esriFeatureType.esriFTSimple, tempShapeFieldName, "");//这一句老是出问题！最后的解决方案是：原来之前设定的坐标系统没有添加域！
                IDataset pdataset = (IDataset)pfclass; // 创建geodatabase属性表
                pdataset.BrowseName = slayername;
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
            return pfeatureworkspace;
        }
    }
}
