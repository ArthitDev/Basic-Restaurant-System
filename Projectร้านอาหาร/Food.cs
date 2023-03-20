using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Projectร้านอาหาร
{
    public partial class Food : Form
    {
        int c = 0;
        string foodImg = "";
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public Food()
        {
            InitializeComponent();
            connect.ConnectionString = "Data Source=ASUS-TUF-GAMING;Initial Catalog=restaurantDB;Integrated Security=True";
            connect.Open();
            command.Connection = connect;
            ShowItem();
            getTypeFood();

        }
        private void browse_Click(object sender, EventArgs e)
        {
            //openFileDialog1.InitialDirectory = ("C:\\Users\\ArthitPC\\Pictures\\meme");
            //openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png|JFIF|*.jfif|All Files|*.*";
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    photoBox.Image = Image.FromFile(openFileDialog1.FileName);
            //}

            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    Image image = Image.FromFile(ofd.FileName);
            //    photoBox.Image = image;
            //    label15.Text = ofd.FileName;
            //}
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                photoBox.Image = Image.FromFile(openFileDialog1.FileName);
                foodImg = openFileDialog1.FileName;
               
                // System.IO.FileInfo fileInfo = new System.IO.FileInfo(openFileDialog1.FileName);
                // MessageBox.Show(openFileDialog1.FileName);
                // label7.Text = fileInfo.Name;
            }
        }
        private void showImg_Click_1(object sender, EventArgs e)
        {
            command.CommandText = "select foodImage from food";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataSet table = new DataSet();
            da.Fill(table);
            if (table.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])table.Tables[0].Rows[0]["foodImage"]);
                photoBox.Image = new Bitmap(ms);
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            foodCode.Clear();
            foodName.Clear();
            //foodType.Items.Clear();
            foodSmall.Clear();
            foodMedium.Clear();
            foodLarge.Clear();
            foodCode.Focus();
            photoBox.Image = null;
            
        }
        private void getTypeFood()
        {
            command.CommandText = "select * from foodType";
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = command;
            DataTable table = new DataTable();
            ad.Fill(table);
            bindingSource2.DataSource = table;
            foodType.DataSource = bindingSource2;
            foodType.DisplayMember = "foodTypeName";
            foodType.ValueMember = "foodTypeCode";


        }
        private void ShowItem()
        {
            command.CommandText = "select foodCode as 'รหัสอาหาร',foodName as 'ชื่ออาหาร' ,foodTypeName as 'ประเภทอาหาร',foodSmallPrice as 'ราคา-ขนาดเล็ก',foodMediumPrice as 'ราคา-ขนาดกลาง',foodLargePrice as 'ราคา-ขนาดใหญ่',foodImg as 'รูปภาพ' from food join foodType on food.foodTypeCode = foodType.foodTypeCode";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            command.CommandText = "insert into food values('" + foodCode.Text + "','" + foodName.Text +  "','" + foodType.SelectedValue + "','" + foodSmall.Text + "','" + foodMedium.Text + "','" + foodLarge.Text + "','" + foodImg + "')";
            command.ExecuteNonQuery();
            ShowItem();
        }
        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                command.CommandText = "update food set foodName = '" + foodName.Text + "', foodTypeCode = '" + foodType.SelectedValue + "', foodSmallPrice = '" + foodSmall.Text + "', foodMediumPrice = '" + foodMedium.Text + "', foodLargePrice = '" + foodLarge.Text + "', foodImg = '" + foodImg + "' Where foodCode = '" + foodCode.Text + "'";
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
                    command.CommandText = "delete from food where foodCode = '" + foodCode.Text + "'";
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
                foodCode.Text = dataGridView1[0, c].Value + "";
                foodName.Text = dataGridView1[1, c].Value + "";
                foodType.Text = dataGridView1[2, c].Value + "";
                foodSmall.Text = dataGridView1[3, c].Value + "";
                foodMedium.Text = dataGridView1[4, c].Value + "";
                foodLarge.Text = dataGridView1[5, c].Value + "";
                //label15.Text = dataGridView1[6, c].Value + "";
                string imagePath = dataGridView1[6, c].Value + "";
                photoBox.Image = Image.FromFile(imagePath);
               
            }
            
            catch (Exception) { }
        }

        //private void label15_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Image image = Image.FromFile(label15.Text);
        //        photoBox.Image = image;
                
        //    }
        //    catch { }
        //}


    }
}
