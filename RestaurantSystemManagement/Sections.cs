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
    public partial class Sections : Form
    {
        public Sections()
        {
            InitializeComponent();
            btnExcute.Hide();
            if (Program.user.CheckWrite())
            {
                btnExcute.Visible =true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dataTable;
        private void RefreashDataGridView()
        {
            dataTable = Program.dbase.Search("SELECT * FROM Sections;");
            dataGridView1.DataSource = dataTable;
        }
        private void InitializeDataGridView()
        {

            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.ForeColor = Color.DarkRed;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Coral;


            dataTable = Program.dbase.Search("SELECT * FROM Sections");


            dataGridView1.DataSource = dataTable;
            string[] columnsName = { "الرقم", "اسم القسم"};


            for (int i = 0; i < columnsName.Length; i++)
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

            // Set the row style
           
            dataGridView1.DefaultCellStyle.SelectionBackColor = Program.selectColor;
            dataGridView1.DefaultCellStyle.ForeColor = Program.lineColor;
            this.ForeColor = Program.lineColor;
            // applling functions
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          
        }
        int Id = -1;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "حذف")
                {
                     Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["SectionID"].Value.ToString());
                    if (DialogResult.Yes == MessageDialog.ShowDialog("delete"))
                    {
                        Program.dbase.Delete("DELETE FROM Item WHERE SectionID = " + Id + "");


                        Program.dbase.Delete("DELETE FROM Sections WHERE SectionID = " + Id + "");
                        MessageBox.Show("Sf");
                    }
                    RefreashDataGridView();

                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "تعديل")
                {
                     Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["SectionID"].Value.ToString());
                     txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["SectionName"].Value.ToString();
                     btnExcute.Text = "تعديل";
                    RefreashDataGridView();
                }
            }
        }

        private void BtnExcute_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                if (btnExcute.Text == "اضافة")
                {
                    Id = Program.dbase.CountItem("Sections") + 1;
                    Program.dbase.Add("INSERT INTO Sections (SectionName)  VALUES ('" + txtName.Text + "' );");
                    txtName.Text = "";
                    Id = -1;
                    RefreashDataGridView();
                }
                else
                {

                    btnExcute.Text = "اضافة";
                  
                    Program.dbase.Update("update Sections set SectionName = '" + txtName.Text + "'  where  SectionID = " + Id + ";");
                    Id = -1;
                    txtName.Text = "";
                    RefreashDataGridView();
                }
            }
           
        }

        private void Sections_Load(object sender, EventArgs e)
        {
          
            InitializeDataGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
