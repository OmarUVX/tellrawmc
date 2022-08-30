namespace TellrawMC
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LOGO = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mine = new System.Windows.Forms.PictureBox();
            this.closee = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cog = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdState = new System.Windows.Forms.NumericUpDown();
            this.addB = new System.Windows.Forms.PictureBox();
            this.remvB = new System.Windows.Forms.PictureBox();
            this.runB = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.consoleLog = new System.Windows.Forms.RichTextBox();
            this.saveLog = new System.Windows.Forms.Button();
            this.SLD = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closee)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remvB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.LOGO);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mine);
            this.panel1.Controls.Add(this.closee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // LOGO
            // 
            this.LOGO.Image = global::TellrawMC.Properties.Resources.TRLOG;
            this.LOGO.Location = new System.Drawing.Point(0, 0);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(34, 25);
            this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOGO.TabIndex = 3;
            this.LOGO.TabStop = false;
            this.toolTip1.SetToolTip(this.LOGO, "noice logo + crashking bitches");
            this.LOGO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.LOGO.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.LOGO.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TellrawMC";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // mine
            // 
            this.mine.BackColor = System.Drawing.Color.Transparent;
            this.mine.Image = global::TellrawMC.Properties.Resources.Min;
            this.mine.Location = new System.Drawing.Point(244, 0);
            this.mine.Name = "mine";
            this.mine.Size = new System.Drawing.Size(35, 25);
            this.mine.TabIndex = 1;
            this.mine.TabStop = false;
            this.mine.Click += new System.EventHandler(this.Min_Click);
            this.mine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Min_MouseDown);
            this.mine.MouseEnter += new System.EventHandler(this.Min_MouseEnter);
            this.mine.MouseLeave += new System.EventHandler(this.Min_MouseLeave);
            this.mine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Min_MouseUp);
            // 
            // closee
            // 
            this.closee.BackColor = System.Drawing.Color.Transparent;
            this.closee.Image = global::TellrawMC.Properties.Resources.Close;
            this.closee.Location = new System.Drawing.Point(278, 0);
            this.closee.Name = "closee";
            this.closee.Size = new System.Drawing.Size(35, 25);
            this.closee.TabIndex = 0;
            this.closee.TabStop = false;
            this.closee.Click += new System.EventHandler(this.Close_Click);
            this.closee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Close_MouseDown);
            this.closee.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.closee.MouseLeave += new System.EventHandler(this.Close_Leave);
            this.closee.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Close_MouseUp);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.Silver;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 195);
            this.listBox1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.listBox1, "Sponsored by Raid : Shadow Legends");
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wowToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 70);
            // 
            // wowToolStripMenuItem
            // 
            this.wowToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.wowToolStripMenuItem.Name = "wowToolStripMenuItem";
            this.wowToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.wowToolStripMenuItem.Text = "Color";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.cog);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmdState);
            this.panel2.Controls.Add(this.addB);
            this.panel2.Controls.Add(this.remvB);
            this.panel2.Controls.Add(this.runB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(265, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 276);
            this.panel2.TabIndex = 2;
            // 
            // cog
            // 
            this.cog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cog.Image = global::TellrawMC.Properties.Resources.COG;
            this.cog.Location = new System.Drawing.Point(0, 45);
            this.cog.Name = "cog";
            this.cog.Size = new System.Drawing.Size(48, 48);
            this.cog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cog.TabIndex = 5;
            this.cog.TabStop = false;
            this.toolTip1.SetToolTip(this.cog, "Settings");
            this.cog.Click += new System.EventHandler(this.cog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lines";
            // 
            // cmdState
            // 
            this.cmdState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.cmdState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdState.ForeColor = System.Drawing.Color.Silver;
            this.cmdState.Location = new System.Drawing.Point(0, 24);
            this.cmdState.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.cmdState.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmdState.Name = "cmdState";
            this.cmdState.Size = new System.Drawing.Size(48, 20);
            this.cmdState.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmdState, "You can have infinite words. Well, probably one thousand since you need it for co" +
        "lors.");
            this.cmdState.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmdState.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // addB
            // 
            this.addB.Image = global::TellrawMC.Properties.Resources.Add;
            this.addB.Location = new System.Drawing.Point(0, 129);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(48, 48);
            this.addB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addB.TabIndex = 2;
            this.addB.TabStop = false;
            this.toolTip1.SetToolTip(this.addB, "Add a text");
            this.addB.Click += new System.EventHandler(this.addB_Click);
            this.addB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Add_MouseDown);
            this.addB.MouseEnter += new System.EventHandler(this.Add_MouseEnter);
            this.addB.MouseLeave += new System.EventHandler(this.Add_MouseLeave);
            this.addB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Add_MouseUp);
            // 
            // remvB
            // 
            this.remvB.Image = global::TellrawMC.Properties.Resources.Remove;
            this.remvB.Location = new System.Drawing.Point(0, 178);
            this.remvB.Name = "remvB";
            this.remvB.Size = new System.Drawing.Size(48, 48);
            this.remvB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.remvB.TabIndex = 1;
            this.remvB.TabStop = false;
            this.toolTip1.SetToolTip(this.remvB, "Remove a text");
            this.remvB.Click += new System.EventHandler(this.remvB_Click);
            this.remvB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Remv_MouseDown);
            this.remvB.MouseEnter += new System.EventHandler(this.Remv_MouseEnter);
            this.remvB.MouseLeave += new System.EventHandler(this.Remv_MouseLeave);
            this.remvB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Remv_MouseUp);
            // 
            // runB
            // 
            this.runB.Image = global::TellrawMC.Properties.Resources.Save;
            this.runB.Location = new System.Drawing.Point(0, 227);
            this.runB.Name = "runB";
            this.runB.Size = new System.Drawing.Size(48, 48);
            this.runB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.runB.TabIndex = 0;
            this.runB.TabStop = false;
            this.toolTip1.SetToolTip(this.runB, "Create & copy the command");
            this.runB.Click += new System.EventHandler(this.runB_Click);
            this.runB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Run_MouseDown);
            this.runB.MouseEnter += new System.EventHandler(this.Run_MouseEnter);
            this.runB.MouseLeave += new System.EventHandler(this.Run_MouseLeave);
            this.runB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Run_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // consoleLog
            // 
            this.consoleLog.BackColor = System.Drawing.Color.Black;
            this.consoleLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleLog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleLog.ForeColor = System.Drawing.Color.Silver;
            this.consoleLog.Location = new System.Drawing.Point(0, 223);
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.ReadOnly = true;
            this.consoleLog.Size = new System.Drawing.Size(263, 78);
            this.consoleLog.TabIndex = 3;
            this.consoleLog.Text = "lol";
            // 
            // saveLog
            // 
            this.saveLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveLog.Location = new System.Drawing.Point(198, 194);
            this.saveLog.Name = "saveLog";
            this.saveLog.Size = new System.Drawing.Size(65, 28);
            this.saveLog.TabIndex = 5;
            this.saveLog.Text = "Save Log";
            this.saveLog.UseVisualStyleBackColor = true;
            this.saveLog.Click += new System.EventHandler(this.saveLog_Click);
            // 
            // SLD
            // 
            this.SLD.Filter = "Text File|*.txt|Log File|*.log|All files|*.*";
            this.SLD.InitialDirectory = "C:\\";
            this.SLD.Title = "Save log file.";
            this.SLD.FileOk += new System.ComponentModel.CancelEventHandler(this.SLD_FileOk);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(313, 301);
            this.Controls.Add(this.saveLog);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.consoleLog);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TellrawMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closee)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remvB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closee;
        private System.Windows.Forms.PictureBox mine;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox runB;
        private System.Windows.Forms.PictureBox addB;
        private System.Windows.Forms.PictureBox remvB;
        private System.Windows.Forms.PictureBox LOGO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cmdState;
        private System.Windows.Forms.RichTextBox consoleLog;
        private System.Windows.Forms.Button saveLog;
        private System.Windows.Forms.SaveFileDialog SLD;
        private System.Windows.Forms.PictureBox cog;
    }
}

