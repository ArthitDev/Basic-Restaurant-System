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
    public partial class EmployeeStatusUpdate : Form
    {
        int c = 0;
        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public EmployeeStatusUpdate()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=ASUS-TUF-GAMING;Initial Catalog=restaurantDB;Integrated Security=True";
            con.Open();
            command.Connection = con;
            ShowItem();
        }
        private void ShowItem()
        {
            command.CommandText = "select orderCode as 'หมายเลขใบสั่งอาหาร',date as 'วัน-เวลา' ,tables.tableCode as 'เลขโต๊ะ',cusName as 'ชื่อลูกค้า' ,empName as 'ชื่อพนักงาน' ,foodName as 'ชื่ออาหาร' ,price as 'ราคา' ,qty as 'จำนวน',note as 'หมายเหตุ' ,orderStatus as 'สถานะออร์เดอร์' from orders join customer on orders.cusCode = customer.cusCode join employee on orders.empCode = employee.empCode join tables on orders.tableCode = tables.tableCode join food on orders.foodCode = food.foodCode";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
        }
        private void updateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderCode.Text == "")
                {
                    MessageBox.Show("ไม่ทราบสถานะ", "แจ้งเตือน");
                }
                else
                {
                    if (dataGridView1[9, c].Value + "" == "สั่งอาหาร")
                    {
                        command.CommandText = "update orders set orderStatus = '" + "กำลังจัดเตรียมอาหาร" + "' Where orderCode = '" + orderCode.Text + "'";
                        command.ExecuteNonQuery();
                        ShowItem();
                        MessageBox.Show("อัพเดทสถานะ : กำลังจัดเตรียมอาหาร");
                    }
                    else if (dataGridView1[9, c].Value + "" == "กำลังจัดเตรียมอาหาร")
                    {
                        command.CommandText = "update orders set orderStatus = '" + "รอเสิร์ฟ" + "' Where orderCode = '" + orderCode.Text + "'";
                        command.ExecuteNonQuery();
                        ShowItem();
                        MessageBox.Show("อัพเดทสถานะ : รอพนักงานนำไปเสิร์ฟ");
                    }
                    else if (dataGridView1[9, c].Value + "" == "รอเสิร์ฟ")
                    {
                        command.CommandText = "update orders set orderStatus = '" + "เสิร์ฟอาหารเรียบร้อยแล้ว" + "' Where orderCode = '" + orderCode.Text + "'";
                        command.ExecuteNonQuery();
                        ShowItem();
                        MessageBox.Show("อัพเดทสถานะ : เสิร์ฟอาหารเรียบร้อยแล้ว");
                    }
                    else if (orderCode.Text != "" && dataGridView1[9, c].Value + "" == "เสิร์ฟอาหารเรียบร้อยแล้ว")
                    {
                        MessageBox.Show("รายการนี้สำเร็จแล้ว");
                        /*if (MessageBox.Show("ต้องการลบข้อมูลหรือไม่ ? ", "ลบข้อมูล", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            command.CommandText = "delete from orders where orderCode = '" + orderCode.Text + "'";
                            command.ExecuteNonQuery();
                            MessageBox.Show("ลบข้อมูลแล้ว", "แจ้งเตือน");
                            ShowItem();
                        }*/
                    }
                    else
                    {
                        MessageBox.Show("ไม่ทราบสถานะ", "แจ้งเตือน");
                    }
                }    
            }
            catch (Exception) { };
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
                orderCode.Text = dataGridView1[0, c].Value + "";
            }
            catch (Exception) { }
        }
    }
}
