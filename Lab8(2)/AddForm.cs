using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_2_
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void saveAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                string fio = textBox2.Text;
                string position = textBox3.Text;
                float salary = float.Parse(textBox4.Text);
                DateTime date = dateTimePicker1.Value;
                Employee employee = new Employee(id,fio,position,salary,date.Date);       
                MessageBox.Show("Збережено успішно");

                Form1.employees.Add(employee);
                //Form1.dataTable.Rows.Add(employee.ID, employee.FIO, employee.Position, employee.Salary, employee.StartWork.Date.ToString("dd.mm.yyyy"));
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
