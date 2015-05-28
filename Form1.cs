using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TXTextControl;
namespace tx_view_modes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textControl1.RulerBar = rulerBar2;
            textControl1.StatusBar = statusBar1;
            textControl1.VerticalRulerBar = rulerBar1;
        }

        private void FitToWindow()
        {
            textControl1.PageUnit = MeasuringUnit.Twips;
            int iVisibleGap = 65;

            // get resolution to calculate convert twips 1/100 inch 
            Graphics g = textControl1.CreateGraphics();
            int iTwipsPerPixel = (int)(1440 / g.DpiX);

            SectionFormat currentSection = textControl1.Sections.GetItem().Format;
            
            double widthZoom = 100 * textControl1.Width / 
                ((currentSection.PageSize.Width / iTwipsPerPixel)
                + iVisibleGap);
            double heightZoom = 100 * textControl1.Height / 
                ((currentSection.PageSize.Height / iTwipsPerPixel)
                + iVisibleGap);

            if (widthZoom < heightZoom)
                textControl1.ZoomFactor = (int)widthZoom;
            else
                textControl1.ZoomFactor = (int)heightZoom;
        }

        private void FitToWidth()
        {
            textControl1.PageUnit = MeasuringUnit.Twips;
            int iVisibleGap = 200;

            // get resolution to calculate convert twips 1/100 inch 
            Graphics g = textControl1.CreateGraphics();
            int iTwipsPerPixel = (int)(1440 / g.DpiX);

            SectionFormat currentSection = textControl1.Sections.GetItem().Format;

            double widthZoom = 100 * textControl1.Width / ((currentSection.PageSize.Width / iTwipsPerPixel) + iVisibleGap);

            textControl1.ZoomFactor = (int)widthZoom;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = false;
            FitToWidth();
        }

        private void textControl1_Resize(object sender, EventArgs e)
        {
            Resize();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton2.Checked = false;
            FitToWindow();
        }

        private void textControl1_SectionChanged(object sender, EventArgs e)
        {
            Resize();
        }

        private void Resize()
        {
            if (toolStripButton1.Checked == true)
                FitToWindow();
            else if (toolStripButton2.Checked == true)
                FitToWidth();
        }
    }
}
