using SCHOTT.WinForms.Controls.Buttons;
using SCHOTT.WinForms.Controls.Combo_Controls;
using SCHOTT.WinForms.Controls.Labels;

namespace SCHOTT.VisiLED.Dashboard.Forms
{
    partial class ChannelControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChannelControls));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 0D);
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.segmentsFull = new System.Windows.Forms.Button();
            this.segmentsNone = new System.Windows.Forms.Button();
            this.segmentsEigthSpaced = new System.Windows.Forms.Button();
            this.segmentsQuarterSpaced = new System.Windows.Forms.Button();
            this.segmentsQuarter = new System.Windows.Forms.Button();
            this.segmentsHalf = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.contRotationCW = new ToggleButton();
            this.strobe = new ToggleButton();
            this.contRotationCCW = new ToggleButton();
            this.rotateCCW = new System.Windows.Forms.Button();
            this.rotateCW = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.outputPowerToggle = new ToggleButton();
            this.outputPower = new SliderNumericCombo();
            this.segments = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.transparentLabel = new TransparentLabel();
            this.scrollPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segments)).BeginInit();
            this.SuspendLayout();
            // 
            // scrollPanel
            // 
            this.scrollPanel.Controls.Add(this.tableLayoutPanel1);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Padding = new System.Windows.Forms.Padding(3);
            this.scrollPanel.Size = new System.Drawing.Size(292, 442);
            this.scrollPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.segments, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 436);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 264);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(280, 169);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.segmentsFull, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.segmentsNone, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.segmentsEigthSpaced, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.segmentsQuarterSpaced, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.segmentsQuarter, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.segmentsHalf, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(274, 50);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // segmentsFull
            // 
            this.segmentsFull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.segmentsFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.segmentsFull.Location = new System.Drawing.Point(3, 3);
            this.segmentsFull.Name = "segmentsFull";
            this.segmentsFull.Size = new System.Drawing.Size(39, 44);
            this.segmentsFull.TabIndex = 0;
            this.segmentsFull.UseVisualStyleBackColor = true;
            this.segmentsFull.Click += new System.EventHandler(this.segmentsFull_Click);
            // 
            // segmentsNone
            // 
            this.segmentsNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.segmentsNone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.segmentsNone.Location = new System.Drawing.Point(228, 3);
            this.segmentsNone.Name = "segmentsNone";
            this.segmentsNone.Size = new System.Drawing.Size(43, 44);
            this.segmentsNone.TabIndex = 5;
            this.segmentsNone.UseVisualStyleBackColor = true;
            this.segmentsNone.Click += new System.EventHandler(this.segmentsNone_Click);
            // 
            // segmentsEigthSpaced
            // 
            this.segmentsEigthSpaced.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.segmentsEigthSpaced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.segmentsEigthSpaced.Location = new System.Drawing.Point(183, 3);
            this.segmentsEigthSpaced.Name = "segmentsEigthSpaced";
            this.segmentsEigthSpaced.Size = new System.Drawing.Size(39, 44);
            this.segmentsEigthSpaced.TabIndex = 4;
            this.segmentsEigthSpaced.UseVisualStyleBackColor = true;
            this.segmentsEigthSpaced.Click += new System.EventHandler(this.segmentsEigthSpaced_Click);
            // 
            // segmentsQuarterSpaced
            // 
            this.segmentsQuarterSpaced.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.segmentsQuarterSpaced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.segmentsQuarterSpaced.Location = new System.Drawing.Point(138, 3);
            this.segmentsQuarterSpaced.Name = "segmentsQuarterSpaced";
            this.segmentsQuarterSpaced.Size = new System.Drawing.Size(39, 44);
            this.segmentsQuarterSpaced.TabIndex = 3;
            this.segmentsQuarterSpaced.UseVisualStyleBackColor = true;
            this.segmentsQuarterSpaced.Click += new System.EventHandler(this.segmentsQuarterSpaced_Click);
            // 
            // segmentsQuarter
            // 
            this.segmentsQuarter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.segmentsQuarter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.segmentsQuarter.Location = new System.Drawing.Point(93, 3);
            this.segmentsQuarter.Name = "segmentsQuarter";
            this.segmentsQuarter.Size = new System.Drawing.Size(39, 44);
            this.segmentsQuarter.TabIndex = 2;
            this.segmentsQuarter.UseVisualStyleBackColor = true;
            this.segmentsQuarter.Click += new System.EventHandler(this.segmentsQuarter_Click);
            // 
            // segmentsHalf
            // 
            this.segmentsHalf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.segmentsHalf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.segmentsHalf.Location = new System.Drawing.Point(48, 3);
            this.segmentsHalf.Name = "segmentsHalf";
            this.segmentsHalf.Size = new System.Drawing.Size(39, 44);
            this.segmentsHalf.TabIndex = 1;
            this.segmentsHalf.UseVisualStyleBackColor = true;
            this.segmentsHalf.Click += new System.EventHandler(this.segmentsHalf_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.contRotationCW, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.strobe, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.contRotationCCW, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rotateCCW, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rotateCW, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 50);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // contRotationCW
            // 
            this.contRotationCW.BackColor = System.Drawing.Color.Red;
            this.contRotationCW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contRotationCW.BackgroundImage")));
            this.contRotationCW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.contRotationCW.Channel = 0;
            this.contRotationCW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contRotationCW.Location = new System.Drawing.Point(165, 3);
            this.contRotationCW.Name = "contRotationCW";
            this.contRotationCW.Size = new System.Drawing.Size(48, 44);
            this.contRotationCW.TabIndex = 3;
            this.contRotationCW.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.contRotationCW.ToggleDisabledText = "Disabled";
            this.contRotationCW.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.contRotationCW.ToggleEnabledText = "Enabled";
            this.contRotationCW.UseVisualStyleBackColor = false;
            this.contRotationCW.Click += new System.EventHandler(this.contRotationCW_Click);
            // 
            // strobe
            // 
            this.strobe.BackColor = System.Drawing.Color.Red;
            this.strobe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("strobe.BackgroundImage")));
            this.strobe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.strobe.Channel = 0;
            this.strobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strobe.Location = new System.Drawing.Point(219, 3);
            this.strobe.Name = "strobe";
            this.strobe.Size = new System.Drawing.Size(52, 44);
            this.strobe.TabIndex = 4;
            this.strobe.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.strobe.ToggleDisabledText = "Disabled";
            this.strobe.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.strobe.ToggleEnabledText = "Enabled";
            this.strobe.UseVisualStyleBackColor = false;
            this.strobe.Click += new System.EventHandler(this.strobe_Click);
            // 
            // contRotationCCW
            // 
            this.contRotationCCW.BackColor = System.Drawing.Color.Red;
            this.contRotationCCW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contRotationCCW.BackgroundImage")));
            this.contRotationCCW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.contRotationCCW.Channel = 0;
            this.contRotationCCW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contRotationCCW.Location = new System.Drawing.Point(3, 3);
            this.contRotationCCW.Name = "contRotationCCW";
            this.contRotationCCW.Size = new System.Drawing.Size(48, 44);
            this.contRotationCCW.TabIndex = 0;
            this.contRotationCCW.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.contRotationCCW.ToggleDisabledText = "Disabled";
            this.contRotationCCW.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.contRotationCCW.ToggleEnabledText = "Enabled";
            this.contRotationCCW.UseVisualStyleBackColor = false;
            this.contRotationCCW.Click += new System.EventHandler(this.contRotationCCW_Click);
            // 
            // rotateCCW
            // 
            this.rotateCCW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rotateCCW.BackgroundImage")));
            this.rotateCCW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rotateCCW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateCCW.Location = new System.Drawing.Point(57, 3);
            this.rotateCCW.Name = "rotateCCW";
            this.rotateCCW.Size = new System.Drawing.Size(48, 44);
            this.rotateCCW.TabIndex = 1;
            this.rotateCCW.UseVisualStyleBackColor = true;
            this.rotateCCW.Click += new System.EventHandler(this.rotateCCW_Click);
            // 
            // rotateCW
            // 
            this.rotateCW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rotateCW.BackgroundImage")));
            this.rotateCW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rotateCW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateCW.Location = new System.Drawing.Point(111, 3);
            this.rotateCW.Name = "rotateCW";
            this.rotateCW.Size = new System.Drawing.Size(48, 44);
            this.rotateCW.TabIndex = 2;
            this.rotateCW.UseVisualStyleBackColor = true;
            this.rotateCW.Click += new System.EventHandler(this.rotateCW_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.Controls.Add(this.outputPowerToggle, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.outputPower, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 115);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(274, 51);
            this.tableLayoutPanel6.TabIndex = 14;
            // 
            // outputPowerToggle
            // 
            this.outputPowerToggle.AutoSize = true;
            this.outputPowerToggle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outputPowerToggle.Channel = 0;
            this.outputPowerToggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPowerToggle.Location = new System.Drawing.Point(3, 3);
            this.outputPowerToggle.Name = "outputPowerToggle";
            this.outputPowerToggle.Size = new System.Drawing.Size(48, 45);
            this.outputPowerToggle.TabIndex = 0;
            this.outputPowerToggle.Text = "Off";
            this.outputPowerToggle.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.outputPowerToggle.ToggleDisabledText = "Disabled";
            this.outputPowerToggle.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.outputPowerToggle.ToggleEnabledText = "Enabled";
            this.outputPowerToggle.UseVisualStyleBackColor = true;
            this.outputPowerToggle.Click += new System.EventHandler(this.outputPowerToggle_Click);
            // 
            // outputPower
            // 
            this.outputPower.AutoSize = true;
            this.outputPower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outputPower.Channel = 0;
            this.outputPower.DecimalPlaces = 0;
            this.outputPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPower.FontSize = 8.25F;
            this.outputPower.Location = new System.Drawing.Point(57, 3);
            this.outputPower.Maximum = 100;
            this.outputPower.Minimum = 0;
            this.outputPower.Name = "outputPower";
            this.outputPower.Size = new System.Drawing.Size(214, 45);
            this.outputPower.TabIndex = 1;
            this.outputPower.Value = 50;
            // 
            // segments
            // 
            this.segments.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.segments.ChartAreas.Add(chartArea1);
            this.segments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.segments.Location = new System.Drawing.Point(3, 3);
            this.segments.Name = "segments";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Name = "Series1";
            dataPoint1.BorderColor = System.Drawing.Color.Black;
            dataPoint1.Color = System.Drawing.Color.Red;
            dataPoint2.BorderColor = System.Drawing.Color.Black;
            dataPoint2.Color = System.Drawing.Color.Red;
            dataPoint3.BorderColor = System.Drawing.Color.Black;
            dataPoint3.Color = System.Drawing.Color.Red;
            dataPoint4.BorderColor = System.Drawing.Color.Black;
            dataPoint4.Color = System.Drawing.Color.Red;
            dataPoint5.BorderColor = System.Drawing.Color.Black;
            dataPoint5.Color = System.Drawing.Color.Red;
            dataPoint6.BorderColor = System.Drawing.Color.Black;
            dataPoint6.Color = System.Drawing.Color.Red;
            dataPoint7.BorderColor = System.Drawing.Color.Black;
            dataPoint7.Color = System.Drawing.Color.Red;
            dataPoint8.BorderColor = System.Drawing.Color.Black;
            dataPoint8.Color = System.Drawing.Color.Red;
            dataPoint9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataPoint9.IsValueShownAsLabel = false;
            dataPoint9.Label = "Cord";
            dataPoint9.LabelBackColor = System.Drawing.Color.Black;
            dataPoint9.LabelForeColor = System.Drawing.Color.White;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            this.segments.Series.Add(series1);
            this.segments.Size = new System.Drawing.Size(280, 255);
            this.segments.TabIndex = 0;
            this.segments.Text = "chart1";
            // 
            // transparentLabel
            // 
            this.transparentLabel.BackColor = System.Drawing.Color.Transparent;
            this.transparentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel.Location = new System.Drawing.Point(0, 0);
            this.transparentLabel.Name = "transparentLabel";
            this.transparentLabel.Opacity = 150;
            this.transparentLabel.Size = new System.Drawing.Size(292, 442);
            this.transparentLabel.TabIndex = 3;
            this.transparentLabel.TransparentBackColor = System.Drawing.Color.SlateGray;
            // 
            // ChannelControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 442);
            this.Controls.Add(this.scrollPanel);
            this.Controls.Add(this.transparentLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChannelControls";
            this.Text = "Controls";
            this.scrollPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart segments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button rotateCW;
        private System.Windows.Forms.Button rotateCCW;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button segmentsEigthSpaced;
        private System.Windows.Forms.Button segmentsFull;
        private System.Windows.Forms.Button segmentsHalf;
        private System.Windows.Forms.Button segmentsQuarter;
        private System.Windows.Forms.Button segmentsQuarterSpaced;
        private System.Windows.Forms.Button segmentsNone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private ToggleButton contRotationCW;
        private ToggleButton contRotationCCW;
        private ToggleButton strobe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private ToggleButton outputPowerToggle;
        private SliderNumericCombo outputPower;
        private TransparentLabel transparentLabel;
    }
}