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
    public partial class FoodType : Form
    {
        int c=0;
        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public FoodType()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=ASUS-TUF-GAMING;Initial Catalog=restaurantDB;Integrated Security=True";
            con.Open();
            command.Connection = con;
            getData();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            command.CommandText = "update foodType set foodTypeName='" + foodTypeName.Text + "' where foodTypeCode ='" + foodTypeCode.Text + "'";
            command.ExecuteNonQuery();
            getData();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            command.CommandText = "delete from foodType where foodTypeCode = '" + foodTypeCode.Text + "'";
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
            foodTypeCode.Clear();
            foodTypeName.Clear();
            foodTypeCode.Focus();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            command.CommandText = "Insert into foodType values('" + foodTypeCode.Text + "','" + foodTypeName.Text + "')";
            command.ExecuteNonQuery();
            getData();
        }

        private void bDeleteClick(object sender, EventArgs e)
        {
            command.CommandText = "delete from foodType where foodTypeCode = '" + foodTypeCode.Text + "'";
            command.ExecuteNonQuery();
            getData();
        }
        private void getData()
        {
            command.CommandText = "select * from foodType";
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = command;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
        }

        private void foodTypeCode_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foodTypeName.Text = "";
                command.CommandText = "select * from foodType where foodTypeCode='" + foodTypeCode.Text + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    foodTypeName.Text = dr[1].ToString();
                }
                dr.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                c = e.RowIndex;
                foodTypeCode.Text = dataGridView1[0, c].Value + "";
                foodTypeName.Text = dataGridView1[1, c].Value + "";
            }
            catch (Exception) { }
        }
    }
}
