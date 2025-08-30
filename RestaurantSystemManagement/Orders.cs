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
    public partial class Orders : Form
    {
        Dictionary<string, string> selectedItems;
        int bookID = -1;
        DateTime currentDate ;
        public Orders()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeDate();
            currentDate = DateTime.Now;
           
            selectedItems = new Dictionary<string, string>();
        }
        void InitializeDate()
        {
            bookDate.Value = DateTime.Today;
            Dictionary<string, string> customersDate = Program.dbase.ReadNameWithID("select Cust_ID , Cust_Name from Customer;");
            bookCust.DataSource = new BindingSource(customersDate, null);
            bookCust.DisplayMember = "value";
            bookCust.ValueMember = "key";

            //Dictionary<string, string> customersDate = Program.dbase.ReadNameWithID("select Cust_ID , Cust_Name from Customer;");
            orderCust.DataSource = new BindingSource(customersDate, null);
            orderCust.DisplayMember = "value";
            orderCust.ValueMember = "key";
          

            Dictionary<string, string> tablesDate = Program.dbase.ReadNameWithID("select TablID , TableCapacity from Tables;");
            bookTable.DataSource = new BindingSource(tablesDate, null);
            bookTable.DisplayMember = "value";
            bookTable.ValueMember = "key";

            Dictionary<string, string> sectionsDate = Program.dbase.ReadRelations("select * from Sections;");
            orderSection.DataSource = new BindingSource(sectionsDate, null);
            orderSection.DisplayMember = "value";
            orderSection.ValueMember = "key";
            

        }
        private void BtnSaveBooking_Click(object sender, EventArgs e)
        {
           
            string formattedDate = currentDate.ToString("MM/dd/yyyy");
            bookID = Program.GeneratID("Booking");
            string selectedCust = (string)((KeyValuePair<string, string>)bookCust.SelectedItem).Key;
            string selectedTable = (string)((KeyValuePair<string, string>)bookTable.SelectedItem).Key;
            MessageBox.Show( Program.dbase.Add("insert into Booking values("+bookID+"," + selectedCust + ",'" + formattedDate + "'," + selectedTable +")"));  
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if((new CustomerDialog()).ShowDialog() == DialogResult.Yes)
            {
                InitializeDate();
            }
        }
        Dictionary<string, string> itemsData;
        private void OrderSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            listItems.Items.Clear();
            string selectedKey = (string)((KeyValuePair<string, string>)orderSection.SelectedItem).Key;
            itemsData = Program.dbase.ReadNameWithID("select ItemID , ItemName from Item where SectionID = "+selectedKey);
            foreach (KeyValuePair<string, string> item in itemsData)
            { 
                listItems.Items.Add(item);
            } 
        }
        string customer;
        private void OrderCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string selectedKey = (string)((KeyValuePair<string, string>)orderCust.SelectedItem).Key;
            customer = selectedKey;
            Dictionary<string, string> bookingDate = Program.dbase.ReadNameWithID("select BookingID,  CustomerID from Booking where CustomerID = " + selectedKey+";");
            orderBookID.DataSource = new BindingSource(bookingDate, null);
            orderBookID.DisplayMember = "value";
            orderBookID.ValueMember = "value";
            listItems.Items.Clear();
            lstBill.Items.Clear();
            txtBill.Text = "";

        }

        private void ListItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> item = itemsData.ElementAt(listItems.SelectedIndex);
          
            lstBill.Items.Add(itemsData.ElementAt(listItems.SelectedIndex));

        }

        private void BtnSavePrint_Click(object sender, EventArgs e)
        {
            if (orderBookID.Text != "")
            {
                bookID = int.Parse(orderBookID.Text);
                MessageBox.Show(bookID + "");
           
                int OrderId = Program.GeneratID("Ordr");
                string formattedDate = currentDate.ToString("MM/dd/yyyy");
                Program.dbase.Add("insert into Ordr values(" + OrderId + "," + bookID + "," + formattedDate + " );");
                List<string> items = new List<string>();
                List<double> price = new List<double>();
                foreach (KeyValuePair<string, string> item in lstBill.Items)
                {
                    string pr = Program.dbase.ReadValue("select Price from Item where ItemID = " + item.Key + "  ");
                   Program.dbase.Add("insert into OrderItem values(" + OrderId + "," + item.Key + "," + pr+");");
                    txtBill.Text += item.Value + "\n";
                    items.Add(item.Value);
                    price.Add(double.Parse(pr));
                }
                double totalPrice = GenerateBillString(orderCust.Text,items,price);
                Program.dbase.Add("INSERT INTO Bill (BookingID, TotalAmount, UserID, PaymentStatus) VALUES(" + bookID + ", " + totalPrice.ToString() + ","+Program.user.GetId()+" , 'Paid'); ");

            }
        }
        public  double GenerateBillString(string customerName, List<string> items, List<double> prices)
        {
            string space = "                   ";
            string billString =space+"------------------------------\n";
            billString += space + "         SHOPPING BILL        \n";
            billString += space + "------------------------------\n";
            billString += space + $"Customer: {customerName}\n";
            billString += space + "------------------------------\n";
            billString += space + "Item             Price\n";
            billString += space + "------------------------------\n";

            for (int i = 0; i < items.Count; i++)
            {
                billString +=space+ $"{items[i],-15} {prices[i],10:C}\n";
            }

            billString += space + "------------------------------\n";
            double total = CalculateTotal(prices);
            billString += space + $"Total:           {total,10:C}\n";
            billString += space + "------------------------------\n";
            txtBill.Text = billString;
            return total;
        }
        private  double CalculateTotal(List<double> prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }

        private void OrderBookID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            
            this.ForeColor = Program.lineColor;
            InitialButtons();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }


        private void BtnHome_Click(object sender, EventArgs e)
        {
            (new Thread(() =>
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Home());
            }
            )).Start();
            this.Close();
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
            btnClose.Click += BtnClose_Click;
            lbUserName.Text = Program.user.GetUsername();
            btnUser.Click += BtnUser_Click;

            sliderBar.BackColor = Program.secColor;


        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            (new Thread(() =>
            {
                Application.Run(new Orders());
            }
            )).Start();
            this.Close();
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
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Items());
            }
            )).Start();
            this.Close();
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            (new Thread(() =>
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
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
    }
}
