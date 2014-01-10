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
using ESRI.ArcGIS.esriSystem;

namespace WindowsFormsApplication1
{
    public partial class mainForm
    {
        private void zoomToSelectedFeature()
        {
            //符号边线颜色
            ILineSymbol lineSymbol = new SimpleLineSymbolClass();
            lineSymbol.Color = getRGB(0, 0, 0);
            lineSymbol.Width = 5;

            //填充符号
            ISimpleFillSymbol simpleFillSymbol = new SimpleFillSymbolClass();
            simpleFillSymbol.Outline = lineSymbol;
            simpleFillSymbol.Color = getRGB(0, 94, 76);


        }

        
    }
}
