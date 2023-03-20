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

namespace Projectร้านอาหาร
{
    public partial class EmployeeType : Form
    {
        int c = 0;
        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public EmployeeType()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=LAPTOP-O99KUFHP;Initial Catalog=restaurantDB;Integrated Security=True";
            con.Open();
            command.Connection = con;
            getData();
        }


        private void bUpdate_Click(object sender, EventArgs e)
        {
            command.CommandText = "update employeeType set empTypeName='" + empTypeName.Text + "' where empTypeCode ='" + empTypeCode.Text + "'";
            command.ExecuteNonQuery();
            getData();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            command.CommandText = "delete from employeeType where empTypeCode = '" + empTypeCode.Text + "'";
            command.ExecuteNonQuery();
            getData();
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
            empTypeCode.Clear();
            empTypeName.Clear();
            empTypeCode.Focus();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            command.CommandText = "Insert into employeeType values('" + empTypeCode.Text + "','" + empTypeName.Text + "')";
            command.ExecuteNonQuery();
            getData();
        }
        private void getData()
        {
            command.CommandText = "select * from employeeType";
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = command;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
        }

        private void empTypeCode_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                empTypeName.Text = "";
                command.CommandText = "select * from employeeType where empTypeCode='" + empTypeCode.Text + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    empTypeName.Text = dr[1].ToString();
                }
                dr.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                c = e.RowIndex;
                empTypeCode.Text = dataGridView1[0, c].Value + "";
                empTypeName.Text = dataGridView1[1, c].Value + "";
            }
            catch (Exception) { }
        }
    }
}
