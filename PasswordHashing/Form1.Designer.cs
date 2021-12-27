
namespace Thing
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
            this.Control_Bar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Loginmain = new System.Windows.Forms.Button();
            this.signupmain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login_Panel = new System.Windows.Forms.Panel();
            this.SignUp_panel = new System.Windows.Forms.Panel();
            this.signupdone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Signupusername = new System.Windows.Forms.TextBox();
            this.signupredopass = new System.Windows.Forms.TextBox();
            this.signuppassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logindone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.loginpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginusername = new System.Windows.Forms.TextBox();
            this.ErrorHandlerLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.Control_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.Login_Panel.SuspendLayout();
            this.SignUp_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control_Bar
            // 
            this.Control_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Control_Bar.Controls.Add(this.pictureBox1);
            this.Control_Bar.Controls.Add(this.ExitBox);
            this.Control_Bar.Controls.Add(this.panel2);
            this.Control_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Control_Bar.Location = new System.Drawing.Point(0, 0);
            this.Control_Bar.Name = "Control_Bar";
            this.Control_Bar.Size = new System.Drawing.Size(446, 32);
            this.Control_Bar.TabIndex = 0;
            this.Control_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_Bar_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Thing.Properties.Resources._;
            this.pictureBox1.Location = new System.Drawing.Point(382, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // ExitBox
            // 
            this.ExitBox.Image = global::Thing.Properties.Resources.x;
            this.ExitBox.Location = new System.Drawing.Point(414, 0);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(32, 32);
            this.ExitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExitBox.TabIndex = 3;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            this.ExitBox.MouseLeave += new System.EventHandler(this.ExitBox_MouseLeave);
            this.ExitBox.MouseHover += new System.EventHandler(this.ExitBox_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(132, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 175);
            this.panel2.TabIndex = 4;
            // 
            // Loginmain
            // 
            this.Loginmain.Location = new System.Drawing.Point(21, 52);
            this.Loginmain.Name = "Loginmain";
            this.Loginmain.Size = new System.Drawing.Size(84, 23);
            this.Loginmain.TabIndex = 1;
            this.Loginmain.Text = "Login";
            this.Loginmain.UseVisualStyleBackColor = true;
            this.Loginmain.Click += new System.EventHandler(this.Loginmain_Click);
            // 
            // signupmain
            // 
            this.signupmain.Location = new System.Drawing.Point(21, 135);
            this.signupmain.Name = "signupmain";
            this.signupmain.Size = new System.Drawing.Size(84, 23);
            this.signupmain.TabIndex = 2;
            this.signupmain.Text = "Sign Up";
            this.signupmain.UseVisualStyleBackColor = true;
            this.signupmain.Click += new System.EventHandler(this.signupmain_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.signupmain);
            this.panel1.Controls.Add(this.Loginmain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 229);
            this.panel1.TabIndex = 3;
            // 
            // Login_Panel
            // 
            this.Login_Panel.Controls.Add(this.SignUp_panel);
            this.Login_Panel.Controls.Add(this.logindone);
            this.Login_Panel.Controls.Add(this.label2);
            this.Login_Panel.Controls.Add(this.loginpassword);
            this.Login_Panel.Controls.Add(this.label1);
            this.Login_Panel.Controls.Add(this.loginusername);
            this.Login_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_Panel.Location = new System.Drawing.Point(126, 32);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.Size = new System.Drawing.Size(320, 181);
            this.Login_Panel.TabIndex = 5;
            // 
            // SignUp_panel
            // 
            this.SignUp_panel.Controls.Add(this.signupdone);
            this.SignUp_panel.Controls.Add(this.label4);
            this.SignUp_panel.Controls.Add(this.label5);
            this.SignUp_panel.Controls.Add(this.Signupusername);
            this.SignUp_panel.Controls.Add(this.signupredopass);
            this.SignUp_panel.Controls.Add(this.signuppassword);
            this.SignUp_panel.Controls.Add(this.label3);
            this.SignUp_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignUp_panel.Location = new System.Drawing.Point(0, 0);
            this.SignUp_panel.Name = "SignUp_panel";
            this.SignUp_panel.Size = new System.Drawing.Size(320, 181);
            this.SignUp_panel.TabIndex = 7;
            // 
            // signupdone
            // 
            this.signupdone.Location = new System.Drawing.Point(233, 137);
            this.signupdone.Name = "signupdone";
            this.signupdone.Size = new System.Drawing.Size(75, 23);
            this.signupdone.TabIndex = 2;
            this.signupdone.Text = "Done";
            this.signupdone.UseVisualStyleBackColor = true;
            this.signupdone.Click += new System.EventHandler(this.signupdone_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(24, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(24, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Redo pass:";
            // 
            // Signupusername
            // 
            this.Signupusername.Location = new System.Drawing.Point(128, 20);
            this.Signupusername.Name = "Signupusername";
            this.Signupusername.Size = new System.Drawing.Size(180, 24);
            this.Signupusername.TabIndex = 0;
            this.Signupusername.TextChanged += new System.EventHandler(this.Signupusername_TextChanged);
            // 
            // signupredopass
            // 
            this.signupredopass.Location = new System.Drawing.Point(128, 107);
            this.signupredopass.Name = "signupredopass";
            this.signupredopass.Size = new System.Drawing.Size(180, 24);
            this.signupredopass.TabIndex = 0;
            // 
            // signuppassword
            // 
            this.signuppassword.Location = new System.Drawing.Point(128, 66);
            this.signuppassword.Name = "signuppassword";
            this.signuppassword.Size = new System.Drawing.Size(180, 24);
            this.signuppassword.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(24, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // logindone
            // 
            this.logindone.Location = new System.Drawing.Point(233, 135);
            this.logindone.Name = "logindone";
            this.logindone.Size = new System.Drawing.Size(75, 23);
            this.logindone.TabIndex = 2;
            this.logindone.Text = "Done";
            this.logindone.UseVisualStyleBackColor = true;
            this.logindone.Click += new System.EventHandler(this.logindone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // loginpassword
            // 
            this.loginpassword.Location = new System.Drawing.Point(128, 98);
            this.loginpassword.Name = "loginpassword";
            this.loginpassword.Size = new System.Drawing.Size(180, 24);
            this.loginpassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // loginusername
            // 
            this.loginusername.Location = new System.Drawing.Point(128, 52);
            this.loginusername.Name = "loginusername";
            this.loginusername.Size = new System.Drawing.Size(180, 24);
            this.loginusername.TabIndex = 0;
            this.loginusername.TextChanged += new System.EventHandler(this.loginusername_TextChanged);
            // 
            // ErrorHandlerLabel
            // 
            this.ErrorHandlerLabel.AutoSize = true;
            this.ErrorHandlerLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorHandlerLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorHandlerLabel.Location = new System.Drawing.Point(3, 3);
            this.ErrorHandlerLabel.Name = "ErrorHandlerLabel";
            this.ErrorHandlerLabel.Size = new System.Drawing.Size(60, 17);
            this.ErrorHandlerLabel.TabIndex = 3;
            this.ErrorHandlerLabel.Text = "Error";
            this.ErrorHandlerLabel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.InfoLabel);
            this.panel3.Controls.Add(this.ErrorHandlerLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(126, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 48);
            this.panel3.TabIndex = 0;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Location = new System.Drawing.Point(3, 3);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(45, 17);
            this.InfoLabel.TabIndex = 3;
            this.InfoLabel.Text = "Info";
            this.InfoLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(446, 261);
            this.Controls.Add(this.Login_Panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Control_Bar);
            this.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Control_Bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Login_Panel.ResumeLayout(false);
            this.Login_Panel.PerformLayout();
            this.SignUp_panel.ResumeLayout(false);
            this.SignUp_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Control_Bar;
        private System.Windows.Forms.Button Loginmain;
        private System.Windows.Forms.Button signupmain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Login_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginusername;
        private System.Windows.Forms.Button logindone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginpassword;
        private System.Windows.Forms.Button signupdone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox signupredopass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signuppassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Signupusername;
        private System.Windows.Forms.Panel SignUp_panel;
        private System.Windows.Forms.PictureBox ExitBox;
        private System.Windows.Forms.Label ErrorHandlerLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label InfoLabel;
    }
}

