namespace Data_Transfer_YH
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DatasetLocationLabel = new System.Windows.Forms.Label();
            this.TimeStampLocationLabel = new System.Windows.Forms.Label();
            this.DatasetLocationTextbox = new System.Windows.Forms.TextBox();
            this.TimeStampLocationTextbox = new System.Windows.Forms.TextBox();
            this.DatasetChooseButton = new System.Windows.Forms.Button();
            this.TimeStampChooseButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.cycleLbl = new System.Windows.Forms.Label();
            this.cycleTextbox = new System.Windows.Forms.TextBox();
            this.resolutionLbl = new System.Windows.Forms.Label();
            this.resolutionTextbox = new System.Windows.Forms.TextBox();
            this.saveTypeLbl = new System.Windows.Forms.Label();
            this.saveTypeTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpMssgLbl = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatasetLocationLabel
            // 
            this.DatasetLocationLabel.AutoSize = true;
            this.DatasetLocationLabel.Location = new System.Drawing.Point(12, 18);
            this.DatasetLocationLabel.Name = "DatasetLocationLabel";
            this.DatasetLocationLabel.Size = new System.Drawing.Size(82, 15);
            this.DatasetLocationLabel.TabIndex = 0;
            this.DatasetLocationLabel.Text = "数据集路径";
            // 
            // TimeStampLocationLabel
            // 
            this.TimeStampLocationLabel.AutoSize = true;
            this.TimeStampLocationLabel.Location = new System.Drawing.Point(12, 62);
            this.TimeStampLocationLabel.Name = "TimeStampLocationLabel";
            this.TimeStampLocationLabel.Size = new System.Drawing.Size(82, 15);
            this.TimeStampLocationLabel.TabIndex = 1;
            this.TimeStampLocationLabel.Text = "时间戳路径";
            this.TimeStampLocationLabel.Click += new System.EventHandler(this.TimeStampLocationLabel_Click);
            // 
            // DatasetLocationTextbox
            // 
            this.DatasetLocationTextbox.Location = new System.Drawing.Point(111, 15);
            this.DatasetLocationTextbox.Name = "DatasetLocationTextbox";
            this.DatasetLocationTextbox.Size = new System.Drawing.Size(297, 25);
            this.DatasetLocationTextbox.TabIndex = 2;
            // 
            // TimeStampLocationTextbox
            // 
            this.TimeStampLocationTextbox.Location = new System.Drawing.Point(111, 59);
            this.TimeStampLocationTextbox.Name = "TimeStampLocationTextbox";
            this.TimeStampLocationTextbox.Size = new System.Drawing.Size(297, 25);
            this.TimeStampLocationTextbox.TabIndex = 3;
            // 
            // DatasetChooseButton
            // 
            this.DatasetChooseButton.Location = new System.Drawing.Point(440, 15);
            this.DatasetChooseButton.Name = "DatasetChooseButton";
            this.DatasetChooseButton.Size = new System.Drawing.Size(90, 30);
            this.DatasetChooseButton.TabIndex = 4;
            this.DatasetChooseButton.Text = "加载数据集";
            this.DatasetChooseButton.UseVisualStyleBackColor = true;
            this.DatasetChooseButton.Click += new System.EventHandler(this.DatasetChooseButton_Click);
            // 
            // TimeStampChooseButton
            // 
            this.TimeStampChooseButton.Location = new System.Drawing.Point(440, 59);
            this.TimeStampChooseButton.Name = "TimeStampChooseButton";
            this.TimeStampChooseButton.Size = new System.Drawing.Size(90, 30);
            this.TimeStampChooseButton.TabIndex = 5;
            this.TimeStampChooseButton.Text = "加载时间戳";
            this.TimeStampChooseButton.UseVisualStyleBackColor = true;
            this.TimeStampChooseButton.Click += new System.EventHandler(this.TimeStampChooseButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(440, 117);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(90, 30);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "开始转换";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // cycleLbl
            // 
            this.cycleLbl.AutoSize = true;
            this.cycleLbl.Location = new System.Drawing.Point(12, 117);
            this.cycleLbl.Name = "cycleLbl";
            this.cycleLbl.Size = new System.Drawing.Size(67, 15);
            this.cycleLbl.TabIndex = 7;
            this.cycleLbl.Text = "循环次数";
            // 
            // cycleTextbox
            // 
            this.cycleTextbox.Location = new System.Drawing.Point(85, 114);
            this.cycleTextbox.Name = "cycleTextbox";
            this.cycleTextbox.Size = new System.Drawing.Size(39, 25);
            this.cycleTextbox.TabIndex = 8;
            this.cycleTextbox.Text = "10";
            // 
            // resolutionLbl
            // 
            this.resolutionLbl.AutoSize = true;
            this.resolutionLbl.Location = new System.Drawing.Point(140, 117);
            this.resolutionLbl.Name = "resolutionLbl";
            this.resolutionLbl.Size = new System.Drawing.Size(52, 15);
            this.resolutionLbl.TabIndex = 9;
            this.resolutionLbl.Text = "分辨率";
            // 
            // resolutionTextbox
            // 
            this.resolutionTextbox.Location = new System.Drawing.Point(198, 114);
            this.resolutionTextbox.Name = "resolutionTextbox";
            this.resolutionTextbox.Size = new System.Drawing.Size(42, 25);
            this.resolutionTextbox.TabIndex = 10;
            this.resolutionTextbox.Text = "500";
            // 
            // saveTypeLbl
            // 
            this.saveTypeLbl.AutoSize = true;
            this.saveTypeLbl.Location = new System.Drawing.Point(262, 117);
            this.saveTypeLbl.Name = "saveTypeLbl";
            this.saveTypeLbl.Size = new System.Drawing.Size(67, 15);
            this.saveTypeLbl.TabIndex = 11;
            this.saveTypeLbl.Text = "存储格式";
            // 
            // saveTypeTextBox
            // 
            this.saveTypeTextBox.Location = new System.Drawing.Point(335, 114);
            this.saveTypeTextBox.Name = "saveTypeTextBox";
            this.saveTypeTextBox.Size = new System.Drawing.Size(42, 25);
            this.saveTypeTextBox.TabIndex = 12;
            this.saveTypeTextBox.Text = "dat";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 161);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(554, 25);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(113, 20);
            this.toolStripStatusLabel.Text = "help message:";
            // 
            // helpMssgLbl
            // 
            this.helpMssgLbl.AutoSize = true;
            this.helpMssgLbl.Location = new System.Drawing.Point(124, 161);
            this.helpMssgLbl.Name = "helpMssgLbl";
            this.helpMssgLbl.Size = new System.Drawing.Size(0, 15);
            this.helpMssgLbl.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 186);
            this.Controls.Add(this.helpMssgLbl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.saveTypeTextBox);
            this.Controls.Add(this.saveTypeLbl);
            this.Controls.Add(this.resolutionTextbox);
            this.Controls.Add(this.resolutionLbl);
            this.Controls.Add(this.cycleTextbox);
            this.Controls.Add(this.cycleLbl);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimeStampChooseButton);
            this.Controls.Add(this.DatasetChooseButton);
            this.Controls.Add(this.TimeStampLocationTextbox);
            this.Controls.Add(this.DatasetLocationTextbox);
            this.Controls.Add(this.TimeStampLocationLabel);
            this.Controls.Add(this.DatasetLocationLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DatasetLocationLabel;
        private System.Windows.Forms.Label TimeStampLocationLabel;
        private System.Windows.Forms.TextBox DatasetLocationTextbox;
        private System.Windows.Forms.TextBox TimeStampLocationTextbox;
        private System.Windows.Forms.Button DatasetChooseButton;
        private System.Windows.Forms.Button TimeStampChooseButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label cycleLbl;
        private System.Windows.Forms.TextBox cycleTextbox;
        private System.Windows.Forms.Label resolutionLbl;
        private System.Windows.Forms.TextBox resolutionTextbox;
        private System.Windows.Forms.Label saveTypeLbl;
        private System.Windows.Forms.TextBox saveTypeTextBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label helpMssgLbl;
    }
}

