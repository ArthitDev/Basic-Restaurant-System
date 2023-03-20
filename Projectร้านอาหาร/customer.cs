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
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Projectร้านอาหาร
{
    public partial class customer : Form
    {
        int c = 0;
        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public customer()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=ASUS-TUF-GAMING;Initial Catalog=restaurantDB;Integrated Security=True";
            con.Open();
            command.Connection = con;
            ShowItem();
        }

        private void ShowItem()
        {
            command.CommandText = "select cusCode as 'รหัสลูกค้า',cusName as 'ชื่อลูกค้า' ,cusPhone as 'เบอร์โทร',cusType as 'ประเภท' from customer";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            cusCode.Clear();
            cusName.Clear();
            cusPhone.Clear();
            walkin.Checked = false;
            reserve.Checked = false;
            cusCode.Focus();
            ShowItem();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            if (cusCode.Text != "" && cusName.Text != "" || cusPhone.Text != "")
            {
                try
                {
                    if (walkin.Checked == true)
                    {
                        command.CommandText = "Insert into customer values('" + cusCode.Text + "','" + cusName.Text + "','" + cusPhone.Text + "','" + walkin.Text + "')";
                        command.ExecuteNonQuery();
                    }
                    else if (reserve.Checked == true)
                    {
                        command.CommandText = "Insert into customer values('" + cusCode.Text + "','" + cusName.Text + "','" + cusPhone.Text + "','" + reserve.Text + "')";
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("กรุณาเลือกประเภทลูกค้า");
                    }
                }
                catch (Exception) { MessageBox.Show("ข้อมูลซ้ำ"); };
            }
            else
            {
                MessageBox.Show("กรอกข้อมูลให้ครบถ้วน");
            }
            ShowItem();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (walkin.Checked == true)
                {
                    command.CommandText = "update customer set cusName = '" + cusName.Text + "', cusPhone = '" + cusPhone.Text + "',cusType = '" + walkin.Text + "' Where cusCode = '" + cusCode.Text + "'";
                    command.ExecuteNonQuery();
                    ShowItem();
                }
                else if(reserve.Checked == true)
                {
                    command.CommandText = "update customer set cusName = '" + cusName.Text + "', cusPhone = '" + cusPhone.Text + "', cusType = '" + reserve.Text + "' Where cusCode = '" + cusCode.Text + "'";
                    command.ExecuteNonQuery();
                    ShowItem(); 
                }
                else if (reserve_food.Checked == true)
                {
                    command.CommandText = "update customer set cusName = '" + cusName.Text + "', cusPhone = '" + cusPhone.Text + "', cusType = '" + reserve_food.Text + "' Where cusCode = '" + cusCode.Text + "'";
                    command.ExecuteNonQuery();
                    ShowItem();
                }

            }
            catch(Exception) { };
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                if (MessageBox.Show("ต้องการลบข้อมูลหรือไม่ ? ", "ลบข้อมูล", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    command.CommandText = "delete from customer where cusCode = '" + cusCode.Text + "'";
                    command.ExecuteNonQuery();
                    ShowItem();
                    MessageBox.Show("ลบข้อมูลแล้ว","แจ้งเตือน");
                }
            }
            else
            {
                MessageBox.Show("ไม่มีข้อมูลให้ลบ","แจ้งเตือน");
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
                cusCode.Text = dataGridView1[0, c].Value + "";
                cusName.Text = dataGridView1[1, c].Value + "";
                cusPhone.Text = dataGridView1[2, c].Value + "";
                if (dataGridView1[3, c].Value + "" == "ปกติ")
                {
                    walkin.Checked = true;
                }
                else if (dataGridView1[3, c].Value + "" == "จอง")
                {
                    reserve.Checked = true;
                }
                else if (dataGridView1[3, c].Value + "" == "จอง + สั่งอาหาร")
                {
                    reserve_food.Checked = true;
                }
                else
                {
                    walkin.Checked = false;
                    reserve.Checked = false;
                    reserve_food.Checked = false;
                }
            }
            catch (Exception) { }
        }

        private void cusCode_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cusName.Text = "";
                command.CommandText = "select * from customer where cusCode='" + cusCode.Text + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    cusName.Text = dr[1].ToString();
                    cusPhone.Text = dr[2].ToString();
                    if (dataGridView1[3, c].Value + "" == "หน้าร้าน")
                    {
                        walkin.Checked = true;
                    }
                    else if (dataGridView1[3, c].Value + "" == "จอง")
                    {
                        reserve.Checked = true;
                    }
                    else
                    {
                        walkin.Checked = false;
                        reserve.Checked = false;
                    }
                }
                dr.Close();
            }
        }
    }
}
