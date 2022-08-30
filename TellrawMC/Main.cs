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
using System.IO;
using System.Drawing.Drawing2D;

namespace TellrawMC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
            if (mouseDown == true)
            {
                Point currentScreenPox = PointToScreen(e.Location);
                Location = new Point(currentScreenPox.X - offset.X, currentScreenPox.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        #region Vars
        string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        string cmdP1 = "/tellraw @a [{\"text\":\"";
        string cmdMid = "\"},{\"text\":\"";
        string cmdP2 = "\"}]";
        int maxLines = 1;

        private int borderRadius = 5;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(44, 49, 61);

        #endregion

        #region Shorts
        private void TransImage(PictureBox picture, Image image)
        {
            picture.Image = image;
        }

        private void WriteLog(string Text)
        {
            consoleLog.Text += "\n" + Text;
        }

        private void FileSaveData()
        {
            if (Settings.Default.firstSaveW == false)
            {
                var hello = MessageBox.Show("This is going to create files in a folder called CMDS, Do you confirm?", "First Save Warning", MessageBoxButtons.YesNoCancel);
                if (hello == DialogResult.Yes)
                {
                    Settings.Default.firstSaveW = true;
                    Settings.Default.Save();
                    Directory.CreateDirectory(Application.StartupPath + @"\CMDS");

                    if (cmdState.Value == 1)
                    {
                        foreach (string Text in listBox1.Items)
                        {
                            using (var writer = File.AppendText(Application.StartupPath + @"\CMDS\Result.txt"))
                            {
                                writer.WriteLine(cmdP1 + Text + cmdP2);
                            }
                            Clipboard.SetText(cmdP1 + Text + cmdP2);
                            WriteLog("Command compiled : " + cmdP1 + Text + cmdP2);
                        }// dang it
                    }
                    if (cmdState.Value == 2)
                    {
                        foreach (string Text in listBox1.Items)
                        {
                            using (var writer = File.AppendText(Application.StartupPath + @"\CMDS\Result.txt"))
                            {
                                writer.WriteLine(cmdP1 + listBox1.SelectedItem + cmdMid + listBox1.GetItemText(1) + cmdP2);
                            }
                            WriteLog("Command compiled : " + cmdP1 + listBox1.GetItemText(0) + cmdMid + listBox1.GetItemText(1) + cmdP2);
                            Clipboard.SetText(cmdP1 + listBox1.GetItemText(0) + cmdMid + listBox1.GetItemText(1) + cmdP2);
                        }
                    }

                    MessageBox.Show("Saved & copied to clipboard!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (hello == DialogResult.No)
                {
                    Settings.Default.appDataMode = true;
                    Settings.Default.Save();
                }

            }
            else
            {
                try
                {
                    if (cmdState.Value == 1)
                    {
                        foreach (string Text in listBox1.Items)
                        {
                            using (var writer = File.AppendText(Application.StartupPath + @"\CMDS\Result.txt"))
                            {
                                writer.WriteLine(cmdP1 + Text + cmdP2);
                            }
                            Clipboard.SetText(cmdP1 + Text + cmdP2);
                            WriteLog("Command compiled : " + cmdP1 + Text + cmdP2);
                        }
                    }
                    if (cmdState.Value == 2)
                    {
                        foreach (string Text in listBox1.Items)
                        {
                            using (var writer = File.AppendText(Application.StartupPath + @"\CMDS\Result.txt"))
                            {
                                writer.WriteLine(cmdP1 + listBox1.GetItemText(0) + cmdMid + listBox1.GetItemText(1) + cmdP2);
                            }
                            Clipboard.SetText(cmdP1 + listBox1.GetItemText(0) + cmdMid + listBox1.GetItemText(1) + cmdP2);
                            WriteLog("Command compiled : " + cmdP1 + listBox1.GetItemText(0) + cmdMid + listBox1.GetItemText(1) + cmdP2);
                        }
                    }
                    MessageBox.Show("Saved & copied to clipboard!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Have you moved the app or something? Reinstalling...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (MessageBox.Show("This is going to create files in a folder called CMDS, Do you confirm?", "First Save Warning", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        Directory.CreateDirectory(Application.StartupPath + @"\CMDS");


                        if (cmdState.Value == 1)
                        {
                            foreach (string Text in listBox1.Items)
                            {
                                using (var writer = File.AppendText(Application.StartupPath + @"\CMDS\Result.txt"))
                                {
                                    writer.WriteLine(cmdP1 + Text + cmdP2);
                                }
                                Clipboard.SetText(cmdP1 + Text + cmdP2);
                                WriteLog("Command compiled : " + cmdP1 + Text + cmdP2);
                            }
                        }
                        if (cmdState.Value == 2)
                        {
                            foreach (string Text in listBox1.Items)
                            {
                                using (var writer = File.AppendText(Application.StartupPath + @"\CMDS\Result.txt"))
                                {
                                    writer.WriteLine(cmdP1 + listBox1.GetItemText(0) + cmdMid + listBox1.GetItemText(1) + cmdP2);
                                }
                                Clipboard.SetText(cmdP1 + listBox1.GetItemText(0) + cmdMid + listBox1.GetItemText(1) + cmdP2);
                                WriteLog("Command compiled : " + cmdP1 + listBox1.GetItemText(0) + cmdMid + listBox1.GetItemText(1) + cmdP2);
                            }
                        }
                        MessageBox.Show("Saved & copied to clipboard!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Settings.Default.appDataMode = true;
                        Settings.Default.Save();
                    }
                }
            }
        }

        private void HideLogChecking()
        {
            if (Settings.Default.hideLog == true)
            {
                consoleLog.Hide();
                listBox1.Size = new Size(263, 273);
                saveLog.Location = new Point(198, 272);
                this.Update();
            }
            else
            {
                consoleLog.Show();
                listBox1.Size = new Size(263, 195);
                saveLog.Location = new Point(198, 194);
                this.Update();
            }
        }
        #endregion

        #region Anims
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
        #region MinButton
        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Min_MouseDown(object sender, MouseEventArgs e)
        {
            TransImage(mine, Resources.Mined);
        }

        private void Min_MouseEnter(object sender, EventArgs e)
        {
            TransImage(mine, Resources.Mining);
        }

        private void Min_MouseLeave(object sender, EventArgs e)
        {
            TransImage(mine, Resources.Min);
        }

        private void Min_MouseUp(object sender, MouseEventArgs e)
        {
            TransImage(mine, Resources.Mining);
        }
        #endregion
        #region SaveB
        private void Run_MouseDown(object sender, MouseEventArgs e)
        {
            TransImage(runB, Resources.Saved);
        }

        private void Run_MouseEnter(object sender, EventArgs e)
        {
            TransImage(runB, Resources.Saving);
        }

        private void Run_MouseLeave(object sender, EventArgs e)
        {
            TransImage(runB, Resources.Save);
        }
        private void Run_MouseUp(object sender, MouseEventArgs e)
        {
            TransImage(runB, Resources.Saving);
        }

        #endregion
        #region AddB

        private void Add_MouseDown(object sender, MouseEventArgs e)
        {
            TransImage(addB, Resources.Added);
        }

        private void Add_MouseEnter(object sender, EventArgs e)
        {
            TransImage(addB, Resources.Adding);
        }

        private void Add_MouseLeave(object sender, EventArgs e)
        {
            TransImage(addB, Resources.Add);
        }

        private void Add_MouseUp(object sender, MouseEventArgs e)
        {
            TransImage(addB, Resources.Adding);
        }

        #endregion        
        #region RemoveB

        private void Remv_MouseDown(object sender, MouseEventArgs e)
        {
            TransImage(remvB, Resources.Removed);
        }

        private void Remv_MouseEnter(object sender, EventArgs e)
        {
            TransImage(remvB, Resources.Removing);
        }

        private void Remv_MouseLeave(object sender, EventArgs e)
        {
            TransImage(remvB, Resources.Remove);
        }

        private void Remv_MouseUp(object sender, MouseEventArgs e)
        {
            TransImage(remvB, Resources.Removing);
        }

        #endregion
        #endregion

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


        private void Form1_Load(object sender, EventArgs e)
        {
            cmdState.Value = 1;
            consoleLog.Text = "TellrawMC(TM) Console Log.\n" + "Application just started";

            HideLogChecking();


        }

        private void runB_Click(object sender, EventArgs e)
        {
            foreach (string addedText in listBox1.Items)
            {
                if (addedText == "")
                {
                    MessageBox.Show("Please add items in the list first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (listBox1.Items.Count == 1)
                        {
                            string result = cmdP1 + addedText + cmdP2;

                            WriteLog("Command created successfully");
                            WriteLog("CMD : " + result);
                            Clipboard.SetText(result);
                        }
                        if (listBox1.Items.Count >= 1)
                        {
                            string compile = addedText + cmdMid + addedText;

                            string repdis = String.Concat(Enumerable.Repeat(compile, listBox1.Items.Count));

                            string result = cmdP1 + repdis + cmdP2;

                            WriteLog("Command created successfully");
                            WriteLog("CMD : " + result);
                            Clipboard.SetText(result);
                        }
                    }
                    catch
                    {
                        WriteLog("ERR : Error occured in creating command..");
                        WriteLog("WRN : If commands contain tags, etc. Please remove them.");
                    }


                }
            }
        }

        private void addB_Click(object sender, EventArgs e)
        {
            AddText add = new AddText();
            if (add.ShowDialog() == DialogResult.OK) 
            {
                listBox1.Items.Add(Settings.Default.added);
                Settings.Default.Save();
                
            }
        }

        private void remvB_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.D)
            {
                Settings.Default.added = "";
                Settings.Default.appDataMode = false;
                Settings.Default.firstSaveW = false;
                Settings.Default.Save();

                MessageBox.Show("Daddy Reset is complete!", "Daddy Reset");
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < maxLines)
            {
                addB.Show();
            }
            else
            {
                addB.Hide();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Settings.Default.frm1Loc = new Point(this.Location.X, this.Location.Y);
            Settings.Default.Save();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(cmdState.Value);
            maxLines = value;
        }

        private void saveLog_Click(object sender, EventArgs e)
        {
            SLD.InitialDirectory = Documents;
            if (SLD.ShowDialog() == DialogResult.OK)
            {
                WriteLog("Log Saved");
                WriteLog("Saved in " + SLD.FileName);
            }
        }

        private void SLD_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(SLD.FileName, consoleLog.Text);
        }

        private void cog_Click(object sender, EventArgs e)
        {
            Setting form = new Setting();
            if (form.ShowDialog() == DialogResult.OK)
            {
                HideLogChecking();
            }
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics,borderColor,borderSize);
        }
    }
}
