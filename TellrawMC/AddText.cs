using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TellrawMC.Properties;

namespace TellrawMC
{
    public partial class AddText : Form
    {
        public AddText()
        {
            InitializeComponent();
        }
        private void TransImage(Button button, Image image)
        {
            button.BackgroundImage = image;
        }

        #region dragen
        bool mouseDown;
        private Point offset;
        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {

        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
        #region CloseButton
        private void Close_Click(object sender, EventArgs e)
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.Default.added = textBox1.Text;
            Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(Settings.Default.frm1Loc.X + 320, Settings.Default.frm1Loc.Y + 86);

            this.Update();
        }

        private void AddText_Load(object sender, EventArgs e)
        {
            Point wee = new Point(this.Location.X + 248, this.Location.Y - 21);

            this.Location = wee;
        }
    }
}
