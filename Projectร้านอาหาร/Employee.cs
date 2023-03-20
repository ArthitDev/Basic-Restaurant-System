using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projectร้านอาหาร
{
    public partial class Employee : Form
    {
        int c = 0;
        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public Employee()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=ASUS-TUF-GAMING;Initial Catalog=restaurantDB;Integrated Security=True";
            con.Open();
            command.Connection = con;
            ShowData();
            getEmployee();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดหน้านี้หรือไม่ ? ", "ปิด", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void bClear_Click(object sender, EventArgs e)
        {
            empCode.Clear();
            empName.Clear();
            empPhone.Clear();
            empEmail.Clear();
            empAddress.Clear();
            empCode.Focus();
            employeeType.Items.Clear();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            command.CommandText = "Insert into employee values('" + empCode.Text + "','" + empName.Text + "','" + empPhone.Text + "','" + empEmail.Text + "','" + empAddress.Text + "','" + employeeType.SelectedValue + "')";
            command.ExecuteNonQuery();
            ShowData();
        }

        private void bUpdateClick(object sender, EventArgs e)
        {
            command.CommandText = "update employee set empName='" + empName.Text + "',empPhone='" + empPhone.Text + "',empEmail='" + empEmail.Text + "',empAddress='" + empAddress.Text + "',empTypeCode='" + employeeType.SelectedValue + "' where empCode ='" + empCode.Text + "'";
            command.ExecuteNonQuery();
            ShowData();
        }

        private void bDeleteClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                if (MessageBox.Show("ต้องการลบข้อมูลหรือไม่ ? ", "ลบข้อมูล", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    command.CommandText = "delete from employee where empCode = '" + empCode.Text + "'";
                    command.ExecuteNonQuery();
                    ShowData();
                    MessageBox.Show("ลบข้อมูลแล้ว", "แจ้งเตือน");
                }
            }
        }

        private void getEmployee()
        {
            command.CommandText = "select * from employeeType";
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = command;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource1.DataSource = table;
            employeeType.DataSource = bindingSource1;
            employeeType.DisplayMember = "empTypeName";
            employeeType.ValueMember = "empTypeCode";


        }
        private void ShowData()
        {
            command.CommandText = "select empCode as 'รหัสผนักงาน',empName as 'ชื่อพนักงาน',empPhone as 'เบอร์โทร',empEmail as 'อีเมล',empAddress as 'ที่อยู่',empTypeName as 'ประเภทพนักงาน' from employee join employeeType on employee.empTypeCode = employeeType.empTypeCode";
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = command;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource2.DataSource = table;
            dataGridView1.DataSource = bindingSource2;
        }

        private void empCode_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                empName.Text = "";
                command.CommandText = "select * from employee where empCode='" + empCode.Text + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    empName.Text = dr[1].ToString();
                    empPhone.Text = dr[2].ToString();
                    empEmail.Text = dr[3].ToString();
                    empAddress.Text = dr[4].ToString();
                    employeeType.SelectedValue = dr[5].ToString();
                }
                dr.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                c = e.RowIndex;
                empCode.Text = dataGridView1[0, c].Value + "";
                empName.Text = dataGridView1[1, c].Value + "";
                empPhone.Text = dataGridView1[2, c].Value + "";
                empEmail.Text = dataGridView1[3, c].Value + "";
                empAddress.Text = dataGridView1[4, c].Value + "";
                employeeType.Text = dataGridView1[5, c].Value + "";

            }
            catch (Exception) { }
        }
    }
    
}
