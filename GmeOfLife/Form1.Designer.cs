
namespace GameOfLife
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bExit = new System.Windows.Forms.Button();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bSTOP = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.labelDensity = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.bExit);
            this.splitContainer1.Panel1.Controls.Add(this.nudTimer);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.bSTOP);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            this.splitContainer1.Panel1.Controls.Add(this.nudDensity);
            this.splitContainer1.Panel1.Controls.Add(this.labelDensity);
            this.splitContainer1.Panel1.Controls.Add(this.nudResolution);
            this.splitContainer1.Panel1.Controls.Add(this.labelResolution);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Inconsolata LGC", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1366, 749);
            this.splitContainer1.SplitterDistance = 191;
            this.splitContainer1.TabIndex = 0;
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Black;
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Inconsolata LGC", 10F);
            this.bExit.ForeColor = System.Drawing.SystemColors.Info;
            this.bExit.Location = new System.Drawing.Point(65, 290);
            this.bExit.Margin = new System.Windows.Forms.Padding(0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(50, 25);
            this.bExit.TabIndex = 8;
            this.bExit.Text = "exit";
            this.bExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bExit_MouseClick);
            // 
            // nudTimer
            // 
            this.nudTimer.AutoSize = true;
            this.nudTimer.BackColor = System.Drawing.Color.Black;
            this.nudTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTimer.Font = new System.Drawing.Font("Inconsolata LGC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.nudTimer.ForeColor = System.Drawing.Color.Red;
            this.nudTimer.Location = new System.Drawing.Point(103, 63);
            this.nudTimer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimer.Name = "nudTimer";
            this.nudTimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudTimer.Size = new System.Drawing.Size(81, 23);
            this.nudTimer.TabIndex = 7;
            this.nudTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTimer.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Inconsolata LGC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Timer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bSTOP
            // 
            this.bSTOP.BackColor = System.Drawing.Color.Red;
            this.bSTOP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bSTOP.FlatAppearance.BorderSize = 0;
            this.bSTOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSTOP.Font = new System.Drawing.Font("Inconsolata LGC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSTOP.Location = new System.Drawing.Point(99, 152);
            this.bSTOP.Margin = new System.Windows.Forms.Padding(0);
            this.bSTOP.Name = "bSTOP";
            this.bSTOP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bSTOP.Size = new System.Drawing.Size(85, 45);
            this.bSTOP.TabIndex = 5;
            this.bSTOP.Text = "STOP";
            this.bSTOP.UseVisualStyleBackColor = false;
            this.bSTOP.Click += new System.EventHandler(this.bSTOP_Click);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bStart.Font = new System.Drawing.Font("Inconsolata LGC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.ForeColor = System.Drawing.Color.Black;
            this.bStart.Location = new System.Drawing.Point(6, 152);
            this.bStart.Name = "bStart";
            this.bStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bStart.Size = new System.Drawing.Size(85, 45);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "START";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // nudDensity
            // 
            this.nudDensity.AutoSize = true;
            this.nudDensity.BackColor = System.Drawing.Color.Black;
            this.nudDensity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudDensity.Font = new System.Drawing.Font("Inconsolata LGC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.nudDensity.ForeColor = System.Drawing.Color.Red;
            this.nudDensity.Location = new System.Drawing.Point(103, 35);
            this.nudDensity.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudDensity.Size = new System.Drawing.Size(81, 23);
            this.nudDensity.TabIndex = 3;
            this.nudDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDensity.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // labelDensity
            // 
            this.labelDensity.AutoSize = true;
            this.labelDensity.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDensity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelDensity.Font = new System.Drawing.Font("Inconsolata LGC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDensity.ForeColor = System.Drawing.Color.Red;
            this.labelDensity.Location = new System.Drawing.Point(3, 37);
            this.labelDensity.Name = "labelDensity";
            this.labelDensity.Size = new System.Drawing.Size(71, 18);
            this.labelDensity.TabIndex = 2;
            this.labelDensity.Text = "Density";
            this.labelDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelResolution.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelResolution.Font = new System.Drawing.Font("Inconsolata LGC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResolution.ForeColor = System.Drawing.Color.Red;
            this.labelResolution.Location = new System.Drawing.Point(3, 11);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(98, 18);
            this.labelResolution.TabIndex = 0;
            this.labelResolution.Text = "Resolution";
            this.labelResolution.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1167, 745);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nudResolution
            // 
            this.nudResolution.AllowDrop = true;
            this.nudResolution.AutoSize = true;
            this.nudResolution.BackColor = System.Drawing.Color.Black;
            this.nudResolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudResolution.Font = new System.Drawing.Font("Inconsolata LGC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.nudResolution.ForeColor = System.Drawing.Color.Red;
            this.nudResolution.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudResolution.Location = new System.Drawing.Point(103, 9);
            this.nudResolution.Margin = new System.Windows.Forms.Padding(0);
            this.nudResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudResolution.Size = new System.Drawing.Size(81, 23);
            this.nudResolution.TabIndex = 1;
            this.nudResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudResolution.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Game Of Life";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDensity;
        private System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.Button bSTOP;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown nudTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.NumericUpDown nudResolution;
    }
}

