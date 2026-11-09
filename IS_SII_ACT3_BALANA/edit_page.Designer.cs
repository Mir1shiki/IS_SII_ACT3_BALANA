namespace IS_SII_ACT3_BALANA
{
    partial class edit_page
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
            panel1 = new Panel();
            edReor = new NumericUpDown();
            editUp = new NumericUpDown();
            edQty = new NumericUpDown();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            update = new Button();
            label4 = new Label();
            label3 = new Label();
            prodCategory = new TextBox();
            prodName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edReor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edQty).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(edReor);
            panel1.Controls.Add(editUp);
            panel1.Controls.Add(edQty);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(update);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(prodCategory);
            panel1.Controls.Add(prodName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 337);
            panel1.TabIndex = 5;
            // 
            // edReor
            // 
            edReor.Location = new Point(123, 250);
            edReor.Name = "edReor";
            edReor.Size = new Size(232, 23);
            edReor.TabIndex = 15;
            // 
            // editUp
            // 
            editUp.Location = new Point(123, 204);
            editUp.Name = "editUp";
            editUp.Size = new Size(232, 23);
            editUp.TabIndex = 14;
            // 
            // edQty
            // 
            edQty.Location = new Point(123, 160);
            edQty.Name = "edQty";
            edQty.Size = new Size(232, 23);
            edQty.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 254);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 12;
            label1.Text = "reorder level";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 203);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 10;
            label6.Text = "unit price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 159);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 8;
            label5.Text = "quantity";
            // 
            // update
            // 
            update.Location = new Point(170, 294);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 6;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 112);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 4;
            label4.Text = "category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 68);
            label3.Name = "label3";
            label3.Size = new Size(45, 19);
            label3.TabIndex = 3;
            label3.Text = "name";
            // 
            // prodCategory
            // 
            prodCategory.Location = new Point(123, 112);
            prodCategory.Name = "prodCategory";
            prodCategory.Size = new Size(232, 23);
            prodCategory.TabIndex = 2;
            // 
            // prodName
            // 
            prodName.Location = new Point(123, 68);
            prodName.Name = "prodName";
            prodName.Size = new Size(232, 23);
            prodName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 11);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 0;
            label2.Text = "Edit Product";
            // 
            // edit_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 361);
            Controls.Add(panel1);
            Name = "edit_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "edit_page";
            Load += edit_page_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edReor).EndInit();
            ((System.ComponentModel.ISupportInitialize)editUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)edQty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown edReor;
        private NumericUpDown editUp;
        private NumericUpDown edQty;
        private Label label1;
        private Label label6;
        private Label label5;
        private Button update;
        private Label label4;
        private Label label3;
        private TextBox prodCategory;
        private TextBox prodName;
        private Label label2;
    }
}