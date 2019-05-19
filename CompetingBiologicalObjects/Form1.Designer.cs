namespace CompetingBiologicalObjects
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlotButton = new System.Windows.Forms.Button();
            this.GraphControl = new ZedGraph.ZedGraphControl();
            this.SaveGraphDialog = new System.Windows.Forms.SaveFileDialog();
            this.TimeSpan = new System.Windows.Forms.NumericUpDown();
            this.StepSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PredPreyTabControl = new System.Windows.Forms.TabControl();
            this.PredatorTabPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PredatorPopulation = new System.Windows.Forms.NumericUpDown();
            this.PredatorDeathRate = new System.Windows.Forms.NumericUpDown();
            this.PredatorBirthRate = new System.Windows.Forms.NumericUpDown();
            this.PreyTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PreyPopulation = new System.Windows.Forms.NumericUpDown();
            this.PreyDeathRate = new System.Windows.Forms.NumericUpDown();
            this.PreyBirthRate = new System.Windows.Forms.NumericUpDown();
            this.RKF45 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepSize)).BeginInit();
            this.PredPreyTabControl.SuspendLayout();
            this.PredatorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorDeathRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorBirthRate)).BeginInit();
            this.PreyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreyPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreyDeathRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreyBirthRate)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1006, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGraphToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveGraphToolStripMenuItem
            // 
            this.saveGraphToolStripMenuItem.Name = "saveGraphToolStripMenuItem";
            this.saveGraphToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.saveGraphToolStripMenuItem.Text = "Save graph";
            this.saveGraphToolStripMenuItem.Click += new System.EventHandler(this.saveGraphToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PlotButton
            // 
            this.PlotButton.Location = new System.Drawing.Point(9, 407);
            this.PlotButton.Name = "PlotButton";
            this.PlotButton.Size = new System.Drawing.Size(98, 46);
            this.PlotButton.TabIndex = 1;
            this.PlotButton.Text = "Plot";
            this.PlotButton.UseVisualStyleBackColor = true;
            this.PlotButton.Click += new System.EventHandler(this.PlotButton_Click);
            // 
            // GraphControl
            // 
            this.GraphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraphControl.IsShowPointValues = false;
            this.GraphControl.Location = new System.Drawing.Point(219, 44);
            this.GraphControl.Name = "GraphControl";
            this.GraphControl.PointValueFormat = "G";
            this.GraphControl.Size = new System.Drawing.Size(775, 409);
            this.GraphControl.TabIndex = 2;
            // 
            // SaveGraphDialog
            // 
            this.SaveGraphDialog.DefaultExt = "png";
            this.SaveGraphDialog.FileName = "graph.png";
            this.SaveGraphDialog.Filter = "Image files (*.png)|*.png";
            this.SaveGraphDialog.Title = "Save graph";
            // 
            // TimeSpan
            // 
            this.TimeSpan.Location = new System.Drawing.Point(85, 357);
            this.TimeSpan.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TimeSpan.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TimeSpan.Name = "TimeSpan";
            this.TimeSpan.Size = new System.Drawing.Size(79, 22);
            this.TimeSpan.TabIndex = 9;
            this.TimeSpan.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // StepSize
            // 
            this.StepSize.DecimalPlaces = 3;
            this.StepSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.StepSize.Location = new System.Drawing.Point(85, 317);
            this.StepSize.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.StepSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            196608});
            this.StepSize.Name = "StepSize";
            this.StepSize.Size = new System.Drawing.Size(79, 22);
            this.StepSize.TabIndex = 8;
            this.StepSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            196608});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Step size:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Iterations:";
            // 
            // PredPreyTabControl
            // 
            this.PredPreyTabControl.Controls.Add(this.PredatorTabPage);
            this.PredPreyTabControl.Controls.Add(this.PreyTabPage);
            this.PredPreyTabControl.Location = new System.Drawing.Point(12, 44);
            this.PredPreyTabControl.Name = "PredPreyTabControl";
            this.PredPreyTabControl.SelectedIndex = 0;
            this.PredPreyTabControl.Size = new System.Drawing.Size(200, 150);
            this.PredPreyTabControl.TabIndex = 13;
            // 
            // PredatorTabPage
            // 
            this.PredatorTabPage.BackColor = System.Drawing.Color.White;
            this.PredatorTabPage.Controls.Add(this.label6);
            this.PredatorTabPage.Controls.Add(this.label5);
            this.PredatorTabPage.Controls.Add(this.label4);
            this.PredatorTabPage.Controls.Add(this.PredatorPopulation);
            this.PredatorTabPage.Controls.Add(this.PredatorDeathRate);
            this.PredatorTabPage.Controls.Add(this.PredatorBirthRate);
            this.PredatorTabPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PredatorTabPage.Location = new System.Drawing.Point(4, 25);
            this.PredatorTabPage.Name = "PredatorTabPage";
            this.PredatorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PredatorTabPage.Size = new System.Drawing.Size(192, 121);
            this.PredatorTabPage.TabIndex = 0;
            this.PredatorTabPage.Text = "Predator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Population:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Death rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Birth rate:";
            // 
            // PredatorPopulation
            // 
            this.PredatorPopulation.Location = new System.Drawing.Point(101, 81);
            this.PredatorPopulation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PredatorPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PredatorPopulation.Name = "PredatorPopulation";
            this.PredatorPopulation.Size = new System.Drawing.Size(79, 22);
            this.PredatorPopulation.TabIndex = 18;
            this.PredatorPopulation.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // PredatorDeathRate
            // 
            this.PredatorDeathRate.DecimalPlaces = 3;
            this.PredatorDeathRate.Location = new System.Drawing.Point(101, 49);
            this.PredatorDeathRate.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PredatorDeathRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.PredatorDeathRate.Name = "PredatorDeathRate";
            this.PredatorDeathRate.Size = new System.Drawing.Size(79, 22);
            this.PredatorDeathRate.TabIndex = 17;
            this.PredatorDeathRate.Value = new decimal(new int[] {
            200,
            0,
            0,
            131072});
            // 
            // PredatorBirthRate
            // 
            this.PredatorBirthRate.DecimalPlaces = 3;
            this.PredatorBirthRate.Location = new System.Drawing.Point(101, 17);
            this.PredatorBirthRate.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PredatorBirthRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.PredatorBirthRate.Name = "PredatorBirthRate";
            this.PredatorBirthRate.Size = new System.Drawing.Size(79, 22);
            this.PredatorBirthRate.TabIndex = 16;
            this.PredatorBirthRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // PreyTabPage
            // 
            this.PreyTabPage.Controls.Add(this.label1);
            this.PreyTabPage.Controls.Add(this.label2);
            this.PreyTabPage.Controls.Add(this.label3);
            this.PreyTabPage.Controls.Add(this.PreyPopulation);
            this.PreyTabPage.Controls.Add(this.PreyDeathRate);
            this.PreyTabPage.Controls.Add(this.PreyBirthRate);
            this.PreyTabPage.Location = new System.Drawing.Point(4, 25);
            this.PreyTabPage.Name = "PreyTabPage";
            this.PreyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PreyTabPage.Size = new System.Drawing.Size(192, 121);
            this.PreyTabPage.TabIndex = 1;
            this.PreyTabPage.Text = "Prey";
            this.PreyTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Population:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Death rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Birth rate:";
            // 
            // PreyPopulation
            // 
            this.PreyPopulation.Location = new System.Drawing.Point(101, 81);
            this.PreyPopulation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PreyPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PreyPopulation.Name = "PreyPopulation";
            this.PreyPopulation.Size = new System.Drawing.Size(79, 22);
            this.PreyPopulation.TabIndex = 18;
            this.PreyPopulation.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // PreyDeathRate
            // 
            this.PreyDeathRate.DecimalPlaces = 3;
            this.PreyDeathRate.Location = new System.Drawing.Point(101, 49);
            this.PreyDeathRate.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PreyDeathRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.PreyDeathRate.Name = "PreyDeathRate";
            this.PreyDeathRate.Size = new System.Drawing.Size(79, 22);
            this.PreyDeathRate.TabIndex = 17;
            this.PreyDeathRate.Value = new decimal(new int[] {
            40,
            0,
            0,
            131072});
            // 
            // PreyBirthRate
            // 
            this.PreyBirthRate.DecimalPlaces = 3;
            this.PreyBirthRate.Location = new System.Drawing.Point(101, 17);
            this.PreyBirthRate.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PreyBirthRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.PreyBirthRate.Name = "PreyBirthRate";
            this.PreyBirthRate.Size = new System.Drawing.Size(79, 22);
            this.PreyBirthRate.TabIndex = 16;
            this.PreyBirthRate.Value = new decimal(new int[] {
            40,
            0,
            0,
            131072});
            // 
            // RKF45
            // 
            this.RKF45.AutoSize = true;
            this.RKF45.Location = new System.Drawing.Point(12, 219);
            this.RKF45.Name = "RKF45";
            this.RKF45.Size = new System.Drawing.Size(102, 21);
            this.RKF45.TabIndex = 14;
            this.RKF45.Text = "Use RKF45";
            this.RKF45.UseVisualStyleBackColor = true;
            this.RKF45.CheckedChanged += new System.EventHandler(this.RKF45_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Step size chosen automatically";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1006, 465);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RKF45);
            this.Controls.Add(this.PredPreyTabControl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TimeSpan);
            this.Controls.Add(this.StepSize);
            this.Controls.Add(this.GraphControl);
            this.Controls.Add(this.PlotButton);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(1024, 512);
            this.Name = "Form1";
            this.Text = "Competing Biological Objects";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepSize)).EndInit();
            this.PredPreyTabControl.ResumeLayout(false);
            this.PredatorTabPage.ResumeLayout(false);
            this.PredatorTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorDeathRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorBirthRate)).EndInit();
            this.PreyTabPage.ResumeLayout(false);
            this.PreyTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreyPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreyDeathRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreyBirthRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button PlotButton;
        private ZedGraph.ZedGraphControl GraphControl;
        private System.Windows.Forms.SaveFileDialog SaveGraphDialog;
        private System.Windows.Forms.NumericUpDown TimeSpan;
        private System.Windows.Forms.NumericUpDown StepSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl PredPreyTabControl;
        private System.Windows.Forms.TabPage PredatorTabPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PredatorPopulation;
        private System.Windows.Forms.NumericUpDown PredatorDeathRate;
        private System.Windows.Forms.NumericUpDown PredatorBirthRate;
        private System.Windows.Forms.TabPage PreyTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PreyPopulation;
        private System.Windows.Forms.NumericUpDown PreyDeathRate;
        private System.Windows.Forms.NumericUpDown PreyBirthRate;
        private System.Windows.Forms.CheckBox RKF45;
        private System.Windows.Forms.Label label9;
    }
}

