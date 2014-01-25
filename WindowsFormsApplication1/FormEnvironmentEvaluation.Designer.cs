
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
            this.button1 = new System.Windows.Forms.Button();
            this.edoUserControl1 = new TestWF.EdoUserControl();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edoUserControl1
            // 
            this.edoUserControl1.Location = new System.Drawing.Point(100, 144);
            this.edoUserControl1.Name = "edoUserControl1";
            this.edoUserControl1.Size = new System.Drawing.Size(614, 515);
            this.edoUserControl1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "打开文档";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(125, 24);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.ReadOnly = true;
            this.txtPath1.Size = new System.Drawing.Size(225, 21);
            this.txtPath1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "选择路径";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormEnvironmentEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 718);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.edoUserControl1);
            this.Controls.Add(this.button1);
            this.Name = "FormEnvironmentEvaluation";
            this.Text = "企业环评记录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private TestWF.EdoUserControl edoUserControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.Button button3;

    }
}

