“打开文件夹即可获取一个Workspace；打开其中的某个shapefile文件，即可得到FeatureClass。”

“工作空间是由数据集组成，每个要素图层对象都有一个要素类FeatureClass，该要素类由图层中所有Feature组成。”

“在开始数据编辑前，需要先获取图层的要素类FeatureClass，可以通过要素图层的FeatureClass属性返回该要素类，获取到要素类之后将要素类转为IDataset集合，该接口提供了工作空间的获取，通过接口的Workspace属性可以获取到要素类的工作空间。”