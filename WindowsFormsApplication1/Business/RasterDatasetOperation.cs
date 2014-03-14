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
    public class RasterDatasetOperation
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public void toRasterDataset(IFeatureLayer featureLayer)
        {
            IFeatureClass featureClass = featureLayer.FeatureClass;

            IFeatureClassDescriptor featureClassDescriptor = new FeatureClassDescriptorClass();
            featureClassDescriptor.Create(featureClass, null, "fid");

            IGeoDataset geoDataset = featureClassDescriptor as IGeoDataset;
            string outPutPath = @"D:\projects\2014_baojigis\rasterfiles";

            IWorkspaceFactory workspaceFactory = new RasterWorkspaceFactoryClass();
            IWorkspace workspace = workspaceFactory.OpenFromFile(outPutPath, 0);
            IConversionOp conversionOp = new RasterConversionOpClass();
            IRasterAnalysisEnvironment rasterAnalysisEnvironment = conversionOp as IRasterAnalysisEnvironment;

            double dCellSize = 0.0003;
            object oCellSize = dCellSize as object;

            rasterAnalysisEnvironment.SetCellSize(esriRasterEnvSettingEnum.esriRasterEnvValue, ref oCellSize);
            IRasterDataset rasterDataset = conversionOp.ToRasterDataset(geoDataset, "GRID", workspace, "NewRaster");

        }

        public void toFeatureData()
        {
            IConversionOp convesionOp = new RasterConversionOpClass();
            IWorkspaceFactory workspaceFactory = new RasterWorkspaceFactoryClass();

            string filePath = @"D:\projects\2014_baojigis\rasterfiles";
            IRasterWorkspace2 rasterWorkspace = workspaceFactory.OpenFromFile(filePath, 0) as IRasterWorkspace2;
            RasterDataset rasterDataset = (RasterDataset)rasterWorkspace.OpenRasterDataset(@"\NewRaster");

            //IRasterLayer rasterLayer = new RasterLayerClass();
            //rasterLayer.CreateFromDataset(rasterDataset);
            //IRaster raster = rasterLayer.Raster;

            IWorkspaceFactory featureWorkspaceFactory = new ShapefileWorkspaceFactory();
            IWorkspace workspace = featureWorkspaceFactory.OpenFromFile( @"D:\projects\2014_baojigis\shapefiles", 0);
            string outFeatureClassName = "NewShapefile.shp";
            IGeoDataset geoDataset = convesionOp.RasterDataToPointFeatureData(rasterDataset as IGeoDataset, workspace, outFeatureClassName);

        }

        public void createThiessenPolygon(IFeatureLayer featureLayer)
        {

            Geoprocessor gp = new Geoprocessor();
            gp.OverwriteOutput = true;
            //gp.SetEnvironmentValue("workspace", "workspacename");
            //gp.SetEnvironmentValue("extent", "all");
            CreateThiessenPolygons createthiessenpolygon = new CreateThiessenPolygons(@"D:\projects\2014_baojigis\shapefiles\NewShapefile.shp", "D:\\projects\\2014_baojigis\\shapefiles\\river_thiessen.shp");
            //CreateThiessenPolygons createthiessenpolygon = new CreateThiessenPolygons();
            //createthiessenpolygon.in_features = featureLayer;
            //createthiessenpolygon.out_feature_class = @"D:\projects\2014_baojigis\shapefiles\NewCTP.shp";
            createthiessenpolygon.fields_to_copy = "ALL";
            gp.Execute(createthiessenpolygon, null);
            
        }
    }
}
