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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            if (Program.user.CheckUpdate())
            {
                btnAddNew.Visible = true;
            }
        }

        private void Items_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            InitialButtons();
        }
        DataTable dataTable;
        private void RefreashDataGridView()
        {
            dataTable = Program.dbase.Search("SELECT * FROM Item;");
            dataGridView1.DataSource = dataTable;
        }
        private void InitializeDataGridView()
        {

            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            


            dataTable = Program.dbase.Search("SELECT * FROM Item");
            dataGridView1.DataSource = dataTable;
            string[] columnsName = { "رقم الصنف", "اسم الصنف", "السعر", "رقم القسم" };

            dataGridView1.DefaultCellStyle.SelectionBackColor = Program.selectColor;
            dataGridView1.DefaultCellStyle.ForeColor = Program.lineColor;
            this.ForeColor = Program.lineColor;

            for (int i = 0; i < columnsName.Length &&i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderText = columnsName[i];
            }
            DataGridViewButtonColumn dataDelete = new DataGridViewButtonColumn();
            dataDelete.Name = "حذف";
            dataDelete.Text = "حذف";
            dataDelete.FlatStyle = FlatStyle.Popup;
            dataDelete.UseColumnTextForButtonValue = true;
            if (Program.user.CheckDelete())
                dataGridView1.Columns.Add(dataDelete);

            // update button
            DataGridViewButtonColumn dataUpdate = new DataGridViewButtonColumn();
            dataUpdate.Name = "تعديل";
            dataUpdate.Text = "تعديل";
            dataUpdate.UseColumnTextForButtonValue = true;
            dataUpdate.FlatStyle = FlatStyle.Popup;
            if (Program.user.CheckUpdate())
                dataGridView1.Columns.Add(dataUpdate);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (!(column.HeaderText == "تعديل" || column.HeaderText == "حذف"))
                    comboBoxSort.Items.Add(column.HeaderText);
            }
            comboBoxSort.SelectedIndex = 0;

            // Set the row style
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.BurlyWood;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // applling functions
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColumn = comboBoxSort.SelectedItem.ToString();
            // Find the column index
            int columnIndex = -1;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.HeaderText == selectedColumn)
                {
                    columnIndex = column.Index;
                    break;
                }
            }
            // Sort the DataGridView by the selected column
            if (columnIndex != -1)
            {
                dataGridView1.Sort(dataGridView1.Columns[columnIndex], ListSortDirection.Ascending);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

            string searchText = textBoxSearch.Text;
            // Clear the current selection
            dataGridView1.ClearSelection();
            // Perform the search
            if (!string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "حذف")
                {
                    int itemId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ItemID"].Value.ToString());
                    if (DialogResult.Yes == MessageDialog.ShowDialog("delete"))
                    {
                        MessageBox.Show(Program.dbase.Delete("DELETE FROM Item WHERE ItemID = " + itemId));
                        RefreashDataGridView();
                    }
                    

                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "تعديل")
                {
                    int empId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ItemID"].Value.ToString());
                    MessageBox.Show(empId.ToString());
                    ItemDialog sd = new ItemDialog(empId);
                    sd.ShowDialog();
                    RefreashDataGridView();
                }
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            (new ItemDialog()).ShowDialog();
              RefreashDataGridView();
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
