using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestWF
{
    public partial class EdoUserControl : UserControl
    {
        public EdoUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开指定文件
        /// </summary>
        /// <param name="fileName">文件路径</param>
        public void Open(string fileName)
        {
            try
            {
                //Console.WriteLine("---");
                //Console.WriteLine(fileName);
                axOfficeViewer.Open(fileName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        public void Save()
        {
            axOfficeViewer.Save();
        }

        /// <summary>
        /// 保存文件另存为
        /// </summary>
        public void SaveAs()
        {
            axOfficeViewer.SaveOfficeFileDialog();
        }

        /// <summary>
        /// 打印预览
        /// </summary>
        public void Print()
        {
            axOfficeViewer.PrintPreview();
        }

        /// <summary>
        /// 关闭文档
        /// </summary>
        public void Close()
        {
            axOfficeViewer.Close();
        }

        private void axOfficeViewer_OnFileCommand(object sender, AxOfficeViewer._DOfficeViewerEvents_OnFileCommandEvent e)
        {

        }

       
    }
}
