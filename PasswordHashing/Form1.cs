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
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public const int SALT_BYTE_SIZE = 24;
        public const int HASH_BYTE_SIZE = 24;
        public const int PBKDF2_ITERATIONS = 1000;

        public const int ITERATION_INDEX = 0;
        public const int SALT_INDEX = 1;
        public const int PBKDF2_INDEX = 2;

        public static string CreateHash(string password)
        {
            RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_BYTE_SIZE];
            csprng.GetBytes(salt);
            byte[] hash = PBKDF2(password, salt, PBKDF2_ITERATIONS, HASH_BYTE_SIZE);
            return PBKDF2_ITERATIONS + ":" +
                Convert.ToBase64String(salt) + ":" +
                Convert.ToBase64String(hash);
        }

        public static bool ValidatePassword(string password, string correctHash)
        {
            char[] delimiter = { ':' };
            string[] split = correctHash.Split(delimiter);
            int iterations = Int32.Parse(split[ITERATION_INDEX]);
            byte[] salt = Convert.FromBase64String(split[SALT_INDEX]);
            byte[] hash = Convert.FromBase64String(split[PBKDF2_INDEX]);

            byte[] testHash = PBKDF2(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= (uint)(a[i] ^ b[i]);
            return diff == 0;
        }

        private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;
            return pbkdf2.GetBytes(outputBytes);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SignUp_panel.Hide();
            Login_Panel.Hide();
            signupdone.Enabled = false;
            logindone.Enabled = false;
        }

        private void Control_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Loginmain_Click(object sender, EventArgs e)
        {
            Login_Panel.Show();
            SignUp_panel.Hide();
        }

        private void signupmain_Click(object sender, EventArgs e)
        {
            Login_Panel.Show();
            SignUp_panel.Show();
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
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(50, 53, 56);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void Signupusername_TextChanged(object sender, EventArgs e)
        {
            if (Signupusername.TextLength == 0){signupdone.Enabled = false;} else{signupdone.Enabled = true;}
        }
        private void loginusername_TextChanged(object sender, EventArgs e)
        {
            if (loginusername.TextLength == 0){logindone.Enabled = false;} else{logindone.Enabled = true;}
        }

        private void logindone_Click(object sender, EventArgs e)
        {
            ErrorHandlerLabel.Hide();
            InfoLabel.Hide();
            string Username = File.ReadLines("Login.txt").First();
            string passwordhash = File.ReadLines("Login.txt").Last();
            if (ValidatePassword(loginpassword.Text, passwordhash) == true && loginusername.Text == Username)
            {
                Form2 frm = new Form2(this);
                frm.Show();
            }
            else if (loginpassword.TextLength==0)
            {
                ErrorHandlerLabel.Text = "Enter a Password";
                ErrorHandlerLabel.Show();
            }
            else
            {
                ErrorHandlerLabel.Text = "The Password or Username was \n incorrect";
                ErrorHandlerLabel.Show();
            }
        }

        private void signupdone_Click(object sender, EventArgs e)
        {
            InfoLabel.Hide();
            ErrorHandlerLabel.Hide();
            if (signuppassword.Text != signupredopass.Text)
            {
                ErrorHandlerLabel.Text = "Password And Redo do not Match";
                ErrorHandlerLabel.Show();
            }
            else if (Signupusername.TextLength==0) 
            {
                ErrorHandlerLabel.Text = "Enter a Username";
                ErrorHandlerLabel.Show();
            }
            else if (signuppassword.TextLength == 0)
            {
                ErrorHandlerLabel.Text = "Enter a Password";
                ErrorHandlerLabel.Show();
            }
            else
            {
                string[] logininfo = {Signupusername.Text, CreateHash(signuppassword.Text)};
                File.WriteAllLines("Login.txt", logininfo);
                SignUp_panel.Hide();
                InfoLabel.Show();
                InfoLabel.Text = "Account Created";
            }
        }
    }
}
