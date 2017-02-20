using SCHOTT.WinForms.Controls.Buttons;
using SCHOTT.WinForms.Controls.Labels;

namespace SCHOTT.VisiLED.Dashboard.Forms
{
    partial class CommonControls
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
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.strobeOnTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.strobePeriod = new System.Windows.Forms.NumericUpDown();
            this.rotationPeriod = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.loadSettings = new System.Windows.Forms.Button();
            this.M3 = new System.Windows.Forms.Button();
            this.M2 = new System.Windows.Forms.Button();
            this.M1 = new System.Windows.Forms.Button();
            this.M0 = new System.Windows.Forms.Button();
            this.saveLoad = new ToggleButton();
            this.saveStartup = new System.Windows.Forms.Button();
            this.ToggleOutput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.transparentLabel = new TransparentLabel();
            this.scrollPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strobeOnTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strobePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.AutoSize = true;
            this.scrollPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollPanel.Controls.Add(this.tableLayoutPanel2);
            this.scrollPanel.Controls.Add(this.tableLayoutPanel1);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Padding = new System.Windows.Forms.Padding(3);
            this.scrollPanel.Size = new System.Drawing.Size(120, 610);
            this.scrollPanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.strobeOnTime, 0, 19);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 18);
            this.tableLayoutPanel2.Controls.Add(this.strobePeriod, 0, 16);
            this.tableLayoutPanel2.Controls.Add(this.rotationPeriod, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.loadSettings, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.M3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.M2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.M1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.M0, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.saveLoad, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveStartup, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.ToggleOutput, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 15);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 20;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(114, 560);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // strobeOnTime
            // 
            this.strobeOnTime.AutoSize = true;
            this.strobeOnTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.strobeOnTime.Location = new System.Drawing.Point(3, 537);
            this.strobeOnTime.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.strobeOnTime.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.strobeOnTime.Name = "strobeOnTime";
            this.strobeOnTime.Size = new System.Drawing.Size(108, 20);
            this.strobeOnTime.TabIndex = 3;
            this.strobeOnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.strobeOnTime.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.strobeOnTime.ValueChanged += new System.EventHandler(this.strobeOnTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Strobe On\r\nTime (µs)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // strobePeriod
            // 
            this.strobePeriod.AutoSize = true;
            this.strobePeriod.Dock = System.Windows.Forms.DockStyle.Top;
            this.strobePeriod.Location = new System.Drawing.Point(3, 465);
            this.strobePeriod.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.strobePeriod.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.strobePeriod.Name = "strobePeriod";
            this.strobePeriod.Size = new System.Drawing.Size(108, 20);
            this.strobePeriod.TabIndex = 3;
            this.strobePeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.strobePeriod.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.strobePeriod.ValueChanged += new System.EventHandler(this.strobePeriod_ValueChanged);
            // 
            // rotationPeriod
            // 
            this.rotationPeriod.AutoSize = true;
            this.rotationPeriod.Dock = System.Windows.Forms.DockStyle.Top;
            this.rotationPeriod.Location = new System.Drawing.Point(3, 393);
            this.rotationPeriod.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.rotationPeriod.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rotationPeriod.Name = "rotationPeriod";
            this.rotationPeriod.Size = new System.Drawing.Size(108, 20);
            this.rotationPeriod.TabIndex = 3;
            this.rotationPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rotationPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rotationPeriod.ValueChanged += new System.EventHandler(this.rotationPeriod_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rotation\r\nPeriod (ms)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadSettings
            // 
            this.loadSettings.AutoSize = true;
            this.loadSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadSettings.Location = new System.Drawing.Point(3, 305);
            this.loadSettings.Name = "loadSettings";
            this.loadSettings.Size = new System.Drawing.Size(108, 36);
            this.loadSettings.TabIndex = 1;
            this.loadSettings.Text = "Get Unit\r\nState";
            this.loadSettings.UseVisualStyleBackColor = true;
            this.loadSettings.Click += new System.EventHandler(this.loadSettings_Click);
            // 
            // M3
            // 
            this.M3.AutoSize = true;
            this.M3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.M3.Dock = System.Windows.Forms.DockStyle.Top;
            this.M3.Location = new System.Drawing.Point(3, 139);
            this.M3.Name = "M3";
            this.M3.Size = new System.Drawing.Size(108, 23);
            this.M3.TabIndex = 0;
            this.M3.Text = "M4";
            this.M3.UseVisualStyleBackColor = true;
            this.M3.Click += new System.EventHandler(this.MemoryClick);
            // 
            // M2
            // 
            this.M2.AutoSize = true;
            this.M2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.M2.Dock = System.Windows.Forms.DockStyle.Top;
            this.M2.Location = new System.Drawing.Point(3, 110);
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(108, 23);
            this.M2.TabIndex = 0;
            this.M2.Text = "M4";
            this.M2.UseVisualStyleBackColor = true;
            this.M2.Click += new System.EventHandler(this.MemoryClick);
            // 
            // M1
            // 
            this.M1.AutoSize = true;
            this.M1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.M1.Dock = System.Windows.Forms.DockStyle.Top;
            this.M1.Location = new System.Drawing.Point(3, 81);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(108, 23);
            this.M1.TabIndex = 0;
            this.M1.Text = "M3";
            this.M1.UseVisualStyleBackColor = true;
            this.M1.Click += new System.EventHandler(this.MemoryClick);
            // 
            // M0
            // 
            this.M0.AutoSize = true;
            this.M0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.M0.Dock = System.Windows.Forms.DockStyle.Top;
            this.M0.Location = new System.Drawing.Point(3, 52);
            this.M0.Name = "M0";
            this.M0.Size = new System.Drawing.Size(108, 23);
            this.M0.TabIndex = 0;
            this.M0.Text = "M2";
            this.M0.UseVisualStyleBackColor = true;
            this.M0.Click += new System.EventHandler(this.MemoryClick);
            // 
            // saveLoad
            // 
            this.saveLoad.AutoSize = true;
            this.saveLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveLoad.Channel = 0;
            this.saveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad.Location = new System.Drawing.Point(3, 3);
            this.saveLoad.Name = "saveLoad";
            this.saveLoad.Size = new System.Drawing.Size(108, 23);
            this.saveLoad.TabIndex = 0;
            this.saveLoad.Text = "Save";
            this.saveLoad.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.saveLoad.ToggleDisabledText = "Disabled";
            this.saveLoad.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.saveLoad.ToggleEnabledText = "Enabled";
            this.saveLoad.UseVisualStyleBackColor = true;
            this.saveLoad.Click += new System.EventHandler(this.saveLoad_Click);
            // 
            // saveStartup
            // 
            this.saveStartup.AutoSize = true;
            this.saveStartup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveStartup.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveStartup.Location = new System.Drawing.Point(3, 188);
            this.saveStartup.Name = "saveStartup";
            this.saveStartup.Size = new System.Drawing.Size(108, 49);
            this.saveStartup.TabIndex = 4;
            this.saveStartup.Text = "Save\r\nStartup\r\nConfig";
            this.saveStartup.UseVisualStyleBackColor = true;
            this.saveStartup.Click += new System.EventHandler(this.saveStartup_Click);
            // 
            // ToggleOutput
            // 
            this.ToggleOutput.AutoSize = true;
            this.ToggleOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToggleOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToggleOutput.Location = new System.Drawing.Point(3, 263);
            this.ToggleOutput.Name = "ToggleOutput";
            this.ToggleOutput.Size = new System.Drawing.Size(108, 36);
            this.ToggleOutput.TabIndex = 1;
            this.ToggleOutput.Text = "Toggle\r\nOutputs";
            this.ToggleOutput.UseVisualStyleBackColor = true;
            this.ToggleOutput.Click += new System.EventHandler(this.ToggleOutput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Strobe\r\nPeriod (µs)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // transparentLabel
            // 
            this.transparentLabel.BackColor = System.Drawing.Color.Transparent;
            this.transparentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel.Location = new System.Drawing.Point(0, 0);
            this.transparentLabel.Name = "transparentLabel";
            this.transparentLabel.Opacity = 150;
            this.transparentLabel.Size = new System.Drawing.Size(120, 610);
            this.transparentLabel.TabIndex = 4;
            this.transparentLabel.TransparentBackColor = System.Drawing.Color.SlateGray;
            // 
            // CommonControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 610);
            this.Controls.Add(this.scrollPanel);
            this.Controls.Add(this.transparentLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CommonControls";
            this.Text = "CommonControls";
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strobeOnTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strobePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ToggleButton saveLoad;
        private System.Windows.Forms.Button M0;
        private System.Windows.Forms.Button M1;
        private System.Windows.Forms.Button M2;
        private System.Windows.Forms.Button M3;
        private System.Windows.Forms.Button ToggleOutput;
        private System.Windows.Forms.Button loadSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rotationPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown strobePeriod;
        private System.Windows.Forms.NumericUpDown strobeOnTime;
        private TransparentLabel transparentLabel;
        private System.Windows.Forms.Button saveStartup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}