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
    public partial class Order : Form
    {
        int c = 0;
        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlCommand command_2 = new SqlCommand();
        SqlCommand command_3 = new SqlCommand();
        SqlCommand command_4 = new SqlCommand();
        public Order()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=ASUS-TUF-GAMING;Initial Catalog=restaurantDB;Integrated Security=True";
            con.Open();
            command.Connection = con;
            command_2.Connection = con;
            command_3.Connection = con;
            command_4.Connection = con;
            ShowItem();
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            getFood();
            getEmployee();
            cusType.ResetText();
            empName.SelectedIndex = 0;
            food_select.SelectedIndex = 0;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            date.Text = now.ToString("MM / dd / yyyy HH: mm: s");
        }
        private void getFood()
        {
            command.CommandText = "select * from food";
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = command;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource2.DataSource = table;
            food_select.DataSource = bindingSource2;
            food_select.DisplayMember = "foodName";
            food_select.ValueMember = "foodCode";
        }
        private void getEmployee()
        {
            command.CommandText = "select * from employee join employeeType on employee.empTypeCode = employeeType.empTypeCode where employee.empTypeCode='01'";
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = command;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource3.DataSource = table;
            empName.DataSource = bindingSource3;
            empName.DisplayMember = "empName";
            empName.ValueMember = "empCode";
        }
        private void ShowItem()
        {
            command.CommandText = "select orderCode as 'หมายเลขใบสั่งอาหาร',date as 'วัน-เวลา' ,tables.tableCode as 'เลขโต๊ะ',orders.cusCode as 'รหัสลูกค้า' ,cusName as 'ชื่อลูกค้า' ,empName as 'ชื่อพนักงาน' ,foodName as 'ชื่ออาหาร' ,price as 'ราคา' ,qty as 'จำนวน',price*qty as 'เป็นเงิน',note as 'หมายเหตุ' ,orderStatus as 'สถานะออร์เดอร์' from orders join customer on orders.cusCode = customer.cusCode join employee on orders.empCode = employee.empCode join tables on orders.tableCode = tables.tableCode join food on orders.foodCode = food.foodCode";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            orderCode.Clear();  
            tableNumber.Clear();
            cusName.Clear();
            empName.ResetText();
            cusPhone.Clear();
            food_select.ResetText();
            qty.Clear();
            cusType.ResetText();
            orderCode.Focus();
            note.Clear();
            cusCode.Clear();
            pNum.Clear();
            small.Checked = false;
            medium.Checked = false;
            large.Checked = false;
            foodPrice.Clear();
            result.Clear();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            command.CommandText = "INSERT INTO orders (orderCode,date,tableCode,cusCode,empCode,reserve,price,qty,amount,foodCode,orderStatus,note) VALUES ('" + orderCode.Text + "', '" + date.Text + "', '" + tableNumber.Text + "','" + cusCode.Text + "','" + empName.SelectedValue + "','" + cusType.Text + "', '" + foodPrice.Text + "', '" + qty.Text + "','" + result.Text + "', '" + food_select.SelectedValue + "', '" + "สั่งอาหาร" + "', '" + note.Text + "')";
            command.ExecuteNonQuery();
            command_2.CommandText = "Insert into tables values('" + tableNumber.Text + "','" + pNum.Text + "','" + "ไม่ว่าง" + "')";
            command_2.ExecuteNonQuery();
            command_3.CommandText = "Insert into customer values('" + cusCode.Text + "','" + cusName.Text + "','" + cusPhone.Text + "','" + cusType.Text + "')";
            command_3.ExecuteNonQuery();
            command_4.CommandText = "Insert into orderTable values('" + tableNumber.Text + "','" + orderCode.Text + "')";
            command_4.ExecuteNonQuery();
            ShowItem();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                if (MessageBox.Show("ต้องการลบข้อมูลหรือไม่ ? ", "ลบข้อมูล", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    command.CommandText = "delete from orders where orderCode = '" + orderCode.Text + "'";
                    command.ExecuteNonQuery();
                    MessageBox.Show("ลบข้อมูลแล้ว", "แจ้งเตือน");
                    orderCode.Clear();
                    tableNumber.Clear();
                    cusName.Clear();
                    empName.ResetText();
                    cusPhone.Clear();
                    food_select.ResetText();
                    qty.Clear();
                    cusType.ResetText();
                    orderCode.Focus();
                    note.Clear();
                    cusCode.Clear();
                    pNum.Clear();
                    small.Checked = false;
                    medium.Checked = false;
                    large.Checked = false;
                    foodPrice.Clear();
                    result.Clear();
                    ShowItem();
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

        private void small_CheckedChanged(object sender, EventArgs e)
        {
            if (small.Checked)
            {
                command.CommandText = "select foodSmallPrice from food where foodCode = '" + food_select.SelectedValue + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    foodPrice.Text = dr[0].ToString();
                }
                dr.Close();
            }
        }

        private void medium_CheckedChanged(object sender, EventArgs e)
        {
            if (medium.Checked)
            {
                command.CommandText = "select foodMediumPrice from food where foodCode = '" + food_select.SelectedValue + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    foodPrice.Text = dr[0].ToString();
                }
                dr.Close();
            }
        }

        private void large_CheckedChanged(object sender, EventArgs e)
        {
            if (large.Checked)
            {
                command.CommandText = "select foodLargePrice from food where foodCode = '" + food_select.SelectedValue + "'";
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    foodPrice.Text = dr[0].ToString();
                }
                dr.Close();
            }
        }

        private void food_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            small.Checked = false;
            medium.Checked = false;
            large.Checked = false;  
            foodPrice.Clear();  
        }

        private void qty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    result.Text = (Convert.ToDouble(qty.Text) * Convert.ToDouble(foodPrice.Text)).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("กรุณาระบุจำนวนและราคา","แจ้งเตือน");
            }
            
            
        }

        private void result_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    result.Text = (Convert.ToDouble(qty.Text) * Convert.ToDouble(foodPrice.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("กรุณาระบุจำนวนและราคา","แจ้งเตือน");
            }
        }
    }
}
