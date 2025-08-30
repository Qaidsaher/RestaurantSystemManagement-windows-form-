using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemManagement
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
           
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string selectedKey;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedKey = (string)((KeyValuePair<string, string>)comboBox1.SelectedItem).Key;
            //MessageBox.Show(selectedKey);
        }

        private void Users_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            panel1.Visible = false;
            Dictionary<string, string> dataDictionary = Program.dbase.ReadNameWithID("SELECT ID, FirstName+' '+LastName AS Name FROM Employee;") ;
            
            comboBox1.DataSource = new BindingSource(dataDictionary, null);
            comboBox1.DisplayMember = "value";
            comboBox1.ValueMember = "key";
        }

        DataTable dataTable;
        private void RefreashDataGridView()
        {
            //dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            InitializeDataGridView();
        }
       
        int Id = -1;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "حذف")
                {
                    Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value.ToString());
                  
                        Program.dbase.Delete("DELETE FROM UserPermissions WHERE UserID = " + Id);
                        Program.dbase.Delete("DELETE FROM Users WHERE UserID = " + Id + "");
                    
                   

                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "تعديل")
                {
                 
                    
                    Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value.ToString());
                    comboBox1.SelectedText = dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                    //btnExcute.Text = "تعديل";
                    if (dataGridView1.Rows[e.RowIndex].Cells["Delete"].Value.ToString()=="True")
                    {
                        chDelete.Checked = true;
                    }
                    if (dataGridView1.Rows[e.RowIndex].Cells["Update"].Value.ToString() == "True")
                    {
                        chUpdate.Checked = true;
                    }
                    if (dataGridView1.Rows[e.RowIndex].Cells["Write"].Value.ToString() == "True")
                    {
                        chAdd.Checked = true;
                        
                    }

                    panel1.Visible = true;
                  
                }
                RefreashDataGridView();
            }
        }

       
        void InitializeDataGridView()
        {

           
            string query = "SELECT Users.UserID, Users.UserName, Users.UserPassword, Permissions.PermissionName " +
                              "FROM (Users LEFT JOIN UserPermissions ON Users.UserID = UserPermissions.UserID) " +
                              "LEFT JOIN Permissions ON UserPermissions.PermissionID = Permissions.PermissionID ORDER BY Permissions.PermissionID";

            DataTable dataTable = Program.dbase.Search(query);
            DataTable transformedData = new DataTable();
            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
       
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Program.selectColor;
            dataGridView1.DefaultCellStyle.ForeColor = Program.lineColor;
            this.ForeColor = Program.lineColor;
            transformedData.Columns.Add("UserID", typeof(int));
            transformedData.Columns.Add("UserName", typeof(string));
            transformedData.Columns.Add("UserPassword", typeof(int));

            // Get the distinct UserIDs from the original DataTable
            var distinctUserIDs = dataTable.AsEnumerable()
                .Select(row => row.Field<int>("UserID"))
                .Distinct();

            // Iterate over the distinct UserIDs
            foreach (int userID in distinctUserIDs)
            {
                // Get the rows for the current UserID
                var userRows = dataTable.AsEnumerable()
                    .Where(row => row.Field<int>("UserID") == userID);

                // Create a new row for the transformed DataTable
                DataRow newRow = transformedData.NewRow();
                if (!transformedData.Columns.Contains("Update"))
                {
                    transformedData.Columns.Add("Update", typeof(bool)).DefaultValue = false;
                }
                if (!transformedData.Columns.Contains("Write"))
                {
                    transformedData.Columns.Add("Write", typeof(bool)).DefaultValue = false;
                }
                if (!transformedData.Columns.Contains("Delete"))
                {
                    transformedData.Columns.Add("Delete", typeof(bool)).DefaultValue = false;
                }
                // Set the values for the current UserID
                newRow["UserID"] = userID;
                newRow["UserName"] = userRows.First()["UserName"];
                newRow["UserPassword"] = userRows.First()["UserPassword"];

                // Add permissions as columns and set their values
                foreach (var permissionRow in userRows)
                {
                    string permissionName = permissionRow.Field<string>("PermissionName");

                    if (permissionName != null)
                    {

                        newRow[permissionName] = true;
                    }
                }
                //if (newRow.Table.Columns.Contains(""))
                //{

                //}
                // Add the new row to the transformed DataTable
                transformedData.Rows.Add(newRow);
            }

            // Bind the transformed DataTable to the DataGridView to display the data
            dataGridView1.DataSource = transformedData;
            string[] columnsName = { "الرقم", "اسم المستخدم" };


            for (int i = 0; i < columnsName.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = columnsName[i];
            }
            DataGridViewButtonColumn dataDelete = new DataGridViewButtonColumn();
            dataDelete.Name = "حذف";
            dataDelete.Text = "حذف";
            dataDelete.FlatStyle = FlatStyle.Popup;
            dataDelete.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(dataDelete);

            // update button
            DataGridViewButtonColumn dataUpdate = new DataGridViewButtonColumn();
            dataUpdate.Name = "تعديل";
            dataUpdate.Text = "تعديل";
            dataUpdate.UseColumnTextForButtonValue = true;
            dataUpdate.FlatStyle = FlatStyle.Popup;
            dataGridView1.Columns.Add(dataUpdate);

            // Set the row style
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.BurlyWood;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // applling functions
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Id != -1)
            {


                Program.dbase.Delete("DELETE FROM UserPermissions WHERE UserID = " + Id);
               
                bool[] per = { chAdd.Checked, chUpdate.Checked, chDelete.Checked };
                if (per[0])
                {
                    Program.dbase.Add("INSERT INTO UserPermissions(UserID, PermissionID) VALUES(" + Id + ", 2);");
                }
                if (per[1])
                {
                    Program.dbase.Add("INSERT INTO UserPermissions(UserID, PermissionID) VALUES(" + Id + ", 1);");
                }
                if (per[2])
                {
                    Program.dbase.Add("INSERT INTO UserPermissions(UserID, PermissionID) VALUES(" + Id + ", 3);");
                }
                RefreashDataGridView();
                panel1.Visible = false;
            }
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExcute_Click_1(object sender, EventArgs e)
        {
           
            
            if (txtPass.Text != "")
            {
                if (Program.dbase.CountItem("Users ", " WHERE UserName = '" + comboBox1.Text + "' ;") == 0)
                {
                    Program.dbase.Add("INSERT INTO Users (UserName, UserPassword) VALUES('" + comboBox1.Text + "'," + txtPass.Text + " );");
                    RefreashDataGridView();
                }
                else
                    MessageBox.Show("it exist");
            }
            else
            {
                MessageBox.Show("it exist fill");
            }
                
        }
    }          
        
    
}
