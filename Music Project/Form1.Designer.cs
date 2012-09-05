namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pKeyDisplay = new System.Windows.Forms.Panel();
            this.lKeyDisplay = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bLeft = new System.Windows.Forms.Button();
            this.bMiddle = new System.Windows.Forms.Button();
            this.bRight = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.rMajor = new System.Windows.Forms.RadioButton();
            this.rBoth = new System.Windows.Forms.RadioButton();
            this.rMinor = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MinorTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pKeyDisplay.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weeeeToolStripMenuItem,
            this.timerToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // weeeeToolStripMenuItem
            // 
            this.weeeeToolStripMenuItem.Name = "weeeeToolStripMenuItem";
            this.weeeeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.weeeeToolStripMenuItem.Text = "Weeee!";
            this.weeeeToolStripMenuItem.Click += new System.EventHandler(this.weeeeToolStripMenuItem_Click);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editIntervalToolStripMenuItem});
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.timerToolStripMenuItem.Text = "Timer";
            // 
            // editIntervalToolStripMenuItem
            // 
            this.editIntervalToolStripMenuItem.Name = "editIntervalToolStripMenuItem";
            this.editIntervalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.editIntervalToolStripMenuItem.Text = "Edit Interval";
            this.editIntervalToolStripMenuItem.Click += new System.EventHandler(this.editIntervalToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.14271F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.74725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.36264F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 364);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 212);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pKeyDisplay, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.6087F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.3913F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(493, 212);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 20);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Press the buttons below for random keys to be generated";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pKeyDisplay
            // 
            this.pKeyDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pKeyDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pKeyDisplay.Controls.Add(this.lKeyDisplay);
            this.pKeyDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pKeyDisplay.Location = new System.Drawing.Point(3, 29);
            this.pKeyDisplay.Name = "pKeyDisplay";
            this.pKeyDisplay.Size = new System.Drawing.Size(487, 180);
            this.pKeyDisplay.TabIndex = 1;
            // 
            // lKeyDisplay
            // 
            this.lKeyDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lKeyDisplay.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKeyDisplay.Location = new System.Drawing.Point(0, 0);
            this.lKeyDisplay.Multiline = true;
            this.lKeyDisplay.Name = "lKeyDisplay";
            this.lKeyDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lKeyDisplay.Size = new System.Drawing.Size(485, 178);
            this.lKeyDisplay.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 94);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.bLeft, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bMiddle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bRight, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(493, 94);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // bLeft
            // 
            this.bLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLeft.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLeft.Location = new System.Drawing.Point(3, 3);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(158, 88);
            this.bLeft.TabIndex = 0;
            this.bLeft.Text = "Major";
            this.bLeft.UseVisualStyleBackColor = false;
            this.bLeft.Click += new System.EventHandler(this.bLeft_Click_1);
            // 
            // bMiddle
            // 
            this.bMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bMiddle.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMiddle.Location = new System.Drawing.Point(167, 3);
            this.bMiddle.Name = "bMiddle";
            this.bMiddle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bMiddle.Size = new System.Drawing.Size(158, 88);
            this.bMiddle.TabIndex = 1;
            this.bMiddle.Text = "Both";
            this.bMiddle.UseVisualStyleBackColor = false;
            this.bMiddle.Click += new System.EventHandler(this.bMiddle_Click_1);
            // 
            // bRight
            // 
            this.bRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRight.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRight.Location = new System.Drawing.Point(331, 3);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(159, 88);
            this.bRight.TabIndex = 2;
            this.bRight.Text = "Minor";
            this.bRight.UseVisualStyleBackColor = false;
            this.bRight.Click += new System.EventHandler(this.bRight_Click_1);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.bReset, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 318);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(493, 43);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // bReset
            // 
            this.bReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bReset.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(3, 3);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(240, 37);
            this.bReset.TabIndex = 0;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.82158F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.17842F));
            this.tableLayoutPanel5.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(249, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(241, 37);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Timed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.rMajor, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.rBoth, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.rMinor, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(64, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(177, 37);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // rMajor
            // 
            this.rMajor.AutoSize = true;
            this.rMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rMajor.Checked = true;
            this.rMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rMajor.Location = new System.Drawing.Point(3, 3);
            this.rMajor.Name = "rMajor";
            this.rMajor.Size = new System.Drawing.Size(53, 31);
            this.rMajor.TabIndex = 0;
            this.rMajor.TabStop = true;
            this.rMajor.Text = "Major";
            this.rMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rMajor.UseVisualStyleBackColor = false;
            this.rMajor.CheckedChanged += new System.EventHandler(this.rMajor_CheckedChanged);
            // 
            // rBoth
            // 
            this.rBoth.AutoSize = true;
            this.rBoth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rBoth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rBoth.Location = new System.Drawing.Point(62, 3);
            this.rBoth.Name = "rBoth";
            this.rBoth.Size = new System.Drawing.Size(53, 31);
            this.rBoth.TabIndex = 1;
            this.rBoth.Text = "Both";
            this.rBoth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBoth.UseVisualStyleBackColor = false;
            this.rBoth.CheckedChanged += new System.EventHandler(this.rBoth_CheckedChanged);
            // 
            // rMinor
            // 
            this.rMinor.AutoSize = true;
            this.rMinor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rMinor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rMinor.Location = new System.Drawing.Point(121, 3);
            this.rMinor.Name = "rMinor";
            this.rMinor.Size = new System.Drawing.Size(53, 31);
            this.rMinor.TabIndex = 2;
            this.rMinor.Text = "Minor";
            this.rMinor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rMinor.UseVisualStyleBackColor = false;
            this.rMinor.CheckedChanged += new System.EventHandler(this.rMinor_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 388);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(515, 389);
            this.Name = "Form1";
            this.Text = "Musical Key Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pKeyDisplay.ResumeLayout(false);
            this.pKeyDisplay.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pKeyDisplay;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.TextBox lKeyDisplay;
        private System.Windows.Forms.ToolStripMenuItem weeeeToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.Button bMiddle;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton rMajor;
        private System.Windows.Forms.RadioButton rBoth;
        private System.Windows.Forms.RadioButton rMinor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editIntervalToolStripMenuItem;
        private System.Windows.Forms.Timer MinorTimer;

    }
}

