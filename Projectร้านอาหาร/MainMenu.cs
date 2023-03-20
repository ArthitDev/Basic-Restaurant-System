using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectร้านอาหาร
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void closeProgram_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดโปรแกรมหรือไม่ ? ", "ปิดโปรแกรม", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void customerMenuItem_Click(object sender, EventArgs e)
        {
            customer fr = new customer();
            fr.ShowDialog();
        }
        private void employeeMenuItem_Click(object sender, EventArgs e)
        {
            Employee fr = new Employee();
            fr.ShowDialog();
        }

        private void employeeTypeMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeType fr = new EmployeeType();
            fr.ShowDialog();
        }

        private void tableMenuItem_Click(object sender, EventArgs e)
        {
            Table fr = new Table();
            fr.ShowDialog();
        }
        private void foodMenuItem_Click(object sender, EventArgs e)
        {
            Food fr = new Food();
            fr.ShowDialog();
        }

        private void foodTypeMenuItem_Click(object sender, EventArgs e)
        {
            FoodType fr = new FoodType();
            fr.ShowDialog();
        }

        private void orderMenuItem_Click(object sender, EventArgs e)
        {
            Order fr = new Order();
            fr.ShowDialog();
        }

        private void UpdateStatus_Click(object sender, EventArgs e)
        {
            EmployeeStatusUpdate fr = new EmployeeStatusUpdate();
            fr.ShowDialog();
        }
    }
}
