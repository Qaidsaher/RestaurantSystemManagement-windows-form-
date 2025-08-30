namespace RestaurantSystemManagement
{
    partial class Orders
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookCust = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bookTable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveBooking = new System.Windows.Forms.Button();
            this.btnSavePrint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.orderSection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.orderCust = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.orderBookID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listItems = new System.Windows.Forms.ListBox();
            this.lstBill = new System.Windows.Forms.ListBox();
            this.sliderBar = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.btnUser = new RestaurantSystemManagement.CustomButton();
            this.btnCustomer = new RestaurantSystemManagement.CustomButton();
            this.btnStaff = new RestaurantSystemManagement.CustomButton();
            this.btnItem = new RestaurantSystemManagement.CustomButton();
            this.btnBook = new RestaurantSystemManagement.CustomButton();
            this.btnSection = new RestaurantSystemManagement.CustomButton();
            this.btnOrder = new RestaurantSystemManagement.CustomButton();
            this.btnHome = new RestaurantSystemManagement.CustomButton();
            this.sliderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(736, 97);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم العميل : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookCust
            // 
            this.bookCust.FormattingEnabled = true;
            this.bookCust.Location = new System.Drawing.Point(665, 138);
            this.bookCust.Name = "bookCust";
            this.bookCust.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bookCust.Size = new System.Drawing.Size(167, 24);
            this.bookCust.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 41;
            this.button1.Text = "غير موجود ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bookTable
            // 
            this.bookTable.FormattingEnabled = true;
            this.bookTable.Location = new System.Drawing.Point(311, 137);
            this.bookTable.Name = "bookTable";
            this.bookTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bookTable.Size = new System.Drawing.Size(167, 24);
            this.bookTable.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(382, 96);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "نوع الطاولة : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(125, 97);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "تاريخ اليوم : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookDate
            // 
            this.bookDate.Enabled = false;
            this.bookDate.Location = new System.Drawing.Point(52, 138);
            this.bookDate.Name = "bookDate";
            this.bookDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bookDate.Size = new System.Drawing.Size(172, 24);
            this.bookDate.TabIndex = 46;
            // 
            // btnSaveBooking
            // 
            this.btnSaveBooking.Location = new System.Drawing.Point(52, 179);
            this.btnSaveBooking.Name = "btnSaveBooking";
            this.btnSaveBooking.Size = new System.Drawing.Size(146, 33);
            this.btnSaveBooking.TabIndex = 47;
            this.btnSaveBooking.Text = "حفظ الحجز ";
            this.btnSaveBooking.UseVisualStyleBackColor = true;
            this.btnSaveBooking.Click += new System.EventHandler(this.BtnSaveBooking_Click);
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.Location = new System.Drawing.Point(49, 576);
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.Size = new System.Drawing.Size(172, 33);
            this.btnSavePrint.TabIndex = 55;
            this.btnSavePrint.Text = "حفظ وطباعة الفاتورة";
            this.btnSavePrint.UseVisualStyleBackColor = true;
            this.btnSavePrint.Click += new System.EventHandler(this.BtnSavePrint_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(125, 261);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 53;
            this.label4.Text = "الأصناف : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderSection
            // 
            this.orderSection.FormattingEnabled = true;
            this.orderSection.Location = new System.Drawing.Point(238, 312);
            this.orderSection.Name = "orderSection";
            this.orderSection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderSection.Size = new System.Drawing.Size(156, 24);
            this.orderSection.TabIndex = 52;
            this.orderSection.SelectedIndexChanged += new System.EventHandler(this.OrderSection_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(297, 261);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "الأقسام : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderCust
            // 
            this.orderCust.FormattingEnabled = true;
            this.orderCust.Location = new System.Drawing.Point(665, 312);
            this.orderCust.Name = "orderCust";
            this.orderCust.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderCust.Size = new System.Drawing.Size(167, 24);
            this.orderCust.TabIndex = 49;
            this.orderCust.SelectedIndexChanged += new System.EventHandler(this.OrderCust_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(736, 261);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "اسم العميل : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderBookID
            // 
            this.orderBookID.FormattingEnabled = true;
            this.orderBookID.Location = new System.Drawing.Point(441, 312);
            this.orderBookID.Name = "orderBookID";
            this.orderBookID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderBookID.Size = new System.Drawing.Size(167, 24);
            this.orderBookID.TabIndex = 59;
            this.orderBookID.SelectedIndexChanged += new System.EventHandler(this.OrderBookID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(512, 261);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(99, 23);
            this.label7.TabIndex = 58;
            this.label7.Text = "رقم الحجز : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(441, 380);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(398, 229);
            this.txtBill.TabIndex = 60;
            this.txtBill.Text = "";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(736, 349);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 61;
            this.label8.Text = "الفاتورة";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(395, 9);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(442, 55);
            this.label9.TabIndex = 62;
            this.label9.Text = "انشاء حجز لي عميل";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(395, 198);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(442, 55);
            this.label10.TabIndex = 63;
            this.label10.Text = "انشاء طلب جديد لي حجز";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listItems
            // 
            this.listItems.FormattingEnabled = true;
            this.listItems.ItemHeight = 16;
            this.listItems.Location = new System.Drawing.Point(52, 312);
            this.listItems.Name = "listItems";
            this.listItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listItems.Size = new System.Drawing.Size(169, 244);
            this.listItems.TabIndex = 64;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.ListItems_SelectedIndexChanged);
            // 
            // lstBill
            // 
            this.lstBill.FormattingEnabled = true;
            this.lstBill.ItemHeight = 16;
            this.lstBill.Location = new System.Drawing.Point(238, 375);
            this.lstBill.Name = "lstBill";
            this.lstBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstBill.Size = new System.Drawing.Size(169, 228);
            this.lstBill.TabIndex = 65;
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
            this.sliderBar.Location = new System.Drawing.Point(925, 0);
            this.sliderBar.Name = "sliderBar";
            this.sliderBar.Size = new System.Drawing.Size(224, 631);
            this.sliderBar.TabIndex = 66;
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
            this.btnUser.text = "التحكم";
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
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1145, 631);
            this.Controls.Add(this.sliderBar);
            this.Controls.Add(this.lstBill);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.orderBookID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSavePrint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderSection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orderCust);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveBooking);
            this.Controls.Add(this.bookDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookCust);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.sliderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bookCust;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox bookTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker bookDate;
        private System.Windows.Forms.Button btnSaveBooking;
        private System.Windows.Forms.Button btnSavePrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox orderSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox orderCust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox orderBookID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtBill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listItems;
        private System.Windows.Forms.ListBox lstBill;
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
    }
}