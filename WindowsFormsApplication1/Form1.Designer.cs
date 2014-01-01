namespace WindowsFormsApplication1
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUseMap = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuOpenMap = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuManageEnterprise = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInquire = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGasAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWaterAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(382, 362);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUseMap,
            this.menuManageEnterprise,
            this.menuInquire,
            this.menuGasAnalyse,
            this.menuWaterAnalyse,
            this.menuManageUser,
            this.menuDataTransfer,
            this.menuHelp,
            this.menuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUseMap
            // 
            this.menuUseMap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuOpenMap});
            this.menuUseMap.Name = "menuUseMap";
            this.menuUseMap.Size = new System.Drawing.Size(67, 20);
            this.menuUseMap.Text = "地图操作";
            // 
            // subMenuOpenMap
            // 
            this.subMenuOpenMap.Name = "subMenuOpenMap";
            this.subMenuOpenMap.Size = new System.Drawing.Size(152, 22);
            this.subMenuOpenMap.Text = "打开地图";
            this.subMenuOpenMap.Click += new System.EventHandler(this.subMenuOpenMap_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuManageEnterprise
            // 
            this.menuManageEnterprise.Name = "menuManageEnterprise";
            this.menuManageEnterprise.Size = new System.Drawing.Size(67, 20);
            this.menuManageEnterprise.Text = "企业管理";
            // 
            // menuInquire
            // 
            this.menuInquire.Name = "menuInquire";
            this.menuInquire.Size = new System.Drawing.Size(67, 20);
            this.menuInquire.Text = "信息查询";
            // 
            // menuGasAnalyse
            // 
            this.menuGasAnalyse.Name = "menuGasAnalyse";
            this.menuGasAnalyse.Size = new System.Drawing.Size(67, 20);
            this.menuGasAnalyse.Text = "大气污染";
            // 
            // menuWaterAnalyse
            // 
            this.menuWaterAnalyse.Name = "menuWaterAnalyse";
            this.menuWaterAnalyse.Size = new System.Drawing.Size(55, 20);
            this.menuWaterAnalyse.Text = "水污染";
            // 
            // menuManageUser
            // 
            this.menuManageUser.Name = "menuManageUser";
            this.menuManageUser.Size = new System.Drawing.Size(67, 20);
            this.menuManageUser.Text = "用户管理";
            // 
            // menuDataTransfer
            // 
            this.menuDataTransfer.Name = "menuDataTransfer";
            this.menuDataTransfer.Size = new System.Drawing.Size(67, 20);
            this.menuDataTransfer.Text = "数据传输";
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(43, 20);
            this.menuHelp.Text = "帮助";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(43, 20);
            this.menuAbout.Text = "关于";
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(265, 52);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(696, 571);
            this.axMapControl1.TabIndex = 2;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 52);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(265, 571);
            this.axTOCControl1.TabIndex = 1;
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 24);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(961, 28);
            this.axToolbarControl1.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 623);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.axTOCControl1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "宝鸡市环境污染动态监管系统";
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuUseMap;
        private System.Windows.Forms.ToolStripMenuItem subMenuOpenMap;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuManageEnterprise;
        private System.Windows.Forms.ToolStripMenuItem menuInquire;
        private System.Windows.Forms.ToolStripMenuItem menuGasAnalyse;
        private System.Windows.Forms.ToolStripMenuItem menuWaterAnalyse;
        private System.Windows.Forms.ToolStripMenuItem menuManageUser;
        private System.Windows.Forms.ToolStripMenuItem menuDataTransfer;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
    }
}

