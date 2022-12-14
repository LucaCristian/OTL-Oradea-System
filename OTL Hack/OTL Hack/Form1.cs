using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace OTL_Hack
{
    public partial class Messages : Form
    {
        //Anti Spam counter
        int delaysecs = 0;
        
        // Labels and Picture Boxes Creation
        Label MSG1 = new Label();
        Label MSG2 = new Label();
        Label MSG3 = new Label();

        Label HMSG1 = new Label();
        Label HMSG2 = new Label();
        Label HMSG3 = new Label();

        PictureBox MB2 = new PictureBox();
        PictureBox MB3 = new PictureBox();
        Bitmap image = Properties.Resources.MessageBubble;

        PictureBox HMB1 = new PictureBox();
        PictureBox HMB2 = new PictureBox();
        PictureBox HMB3 = new PictureBox();
        Bitmap Himage = Properties.Resources.MessageHimBubble;

        /*
        MBspeed = Message Bubble speed of scrolling
        mNR = Number of my messages (on the screen)
        mNR2 = Number of his messages (on the screen)
        */
        int MBspeed = 19;
        int mNR = 0;
        int mNR2 = 0;

        public Messages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hud Order
            this.TopBar.BringToFront();
            this.BottomBar.BringToFront();
            this.TextBox.BringToFront();

            // Line Input
            string textbox = TextBox.Text.ToString();

            // Detect if the text box is empty
            if (String.IsNullOrEmpty(TextBox.Text))
                return;
            if (delaysecs < 0)
            {
                TextBox.Text = String.Empty;
                delaysecs = 1;

                string line = "";

                // Date And Time
                var dateAndTime = DateTime.Now;
                int h = dateAndTime.Hour;

                // Random Letters
                Random ran = new Random();
                String b = "ABCDEFGHIJKLMNOPRSTQUVXWXYZ";
                String random = "";
                for (int i = 0; i < 4; i++)
                {
                    int a = ran.Next(26);
                    random = random + b.ElementAt(a);
                }

                // Random Number
                string nr = "";
                Random rnd = new Random();
                for (int j = 0; j < 4; j++)
                {
                    nr = nr + Convert.ToString(rnd.Next(10));
                }

                // Front End
                mNR++;
                mNR2++;

                nrMes();
                MBspeed = 19;

                moveTimer.Enabled = true;
                moveTimer_Tick(sender, e);

                // Coordinates (H - his messages)
                int xMSG = 294, yMSG = 537;
                int HxMSG = 25, HyMSG = 585;

                // Text Length Limit
                if (textbox.Length == 1)
                {
                    line = textbox.Substring(0, 1);
                }
                if (textbox.Length > 1)
                {
                    line = textbox.Substring(0, 2);
                    xMSG = xMSG - 5;
                }


                if (mNR2 == 1)
                {
                    MSG1.Location = new Point(xMSG, yMSG);
                    MSG1.AutoSize = true;
                    MSG1.ForeColor = Color.White;
                    MSG1.BackColor = Color.FromArgb(103, 203, 105);
                    MSG1.Font = new Font("Calibri", 13);
                    this.Controls.Add(MSG1);
                    MSG1.Text = line.ToString();
                    this.MSG1.BringToFront();

                    HMSG1.Location = new Point(HxMSG, HyMSG);
                    HMSG1.AutoSize = true;
                    HMSG1.ForeColor = Color.Black;
                    HMSG1.BackColor = Color.FromArgb(233, 233, 235);
                    HMSG1.Font = new Font("Calibri", 13);
                    this.Controls.Add(HMSG1);
                    HMSG1.Text = $"Biletul dvs pentru linia {line} a fost\nactivat. Cost 0.67Eur+Tva Cod\nconfirmare {random}{nr} Valabil pana\nla " + $"{h + 1}:" + DateTime.Now.ToString("mm") + " " + DateTime.Now.ToString("dd.MM.yyyy") + " Calatorie\nplacuta!";
                    this.HMSG1.BringToFront();
                }
                if (mNR2 == 2)
                {
                    MSG2.Location = new Point(xMSG, yMSG);
                    MSG2.AutoSize = true;
                    MSG2.ForeColor = Color.White;
                    MSG2.BackColor = Color.FromArgb(103, 203, 105);
                    MSG2.Font = new Font("Calibri", 13);
                    this.Controls.Add(MSG2);
                    MSG2.Text = line.ToString();
                    this.MSG2.BringToFront();

                    HMSG2.Location = new Point(HxMSG, HyMSG);
                    HMSG2.AutoSize = true;
                    HMSG2.ForeColor = Color.Black;
                    HMSG2.BackColor = Color.FromArgb(233, 233, 235);
                    HMSG2.Font = new Font("Calibri", 13);
                    this.Controls.Add(HMSG2);
                    HMSG2.Text = $"Biletul dvs pentru linia {line} a fost\nactivat. Cost 0.67Eur+Tva Cod\nconfirmare {random}{nr} Valabil pana\nla " + $"{h + 1}:" + DateTime.Now.ToString("mm") + " " + DateTime.Now.ToString("dd.MM.yyyy") + " Calatorie\nplacuta!";
                    this.HMSG2.BringToFront();
                }
                if (mNR2 == 3)
                {
                    MSG3.Location = new Point(xMSG, yMSG);
                    MSG3.AutoSize = true;
                    MSG3.ForeColor = Color.White;
                    MSG3.BackColor = Color.FromArgb(103, 203, 105);
                    MSG3.Font = new Font("Calibri", 13);
                    this.Controls.Add(MSG3);
                    MSG3.Text = line.ToString();
                    this.MSG3.BringToFront();

                    HMSG3.Location = new Point(HxMSG, HyMSG);
                    HMSG3.AutoSize = true;
                    HMSG3.ForeColor = Color.Black;
                    HMSG3.BackColor = Color.FromArgb(233, 233, 235);
                    HMSG3.Font = new Font("Calibri", 13);
                    this.Controls.Add(HMSG3);
                    HMSG3.Text = $"Biletul dvs pentru linia {line} a fost\nactivat. Cost 0.67Eur+Tva Cod\nconfirmare {random}{nr} Valabil pana\nla " + $"{h + 1}:" + DateTime.Now.ToString("mm") + " " + DateTime.Now.ToString("dd.MM.yyyy") + " Calatorie\nplacuta!";
                    this.HMSG3.BringToFront();

                    mNR2 = 0;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Error Sound Removal
                button1_Click(sender, e);
            }
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            /*
             * Assigning the speed of scrolling
             * MB1, 2, 3 - first, second and third message bubble (picture box)
             * HMB1, 2, 3 - - first, second and third his message bubble (picture box)
            */
            MB1.Top -= MBspeed;
            MB2.Top -= MBspeed;
            MB3.Top -= MBspeed;
            HMB1.Top -= MBspeed;
            HMB2.Top -= MBspeed;
            HMB3.Top -= MBspeed;

            /*
             * MSG1, 2, 3 - first, second and third message (label)
             * HMSG1, 2, 3 - - first, second and third his message (label)
            */
            MSG1.Top -= MBspeed;
            MSG2.Top -= MBspeed;
            MSG3.Top -= MBspeed;
            HMSG1.Top -= MBspeed;
            HMSG2.Top -= MBspeed;
            HMSG3.Top -= MBspeed;
            
            // Movement Stop
            if (MBspeed > 0)
                MBspeed--;
        }
        private void nrMes()
        {
            // Coordinates (H - his messages)
            int xMB = 280, yMB = 550;
            int HxMB = 10, HyMB = 600;
            
            if (mNR == 1)
            {
                MB1 = new PictureBox();
                Controls.Add(MB1);
                MB1.Image = (Image)image;
                MB1.SizeMode = PictureBoxSizeMode.StretchImage;
                MB1.Top = yMB;
                MB1.Left = xMB;
                MB1.Width = 50;
                MB1.Height = 35;

                HMB1 = new PictureBox();
                Controls.Add(HMB1);
                HMB1.Image = (Image)Himage;
                HMB1.SizeMode = PictureBoxSizeMode.StretchImage;
                HMB1.Top = HyMB;
                HMB1.Left = HxMB;
                HMB1.Width = 290;
                HMB1.Height = 120;
            }
            else if (mNR == 2)
            {
                MB2 = new PictureBox();
                MB2.SizeMode = PictureBoxSizeMode.StretchImage;
                MB2.Image = (Image)image;
                Controls.Add(MB2);
                MB2.Top = yMB;
                MB2.Left = xMB;
                MB2.Width = 50;
                MB2.Height = 35;

                HMB2 = new PictureBox();
                Controls.Add(HMB2);
                HMB2.Image = (Image)Himage;
                HMB2.SizeMode = PictureBoxSizeMode.StretchImage;
                HMB2.Top = HyMB;
                HMB2.Left = HxMB;
                HMB2.Width = 290;
                HMB2.Height = 120;
            }
            else if (mNR == 3)
            {
                MB3 = new PictureBox();
                Controls.Add(MB3);
                MB3.SizeMode = PictureBoxSizeMode.StretchImage;
                MB3.Image = (Image)image;
                MB3.Top = yMB;
                MB3.Left = xMB;
                MB3.Width = 50;
                MB3.Height = 35;

                HMB3 = new PictureBox();
                Controls.Add(HMB3);
                HMB3.Image = (Image)Himage;
                HMB3.SizeMode = PictureBoxSizeMode.StretchImage;
                HMB3.Top = HyMB;
                HMB3.Left = HxMB;
                HMB3.Width = 290;
                HMB3.Height = 120;
            }

            // Position Reset
            if (MB1.Top<50)
            {
                MB1.Top = yMB;
                MB1.Left = xMB;
            }
            else if (MB2.Top < 50)
            {
                MB2.Top = yMB;
                MB2.Left = xMB;
            }
            else if (MB3.Top < 50)
            {
                MB3.Top = yMB;
                MB3.Left = xMB;
            }

            if (HMB1.Top < 80)
            {
                HMB1.Top = HyMB;
                HMB1.Left = HxMB;
            }
            else if (HMB2.Top < 80)
            {
                HMB2.Top = HyMB;
                HMB2.Left = HxMB;
            }
            else if (HMB3.Top < 80)
            {
                HMB3.Top = HyMB;
                HMB3.Left = HxMB;
            }
        }

        private void messagedelay(object sender, EventArgs e)
        {
            delaysecs--;
        }
    }
}
