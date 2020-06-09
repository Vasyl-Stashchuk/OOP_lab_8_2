namespace Lab8_2_
{
    partial class EditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveEditBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.salaryTextBox);
            this.groupBox1.Controls.Add(this.positionTextBox);
            this.groupBox1.Controls.Add(this.fioTextBox);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 348);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введіть інформацію:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(42, 299);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 9;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(42, 233);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(337, 22);
            this.salaryTextBox.TabIndex = 8;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(42, 170);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(337, 22);
            this.positionTextBox.TabIndex = 7;
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(42, 100);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(337, 22);
            this.fioTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(70, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(106, 22);
            this.idTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата прийняття на роботу:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Заробітня плата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Посада:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Прізвище, ім\'я, по-бітькові:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.Location = new System.Drawing.Point(218, 386);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.Size = new System.Drawing.Size(141, 48);
            this.saveEditBtn.TabIndex = 3;
            this.saveEditBtn.Text = "Зберегти";
            this.saveEditBtn.UseVisualStyleBackColor = true;
            this.saveEditBtn.Click += new System.EventHandler(this.saveEditBtn_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveEditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveEditBtn;
    }
}