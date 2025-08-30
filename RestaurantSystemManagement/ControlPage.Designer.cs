namespace RestaurantSystemManagement
{
    partial class ControlPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.sliderBar = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUser = new RestaurantSystemManagement.CustomButton();
            this.btnCustomer = new RestaurantSystemManagement.CustomButton();
            this.btnStaff = new RestaurantSystemManagement.CustomButton();
            this.btnItem = new RestaurantSystemManagement.CustomButton();
            this.btnBook = new RestaurantSystemManagement.CustomButton();
            this.btnSection = new RestaurantSystemManagement.CustomButton();
            this.btnOrder = new RestaurantSystemManagement.CustomButton();
            this.btnHome = new RestaurantSystemManagement.CustomButton();
            this.customPanel1 = new RestaurantSystemManagement.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.sliderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(905, 488);
            this.dataGridView1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(783, 93);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "التقرير ال : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboFilter
            // 
            this.comboFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboFilter.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(552, 93);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboFilter.Size = new System.Drawing.Size(187, 24);
            this.comboFilter.TabIndex = 23;
            this.comboFilter.SelectedIndexChanged += new System.EventHandler(this.ComboFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 92);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "من ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 92);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(44, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "الى";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(171, 92);
            this.toDate.Name = "toDate";
            this.toDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toDate.RightToLeftLayout = true;
            this.toDate.Size = new System.Drawing.Size(127, 24);
            this.toDate.TabIndex = 26;
            this.toDate.ValueChanged += new System.EventHandler(this.ToDate_ValueChanged);
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(354, 90);
            this.fromDate.Name = "fromDate";
            this.fromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromDate.RightToLeftLayout = true;
            this.fromDate.Size = new System.Drawing.Size(136, 24);
            this.fromDate.TabIndex = 27;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(23, 86);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(142, 36);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Text = "طباعة التقرير";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // sliderBar
            // 
            this.sliderBar.BackColor = System.Drawing.Color.Gray;
            this.sliderBar.Controls.Add(this.lbUserName);
            this.sliderBar.Controls.Add(this.pictureBox6);
            this.sliderBar.Controls.Add(this.label13);
            this.sliderBar.Controls.Add(this.btnUser);
            this.sliderBar.Controls.Add(this.btnCustomer);
            this.sliderBar.Controls.Add(this.btnStaff);
            this.sliderBar.Controls.Add(this.btnItem);
            this.sliderBar.Controls.Add(this.btnBook);
            this.sliderBar.Controls.Add(this.btnSection);
            this.sliderBar.Controls.Add(this.btnOrder);
            this.sliderBar.Controls.Add(this.btnHome);
            this.sliderBar.Controls.Add(this.btnClose);
            this.sliderBar.Location = new System.Drawing.Point(923, 0);
            this.sliderBar.Name = "sliderBar";
            this.sliderBar.Size = new System.Drawing.Size(224, 631);
            this.sliderBar.TabIndex = 29;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(38, 133);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(140, 34);
            this.lbUserName.TabIndex = 14;
            this.lbUserName.Text = "الخروج من النظام";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = global::RestaurantSystemManagement.Properties.Resources.user_2_;
            this.pictureBox6.Location = new System.Drawing.Point(52, 28);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(109, 102);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 588);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 34);
            this.label13.TabIndex = 12;
            this.label13.Text = "الخروج من النظام";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(154, 588);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(470, 67);
            this.label1.TabIndex = 30;
            this.label1.Text = "مرحباً بك في صفحة التحكم والتقارير";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.bkColor = System.Drawing.Color.White;
            this.btnUser.CornerRadius = 5;
            this.btnUser.font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.frColor = System.Drawing.SystemColors.ControlText;
            this.btnUser.image = global::RestaurantSystemManagement.Properties.Resources.home_button;
            this.btnUser.Location = new System.Drawing.Point(8, 538);
            this.btnUser.Name = "btnUser";
            this.btnUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUser.Size = new System.Drawing.Size(203, 34);
            this.btnUser.TabIndex = 11;
            this.btnUser.text = "اضافة مستخدم";
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.White;
            this.btnCustomer.bkColor = System.Drawing.Color.White;
            this.btnCustomer.CornerRadius = 5;
            this.btnCustomer.font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.frColor = System.Drawing.SystemColors.ControlText;
            this.btnCustomer.image = global::RestaurantSystemManagement.Properties.Resources.home_button;
            this.btnCustomer.Location = new System.Drawing.Point(8, 232);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCustomer.Size = new System.Drawing.Size(203, 34);
            this.btnCustomer.TabIndex = 10;
            this.btnCustomer.text = "الزبائن";
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.bkColor = System.Drawing.Color.White;
            this.btnStaff.CornerRadius = 5;
            this.btnStaff.font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.frColor = System.Drawing.SystemColors.ControlText;
            this.btnStaff.image = global::RestaurantSystemManagement.Properties.Resources.home_button;
            this.btnStaff.Location = new System.Drawing.Point(8, 486);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnStaff.Size = new System.Drawing.Size(203, 34);
            this.btnStaff.TabIndex = 9;
            this.btnStaff.text = "الموظفين";
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.White;
            this.btnItem.bkColor = System.Drawing.Color.White;
            this.btnItem.CornerRadius = 5;
            this.btnItem.font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.frColor = System.Drawing.SystemColors.ControlText;
            this.btnItem.image = global::RestaurantSystemManagement.Properties.Resources.home_button;
            this.btnItem.Location = new System.Drawing.Point(8, 435);
            this.btnItem.Name = "btnItem";
            this.btnItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnItem.Size = new System.Drawing.Size(203, 34);
            this.btnItem.TabIndex = 8;
            this.btnItem.text = "الأصناف";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.White;
            this.btnBook.bkColor = System.Drawing.Color.White;
            this.btnBook.CornerRadius = 5;
            this.btnBook.font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.frColor = System.Drawing.SystemColors.ControlText;
            this.btnBook.image = global::RestaurantSystemManagement.Properties.Resources.home_button;
            this.btnBook.Location = new System.Drawing.Point(8, 382);
            this.btnBook.Name = "btnBook";
            this.btnBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBook.Size = new System.Drawing.Size(203, 34);
            this.btnBook.TabIndex = 7;
            this.btnBook.text = "الحجوزات";
            // 
            // btnSection
            // 
            this.btnSection.BackColor = System.Drawing.Color.White;
            this.btnSection.bkColor = System.Drawing.Color.White;
            this.btnSection.CornerRadius = 5;
            this.btnSection.font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSection.frColor = System.Drawing.SystemColors.ControlText;
            this.btnSection.image = global::RestaurantSystemManagement.Properties.Resources.home_button;
            this.btnSection.Location = new System.Drawing.Point(8, 331);
            this.btnSection.Name = "btnSection";
            this.btnSection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSection.Size = new System.Drawing.Size(203, 34);
            this.btnSection.TabIndex = 5;
            this.btnSection.text = "الأقسام";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.bkColor = System.Drawing.Color.White;
            this.btnOrder.CornerRadius = 5;
            this.btnOrder.font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.frColor = System.Drawing.SystemColors.ControlText;
            this.btnOrder.image = global::RestaurantSystemManagement.Properties.Resources.pen;
            this.btnOrder.Location = new System.Drawing.Point(8, 282);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOrder.Size = new System.Drawing.Size(203, 34);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.text = "الطلبات";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.bkColor = System.Drawing.Color.White;
            this.btnHome.CornerRadius = 5;
            this.btnHome.font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.frColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.image = global::RestaurantSystemManagement.Properties.Resources.home_button;
            this.btnHome.Location = new System.Drawing.Point(8, 180);
            this.btnHome.Name = "btnHome";
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHome.Size = new System.Drawing.Size(203, 34);
            this.btnHome.TabIndex = 3;
            this.btnHome.text = "الصفحة الرئيسية";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.customPanel1.CornerRadius = 5;
            this.customPanel1.Location = new System.Drawing.Point(13, 79);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(904, 51);
            this.customPanel1.TabIndex = 1;
            // 
            // ControlPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1145, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sliderBar);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlPage";
            this.Text = "ControlPage";
            this.Load += new System.EventHandler(this.ControlPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.sliderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel sliderBar;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label13;
        private CustomButton btnUser;
        private CustomButton btnCustomer;
        private CustomButton btnStaff;
        private CustomButton btnItem;
        private CustomButton btnBook;
        private CustomButton btnSection;
        private CustomButton btnOrder;
        private CustomButton btnHome;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label label1;
    }
}