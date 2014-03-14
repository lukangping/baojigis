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

namespace SimpleForm
{
    public partial class FormWaterPollution : Form
    {
        public FormWaterPollution()
        {
            InitializeComponent();
            Console.WriteLine("---");
        }

        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {

        }

        private void FormWaterPollution_Load(object sender, EventArgs e)
        {
            string folder = "D:\\projects\\2014_baojigis\\shapefiles";

            IMap map = axMapControl1.Map;

            IWorkspaceFactory shapefileWorkspaceFactory = new ShapefileWorkspaceFactory();
            IWorkspace workspace = shapefileWorkspaceFactory.OpenFromFile(folder, 0);
            IFeatureWorkspace featureWorkspace = workspace as IFeatureWorkspace;

            //载入底图要素层
            IFeatureLayer featureLayer = new FeatureLayerClass();
            IFeatureClass featureClass = featureWorkspace.OpenFeatureClass("river_thiessen_inter_mer.shp");
            featureLayer.FeatureClass = featureClass;
            featureLayer.Name = featureClass.AliasName;
            map.AddLayer(featureLayer as ILayer);

            axMapControl1.ActiveView.Refresh();

            IFeatureCursor cursor = featureClass.Update(null, false);
            IFields fields = cursor.Fields;
            int fieldIndex = fields.FindField("con");
            IFeature feature = cursor.NextFeature();
            while (feature != null)
            {

                IGeometry geometryShape = feature.Shape;
                IArea area = (IArea)geometryShape;

                double centerX = area.Centroid.X;
                double centerY = area.Centroid.Y;
                //污染源在河中心
                if (centerX > 11950177.803)
                {
                    PollutionConcentration pc = new PollutionConcentration(centerX - 11951177.803, 4074439.628 - centerY);
                    feature.set_Value(fieldIndex, pc.calculate());
                }
                //污染源在岸边
                //if (centerX > 11962871.76)
                //{
                //    PollutionConcentration pc = new PollutionConcentration(centerX - 11963871.76, 4073353.205 - centerY);
                //    feature.set_Value(fieldIndex, pc.calculate());
                //}
                //污染源在分叉口
                //if (centerX > 11974086.428)
                //{
                //    PollutionConcentration pc = new PollutionConcentration(centerX - 11975086.428, 4068539.894 - centerY);
                //    feature.set_Value(fieldIndex, pc.calculate());
                //}
                //模拟倾斜-30度
                //if (centerX > 11962871.76)
                //{
                //    PollutionConcentration pc = new PollutionConcentration(getNewX(11963871.76, 4073353.205, centerX, centerY), getNewY(11963871.76, 4073353.205, centerX, centerY));
                //}
                else
                {
                    feature.set_Value(fieldIndex, 0);
                }

                //Console.WriteLine(area.Centroid.X);
                //Console.WriteLine(area.Centroid.Y);
                //Console.WriteLine(feature.Fields.get_Field(0).ToString());
                cursor.UpdateFeature(feature);
                feature = cursor.NextFeature();

            }

            setClassBreakRender();
        }

        private double getNewX(double x, double y, double a, double b)
        {
            return x * Math.Cos(-30) + y * Math.Sin(-30) - a * Math.Cos(-30) - b * Math.Sin(-30);
        }

        private double getNewY(double x, double y, double a, double b)
        {
            return -x * Math.Sin(-30) + y * Math.Cos(-30) + a * Math.Sin(-30) - b * Math.Cos(-30);
        }


        private void setClassBreakRender()
        {
            IEnumColors colors = createAlgorithmicColorRamp(4).Colors;

            IClassBreaksRenderer classBreaksRender = new ClassBreaksRendererClass();
            classBreaksRender.Field = "con";
            classBreaksRender.BreakCount = 4;
            classBreaksRender.SortClassesAscending = true;

            ISimpleFillSymbol simpleFillSymbol = new SimpleFillSymbolClass();
            simpleFillSymbol.Color = colors.Next();
            simpleFillSymbol.Style = esriSimpleFillStyle.esriSFSSolid;
            classBreaksRender.set_Symbol(0, simpleFillSymbol as ISymbol);
            classBreaksRender.set_Break(0, 0);

            ISimpleFillSymbol simpleFillSymbol1 = new SimpleFillSymbolClass();
            simpleFillSymbol1.Color = colors.Next();
            simpleFillSymbol1.Style = esriSimpleFillStyle.esriSFSSolid;
            classBreaksRender.set_Symbol(1, simpleFillSymbol1 as ISymbol);
            classBreaksRender.set_Break(1, 0.0001);

            ISimpleFillSymbol simpleFillSymbol2 = new SimpleFillSymbolClass();
            simpleFillSymbol2.Color = colors.Next();
            simpleFillSymbol2.Style = esriSimpleFillStyle.esriSFSSolid;
            classBreaksRender.set_Symbol(2, simpleFillSymbol2 as ISymbol);
            classBreaksRender.set_Break(2, 0.1);

            ISimpleFillSymbol simpleFillSymbol3 = new SimpleFillSymbolClass();
            simpleFillSymbol3.Color = colors.Next();
            simpleFillSymbol3.Style = esriSimpleFillStyle.esriSFSSolid;
            classBreaksRender.set_Symbol(3, simpleFillSymbol3 as ISymbol);
            classBreaksRender.set_Break(3, 10000);

            ILayer layer = axMapControl1.get_Layer(0);
            IGeoFeatureLayer geoFeatureLayer = layer as IGeoFeatureLayer;

            geoFeatureLayer.Renderer = classBreaksRender as IFeatureRenderer;

            this.axMapControl1.ActiveView.Refresh();


        }

        //创建颜色带
        private IColorRamp createAlgorithmicColorRamp(int count)
        {
            IAlgorithmicColorRamp algorithmicColorRamp = new AlgorithmicColorRampClass();
            IRgbColor fromColor = new RgbColorClass();
            IRgbColor toColor = new RgbColorClass();

            fromColor.Red = 255;
            fromColor.Green = 255;
            fromColor.Blue = 255;

            toColor.Red = 0;
            toColor.Green = 0;
            toColor.Blue = 255;

            algorithmicColorRamp.FromColor = fromColor;
            algorithmicColorRamp.ToColor = toColor;

            algorithmicColorRamp.Algorithm = esriColorRampAlgorithm.esriCIELabAlgorithm;
            algorithmicColorRamp.Size = count;
            bool bture = true;
            algorithmicColorRamp.CreateRamp(out bture);

            return algorithmicColorRamp;
        }

        private void addConcentrationField(IFeatureClass featureClass)
        {
            IClass fClass = featureClass as IClass;

            //IFieldsEdit fieldsEdit = fClass.Fields as IFieldsEdit;
            IField field = new FieldClass();
            IFieldEdit2 fieldEdit = field as IFieldEdit2;
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeDouble;
            fieldEdit.Name_2 = "XXX";
            fClass.AddField(field);
        }

    }
}
