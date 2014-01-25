namespace SimpleForm
{
    partial class FormQueryPollutionEmission
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CboxList1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(65, 27);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 21);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "统计年份";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(416, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "类型";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "行政地区";
            // 
            // CboxList1
            // 
            this.CboxList1.FormattingEnabled = true;
            this.CboxList1.Items.AddRange(new object[] {
            "统计年份",
            "企业法人代码",
            "企业标识",
            "企业详细名称",
            "曾用名",
            "中心经度",
            "中心维度",
            "法人代表姓名",
            "法人代表电话",
            "法人代表传真",
            "邮政编码",
            "企业详细地址",
            "行政区划代码",
            "登记注册类型代码",
            "企业规模代码",
            "开业时间",
            "排水去向类型",
            "受纳水体代码",
            "受纳水体名称",
            "排入的污水处理厂代码",
            "排入的污水处理厂名称",
            "工业总产值(现金)万元",
            "三废综合利用产品产值",
            "企业专职环保人员数",
            "年正常生产时间(小时)",
            "工业用水量(吨)",
            "其中:新鲜用水量",
            "其中:重复用水量",
            "工业煤炭消费量(吨)",
            "其中:燃料煤消费量(吨)",
            "原料煤消费量(吨)",
            "燃料油消费量(吨)",
            "其中:重油(吨)",
            "其中:柴油(吨)",
            "洁净燃气消费量(万立方米)",
            "工业锅炉数(台)",
            "工业锅炉蒸吨数(蒸吨)",
            "烟尘排放达标的工业锅炉数",
            "烟尘排放达标的工业锅炉蒸吨数(蒸吨)",
            "二氧化硫排放达标的工业锅炉数(台)",
            "二氧化硫排放达标的工业蒸吨数(蒸吨)",
            "工业炉窖数(座)",
            "烟尘排放达标的工业炉窖数(座)",
            "二氧化硫排放达标的工业炉窖数(座)",
            "产品1名称",
            "产品1单位",
            "产品1产量",
            "产品2名称",
            "产品2单位",
            "产品2产量",
            "主要有毒有害物质原辅材料1名称",
            "主要有毒有害物质原辅材料1单位",
            "主要有毒有害物质原辅材料1用量",
            "主要有毒有害物质原辅材料2名称",
            "主要有毒有害物质原辅材料2单位",
            "主要有毒有害物质原辅材料2用量",
            "污水排放口数(个)",
            "其中:直排海的污水排放口数(个)",
            "废水污染物在线监测仪器套数(套)",
            "废气污染物在线监测仪器套数(套)",
            "废水治理设施数(套)",
            "废水治理设施处理能力(吨/日)",
            "废水治理设施运行费用",
            "工业废水处理量(吨)",
            "工业废水排放量(吨)",
            "其中:废水直接排入海的量(吨)",
            "其中:排入污水处理厂的量(吨)",
            "工业废水排放达标量(吨)",
            "工业废气排放量(万标立方米)",
            "其中:燃料燃烧过程中废气排放量",
            "其中:生产工艺过程中废气排放量",
            "废气治理设施数(套)",
            "其中:脱硫设施数(套)",
            "废气治理设施处理能力(标立方米/时)",
            "其中:脱硫设施脱硫能力(千克/时)",
            "废气治理设施运行费用(万元)",
            "其中:脱硫设施运行费用(万元)",
            "二氧化硫去除量(千克)",
            "二氧化硫排放量(千克)",
            "氮氧化物去除量(千克)",
            "氮氧化物排放量(千克)",
            "烟尘去除量(千克)",
            "烟尘排放量(千克)",
            "工业粉尘去除量(千克)",
            "工业粉尘排放量(千克)",
            "工业固体废物产生量(吨)",
            "工业固体废物综合利用量(吨)",
            "工业固体废物贮存量(吨)",
            "工业固体废物处置量(吨)",
            "工业固体废物排放量(吨)",
            "燃料煤产地1",
            "燃料煤消费量1(吨)",
            "燃料煤产地2",
            "燃料煤消费量2(吨)",
            "燃料油名称1",
            "燃料油产地1",
            "燃料油消费量1(吨)",
            "燃料油名称2",
            "燃料油产地2",
            "燃料油消费量2(吨)"});
            this.CboxList1.Location = new System.Drawing.Point(54, 136);
            this.CboxList1.Name = "CboxList1";
            this.CboxList1.Size = new System.Drawing.Size(194, 660);
            this.CboxList1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(727, 661);
            this.dataGridView1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(641, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(54, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 80);
            this.panel1.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(738, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "导出数据";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormQueryPollutionEmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 827);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CboxList1);
            this.Name = "FormQueryPollutionEmission";
            this.Text = "工业企业污染排放及利用情况";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox CboxList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

