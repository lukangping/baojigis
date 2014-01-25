using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1;
using EnvironmentSystem;

namespace SimpleForm
{
    public partial class MainForm :Form
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

        private void subMenuPollutionEmission_Click(object sender, EventArgs e)
        {
            
        }

        private void subMenuPollutionControl_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Name == "FormPollutionControl")
                {
                    Console.WriteLine("no new.");
                    childForm.Visible = true;
                    childForm.Activate();
                    return;
                }

            }

            FormPollutionDispose formPollutionControl = new FormPollutionDispose();

            // 在显示该窗体前使其成为此 MDI 窗体的子窗体。
            formPollutionControl.MdiParent = this;
            formPollutionControl.WindowState = FormWindowState.Maximized;
            formPollutionControl.Name = "FormPollutionControl";
            formPollutionControl.Show();
        }

        private void subMenuPollutionEquipment_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Name == "FormPollutionEquipment")
                {
                    Console.WriteLine("no new.");
                    childForm.Visible = true;
                    childForm.Activate();
                    return;
                }

            }

            FormPollutionEquipment formPollutionEquipment = new FormPollutionEquipment();

            // 在显示该窗体前使其成为此 MDI 窗体的子窗体。
            formPollutionEquipment.MdiParent = this;
            formPollutionEquipment.WindowState = FormWindowState.Maximized;
            formPollutionEquipment.Name = "FormPollutionEquipment";
            formPollutionEquipment.Show();
        }

        private void 工业企业污染排放及处理利用情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Name == "FormQueryPollutionEmission")
                {
                    Console.WriteLine("no new.");
                    childForm.Visible = true;
                    childForm.Activate();
                    return;
                }

            }

            FormQueryPollutionEmission formQueryPollutionEmission = new FormQueryPollutionEmission();

            // 在显示该窗体前使其成为此 MDI 窗体的子窗体。
            formQueryPollutionEmission.MdiParent = this;
            formQueryPollutionEmission.WindowState = FormWindowState.Maximized;
            formQueryPollutionEmission.Name = "FormQueryPollutionEmission";
            formQueryPollutionEmission
                .Show();
        }

        private void 信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Name == "FormPollutionEmission")
                {
                    Console.WriteLine("no new.");
                    childForm.Visible = true;
                    childForm.Activate();
                    return;
                }

            }

            FormPollutionEmission formPollutionEmission = new FormPollutionEmission();

            // 在显示该窗体前使其成为此 MDI 窗体的子窗体。
            formPollutionEmission.MdiParent = this;
            formPollutionEmission.WindowState = FormWindowState.Maximized;
            formPollutionEmission.Name = "FormPollutionEmission";
            formPollutionEmission.Show();
        }

        private void subMenuEnvivonmentEvaluation_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Name == "FormEnvironmentEvaluation")
                {
                    Console.WriteLine("no new.");
                    childForm.Visible = true;
                    childForm.Activate();
                    return;
                }

            }

            FormEnvironmentEvaluation formEnvironmentEvaluation = new FormEnvironmentEvaluation();

            // 在显示该窗体前使其成为此 MDI 窗体的子窗体。
            formEnvironmentEvaluation.MdiParent = this;
            formEnvironmentEvaluation.WindowState = FormWindowState.Maximized;
            formEnvironmentEvaluation.Name = "FormEnvironmentEvaluation";
            formEnvironmentEvaluation.Show();
        }

        
    }
}
