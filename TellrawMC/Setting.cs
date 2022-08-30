using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TellrawMC.Properties;

namespace TellrawMC
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private int borderRadius = 5;
        private int borderSize = 2;
        private Color borderColor = Color.Silver;

        #region RoundedCorners
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }
        #endregion
        
        
        private void TransImage(Button button, Image image)
        {
            button.BackgroundImage = image;
        }

        #region dragen
        #endregion
        #region CloseButton
        private void Close_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
            Close();
        }

        private void Close_MouseDown(object sender, MouseEventArgs e)
        {
            TransImage(closee, Resources.Closing);
        }

        private void Close_Leave(object sender, EventArgs e)
        {
            TransImage(closee, Resources.Close);
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            TransImage(closee, Resources.Closed);
        }
        private void Close_MouseUp(object sender, MouseEventArgs e)
        {
            TransImage(closee, Resources.Closed);
        }
        #endregion

        private void AddText_Load(object sender, EventArgs e)
        {

            if (Settings.Default.hideLog == true)
            {
                checkBox1.CheckState = CheckState.Checked;
            }

            Point wee = new Point(this.Location.X - 278, this.Location.Y - 0);

            this.Location = wee;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(Settings.Default.hideLog == false)
            {
                checkBox1.Checked = true;
                Settings.Default.hideLog = true;
            }
            else if (Settings.Default.hideLog == true)
            {
                checkBox1.Checked = false;
                Settings.Default.hideLog = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unavailable but unstable as hell, still WIP.","Working in progress..",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Setting_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
    }
}
