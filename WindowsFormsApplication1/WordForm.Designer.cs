namespace TestWF
{
    partial class WordForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.edoUserControl1 = new TestWF.EdoUserControl();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.txtPath3 = new System.Windows.Forms.TextBox();
            this.edoUserControl2 = new TestWF.EdoUserControl();
            this.edoUserControl3 = new TestWF.EdoUserControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择路径";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(114, 14);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.ReadOnly = true;
            this.txtPath1.Size = new System.Drawing.Size(225, 21);
            this.txtPath1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "打开文档";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // edoUserControl1
            // 
            this.edoUserControl1.Location = new System.Drawing.Point(13, 107);
            this.edoUserControl1.Name = "edoUserControl1";
            this.edoUserControl1.Size = new System.Drawing.Size(326, 600);
            this.edoUserControl1.TabIndex = 3;
            this.edoUserControl1.Load += new System.EventHandler(this.edoUserControl1_Load);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(345, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "打开文档";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(345, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "选择路径";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(673, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "打开文档";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(673, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "选择路径";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(442, 14);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.ReadOnly = true;
            this.txtPath2.Size = new System.Drawing.Size(225, 21);
            this.txtPath2.TabIndex = 10;
            // 
            // txtPath3
            // 
            this.txtPath3.Location = new System.Drawing.Point(768, 14);
            this.txtPath3.Name = "txtPath3";
            this.txtPath3.ReadOnly = true;
            this.txtPath3.Size = new System.Drawing.Size(225, 21);
            this.txtPath3.TabIndex = 11;
            // 
            // edoUserControl2
            // 
            this.edoUserControl2.Location = new System.Drawing.Point(345, 107);
            this.edoUserControl2.Name = "edoUserControl2";
            this.edoUserControl2.Size = new System.Drawing.Size(326, 600);
            this.edoUserControl2.TabIndex = 12;
            // 
            // edoUserControl3
            // 
            this.edoUserControl3.Location = new System.Drawing.Point(677, 107);
            this.edoUserControl3.Name = "edoUserControl3";
            this.edoUserControl3.Size = new System.Drawing.Size(326, 600);
            this.edoUserControl3.TabIndex = 13;
            // 
            // WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.edoUserControl3);
            this.Controls.Add(this.edoUserControl2);
            this.Controls.Add(this.txtPath3);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.edoUserControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.button1);
            this.Name = "WordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.Button button2;
        private EdoUserControl edoUserControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.TextBox txtPath3;
        private EdoUserControl edoUserControl2;
        private EdoUserControl edoUserControl3;
    }
}