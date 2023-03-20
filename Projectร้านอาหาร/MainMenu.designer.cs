namespace Projectร้านอาหาร
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.อพเดทสถานะอาหารToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.อพเดทสถานะอาหารToolStripMenuItem,
            this.closeProgram});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1201, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerMenuItem,
            this.employeeMenuItem,
            this.employeeTypeMenuItem,
            this.tableMenuItem,
            this.foodMenuItem,
            this.foodTypeMenuItem,
            this.orderMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 29);
            this.toolStripMenuItem1.Text = "จัดการร้านอาหาร";
            // 
            // customerMenuItem
            // 
            this.customerMenuItem.Name = "customerMenuItem";
            this.customerMenuItem.Size = new System.Drawing.Size(270, 34);
            this.customerMenuItem.Text = "ลูกค้า";
            this.customerMenuItem.Click += new System.EventHandler(this.customerMenuItem_Click);
            // 
            // employeeMenuItem
            // 
            this.employeeMenuItem.Name = "employeeMenuItem";
            this.employeeMenuItem.Size = new System.Drawing.Size(270, 34);
            this.employeeMenuItem.Text = "พนักงาน";
            this.employeeMenuItem.Click += new System.EventHandler(this.employeeMenuItem_Click);
            // 
            // employeeTypeMenuItem
            // 
            this.employeeTypeMenuItem.Name = "employeeTypeMenuItem";
            this.employeeTypeMenuItem.Size = new System.Drawing.Size(270, 34);
            this.employeeTypeMenuItem.Text = "ประเภทพนักงาน";
            this.employeeTypeMenuItem.Click += new System.EventHandler(this.employeeTypeMenuItem_Click);
            // 
            // tableMenuItem
            // 
            this.tableMenuItem.Name = "tableMenuItem";
            this.tableMenuItem.Size = new System.Drawing.Size(270, 34);
            this.tableMenuItem.Text = "โต๊ะ";
            this.tableMenuItem.Click += new System.EventHandler(this.tableMenuItem_Click);
            // 
            // foodMenuItem
            // 
            this.foodMenuItem.Name = "foodMenuItem";
            this.foodMenuItem.Size = new System.Drawing.Size(270, 34);
            this.foodMenuItem.Text = "อาหาร";
            this.foodMenuItem.Click += new System.EventHandler(this.foodMenuItem_Click);
            // 
            // foodTypeMenuItem
            // 
            this.foodTypeMenuItem.Name = "foodTypeMenuItem";
            this.foodTypeMenuItem.Size = new System.Drawing.Size(270, 34);
            this.foodTypeMenuItem.Text = "ประเภทอาหาร";
            this.foodTypeMenuItem.Click += new System.EventHandler(this.foodTypeMenuItem_Click);
            // 
            // orderMenuItem
            // 
            this.orderMenuItem.Name = "orderMenuItem";
            this.orderMenuItem.Size = new System.Drawing.Size(270, 34);
            this.orderMenuItem.Text = "ออเดอร์";
            this.orderMenuItem.Click += new System.EventHandler(this.orderMenuItem_Click);
            // 
            // อพเดทสถานะอาหารToolStripMenuItem
            // 
            this.อพเดทสถานะอาหารToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateStatus});
            this.อพเดทสถานะอาหารToolStripMenuItem.Name = "อพเดทสถานะอาหารToolStripMenuItem";
            this.อพเดทสถานะอาหารToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.อพเดทสถานะอาหารToolStripMenuItem.Text = "สถานะอาหาร";
            // 
            // UpdateStatus
            // 
            this.UpdateStatus.Name = "UpdateStatus";
            this.UpdateStatus.Size = new System.Drawing.Size(269, 34);
            this.UpdateStatus.Text = "อัพเดทสถานะสั่งอาหาร";
            this.UpdateStatus.Click += new System.EventHandler(this.UpdateStatus_Click);
            // 
            // closeProgram
            // 
            this.closeProgram.Name = "closeProgram";
            this.closeProgram.Size = new System.Drawing.Size(107, 29);
            this.closeProgram.Text = "ปิดโปรแกรม";
            this.closeProgram.Click += new System.EventHandler(this.closeProgram_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 712);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "เมนูหลัก";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeTypeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodTypeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgram;
        private System.Windows.Forms.ToolStripMenuItem อพเดทสถานะอาหารToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateStatus;
    }
}