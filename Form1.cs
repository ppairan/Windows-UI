using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WindowsUI
{
    public partial class Form1 : Form
    {

        private IconButton currentBtn;
        private Panel leftBdBtn;
        private Form currentChieldForm;
        public Form1()
        {
            InitializeComponent();
            leftBdBtn = new Panel();
            leftBdBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBdBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private struct RGBColors
        {
             public static Color color1 = Color.FromArgb(196, 22, 47);
             public static Color color2 = Color.FromArgb(198, 100, 71);
             public static Color color3 = Color.FromArgb(181, 175, 87);
             public static Color color4 = Color.FromArgb(219, 98, 149);
             public static Color color5 = Color.FromArgb(246, 226, 103);
             public static Color color6 = Color.FromArgb(114, 19, 20);
        }
        private void ActiveButton(object senderBtn, Color color)
        {

            if(senderBtn != null)
            {
                DisableButton();

                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left Button
                leftBdBtn.BackColor = color;
                leftBdBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBdBtn.Visible = true;
                leftBdBtn.BringToFront();
                //icon Child form
                iconCurrentChieldformIcon.IconChar = currentBtn.IconChar;
                iconCurrentChieldformIcon.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(87, 9, 11);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form Childform)
        {
            if (currentChieldForm != null)
            {
                currentChieldForm.Close();
            }

            currentChieldForm = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            panelDesktop.Controls.Add(Childform);
            Childform.BringToFront();
            Childform.Show();
            lblTitleChildform.Text = Childform.Text;
        }

        private void ibtnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new FormDashboard());
        }

        private void ibtnGaming_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new Form2gaming());
        }

        private void ibtnProgramming_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
        }

        private void ibtnCommunication_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
        }

        private void ibtnClient_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
        }

        private void ibtnSettings_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChieldForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBdBtn.Visible = false;
            iconCurrentChieldformIcon.IconChar = IconChar.Home;
            iconCurrentChieldformIcon.IconColor = Color.Orchid;
            lblTitleChildform.Text = "Home";
        }
        //Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
