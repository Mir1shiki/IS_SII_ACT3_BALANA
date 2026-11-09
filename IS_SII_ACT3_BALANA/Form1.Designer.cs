namespace IS_SII_ACT3_BALANA
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
            label1 = new Label();
            panel1 = new Panel();
            signupRed = new Button();
            loginButt = new Button();
            label4 = new Label();
            label3 = new Label();
            pasTxt = new TextBox();
            unTxt = new TextBox();
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
            label1.Location = new Point(178, 22);
            label1.Name = "label1";
            label1.Size = new Size(326, 26);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(signupRed);
            panel1.Controls.Add(loginButt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pasTxt);
            panel1.Controls.Add(unTxt);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(167, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 214);
            panel1.TabIndex = 1;
            // 
            // signupRed
            // 
            signupRed.Location = new Point(202, 152);
            signupRed.Name = "signupRed";
            signupRed.Size = new Size(75, 23);
            signupRed.TabIndex = 6;
            signupRed.Text = "signup";
            signupRed.UseVisualStyleBackColor = true;
            signupRed.Click += signupRed_Click;
            // 
            // loginButt
            // 
            loginButt.Location = new Point(121, 152);
            loginButt.Name = "loginButt";
            loginButt.Size = new Size(75, 23);
            loginButt.TabIndex = 5;
            loginButt.Text = "login";
            loginButt.UseVisualStyleBackColor = true;
            loginButt.Click += loginButt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 116);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 4;
            label4.Text = "password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 68);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 3;
            label3.Text = "username";
            // 
            // pasTxt
            // 
            pasTxt.Location = new Point(121, 112);
            pasTxt.Name = "pasTxt";
            pasTxt.Size = new Size(185, 23);
            pasTxt.TabIndex = 2;
            pasTxt.UseSystemPasswordChar = true;
            // 
            // unTxt
            // 
            unTxt.Location = new Point(121, 68);
            unTxt.Name = "unTxt";
            unTxt.Size = new Size(185, 23);
            unTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 19);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 0;
            label2.Text = "login";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(682, 357);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox pasTxt;
        private TextBox unTxt;
        private Button signupRed;
        private Button loginButt;
    }
}
