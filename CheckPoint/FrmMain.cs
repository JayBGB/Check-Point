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

namespace CheckPoint
{

    public partial class FrmMain : Form
    {
        // OBJECTS AND VARIABLES
        #region

        Methods methods = new Methods();

        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Define the sizes for normal and maximized states
        private Size normalSize = new Size(840, 480); // Adjust these values as needed
        private Size maximizedSize = new Size(1920, 1080); // Adjust these values as needed

        #endregion

        // METHODS

        public FrmMain()
        {
            InitializeComponent();
            CollapseMenu();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Maximized;
 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // We allow the top menu to be clicked to drag the app
        private void panelTopMenu_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void panelDateTime_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnSideMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }



        // INTERNAL METHODS
        #region

        private void timerHour_Tick(object sender, EventArgs e)
        {
            String currentHour = DateTime.Now.ToLongTimeString();
            lblTime.Text = currentHour;

            String currentDate = DateTime.Now.ToLongDateString();
            lblDate.Text = methods.FirstCharToUpper(currentDate);
        }

        private void CollapseMenu()
        {
            if (this.panelSideMenu.Width > 200) //Collapse menu
            {
                panelSideMenu.Width = 100;
                pictureBox1.Visible = false;
                btnSideMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelSideMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0, 0, 135, 0);
                }
            }
            else
            { //Expand menu
                panelSideMenu.Width = 230;
                pictureBox1.Visible = true;
                btnSideMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelSideMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        #endregion


        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = normalSize;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.Size = maximizedSize;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
