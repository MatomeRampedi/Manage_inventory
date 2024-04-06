namespace cafe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            PasswordTB = new TextBox();
            UsernameTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(PasswordTB);
            panel1.Controls.Add(UsernameTB);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(160, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 316);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(42, 236);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 21);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 183);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 122);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 4;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Orange;
            button1.Location = new Point(31, 263);
            button1.Name = "button1";
            button1.Size = new Size(138, 34);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PasswordTB
            // 
            PasswordTB.BackColor = SystemColors.ControlLightLight;
            PasswordTB.Location = new Point(31, 207);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(138, 23);
            PasswordTB.TabIndex = 2;
            PasswordTB.UseSystemPasswordChar = true;
            PasswordTB.TextChanged += textBox2_TextChanged;
            // 
            // UsernameTB
            // 
            UsernameTB.BackColor = SystemColors.ControlLightLight;
            UsernameTB.Location = new Point(31, 146);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(138, 23);
            UsernameTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 12);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(99, 9);
            label2.Name = "label2";
            label2.Size = new Size(320, 30);
            label2.TabIndex = 1;
            label2.Text = "Inventory Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(530, 510);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox UsernameTB;
        private Button button1;
        private TextBox PasswordTB;
        private Label label4;
        private Label label3;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}
