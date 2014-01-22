using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace SimpleForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuUseMap_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                Console.WriteLine(childForm.Name);
                if (childForm.Name == "MapOperation")
                {
                    Console.WriteLine("no new.");
                    childForm.Visible = true;
                    childForm.Activate();
                    return;
                }

            }

            Console.WriteLine("new");
            MapOperation mapOperationForm = new MapOperation();
            // 在显示该窗体前使其成为此 MDI 窗体的子窗体。
            mapOperationForm.MdiParent = this;
            mapOperationForm.WindowState = FormWindowState.Maximized;
            mapOperationForm.Name = "MapOperation";
            mapOperationForm.Show();
        }

        private void menuGasAnalyse_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Name == "GasPollution")
                {
                    Console.WriteLine("no new.");
                    childForm.Visible = true;
                    childForm.Activate();
                    return;
                }

            }

            GasPollution gasPollutionForm = new GasPollution();
            // 在显示该窗体前使其成为此 MDI 窗体的子窗体。
            gasPollutionForm.MdiParent = this;
            gasPollutionForm.WindowState = FormWindowState.Maximized;
            gasPollutionForm.Name = "GasPollution";
            gasPollutionForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Name == "MapOperation")
                {
                    Console.WriteLine("no new.");
                    childForm.Visible = true;
                    childForm.Activate();
                    return;
                }

            }

            MapOperation mapOperationForm = new MapOperation();
            // 在显示该窗体前使其成为此 MDI 窗体的子窗体。
            mapOperationForm.MdiParent = this;
            mapOperationForm.WindowState = FormWindowState.Maximized;
            mapOperationForm.Name = "MapOperation";
            mapOperationForm.Show();
        }

        private void menuManageEnterprise_Click(object sender, EventArgs e)
        {
           
        }

        private void 企业录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Name == "EnterpriseManagement")
                {
                    Console.WriteLine("no new.");
                    childForm.Visible = true;
                    childForm.Activate();
                    return;
                }

            }

            EnterpriseManagement enterpriseManagement = new EnterpriseManagement();

            // 在显示该窗体前使其成为此 MDI 窗体的子窗体。
            enterpriseManagement.MdiParent = this;
            enterpriseManagement.WindowState = FormWindowState.Maximized;
            enterpriseManagement.Name = "EnterpriseManagement";
            enterpriseManagement.Show();
        }
    }
}
