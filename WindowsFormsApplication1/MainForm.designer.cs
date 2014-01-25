namespace SimpleForm
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUseMap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageEnterprise = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuPollutionEmission = new System.Windows.Forms.ToolStripMenuItem();
            this.信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuPollutionEquipment = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuPollutionControl = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuEnvivonmentEvaluation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInquire = new System.Windows.Forms.ToolStripMenuItem();
            this.基表信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工业企业污染排放及处理利用情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGasAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWaterAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUseMap
            // 
            this.menuUseMap.Name = "menuUseMap";
            this.menuUseMap.Size = new System.Drawing.Size(67, 20);
            this.menuUseMap.Text = "地图操作";
            this.menuUseMap.Click += new System.EventHandler(this.menuUseMap_Click);
            // 
            // menuManageEnterprise
            // 
            this.menuManageEnterprise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuPollutionEmission,
            this.subMenuPollutionEquipment,
            this.subMenuPollutionControl,
            this.subMenuEnvivonmentEvaluation});
            this.menuManageEnterprise.Name = "menuManageEnterprise";
            this.menuManageEnterprise.Size = new System.Drawing.Size(67, 20);
            this.menuManageEnterprise.Text = "企业管理";
            this.menuManageEnterprise.Click += new System.EventHandler(this.menuManageEnterprise_Click);
            // 
            // subMenuPollutionEmission
            // 
            this.subMenuPollutionEmission.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息录入ToolStripMenuItem,
            this.编辑管理ToolStripMenuItem});
            this.subMenuPollutionEmission.Name = "subMenuPollutionEmission";
            this.subMenuPollutionEmission.Size = new System.Drawing.Size(254, 22);
            this.subMenuPollutionEmission.Text = "工业企业污染排放及处理利用情况";
            this.subMenuPollutionEmission.Click += new System.EventHandler(this.subMenuPollutionEmission_Click);
            // 
            // 信息录入ToolStripMenuItem
            // 
            this.信息录入ToolStripMenuItem.Name = "信息录入ToolStripMenuItem";
            this.信息录入ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.信息录入ToolStripMenuItem.Text = "信息录入";
            this.信息录入ToolStripMenuItem.Click += new System.EventHandler(this.信息录入ToolStripMenuItem_Click);
            // 
            // 编辑管理ToolStripMenuItem
            // 
            this.编辑管理ToolStripMenuItem.Name = "编辑管理ToolStripMenuItem";
            this.编辑管理ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.编辑管理ToolStripMenuItem.Text = "编辑管理";
            // 
            // subMenuPollutionEquipment
            // 
            this.subMenuPollutionEquipment.Name = "subMenuPollutionEquipment";
            this.subMenuPollutionEquipment.Size = new System.Drawing.Size(254, 22);
            this.subMenuPollutionEquipment.Text = "工业企业处理设施信息";
            this.subMenuPollutionEquipment.Click += new System.EventHandler(this.subMenuPollutionEquipment_Click);
            // 
            // subMenuPollutionControl
            // 
            this.subMenuPollutionControl.Name = "subMenuPollutionControl";
            this.subMenuPollutionControl.Size = new System.Drawing.Size(254, 22);
            this.subMenuPollutionControl.Text = "工业企业污染治理项目建设情况";
            this.subMenuPollutionControl.Click += new System.EventHandler(this.subMenuPollutionControl_Click);
            // 
            // subMenuEnvivonmentEvaluation
            // 
            this.subMenuEnvivonmentEvaluation.Name = "subMenuEnvivonmentEvaluation";
            this.subMenuEnvivonmentEvaluation.Size = new System.Drawing.Size(254, 22);
            this.subMenuEnvivonmentEvaluation.Text = "工业企业环评记录";
            this.subMenuEnvivonmentEvaluation.Click += new System.EventHandler(this.subMenuEnvivonmentEvaluation_Click);
            // 
            // menuInquire
            // 
            this.menuInquire.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基表信息查询ToolStripMenuItem});
            this.menuInquire.Name = "menuInquire";
            this.menuInquire.Size = new System.Drawing.Size(67, 20);
            this.menuInquire.Text = "信息查询";
            // 
            // 基表信息查询ToolStripMenuItem
            // 
            this.基表信息查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工业企业污染排放及处理利用情况ToolStripMenuItem});
            this.基表信息查询ToolStripMenuItem.Name = "基表信息查询ToolStripMenuItem";
            this.基表信息查询ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.基表信息查询ToolStripMenuItem.Text = "基表信息查询";
            // 
            // 工业企业污染排放及处理利用情况ToolStripMenuItem
            // 
            this.工业企业污染排放及处理利用情况ToolStripMenuItem.Name = "工业企业污染排放及处理利用情况ToolStripMenuItem";
            this.工业企业污染排放及处理利用情况ToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.工业企业污染排放及处理利用情况ToolStripMenuItem.Text = "工业企业污染排放及处理利用情况";
            this.工业企业污染排放及处理利用情况ToolStripMenuItem.Click += new System.EventHandler(this.工业企业污染排放及处理利用情况ToolStripMenuItem_Click);
            // 
            // menuGasAnalyse
            // 
            this.menuGasAnalyse.Name = "menuGasAnalyse";
            this.menuGasAnalyse.Size = new System.Drawing.Size(67, 20);
            this.menuGasAnalyse.Text = "大气污染";
            this.menuGasAnalyse.Click += new System.EventHandler(this.menuGasAnalyse_Click);
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
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(961, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 827);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "MainForm";
            this.Text = "宝鸡市环境污染动态监管系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuUseMap;
        private System.Windows.Forms.ToolStripMenuItem menuManageEnterprise;
        private System.Windows.Forms.ToolStripMenuItem menuInquire;
        private System.Windows.Forms.ToolStripMenuItem menuGasAnalyse;
        private System.Windows.Forms.ToolStripMenuItem menuWaterAnalyse;
        private System.Windows.Forms.ToolStripMenuItem menuManageUser;
        private System.Windows.Forms.ToolStripMenuItem menuDataTransfer;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem subMenuPollutionEquipment;
        private System.Windows.Forms.ToolStripMenuItem subMenuPollutionControl;
        private System.Windows.Forms.ToolStripMenuItem subMenuPollutionEmission;
        private System.Windows.Forms.ToolStripMenuItem subMenuEnvivonmentEvaluation;
        private System.Windows.Forms.ToolStripMenuItem 基表信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工业企业污染排放及处理利用情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑管理ToolStripMenuItem;
    }
}

