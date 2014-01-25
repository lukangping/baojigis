namespace WindowsFormsApplication1
{
    partial class MapOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapOperation));
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitcontainerMain = new System.Windows.Forms.SplitContainer();
            this.axMapControl2 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainerMain)).BeginInit();
            this.splitcontainerMain.Panel1.SuspendLayout();
            this.splitcontainerMain.Panel2.SuspendLayout();
            this.splitcontainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(14, 548);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearch.Location = new System.Drawing.Point(200, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(74, 26);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "查询";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSearchName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSearchName.Location = new System.Drawing.Point(8, 13);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(186, 26);
            this.textBoxSearchName.TabIndex = 0;
            this.textBoxSearchName.Text = "请输入企业名称";
            this.textBoxSearchName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSearchName_MouseClick);
            this.textBoxSearchName.TextChanged += new System.EventHandler(this.textBoxSearchName_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "凤县振兴铅锌选矿厂",
            "凤县鑫岭纸业有限公司",
            "宝鸡市永盛矿业有限责任公司"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 296);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.Controls.Add(this.axMapControl2);
            this.splitContainerLeft.Size = new System.Drawing.Size(277, 600);
            this.splitContainerLeft.SplitterDistance = 351;
            this.splitContainerLeft.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxSearchName);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBox1);
            this.splitContainer2.Size = new System.Drawing.Size(277, 351);
            this.splitContainer2.SplitterDistance = 51;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitcontainerMain
            // 
            this.splitcontainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitcontainerMain.Location = new System.Drawing.Point(0, 28);
            this.splitcontainerMain.Name = "splitcontainerMain";
            // 
            // splitcontainerMain.Panel1
            // 
            this.splitcontainerMain.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitcontainerMain.Panel2
            // 
            this.splitcontainerMain.Panel2.Controls.Add(this.axMapControl1);
            this.splitcontainerMain.Size = new System.Drawing.Size(938, 600);
            this.splitcontainerMain.SplitterDistance = 277;
            this.splitcontainerMain.TabIndex = 10;
            // 
            // axMapControl2
            // 
            this.axMapControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl2.Location = new System.Drawing.Point(0, 0);
            this.axMapControl2.Name = "axMapControl2";
            this.axMapControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl2.OcxState")));
            this.axMapControl2.Size = new System.Drawing.Size(277, 245);
            this.axMapControl2.TabIndex = 7;
            this.axMapControl2.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl2_OnMouseDown);
            this.axMapControl2.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl2_OnMouseMove);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(657, 600);
            this.axMapControl1.TabIndex = 6;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnExtentUpdatedEventHandler(this.axMapControl1_OnExtentUpdated);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 0);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(938, 28);
            this.axToolbarControl1.TabIndex = 0;
            this.axToolbarControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IToolbarControlEvents_Ax_OnMouseDownEventHandler(this.axToolbarControl1_OnMouseDown);
            // 
            // MapOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 628);
            this.Controls.Add(this.splitcontainerMain);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axToolbarControl1);
            this.Name = "MapOperation";
            this.Text = "MapOperation";
            this.Load += new System.EventHandler(this.mapOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitcontainerMain.Panel1.ResumeLayout(false);
            this.splitcontainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainerMain)).EndInit();
            this.splitcontainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.SplitContainer splitcontainerMain;
    }
}

