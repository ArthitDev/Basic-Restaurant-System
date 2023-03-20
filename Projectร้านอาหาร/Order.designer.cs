namespace Projectร้านอาหาร
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.label1 = new System.Windows.Forms.Label();
            this.orderCode = new System.Windows.Forms.TextBox();
            this.tableNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cusName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.food_select = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cusPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cusCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.orderBox = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.large = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.small = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.foodPrice = new System.Windows.Forms.TextBox();
            this.empName = new System.Windows.Forms.ComboBox();
            this.note = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cusType = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.orderBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "หมายเลขใบสั่งอาหาร";
            // 
            // orderCode
            // 
            this.orderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCode.Location = new System.Drawing.Point(536, 34);
            this.orderCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderCode.MaxLength = 4;
            this.orderCode.Name = "orderCode";
            this.orderCode.Size = new System.Drawing.Size(202, 44);
            this.orderCode.TabIndex = 1;
            // 
            // tableNumber
            // 
            this.tableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNumber.Location = new System.Drawing.Point(536, 104);
            this.tableNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableNumber.MaxLength = 4;
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.Size = new System.Drawing.Size(202, 44);
            this.tableNumber.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "เลขที่โต๊ะ";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(1080, 37);
            this.date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(402, 48);
            this.date.TabIndex = 17;
            this.date.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(923, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 40);
            this.label9.TabIndex = 16;
            this.label9.Text = "วันที่-เวลา";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 37);
            this.label10.TabIndex = 18;
            this.label10.Text = "ชื่อพนักงาน";
            // 
            // cusName
            // 
            this.cusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusName.Location = new System.Drawing.Point(819, 45);
            this.cusName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(385, 44);
            this.cusName.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(680, 48);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 37);
            this.label11.TabIndex = 20;
            this.label11.Text = "ชื่อลูกค้า";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 753);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1909, 462);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รายการ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Azure;
            this.dataGridView1.Location = new System.Drawing.Point(8, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1891, 416);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.TabStop = false;
            // 
            // food_select
            // 
            this.food_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food_select.FormattingEnabled = true;
            this.food_select.Location = new System.Drawing.Point(997, 45);
            this.food_select.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.food_select.Name = "food_select";
            this.food_select.Size = new System.Drawing.Size(364, 45);
            this.food_select.TabIndex = 37;
            this.food_select.TabStop = false;
            this.food_select.SelectedIndexChanged += new System.EventHandler(this.food_select_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(837, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 37);
            this.label4.TabIndex = 36;
            this.label4.Text = "ชื่ออาหาร";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(840, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 37);
            this.label2.TabIndex = 34;
            this.label2.Text = "ขนาด";
            // 
            // cusPhone
            // 
            this.cusPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhone.Location = new System.Drawing.Point(185, 109);
            this.cusPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cusPhone.MaxLength = 10;
            this.cusPhone.Name = "cusPhone";
            this.cusPhone.Size = new System.Drawing.Size(385, 44);
            this.cusPhone.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 37);
            this.label12.TabIndex = 39;
            this.label12.Text = "เบอร์โทร";
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(1010, 179);
            this.qty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(103, 44);
            this.qty.TabIndex = 8;
            this.qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qty_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(906, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 37);
            this.label5.TabIndex = 41;
            this.label5.Text = "จำนวน";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cusCode);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pNum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cusPhone);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cusName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(251, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1231, 173);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ลูกค้า";
            // 
            // cusCode
            // 
            this.cusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusCode.Location = new System.Drawing.Point(185, 41);
            this.cusCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cusCode.MaxLength = 4;
            this.cusCode.Name = "cusCode";
            this.cusCode.Size = new System.Drawing.Size(385, 44);
            this.cusCode.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(46, 44);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 37);
            this.label14.TabIndex = 44;
            this.label14.Text = "รหัสลูกค้า";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1097, 115);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 37);
            this.label8.TabIndex = 43;
            this.label8.Text = "คน";
            // 
            // pNum
            // 
            this.pNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNum.Location = new System.Drawing.Point(933, 109);
            this.pNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pNum.MaxLength = 99;
            this.pNum.Name = "pNum";
            this.pNum.Size = new System.Drawing.Size(136, 44);
            this.pNum.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(752, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 37);
            this.label7.TabIndex = 41;
            this.label7.Text = "จำนวนลูกค้า";
            // 
            // orderBox
            // 
            this.orderBox.Controls.Add(this.label21);
            this.orderBox.Controls.Add(this.label18);
            this.orderBox.Controls.Add(this.label17);
            this.orderBox.Controls.Add(this.label19);
            this.orderBox.Controls.Add(this.result);
            this.orderBox.Controls.Add(this.large);
            this.orderBox.Controls.Add(this.medium);
            this.orderBox.Controls.Add(this.small);
            this.orderBox.Controls.Add(this.label16);
            this.orderBox.Controls.Add(this.label15);
            this.orderBox.Controls.Add(this.foodPrice);
            this.orderBox.Controls.Add(this.empName);
            this.orderBox.Controls.Add(this.note);
            this.orderBox.Controls.Add(this.label13);
            this.orderBox.Controls.Add(this.qty);
            this.orderBox.Controls.Add(this.label10);
            this.orderBox.Controls.Add(this.label5);
            this.orderBox.Controls.Add(this.food_select);
            this.orderBox.Controls.Add(this.label4);
            this.orderBox.Controls.Add(this.label2);
            this.orderBox.Controls.Add(this.label20);
            this.orderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.orderBox.Location = new System.Drawing.Point(121, 386);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(1590, 242);
            this.orderBox.TabIndex = 49;
            this.orderBox.TabStop = false;
            this.orderBox.Text = "สั่งอาหาร";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1204, 171);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 52);
            this.label21.TabIndex = 97;
            this.label21.Text = "|";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1460, 182);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 37);
            this.label18.TabIndex = 94;
            this.label18.Text = "บาท";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1104, 183);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 37);
            this.label17.TabIndex = 95;
            this.label17.Text = "รายการ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1234, 182);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 37);
            this.label19.TabIndex = 93;
            this.label19.Text = "เป็นเงิน";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(1349, 179);
            this.result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(103, 44);
            this.result.TabIndex = 92;
            this.result.KeyDown += new System.Windows.Forms.KeyEventHandler(this.result_KeyDown);
            // 
            // large
            // 
            this.large.AutoSize = true;
            this.large.Location = new System.Drawing.Point(1176, 118);
            this.large.Name = "large";
            this.large.Size = new System.Drawing.Size(96, 41);
            this.large.TabIndex = 94;
            this.large.TabStop = true;
            this.large.Text = "ใหญ่";
            this.large.UseVisualStyleBackColor = true;
            this.large.CheckedChanged += new System.EventHandler(this.large_CheckedChanged);
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(1054, 117);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(101, 41);
            this.medium.TabIndex = 93;
            this.medium.TabStop = true;
            this.medium.Text = "กลาง";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.CheckedChanged += new System.EventHandler(this.medium_CheckedChanged);
            // 
            // small
            // 
            this.small.AutoSize = true;
            this.small.Location = new System.Drawing.Point(954, 117);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(85, 41);
            this.small.TabIndex = 92;
            this.small.TabStop = true;
            this.small.Text = "เล็ก";
            this.small.UseVisualStyleBackColor = true;
            this.small.CheckedChanged += new System.EventHandler(this.small_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(823, 182);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 37);
            this.label16.TabIndex = 91;
            this.label16.Text = "บาท";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(629, 182);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 37);
            this.label15.TabIndex = 90;
            this.label15.Text = "ราคา";
            // 
            // foodPrice
            // 
            this.foodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodPrice.Location = new System.Drawing.Point(712, 179);
            this.foodPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foodPrice.Multiline = true;
            this.foodPrice.Name = "foodPrice";
            this.foodPrice.ReadOnly = true;
            this.foodPrice.Size = new System.Drawing.Size(103, 44);
            this.foodPrice.TabIndex = 9;
            // 
            // empName
            // 
            this.empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.empName.FormattingEnabled = true;
            this.empName.Location = new System.Drawing.Point(206, 61);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(385, 45);
            this.empName.TabIndex = 88;
            this.empName.TabStop = false;
            // 
            // note
            // 
            this.note.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.Location = new System.Drawing.Point(206, 126);
            this.note.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(385, 44);
            this.note.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(66, 129);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 37);
            this.label13.TabIndex = 46;
            this.label13.Text = "หมายเหตุ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(880, 169);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 52);
            this.label20.TabIndex = 96;
            this.label20.Text = "|";
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bClose.ForeColor = System.Drawing.Color.Crimson;
            this.bClose.Image = ((System.Drawing.Image)(resources.GetObject("bClose.Image")));
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(1242, 672);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(213, 50);
            this.bClose.TabIndex = 85;
            this.bClose.TabStop = false;
            this.bClose.Text = "ปิด";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bDelete.ForeColor = System.Drawing.Color.Blue;
            this.bDelete.Image = ((System.Drawing.Image)(resources.GetObject("bDelete.Image")));
            this.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDelete.Location = new System.Drawing.Point(1010, 672);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(213, 50);
            this.bDelete.TabIndex = 84;
            this.bDelete.TabStop = false;
            this.bDelete.Text = "ลบข้อมูล";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bUpdate.Image = ((System.Drawing.Image)(resources.GetObject("bUpdate.Image")));
            this.bUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bUpdate.Location = new System.Drawing.Point(776, 672);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(213, 50);
            this.bUpdate.TabIndex = 83;
            this.bUpdate.TabStop = false;
            this.bUpdate.Text = "แก้ไขข้อมูล";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bInsert.ForeColor = System.Drawing.Color.ForestGreen;
            this.bInsert.Image = ((System.Drawing.Image)(resources.GetObject("bInsert.Image")));
            this.bInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bInsert.Location = new System.Drawing.Point(537, 672);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(213, 50);
            this.bInsert.TabIndex = 82;
            this.bInsert.TabStop = false;
            this.bInsert.Text = "เพิ่มข้อมูล";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bClear.Image = ((System.Drawing.Image)(resources.GetObject("bClear.Image")));
            this.bClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClear.Location = new System.Drawing.Point(304, 672);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(213, 50);
            this.bClear.TabIndex = 81;
            this.bClear.TabStop = false;
            this.bClear.Text = "เครียร์ข้อมูล";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(876, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 40);
            this.label3.TabIndex = 86;
            this.label3.Text = "ประเภทลูกค้า";
            // 
            // cusType
            // 
            this.cusType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cusType.FormattingEnabled = true;
            this.cusType.Items.AddRange(new object[] {
            "ปกติ",
            "จอง",
            "จอง + สั่งอาหาร"});
            this.cusType.Location = new System.Drawing.Point(1080, 109);
            this.cusType.Name = "cusType";
            this.cusType.Size = new System.Drawing.Size(371, 45);
            this.cusType.TabIndex = 87;
            this.cusType.TabStop = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1925, 1229);
            this.Controls.Add(this.cusType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tableNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Order";
            this.Text = "ใบสั่งอาหาร";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.orderBox.ResumeLayout(false);
            this.orderBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderCode;
        private System.Windows.Forms.TextBox tableNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox food_select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cusPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox orderBox;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cusType;
        private System.Windows.Forms.TextBox pNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cusCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.ComboBox empName;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox foodPrice;
        private System.Windows.Forms.RadioButton large;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton small;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label20;
    }
}