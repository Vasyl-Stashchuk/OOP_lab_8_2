using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_2_
{
    public partial class EditForm : Form
    {
        private int i;
        private List<Employee> employees;
        public EditForm(int rowIndex, List<Employee> emp)
        {
            InitializeComponent();
            employees = emp;
            i = rowIndex;
            idTextBox.Text = employees[i].ID.ToString();
            fioTextBox.Text = employees[i].FIO;
            positionTextBox.Text = employees[i].Position;
            salaryTextBox.Text = employees[i].Salary.ToString();
            dateTimePicker.Value = employees[i].StartWork;
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                employees[i].ID = int.Parse(idTextBox.Text);
                employees[i].FIO = fioTextBox.Text;
                employees[i].Position = positionTextBox.Text;
                employees[i].Salary = float.Parse(salaryTextBox.Text);
                employees[i].StartWork = dateTimePicker.Value;
                
                MessageBox.Show("Збережено успішно");

                Form1.save();
                Form1.update();
                this.Close();
            }
            catch (FormatException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
