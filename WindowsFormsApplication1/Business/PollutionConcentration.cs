using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SimpleForm;
using TestWF;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.GeoAnalyst;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.AnalysisTools;

namespace WindowsFormsApplication1
{
    public class PollutionConcentration
    {
        public double M;//污染物排放质量（Kg）
        public double H;//平均水深（m）
        public double x;//河流横向距离（m）
        public double y;//河流纵向距离（m）
        public int t;//预测时间（S）
        public double Ex;//河流横向弥撒系数（m2/s）
        public double Ey;//河流纵向弥撒系数(m2/s)
        public double Ux;//河流在x方向上的流速分量(m/s)
        public double Uy;//河流在y方向上的流速分量(m/s)
        public double K;//河流降解系数（/d）

        public PollutionConcentration()
        {
            Console.WriteLine(Math.Exp(0));
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(4));

            Console.WriteLine(-2 / 2 - 3 / 3);

        }

        public PollutionConcentration(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //public PollutionConcentration(double M, double H, double x, double y, int t, double Ex, double Ey, double Ux, double Uy, double K)
        //{
        //    this.M = M;
        //    this.H = H;
        //    this.x = x;
        //    this.y = y;
        //    this.t = t;
        //    this.Ex = Ex;
        //    this.Ey = Ey;
        //    this.Ux = Ux;
        //    this.Uy = Uy;
        //    this.K = K;
        //}

        public double calculate()
        {
            //M = 20000;
            //H = 2;
            //Ex = 86;
            //Ey = 0.089;
            //Ux = 0.98;
            //Uy = 0;
            //t = 100;
            //K = 0.12;

            M = 10000;
            H = 15;
            Ex = 20;
            Ey = 15;
            Ux = 2.5;
            Uy = 0.2;
            t = 300;
            K = 0.0001;

            double C = 2000 * M / (4 * Math.PI * H * t * Math.Sqrt(Ex * Ey));
            C = C * Math.Exp(- Math.Pow((x - Ux * t), 2) / (4 * Ex * t) - Math.Pow((y - Uy * t), 2) / (4 * Ey * t));
            C = C * Math.Exp(- K * x);

            //Console.WriteLine(C);
            //Console.WriteLine(C2);
            //Console.WriteLine(Math.Exp(-K * x));

            return C;
        }

    }
}
