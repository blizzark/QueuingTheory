namespace QTS.WinForms
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
            this.RightPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.channelIntencites = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clientLimit_CheckBox = new System.Windows.Forms.CheckBox();
            this.timeLimit_CheckBox = new System.Windows.Forms.CheckBox();
            this.clientLimit_Numeric = new System.Windows.Forms.NumericUpDown();
            this.timeLimit_Numeric = new System.Windows.Forms.NumericUpDown();
            this.threadIntencity_Numeric = new System.Windows.Forms.NumericUpDown();
            this.parkPlace_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteChannelIntencity_Button = new System.Windows.Forms.Button();
            this.addChannelIntencity_Button = new System.Windows.Forms.Button();
            this.minRnd_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.preferFirstChannel_CheckBox = new System.Windows.Forms.CheckBox();
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.PlotPanel = new System.Windows.Forms.Panel();
            this.statusText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLimit_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimit_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadIntencity_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkPlace_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRnd_Numeric)).BeginInit();
            this.PlotPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RightPanel.Controls.Add(this.button3);
            this.RightPanel.Controls.Add(this.label5);
            this.RightPanel.Controls.Add(this.channelIntencites);
            this.RightPanel.Controls.Add(this.numericUpDown1);
            this.RightPanel.Controls.Add(this.label4);
            this.RightPanel.Controls.Add(this.label2);
            this.RightPanel.Controls.Add(this.button2);
            this.RightPanel.Controls.Add(this.button1);
            this.RightPanel.Controls.Add(this.clientLimit_Numeric);
            this.RightPanel.Controls.Add(this.parkPlace_Numeric);
            this.RightPanel.Controls.Add(this.label1);
            this.RightPanel.Controls.Add(this.deleteChannelIntencity_Button);
            this.RightPanel.Controls.Add(this.addChannelIntencity_Button);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(623, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Padding = new System.Windows.Forms.Padding(0, 300, 0, 60);
            this.RightPanel.Size = new System.Drawing.Size(348, 587);
            this.RightPanel.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(10, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(319, 49);
            this.button3.TabIndex = 26;
            this.button3.Text = "Разработчики";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Пропускные способности каналов (шт/ч)";
            // 
            // channelIntencites
            // 
            this.channelIntencites.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.channelIntencites.FormattingEnabled = true;
            this.channelIntencites.Location = new System.Drawing.Point(10, 187);
            this.channelIntencites.Name = "channelIntencites";
            this.channelIntencites.Size = new System.Drawing.Size(319, 134);
            this.channelIntencites.TabIndex = 3;
            this.channelIntencites.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.channelIntencites_MouseDoubleClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(224, 62);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Время обслуживания μ:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(10, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 49);
            this.button2.TabIndex = 22;
            this.button2.Text = "Анализ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(10, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 54);
            this.button1.TabIndex = 21;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientLimit_CheckBox
            // 
            this.clientLimit_CheckBox.AutoSize = true;
            this.clientLimit_CheckBox.Checked = true;
            this.clientLimit_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clientLimit_CheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientLimit_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLimit_CheckBox.Location = new System.Drawing.Point(382, 255);
            this.clientLimit_CheckBox.Name = "clientLimit_CheckBox";
            this.clientLimit_CheckBox.Size = new System.Drawing.Size(225, 21);
            this.clientLimit_CheckBox.TabIndex = 19;
            this.clientLimit_CheckBox.Text = "Ограничение по заявкам(шт):";
            this.clientLimit_CheckBox.UseVisualStyleBackColor = true;
            this.clientLimit_CheckBox.CheckedChanged += new System.EventHandler(this.clientLimit_CheckBox_CheckedChanged);
            // 
            // timeLimit_CheckBox
            // 
            this.timeLimit_CheckBox.AutoSize = true;
            this.timeLimit_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLimit_CheckBox.Location = new System.Drawing.Point(350, 133);
            this.timeLimit_CheckBox.Name = "timeLimit_CheckBox";
            this.timeLimit_CheckBox.Size = new System.Drawing.Size(149, 38);
            this.timeLimit_CheckBox.TabIndex = 18;
            this.timeLimit_CheckBox.Text = "Ограничение по \r\nвремени (в часах):";
            this.timeLimit_CheckBox.UseVisualStyleBackColor = true;
            this.timeLimit_CheckBox.CheckedChanged += new System.EventHandler(this.timeLimit_CheckBox_CheckedChanged);
            // 
            // clientLimit_Numeric
            // 
            this.clientLimit_Numeric.Location = new System.Drawing.Point(224, 26);
            this.clientLimit_Numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.clientLimit_Numeric.Name = "clientLimit_Numeric";
            this.clientLimit_Numeric.Size = new System.Drawing.Size(112, 20);
            this.clientLimit_Numeric.TabIndex = 17;
            this.clientLimit_Numeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // timeLimit_Numeric
            // 
            this.timeLimit_Numeric.DecimalPlaces = 3;
            this.timeLimit_Numeric.Enabled = false;
            this.timeLimit_Numeric.Location = new System.Drawing.Point(505, 137);
            this.timeLimit_Numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.timeLimit_Numeric.Name = "timeLimit_Numeric";
            this.timeLimit_Numeric.Size = new System.Drawing.Size(112, 20);
            this.timeLimit_Numeric.TabIndex = 15;
            // 
            // threadIntencity_Numeric
            // 
            this.threadIntencity_Numeric.Location = new System.Drawing.Point(495, 26);
            this.threadIntencity_Numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.threadIntencity_Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadIntencity_Numeric.Name = "threadIntencity_Numeric";
            this.threadIntencity_Numeric.Size = new System.Drawing.Size(112, 20);
            this.threadIntencity_Numeric.TabIndex = 12;
            this.threadIntencity_Numeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.threadIntencity_Numeric.ValueChanged += new System.EventHandler(this.threadIntencity_Numeric_ValueChanged);
            // 
            // parkPlace_Numeric
            // 
            this.parkPlace_Numeric.Location = new System.Drawing.Point(224, 99);
            this.parkPlace_Numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.parkPlace_Numeric.Name = "parkPlace_Numeric";
            this.parkPlace_Numeric.Size = new System.Drawing.Size(112, 20);
            this.parkPlace_Numeric.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Максимальная очередь";
            // 
            // deleteChannelIntencity_Button
            // 
            this.deleteChannelIntencity_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteChannelIntencity_Button.Enabled = false;
            this.deleteChannelIntencity_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteChannelIntencity_Button.Location = new System.Drawing.Point(217, 335);
            this.deleteChannelIntencity_Button.Name = "deleteChannelIntencity_Button";
            this.deleteChannelIntencity_Button.Size = new System.Drawing.Size(112, 37);
            this.deleteChannelIntencity_Button.TabIndex = 4;
            this.deleteChannelIntencity_Button.Text = "Удалить";
            this.deleteChannelIntencity_Button.UseVisualStyleBackColor = true;
            this.deleteChannelIntencity_Button.Click += new System.EventHandler(this.deleteChannelIntencity_Button_Click);
            // 
            // addChannelIntencity_Button
            // 
            this.addChannelIntencity_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addChannelIntencity_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addChannelIntencity_Button.Location = new System.Drawing.Point(10, 335);
            this.addChannelIntencity_Button.Name = "addChannelIntencity_Button";
            this.addChannelIntencity_Button.Size = new System.Drawing.Size(111, 37);
            this.addChannelIntencity_Button.TabIndex = 3;
            this.addChannelIntencity_Button.Text = "Добавить";
            this.addChannelIntencity_Button.UseVisualStyleBackColor = true;
            this.addChannelIntencity_Button.Click += new System.EventHandler(this.addChannelIntencity_Button_Click);
            // 
            // minRnd_Numeric
            // 
            this.minRnd_Numeric.DecimalPlaces = 3;
            this.minRnd_Numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.minRnd_Numeric.Location = new System.Drawing.Point(495, 203);
            this.minRnd_Numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minRnd_Numeric.Name = "minRnd_Numeric";
            this.minRnd_Numeric.Size = new System.Drawing.Size(112, 20);
            this.minRnd_Numeric.TabIndex = 13;
            this.minRnd_Numeric.ValueChanged += new System.EventHandler(this.minRnd_Numeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(450, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Минимальный интервал\r\nмежду заявками:";
            // 
            // preferFirstChannel_CheckBox
            // 
            this.preferFirstChannel_CheckBox.AutoSize = true;
            this.preferFirstChannel_CheckBox.Checked = true;
            this.preferFirstChannel_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preferFirstChannel_CheckBox.Location = new System.Drawing.Point(24, 66);
            this.preferFirstChannel_CheckBox.Name = "preferFirstChannel_CheckBox";
            this.preferFirstChannel_CheckBox.Size = new System.Drawing.Size(171, 17);
            this.preferFirstChannel_CheckBox.TabIndex = 20;
            this.preferFirstChannel_CheckBox.Text = "Предпочитать первый канал";
            this.preferFirstChannel_CheckBox.UseVisualStyleBackColor = true;
            // 
            // plot1
            // 
            this.plot1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plot1.Location = new System.Drawing.Point(12, -10);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.NoMove2D;
            this.plot1.Size = new System.Drawing.Size(605, 610);
            this.plot1.TabIndex = 0;
            this.plot1.Text = "plot1";
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.plot1.Click += new System.EventHandler(this.plot1_Click);
            this.plot1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.plot1_PreviewKeyDown);
            // 
            // PlotPanel
            // 
            this.PlotPanel.Controls.Add(this.statusText);
            this.PlotPanel.Controls.Add(this.plot1);
            this.PlotPanel.Controls.Add(this.preferFirstChannel_CheckBox);
            this.PlotPanel.Controls.Add(this.label3);
            this.PlotPanel.Controls.Add(this.minRnd_Numeric);
            this.PlotPanel.Controls.Add(this.threadIntencity_Numeric);
            this.PlotPanel.Controls.Add(this.clientLimit_CheckBox);
            this.PlotPanel.Controls.Add(this.timeLimit_CheckBox);
            this.PlotPanel.Controls.Add(this.timeLimit_Numeric);
            this.PlotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotPanel.Location = new System.Drawing.Point(0, 0);
            this.PlotPanel.Name = "PlotPanel";
            this.PlotPanel.Padding = new System.Windows.Forms.Padding(0, 20, 235, 0);
            this.PlotPanel.Size = new System.Drawing.Size(971, 587);
            this.PlotPanel.TabIndex = 1;
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.statusText.Location = new System.Drawing.Point(0, 20);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(73, 17);
            this.statusText.TabIndex = 4;
            this.statusText.Text = "statusText";
            this.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusText.Visible = false;
            this.statusText.Click += new System.EventHandler(this.statusText_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Интенсивность потока λ (шт/ч):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 587);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.PlotPanel);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "Системы массового обслуживания";
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLimit_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimit_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadIntencity_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkPlace_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRnd_Numeric)).EndInit();
            this.PlotPanel.ResumeLayout(false);
            this.PlotPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Button addChannelIntencity_Button;
        private System.Windows.Forms.Button deleteChannelIntencity_Button;
        private System.Windows.Forms.ListBox channelIntencites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private OxyPlot.WindowsForms.PlotView plot1;
        private System.Windows.Forms.Panel PlotPanel;
        private System.Windows.Forms.NumericUpDown threadIntencity_Numeric;
        private System.Windows.Forms.NumericUpDown parkPlace_Numeric;
        private System.Windows.Forms.NumericUpDown minRnd_Numeric;
        private System.Windows.Forms.NumericUpDown timeLimit_Numeric;
        private System.Windows.Forms.NumericUpDown clientLimit_Numeric;
        private System.Windows.Forms.CheckBox timeLimit_CheckBox;
        private System.Windows.Forms.CheckBox preferFirstChannel_CheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label statusText;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox clientLimit_CheckBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}