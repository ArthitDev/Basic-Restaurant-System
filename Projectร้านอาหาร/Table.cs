using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectร้านอาหาร
{
    public partial class Table : Form
    {
        int c = 0;
        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public Table()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=ASUS-TUF-GAMING;Initial Catalog=restaurantDB;Integrated Security=True";
            con.Open();
            command.Connection = con;
            ShowItem();
        }
        private void ShowItem()
        {
            command.CommandText = "select tableCode as 'รหัสโต๊ะ',amount as 'จำนวน',tableStatus as 'สถานะโต๊ะ' from tables";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tableCode.Clear();
            sitNum.Clear();
            empty.Checked = false;
            full.Checked = false;
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            if(empty.Checked == true)
            {
                command.CommandText = "Insert into tables values('" + tableCode.Text + "','" + sitNum.Text + "','" + "ว่าง" + "')";
                command.ExecuteNonQuery();
                ShowItem();
            }
            else if(full.Checked == true)
            {
                command.CommandText = "Insert into tables values('" + tableCode.Text + "','" + sitNum.Text + "','" + "ไม่ว่าง" + "')";
                command.ExecuteNonQuery();
                ShowItem();
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                command.CommandText = "update tables set tableCode = '" + tableCode.Text + "', amount = '" + sitNum.Text + "' Where tableCode = '" + tableCode.Text + "'";
                command.ExecuteNonQuery();
                ShowItem();
            }
            catch (Exception) { };
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                if (MessageBox.Show("ต้องการลบข้อมูลหรือไม่ ? ", "ลบข้อมูล", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    command.CommandText = "delete from tables where tableCode = '" + tableCode.Text + "'";
                    command.ExecuteNonQuery();
                    ShowItem();
                    MessageBox.Show("ลบข้อมูลแล้ว", "แจ้งเตือน");
                }
            }
            else
            {
                MessageBox.Show("ไม่มีข้อมูลให้ลบ", "แจ้งเตือน");
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดหน้านี้หรือไม่ ? ", "ปิด", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                c = e.RowIndex;
                tableCode.Text = dataGridView1[0, c].Value + "";
                sitNum.Text = dataGridView1[1, c].Value + "";
                if (dataGridView1[2, c].Value + "" == "หน้าร้าน")
                {
                    empty.Checked = true;
                }
                else if (dataGridView1[2, c].Value + "" == "จอง")
                {
                    full.Checked = true;
                }
                else
                {
                    empty.Checked = false;
                    full.Checked = false;
                }
            }
            catch (Exception) { }
        }
    }
}
