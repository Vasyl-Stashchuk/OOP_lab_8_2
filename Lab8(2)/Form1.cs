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
    public partial class Form1 : Form
    {
        public static List<Employee> employees;
        private ResourseDepartment resDepartment;
        public static ReaderWriter readerWriter;
        public static DataTable dataTable;
        private int rowIndex;
        public Form1()
        {
            InitializeComponent();
            readerWriter = new ReaderWriter();
            resDepartment = new ResourseDepartment();
            employees = resDepartment.createList();
            dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Прізвище, імя, по-батькові");
            dataTable.Columns.Add("Посада");
            dataTable.Columns.Add("Зарплата");
            dataTable.Columns.Add("Дата прийняття на роботу");
            showEmployeesList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (AddForm addForm = new AddForm())
            {
                addForm.ShowDialog();
            }
        }

        public static void update()
        {         
            dataTable.Rows.Clear();
            foreach (var emp in employees)
            {
                dataTable.Rows.Add(emp.ID, emp.FIO, emp.Position, emp.Salary, emp.StartWork.Date.ToString("dd.mm.yyyy"));
            }
            employeesDataView.DataSource = dataTable;
            employeesDataView.Refresh();
        }

        public static void save()
        {
            sortByDateBtn.Checked = false;
            sortByIDBtn.Checked = false;
            sortBySalaryBtn.Checked = false;
            readerWriter.saveList(employees);
        }
        private void sortByIDBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sortByIDBtn.Checked)
                employees.Sort();
            update();
        }
        private void sortBySalaryBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sortBySalaryBtn.Checked)
                employees.Sort(0, employees.Count, new Employee.SortBySalarey());
            update();
        }

        private void sortByDateBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sortByDateBtn.Checked)
                employees.Sort(0, employees.Count, new Employee.SortByDate());
            update();
        }

        private void employeesDataView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                employeesDataView.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                employeesDataView.Rows[rowIndex].ContextMenuStrip = employeeMenuStrip;
            }
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {
            using (EditForm editForm = new EditForm(rowIndex, employees))
            {
                editForm.ShowDialog();
            }
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataTable.Rows.Remove(dataTable.Rows[rowIndex]);
                employees.Remove(employees[rowIndex]);
                //employeesDataView.Rows.Remove(employeesDataView.Rows[rowIndex]);
                readerWriter.saveList(employees);
                MessageBox.Show("Видалено успішно!");
                employeesDataView.Refresh();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void upDateBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void showEmployeesList()
        {
            
            foreach (var emp in employees)
            {
                dataTable.Rows.Add(emp.ID, emp.FIO, emp.Position, emp.Salary, emp.StartWork.Date.ToString("dd.mm.yyyy"));
            }

            employeesDataView.DataSource = dataTable;
            /*employeesDataView.Columns[1].HeaderText = "Прізвище, імя, по-батькові";
            employeesDataView.Columns[2].HeaderText = "Посада";
            employeesDataView.Columns[3].HeaderText = "Зарплата";
            employeesDataView.Columns[4].HeaderText = "Дата прийняття на роботу";*/
        }
    }
}
