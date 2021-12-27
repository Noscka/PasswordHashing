
namespace Thing
{
    partial class Form2
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
            this.MinimizeBox = new System.Windows.Forms.PictureBox();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.Control_Bar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            this.Control_Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.Image = global::Thing.Properties.Resources._;
            this.MinimizeBox.Location = new System.Drawing.Point(736, 0);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size(32, 32);
            this.MinimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MinimizeBox.TabIndex = 3;
            this.MinimizeBox.TabStop = false;
            this.MinimizeBox.Click += new System.EventHandler(this.MinimizeBox_Click);
            this.MinimizeBox.MouseLeave += new System.EventHandler(this.MinimizeBox_MouseLeave);
            this.MinimizeBox.MouseHover += new System.EventHandler(this.MinimizeBox_MouseHover);
            // 
            // ExitBox
            // 
            this.ExitBox.Image = global::Thing.Properties.Resources.x;
            this.ExitBox.Location = new System.Drawing.Point(768, 0);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(32, 32);
            this.ExitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExitBox.TabIndex = 3;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            this.ExitBox.MouseLeave += new System.EventHandler(this.ExitBox_MouseLeave);
            this.ExitBox.MouseHover += new System.EventHandler(this.ExitBox_MouseHover);
            // 
            // Control_Bar
            // 
            this.Control_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Control_Bar.Controls.Add(this.MinimizeBox);
            this.Control_Bar.Controls.Add(this.ExitBox);
            this.Control_Bar.Controls.Add(this.panel2);
            this.Control_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Control_Bar.Location = new System.Drawing.Point(0, 0);
            this.Control_Bar.Name = "Control_Bar";
            this.Control_Bar.Size = new System.Drawing.Size(800, 32);
            this.Control_Bar.TabIndex = 1;
            this.Control_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_Bar_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(132, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 175);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 418);
            this.panel1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Control_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            this.Control_Bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MinimizeBox;
        private System.Windows.Forms.PictureBox ExitBox;
        private System.Windows.Forms.Panel Control_Bar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}