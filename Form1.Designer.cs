namespace tx_view_modes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textControl1 = new TXTextControl.TextControl();
            this.rulerBar1 = new TXTextControl.RulerBar();
            this.rulerBar2 = new TXTextControl.RulerBar();
            this.statusBar1 = new TXTextControl.StatusBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textControl1
            // 
            this.textControl1.DisplayColors.DarkShadowColor = System.Drawing.Color.WhiteSmoke;
            this.textControl1.DisplayColors.DesktopColor = System.Drawing.Color.WhiteSmoke;
            this.textControl1.DisplayColors.LightShadowColor = System.Drawing.Color.WhiteSmoke;
            this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl1.Location = new System.Drawing.Point(25, 50);
            this.textControl1.Name = "textControl1";
            this.textControl1.Size = new System.Drawing.Size(623, 494);
            this.textControl1.TabIndex = 0;
            this.textControl1.ViewMode = TXTextControl.ViewMode.PageView;
            this.textControl1.SectionChanged += new System.EventHandler(this.textControl1_SectionChanged);
            this.textControl1.Resize += new System.EventHandler(this.textControl1_Resize);
            // 
            // rulerBar1
            // 
            this.rulerBar1.Alignment = TXTextControl.RulerBarAlignment.Left;
            this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rulerBar1.Location = new System.Drawing.Point(0, 50);
            this.rulerBar1.Name = "rulerBar1";
            this.rulerBar1.Size = new System.Drawing.Size(25, 494);
            this.rulerBar1.TabIndex = 1;
            this.rulerBar1.Text = "rulerBar1";
            // 
            // rulerBar2
            // 
            this.rulerBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rulerBar2.Location = new System.Drawing.Point(0, 25);
            this.rulerBar2.Name = "rulerBar2";
            this.rulerBar2.Size = new System.Drawing.Size(648, 25);
            this.rulerBar2.TabIndex = 2;
            this.rulerBar2.Text = "rulerBar2";
            // 
            // statusBar1
            // 
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(0, 544);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(648, 19);
            this.statusBar1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(648, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.CheckOnClick = true;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton1.Text = "Fit one full page";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.CheckOnClick = true;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(132, 22);
            this.toolStripButton2.Text = "Fit to window width";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 563);
            this.Controls.Add(this.textControl1);
            this.Controls.Add(this.rulerBar1);
            this.Controls.Add(this.rulerBar2);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "TX Text Control Sample: Auto View Modes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TXTextControl.TextControl textControl1;
        private TXTextControl.RulerBar rulerBar1;
        private TXTextControl.RulerBar rulerBar2;
        private TXTextControl.StatusBar statusBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

