using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApp6
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form2 : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            PictureBox2 = new PictureBox();
            PictureBox2.Click += new EventHandler(PictureBox2_Click);
            PictureBox3 = new PictureBox();
            PictureBox3.Click += new EventHandler(PictureBox3_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer2 = new Timer(components);
            Timer2.Tick += new EventHandler(Timer2_Tick);
            Label3 = new Label();
            CheckBox1 = new CheckBox();
            CheckBox1.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            CheckBox2 = new CheckBox();
            CheckBox2.CheckedChanged += new EventHandler(CheckBox2_CheckedChanged);
            Timer3 = new Timer(components);
            Timer3.Tick += new EventHandler(Timer3_Tick);
            ComboBox1 = new ComboBox();
            TextBox1 = new TextBox();
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.Transparent;
            PictureBox1.Cursor = Cursors.Hand;
            PictureBox1.Location = new Point(19, 196);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(291, 55);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.BackColor = Color.Transparent;
            PictureBox2.Cursor = Cursors.Hand;
            PictureBox2.Location = new Point(19, 274);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(291, 55);
            PictureBox2.TabIndex = 1;
            PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            PictureBox3.BackColor = Color.Transparent;
            PictureBox3.Cursor = Cursors.Hand;
            PictureBox3.Location = new Point(19, 352);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(291, 55);
            PictureBox3.TabIndex = 2;
            PictureBox3.TabStop = false;
            // 
            // Button1
            // 
            Button1.BackColor = Color.Transparent;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button1.ForeColor = Color.FromArgb(226, 205, 134);
            Button1.Location = new Point(306, -2);
            Button1.Name = "Button1";
            Button1.Size = new Size(32, 28);
            Button1.TabIndex = 11;
            Button1.Text = "X";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Timer1
            // 
            // 
            // Timer2
            // 
            Timer2.Interval = 5000;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.FromArgb(184, 143, 7);
            Label3.Location = new Point(5, 422);
            Label3.Name = "Label3";
            Label3.Size = new Size(101, 16);
            Label3.TabIndex = 12;
            Label3.Text = "BYPASS OFF";
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.BackColor = Color.Transparent;
            CheckBox1.ForeColor = Color.FromArgb(184, 143, 7);
            CheckBox1.Location = new Point(205, 423);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(105, 17);
            CheckBox1.TabIndex = 13;
            CheckBox1.Text = "BEFORE LOGIN";
            CheckBox1.UseVisualStyleBackColor = false;
            // 
            // CheckBox2
            // 
            CheckBox2.AutoSize = true;
            CheckBox2.BackColor = Color.Transparent;
            CheckBox2.ForeColor = Color.FromArgb(184, 143, 7);
            CheckBox2.Location = new Point(205, 446);
            CheckBox2.Name = "CheckBox2";
            CheckBox2.Size = new Size(78, 17);
            CheckBox2.TabIndex = 14;
            CheckBox2.Text = "IN MATCH";
            CheckBox2.UseVisualStyleBackColor = false;
            // 
            // Timer3
            // 
            Timer3.Enabled = true;
            // 
            // ComboBox1
            // 
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Location = new Point(248, 159);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(83, 21);
            ComboBox1.TabIndex = 15;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(478, 274);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(11, 10);
            TextBox1.TabIndex = 20;
            TextBox1.Text = resources.GetString("TextBox1.Text");
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(184, 143, 7);
            Label1.Location = new Point(6, 443);
            Label1.Name = "Label1";
            Label1.Size = new Size(29, 12);
            Label1.TabIndex = 21;
            Label1.Text = "label";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = My.Resources.Resources.Batman_Wallpapers_For_Phone_008;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(334, 475);
            Controls.Add(Label1);
            Controls.Add(TextBox1);
            Controls.Add(ComboBox1);
            Controls.Add(CheckBox2);
            Controls.Add(CheckBox1);
            Controls.Add(Label3);
            Controls.Add(Button1);
            Controls.Add(PictureBox3);
            Controls.Add(PictureBox2);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Opacity = 0.95d;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BATMAN BYPASS";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            MouseDown += new MouseEventHandler(Form2_MouseDown);
            FormClosed += new FormClosedEventHandler(Form2_FormClosed);
            Load += new EventHandler(Form2_Load);
            MouseMove += new MouseEventHandler(Form2_MouseMove);
            ResumeLayout(false);
            PerformLayout();

        }

        internal PictureBox PictureBox1;
        internal PictureBox PictureBox2;
        internal PictureBox PictureBox3;
        internal Button Button1;
        internal Timer Timer1;
        internal Timer Timer2;
        internal Label Label3;
        internal CheckBox CheckBox1;
        internal CheckBox CheckBox2;
        internal Timer Timer3;
        internal ComboBox ComboBox1;
        internal TextBox TextBox1;
        internal Label Label1;
    }
}