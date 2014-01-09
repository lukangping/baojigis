using System;
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
    public partial class mainForm : Form
    {
        string folder = "D:\\projects\\2014_baojigis\\shp_shanxi";

        public mainForm()
        {
            //加入下面一行的代码，用来解决"ArcGIS version not specified."的异常
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            load_shapefiles();
        }

        private void load_shapefiles()
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
            ICharacterMarkerSymbol characterMarkerSymbol = new CharacterMarkerSymbolClass();
            characterMarkerSymbol.CharacterIndex = 35;
            characterMarkerSymbol.Color = getRGB(0, 115, 76);
            characterMarkerSymbol.Size = 20;
            simpleRender.Symbol = characterMarkerSymbol as ISymbol;

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


    }
}
