
namespace EnvironmentSystem

{
    partial class FormEnvironmentEvaluation
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.edoUserControl1 = new TestWF.EdoUserControl();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // edoUserControl1
            // 
            this.edoUserControl1.Location = new System.Drawing.Point(100, 144);
            this.edoUserControl1.Name = "edoUserControl1";
            this.edoUserControl1.Size = new System.Drawing.Size(614, 515);
            this.edoUserControl1.TabIndex = 4;
            // 
            // FormEnvironmentEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 718);
            this.Controls.Add(this.edoUserControl1);
            this.Name = "FormEnvironmentEvaluation";
            this.Text = "企业环评记录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private TestWF.EdoUserControl edoUserControl1;

    }
}

