namespace FontAwesomeNet.Sample
{
    partial class FormSample
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFontAwesomeType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudIconSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbForeColor = new System.Windows.Forms.ComboBox();
            this.cmbBackColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbShowBorder = new System.Windows.Forms.CheckBox();
            this.cmbBorderColor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFontVersion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIconSize)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbShowBorder);
            this.groupBox1.Controls.Add(this.nudIconSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBorderColor);
            this.groupBox1.Controls.Add(this.cmbBackColor);
            this.groupBox1.Controls.Add(this.cmbForeColor);
            this.groupBox1.Controls.Add(this.cmbFontAwesomeType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "图标名称：";
            // 
            // cmbFontAwesomeType
            // 
            this.cmbFontAwesomeType.FormattingEnabled = true;
            this.cmbFontAwesomeType.Location = new System.Drawing.Point(83, 14);
            this.cmbFontAwesomeType.Name = "cmbFontAwesomeType";
            this.cmbFontAwesomeType.Size = new System.Drawing.Size(121, 20);
            this.cmbFontAwesomeType.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 372);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "预览";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 352);
            this.panel1.TabIndex = 5;
            // 
            // nudIconSize
            // 
            this.nudIconSize.Location = new System.Drawing.Point(295, 13);
            this.nudIconSize.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudIconSize.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudIconSize.Name = "nudIconSize";
            this.nudIconSize.Size = new System.Drawing.Size(65, 21);
            this.nudIconSize.TabIndex = 14;
            this.nudIconSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "图标大小：";
            // 
            // cmbForeColor
            // 
            this.cmbForeColor.FormattingEnabled = true;
            this.cmbForeColor.Location = new System.Drawing.Point(83, 40);
            this.cmbForeColor.Name = "cmbForeColor";
            this.cmbForeColor.Size = new System.Drawing.Size(121, 20);
            this.cmbForeColor.TabIndex = 12;
            // 
            // cmbBackColor
            // 
            this.cmbBackColor.FormattingEnabled = true;
            this.cmbBackColor.Location = new System.Drawing.Point(83, 66);
            this.cmbBackColor.Name = "cmbBackColor";
            this.cmbBackColor.Size = new System.Drawing.Size(121, 20);
            this.cmbBackColor.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "前景颜色：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "背景颜色：";
            // 
            // cbShowBorder
            // 
            this.cbShowBorder.AutoSize = true;
            this.cbShowBorder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbShowBorder.Location = new System.Drawing.Point(226, 43);
            this.cbShowBorder.Name = "cbShowBorder";
            this.cbShowBorder.Size = new System.Drawing.Size(72, 16);
            this.cbShowBorder.TabIndex = 15;
            this.cbShowBorder.Text = "显示边框";
            this.cbShowBorder.UseVisualStyleBackColor = true;
            // 
            // cmbBorderColor
            // 
            this.cmbBorderColor.FormattingEnabled = true;
            this.cmbBorderColor.Location = new System.Drawing.Point(295, 69);
            this.cmbBorderColor.Name = "cmbBorderColor";
            this.cmbBorderColor.Size = new System.Drawing.Size(121, 20);
            this.cmbBorderColor.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "边框颜色：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblFontVersion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 21);
            this.panel2.TabIndex = 6;
            // 
            // lblFontVersion
            // 
            this.lblFontVersion.AutoSize = true;
            this.lblFontVersion.Location = new System.Drawing.Point(12, 4);
            this.lblFontVersion.Name = "lblFontVersion";
            this.lblFontVersion.Size = new System.Drawing.Size(161, 12);
            this.lblFontVersion.TabIndex = 0;
            this.lblFontVersion.Text = "FontAwesome Version：4.7.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Helper Version：1.0.0";
            // 
            // FormSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSample";
            this.Text = "FontAwesome示例";
            this.Load += new System.EventHandler(this.FormSample_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudIconSize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFontAwesomeType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudIconSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBackColor;
        private System.Windows.Forms.ComboBox cmbForeColor;
        private System.Windows.Forms.CheckBox cbShowBorder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBorderColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFontVersion;


    }
}

