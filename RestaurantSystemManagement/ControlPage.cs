using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemManagement
{
    public partial class ControlPage : Form
    {
        public ControlPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeDataGridView();
            btnPrint.Click += printButton_Click;
            InitialButtons();

        }

        private void ControlPage_Load(object sender, EventArgs e)
        {
           

            // Create a dictionary of items in Arabic language
            Dictionary<string, string> items = new Dictionary<string, string>
{
    { "booking", "الحجز" },
    { "tables", "الطاولات" },
    { "sections", "الأقسام" },
    { "staffs", "الموظفين" },
    { "users", "المستخدمين" },
    { "bills", "الفواتير" },
    { "items", "الاصناف" },
    { "customers", "العملاء" }

};

            // Set the data source and display member
            comboFilter.DataSource = new BindingSource(items, null);
            comboFilter.DisplayMember = "Value";
            comboFilter.ValueMember = "Key";
        }
        private void showReport(string item)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
           
            if (item == "tables")
            {

                dataTable = Program.dbase.Search("SELECT * FROM Tables");

                dataGridView1.DataSource = dataTable;
                string[] columnsName = { "الرقم", "اسم الطاوله", "نوع الطاوله" };
                for (int i = 0; i < columnsName.Length; i++)
                {
                    if (i < dataGridView1.ColumnCount)
                        dataGridView1.Columns[i].HeaderText = columnsName[i];
                }
            }
            else if (item == "booking")
            {
                dataTable = Program.dbase.Search("SELECT b.BookingID, c.Cust_Name,b.BookingDate   FROM Booking b  INNER JOIN Customer c ON b.CustomerID = c.Cust_ID;");
                dataGridView1.DataSource = dataTable;

                string[] columnsName = { "التارءيخ", "اسم العميل", "رقم الحجز" };
                for (int i = 0; i < columnsName.Length; i++)
                {
                    if (i < dataGridView1.ColumnCount)
                        dataGridView1.Columns[i].HeaderText = columnsName[i];
                }
            }
            else if (item == "customers")
            {


                dataTable = Program.dbase.Search("select * from Customer;");
                dataGridView1.DataSource = dataTable;
                string[] columnsName = { "رقم العميل", "اسم العميل", "عنوان العميل", "رقم هاتف العميل" };
                for (int i = 0; i < columnsName.Length; i++)
                {
                    if (i < dataGridView1.ColumnCount)
                        dataGridView1.Columns[i].HeaderText = columnsName[i];
                }
            }
            else if (item == "items")
            {
                dataTable = Program.dbase.Search("SELECT * FROM Item;");
                dataGridView1.DataSource = dataTable;
                string[] columnsName = { "رقم الصنف", "اسم الصنف", "السعر", "رقم القسم" };
                for (int i = 0; i < columnsName.Length; i++)
                {
                    if (i < dataGridView1.ColumnCount)
                        dataGridView1.Columns[i].HeaderText = columnsName[i];
                }
            }
            else if (item == "staffs")
            {
                dataTable = Program.dbase.Search("SELECT * FROM Employee");
                dataGridView1.DataSource = dataTable;
                string[] columnsName = { "الرقم", "الاسم الاول", "الاسم الاخیر", "العنوان", "نوع العمل", "الراتب", "رقم الهاتف" };
                for (int i = 0; i < columnsName.Length; i++)
                {
                    if (i < dataGridView1.ColumnCount)
                        dataGridView1.Columns[i].HeaderText = columnsName[i];
                }
            }
            else if (item == "users")
            {
                string[] columnsName = { "الرقم", "اسم المستخدم" };

                string query = "SELECT Users.UserID, Users.UserName, Users.UserPassword, Permissions.PermissionName " +
                                   "FROM (Users INNER JOIN UserPermissions ON Users.UserID = UserPermissions.UserID) " +
                                   "INNER JOIN Permissions ON UserPermissions.PermissionID = Permissions.PermissionID";
                dataTable = Program.dbase.Search(query);
                dataGridView1.DataSource = dataTable;
                for (int i = 0; i < columnsName.Length; i++)
                {
                    if (i < dataGridView1.ColumnCount)
                        dataGridView1.Columns[i].HeaderText = columnsName[i];
                }
            }
            else if (item == "bills")
            {
                //    string query = @"
                //SELECT Bill.BillID, Users.UserName, Customer.Cust_Name, Booking.BookingDate, Bill.TotalAmount
                //FROM ((Bill
                //INNER JOIN Booking ON Bill.BookingID = Booking.BookingID)
                //INNER JOIN Customer ON Booking.CustomerID = Customer.Cust_ID)
                //INNER JOIN Users ON Bill.UserID = Users.UserID";


                string query = @" SELECT Bill.BillID, Users.UserName, Customer.Cust_Name, Booking.BookingDate, Bill.TotalAmount
FROM ((Bill
INNER JOIN Booking ON Bill.BookingID = Booking.BookingID)
INNER JOIN Customer ON Booking.CustomerID = Customer.Cust_ID)
INNER JOIN Users ON Bill.UserID = Users.UserID
WHERE Booking.BookingDate >= #" + ((DateTime)fromDate.Value).Date.ToString("dd/MM/yyyy") + "# AND Booking.BookingDate <= #" + ((DateTime)toDate.Value).Date.ToString("dd/MM/yyyy") + "#";
               
                dataTable = Program.dbase.Search(query);
                dataGridView1.DataSource = dataTable;
            }
            else if (item == "sections")
            {
                dataTable = Program.dbase.Search("SELECT * FROM Sections");


                dataGridView1.DataSource = dataTable;
                string[] columnsName = { "الرقم", "اسم القسم" };


                for (int i = 0; i < columnsName.Length; i++)
                {
                    dataGridView1.Columns[i].HeaderText = columnsName[i];
                }
            }




        }
        DataTable dataTable;
        private void InitializeDataGridView()
        {

            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Program.selectColor;
            dataGridView1.DefaultCellStyle.ForeColor = Program.lineColor;
            this.ForeColor = Program.lineColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
           
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void ComboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedKey = (string)((KeyValuePair<string, string>)comboFilter.SelectedItem).Key;
            showReport(selectedKey);
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            // Create a PrintDocument
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            // Create a PrintDialog and set the PrintDocument
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            // Show the print dialog
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Print the document
                printDocument.Print();
            }
        }

       
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set up the print area
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float width = e.MarginBounds.Width;
            float height = 0f;

            // Calculate the height of each row
            float rowHeight = dataGridView1.RowTemplate.Height;

            // Print the column headers
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, dataGridView1.Font, Brushes.Black, x, y);
                x += column.Width;
            }

            y += rowHeight;

            // Print the rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                x = e.MarginBounds.Left;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                        e.Graphics.DrawString(cell.Value.ToString(), dataGridView1.Font, Brushes.Black, x, y);

                    x += cell.OwningColumn.Width;
                }

                y += rowHeight;
            }

            // Check if there are more pages to print
            if (y + rowHeight <= e.MarginBounds.Bottom)
                e.HasMorePages = false;
            else
                e.HasMorePages = true;
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

        // here edit
        private void BtnBook_Click(object sender, EventArgs e)
        {
            (new Tables()).ShowDialog();
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
            (new Users()).ShowDialog();
        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
