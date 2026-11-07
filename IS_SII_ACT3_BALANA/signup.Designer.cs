namespace IS_SII_ACT3_BALANA
{
    partial class signup
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
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            conPass = new TextBox();
            button2 = new Button();
            label4 = new Label();
            loginRed = new Button();
            label3 = new Label();
            passTxt = new TextBox();
            uname = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(168, 14);
            label1.Name = "label1";
            label1.Size = new Size(326, 26);
            label1.TabIndex = 2;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(conPass);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(loginRed);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(passTxt);
            panel1.Controls.Add(uname);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(141, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 258);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 163);
            label5.Name = "label5";
            label5.Size = new Size(123, 19);
            label5.TabIndex = 8;
            label5.Text = "confirm password";
            // 
            // conPass
            // 
            conPass.Location = new Point(170, 159);
            conPass.Name = "conPass";
            conPass.Size = new Size(185, 23);
            conPass.TabIndex = 7;
            conPass.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.Location = new Point(170, 198);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "signup";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 112);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 4;
            label4.Text = "password";
            // 
            // loginRed
            // 
            loginRed.Location = new Point(280, 198);
            loginRed.Name = "loginRed";
            loginRed.Size = new Size(75, 23);
            loginRed.TabIndex = 5;
            loginRed.Text = "login";
            loginRed.UseVisualStyleBackColor = true;
            loginRed.Click += loginRed_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 68);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 3;
            label3.Text = "username";
            // 
            // passTxt
            // 
            passTxt.Location = new Point(170, 112);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(185, 23);
            passTxt.TabIndex = 2;
            passTxt.UseSystemPasswordChar = true;
            passTxt.TextChanged += textBox2_TextChanged;
            // 
            // uname
            // 
            uname.Location = new Point(170, 68);
            uname.Name = "uname";
            uname.Size = new Size(185, 23);
            uname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 19);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 0;
            label2.Text = "signup";
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 370);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "signup";
            Text = "signup";
            FormClosing += signup_FormClosing;
            Load += signup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button2;
        private Button loginRed;
        private Label label4;
        private Label label3;
        private TextBox passTxt;
        private TextBox uname;
        private Label label2;
        private Label label5;
        private TextBox conPass;
    }
}