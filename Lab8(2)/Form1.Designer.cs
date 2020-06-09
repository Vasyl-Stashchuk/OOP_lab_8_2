namespace Lab8_2_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            employeesDataView = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            sortByDateBtn = new System.Windows.Forms.RadioButton();
            sortBySalaryBtn = new System.Windows.Forms.RadioButton();
            sortByIDBtn = new System.Windows.Forms.RadioButton();
            this.employeeMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(employeesDataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.employeeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesDataView
            // 
            employeesDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            employeesDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            employeesDataView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            employeesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesDataView.Location = new System.Drawing.Point(47, 131);
            employeesDataView.Name = "employeesDataView";
            employeesDataView.ReadOnly = true;
            employeesDataView.RowHeadersWidth = 51;
            employeesDataView.RowTemplate.Height = 24;
            employeesDataView.Size = new System.Drawing.Size(718, 241);
            employeesDataView.TabIndex = 0;
            employeesDataView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(employeesDataView_CellMouseClick);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(318, 394);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(153, 46);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Додати";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(sortByDateBtn);
            this.groupBox1.Controls.Add(sortBySalaryBtn);
            this.groupBox1.Controls.Add(sortByIDBtn);
            this.groupBox1.Location = new System.Drawing.Point(47, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортування";
            // 
            // sortByDateBtn
            // 
            sortByDateBtn.AutoSize = true;
            sortByDateBtn.Location = new System.Drawing.Point(282, 31);
            sortByDateBtn.Name = "sortByDateBtn";
            sortByDateBtn.Size = new System.Drawing.Size(233, 21);
            sortByDateBtn.TabIndex = 2;
            sortByDateBtn.Text = "за датою прийняття на роботу";
            sortByDateBtn.UseVisualStyleBackColor = true;
            sortByDateBtn.CheckedChanged += new System.EventHandler(sortByDateBtn_CheckedChanged);
            // 
            // sortBySalaryBtn
            // 
            sortBySalaryBtn.AutoSize = true;
            sortBySalaryBtn.Location = new System.Drawing.Point(130, 31);
            sortBySalaryBtn.Name = "sortBySalaryBtn";
            sortBySalaryBtn.Size = new System.Drawing.Size(120, 21);
            sortBySalaryBtn.TabIndex = 1;
            sortBySalaryBtn.Text = "за зарплатою";
            sortBySalaryBtn.UseVisualStyleBackColor = true;
            sortBySalaryBtn.CheckedChanged += new System.EventHandler(sortBySalaryBtn_CheckedChanged);
            // 
            // sortByIDBtn
            // 
            sortByIDBtn.AutoSize = true;
            sortByIDBtn.Location = new System.Drawing.Point(18, 31);
            sortByIDBtn.Name = "sortByIDBtn";
            sortByIDBtn.Size = new System.Drawing.Size(62, 21);
            sortByIDBtn.TabIndex = 0;
            sortByIDBtn.Text = "по ID";
            sortByIDBtn.UseVisualStyleBackColor = true;
            sortByIDBtn.CheckedChanged += new System.EventHandler(sortByIDBtn_CheckedChanged);
            // 
            // employeeMenuStrip
            // 
            this.employeeMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employeeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuItem,
            this.deleteMenuItem});
            this.employeeMenuStrip.Name = "contextMenuStrip1";
            this.employeeMenuStrip.Size = new System.Drawing.Size(155, 52);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(154, 24);
            this.editMenuItem.Text = "Редагувати";
            this.editMenuItem.Click += new System.EventHandler(this.editMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(154, 24);
            this.deleteMenuItem.Text = "Видалити";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(employeesDataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Відділ кадрів";
            ((System.ComponentModel.ISupportInitialize)(employeesDataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.employeeMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private static System.Windows.Forms.RadioButton sortByDateBtn;
        private static System.Windows.Forms.RadioButton sortBySalaryBtn;
        private static System.Windows.Forms.RadioButton sortByIDBtn;
        private System.Windows.Forms.ContextMenuStrip employeeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private static System.Windows.Forms.DataGridView employeesDataView;
    }
}

