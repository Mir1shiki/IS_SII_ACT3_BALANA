namespace IS_SII_ACT3_BALANA
{
    partial class add_item
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
            reorLvl = new NumericUpDown();
            addUp = new NumericUpDown();
            quantityAdd = new NumericUpDown();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            addItem = new Button();
            label4 = new Label();
            label3 = new Label();
            iCategory = new TextBox();
            iName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reorLvl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityAdd).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(reorLvl);
            panel1.Controls.Add(addUp);
            panel1.Controls.Add(quantityAdd);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(addItem);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(iCategory);
            panel1.Controls.Add(iName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(31, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 337);
            panel1.TabIndex = 4;
            // 
            // reorLvl
            // 
            reorLvl.Location = new Point(123, 250);
            reorLvl.Name = "reorLvl";
            reorLvl.Size = new Size(232, 23);
            reorLvl.TabIndex = 15;
            // 
            // addUp
            // 
            addUp.Location = new Point(123, 204);
            addUp.Name = "addUp";
            addUp.Size = new Size(232, 23);
            addUp.TabIndex = 14;
            // 
            // quantityAdd
            // 
            quantityAdd.Location = new Point(123, 160);
            quantityAdd.Name = "quantityAdd";
            quantityAdd.Size = new Size(232, 23);
            quantityAdd.TabIndex = 13;
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
            // addItem
            // 
            addItem.Location = new Point(170, 294);
            addItem.Name = "addItem";
            addItem.Size = new Size(75, 23);
            addItem.TabIndex = 6;
            addItem.Text = "Add";
            addItem.UseVisualStyleBackColor = true;
            addItem.Click += addItem_Click;
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
            // iCategory
            // 
            iCategory.Location = new Point(123, 112);
            iCategory.Name = "iCategory";
            iCategory.Size = new Size(232, 23);
            iCategory.TabIndex = 2;
            // 
            // iName
            // 
            iName.Location = new Point(123, 68);
            iName.Name = "iName";
            iName.Size = new Size(232, 23);
            iName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 11);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 0;
            label2.Text = "Add Product";
            // 
            // add_item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 372);
            Controls.Add(panel1);
            Name = "add_item";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add_item";
            FormClosing += add_item_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reorLvl).EndInit();
            ((System.ComponentModel.ISupportInitialize)addUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityAdd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Button addItem;
        private Label label4;
        private Label label3;
        private TextBox iCategory;
        private TextBox iName;
        private Label label2;
        private NumericUpDown reorLvl;
        private NumericUpDown addUp;
        private NumericUpDown quantityAdd;
    }
}