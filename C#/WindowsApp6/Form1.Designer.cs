using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApp6
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            TextBox3 = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            PictureBox2 = new PictureBox();
            PictureBox2.Click += new EventHandler(PictureBox2_Click);
            PictureBox3 = new PictureBox();
            PictureBox3.Click += new EventHandler(PictureBox3_Click);
            PictureBox4 = new PictureBox();
            PictureBox4.Click += new EventHandler(PictureBox4_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).BeginInit();
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(61, 297);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(277, 20);
            TextBox1.TabIndex = 0;
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(61, 334);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(277, 20);
            TextBox2.TabIndex = 1;
            // 
            // TextBox3
            // 
            TextBox3.Location = new Point(61, 369);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(277, 20);
            TextBox3.TabIndex = 2;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(0, 279);
            Label1.Name = "Label1";
            Label1.Size = new Size(92, 15);
            Label1.TabIndex = 3;
            Label1.Text = "USERNAME :";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(0, 318);
            Label2.Name = "Label2";
            Label2.Size = new Size(92, 15);
            Label2.TabIndex = 4;
            Label2.Text = "PASSWORD :";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(14, 370);
            Label3.Name = "Label3";
            Label3.Size = new Size(41, 15);
            Label3.TabIndex = 5;
            Label3.Text = "KEY :";
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.Transparent;
            PictureBox1.Cursor = Cursors.Hand;
            PictureBox1.Location = new Point(17, 424);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(153, 66);
            PictureBox1.TabIndex = 6;
            PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.BackColor = Color.Transparent;
            PictureBox2.Cursor = Cursors.Hand;
            PictureBox2.Location = new Point(185, 424);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(153, 66);
            PictureBox2.TabIndex = 7;
            PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            PictureBox3.BackColor = Color.Transparent;
            PictureBox3.Cursor = Cursors.Hand;
            PictureBox3.Location = new Point(185, 424);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(153, 66);
            PictureBox3.TabIndex = 8;
            PictureBox3.TabStop = false;
            // 
            // PictureBox4
            // 
            PictureBox4.BackColor = Color.Transparent;
            PictureBox4.Cursor = Cursors.Hand;
            PictureBox4.Location = new Point(17, 424);
            PictureBox4.Name = "PictureBox4";
            PictureBox4.Size = new Size(153, 66);
            PictureBox4.TabIndex = 9;
            PictureBox4.TabStop = false;
            // 
            // Button1
            // 
            Button1.BackColor = Color.Transparent;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(323, -2);
            Button1.Name = "Button1";
            Button1.Size = new Size(32, 28);
            Button1.TabIndex = 10;
            Button1.Text = "X";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = My.Resources.Resources._4981_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(350, 502);
            Controls.Add(Button1);
            Controls.Add(PictureBox4);
            Controls.Add(PictureBox3);
            Controls.Add(PictureBox2);
            Controls.Add(PictureBox1);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(TextBox3);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Opacity = 0.95d;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).EndInit();
            MouseMove += new MouseEventHandler(Form1_MouseMove);
            MouseDown += new MouseEventHandler(Form1_MouseDown);
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox TextBox1;
        internal TextBox TextBox2;
        internal TextBox TextBox3;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal PictureBox PictureBox1;
        internal PictureBox PictureBox2;
        internal PictureBox PictureBox3;
        internal PictureBox PictureBox4;
        internal Button Button1;
    }
}