namespace TestWF
{
    partial class EdoUserControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdoUserControl));
            this.axOfficeViewer = new AxOfficeViewer.AxOfficeViewer();
            ((System.ComponentModel.ISupportInitialize)(this.axOfficeViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // axOfficeViewer
            // 
            this.axOfficeViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axOfficeViewer.Enabled = true;
            this.axOfficeViewer.Location = new System.Drawing.Point(0, 0);
            this.axOfficeViewer.Name = "axOfficeViewer";
            this.axOfficeViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOfficeViewer.OcxState")));
            this.axOfficeViewer.Size = new System.Drawing.Size(248, 598);
            this.axOfficeViewer.TabIndex = 0;
            this.axOfficeViewer.OnFileCommand += new AxOfficeViewer._DOfficeViewerEvents_OnFileCommandEventHandler(this.axOfficeViewer_OnFileCommand);
            // 
            // EdoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axOfficeViewer);
            this.Name = "EdoUserControl";
            this.Size = new System.Drawing.Size(251, 601);
            ((System.ComponentModel.ISupportInitialize)(this.axOfficeViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxOfficeViewer.AxOfficeViewer axOfficeViewer;
    }
}
