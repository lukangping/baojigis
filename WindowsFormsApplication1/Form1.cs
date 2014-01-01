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
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Multiselect = false;
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return;

            string path = openFileDialog1.FileName;
            string folder = Path.GetDirectoryName(path);
            string fileName = Path.GetFileName(path);

            //System.Diagnostics.Debug.WriteLine(path);
            //System.Diagnostics.Debug.WriteLine(folder);
            //System.Diagnostics.Debug.WriteLine(fileName);
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
