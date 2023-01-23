using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsApp6.Seal;

namespace WindowsApp6
{

    public partial class Form1
    {
        private int x, y;
        private Point newpoint = new Point();

        public Form1()
        {
            InitializeComponent();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            bool response = LOGIN.Seal.Login(TextBox1.Text, TextBox2.Text);

            if (response)
            {
                My.MySettingsProperty.Settings.user = TextBox1.Text;
                My.MySettingsProperty.Settings.pass = TextBox2.Text;
                My.MySettingsProperty.Settings.Save();
                My.MySettingsProperty.Settings.Reload();
                My.MyProject.Forms.Form2.Show();
                Hide();
            }

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            SealCheck.HashChecks();

            if (SealCheck.isValidDLL)
            {
                bool response = LOGIN.Seal.Register(TextBox1.Text, TextBox2.Text, "SHEHAB@GMAIL.COM", TextBox3.Text);

                if (response)
                {
                    // Register Success
                }
            }
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            TextBox3.Visible = false;
            Label3.Visible = false;
            PictureBox3.Visible = true;
            PictureBox4.Visible = false;

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            TextBox3.Visible = true;
            Label3.Visible = true;
            PictureBox3.Visible = false;
            PictureBox4.Visible = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                newpoint = MousePosition;
                newpoint.X -= x;
                newpoint.Y -= y;
                Location = newpoint;
                Application.DoEvents();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = MousePosition.X - Location.X;
            y = MousePosition.Y - Location.Y;
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SealCheck.HashChecks();
            if (SealCheck.isValidDLL)
            {
                LOGIN.Seal.Secret = "Ly9Nepf07acVE3EDw9KuNPCdqngeNlIEZNwheXtz3GKkU";
                LOGIN.Seal.Initialize("1.0");
            }
            TextBox1.Text = My.MySettingsProperty.Settings.user;
            TextBox2.Text = My.MySettingsProperty.Settings.pass;
            TextBox3.Visible = false;
            Label3.Visible = false;


            PictureBox4.Visible = false;

        }
    }
}