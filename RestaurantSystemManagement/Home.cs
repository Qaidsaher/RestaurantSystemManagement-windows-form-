using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            if (Program.user.IsManger())
            {
                Program.userId = Program.user.GetId().ToString();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
            this.ForeColor = Program.lineColor;
            IntialNumbers();
            InitialButtons();



        }
        private void IntialNumbers()
        {
            lbCustomer.Text = "العدد : " + Program.dbase.CountItem("Customer");
            lbBook.Text = "العدد : " + Program.dbase.CountItem("Booking");
            lbSection.Text = "العدد : " + Program.dbase.CountItem("Sections");

            lbItem.Text = "العدد : " + Program.dbase.CountItem("Item");
            lbOrder.Text = "العدد : " + Program.dbase.CountItem("Ordr");
            lbEmp.Text = "العدد : " + Program.dbase.CountItem("Employee");
        }
        

        

        private void CustomButton1_Load(object sender, EventArgs e)
        {

        }

        private void CustomButton3_Load(object sender, EventArgs e)
        {
           
        }

        private void CustomButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void CustomButton1_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
           
        }
        void InitialButtons()
        {
            btnBook.Click += BtnBook_Click;
            btnHome.Click += BtnHome_Click;
            btnOrder.Click += BtnOrder_Click;
            btnItem.Click += BtnItem_Click;
            btnSection.Click += BtnSection_Click;
            btnStaff.Click += BtnStaff_Click;
            btnCustomer.Click += BtnCustomer_Click;
            //btnClose.Click += BtnClose_Click;
            lbUserName.Text = Program.user.GetUsername();
            btnUser.Click += BtnUser_Click;
             this.BackColor = Program.mainColor;
            sliderBar.BackColor = Program.secColor;
            

        }
        //private void BtnClose_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            (new Thread(() =>
            {
                Application.Run(new Customers());
            }
            )).Start();
            this.Close();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            (new Thread(() =>
            {
                Application.Run(new Orders());
            }
            )).Start();
           
        }

        private void BtnSection_Click(object sender, EventArgs e)
        {
            Sections ss = new Sections();
            ss.ShowDialog();
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            (new Thread(() =>
            {
                Application.Run(new Customers());
            }
            )).Start();
            this.Close();
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            (new Thread(() =>
            {
                Application.Run(new Booking());
            }
            )).Start();
            this.Close();
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            (new Thread(() =>
            {
                Application.Run(new Items());
            }
            )).Start();
            this.Close();
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            (new Thread(() =>
            {
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Staffs());
            }
        )).Start();
            this.Close();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            if (Program.user.GetId().ToString() == Program.userId)
            {
                (new Thread(() =>
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new ControlPage());
                }
                )).Start();
                this.Close();
            }
            else
            {
                MessageDialog.ShowDialog("ليس لديك صلاحية التحكم ؟!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

         





        }
    }
}
