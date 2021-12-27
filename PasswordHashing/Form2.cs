using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;

namespace Thing
{
    public partial class Form2 : Form
    {
        Form opener;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form2(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
            opener.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ExitBox_MouseHover(object sender, EventArgs e)
        {
            ExitBox.BackColor = Color.FromArgb(240, 71, 71);
        }

        private void ExitBox_MouseLeave(object sender, EventArgs e)
        {
            ExitBox.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            opener.Close();
            this.Close();
        }

        private void MinimizeBox_MouseHover(object sender, EventArgs e)
        {
            MinimizeBox.BackColor = Color.FromArgb(50, 53, 56);
        }

        private void MinimizeBox_MouseLeave(object sender, EventArgs e)
        {
            MinimizeBox.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void MinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Control_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
