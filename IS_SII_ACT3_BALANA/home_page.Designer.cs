namespace IS_SII_ACT3_BALANA
{
    partial class home_page
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            deleteButton = new Button();
            refreshh = new Button();
            textBox1 = new TextBox();
            button7 = new Button();
            disProd = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)disProd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 23);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management System";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.LightCyan;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(deleteButton);
            flowLayoutPanel1.Controls.Add(refreshh);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Location = new Point(-1, 35);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(820, 29);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "In";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(84, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Out";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(165, 3);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(246, 3);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(327, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // refreshh
            // 
            refreshh.Location = new Point(408, 3);
            refreshh.Name = "refreshh";
            refreshh.Size = new Size(75, 23);
            refreshh.TabIndex = 7;
            refreshh.Text = "Refresh";
            refreshh.UseVisualStyleBackColor = true;
            refreshh.Click += refreshh_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(489, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 8;
            // 
            // button7
            // 
            button7.Location = new Point(726, 3);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 3;
            button7.Text = "Search";
            button7.UseVisualStyleBackColor = true;
            // 
            // disProd
            // 
            disProd.AllowUserToAddRows = false;
            disProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            disProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            disProd.Location = new Point(83, 83);
            disProd.MultiSelect = false;
            disProd.Name = "disProd";
            disProd.ReadOnly = true;
            disProd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            disProd.Size = new Size(641, 407);
            disProd.TabIndex = 2;
            // 
            // home_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(813, 511);
            Controls.Add(disProd);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "home_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "homepage";
            FormClosing += home_page_FormClosing;
            Load += home_page_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)disProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button deleteButton;
        private Button refreshh;
        private TextBox textBox1;
        private Button button7;
        private DataGridView disProd;
    }
}