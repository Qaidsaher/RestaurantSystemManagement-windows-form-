using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemManagement
{
    public partial class StaffsDialog : Form
    {
        bool isAdding = false;
        public StaffsDialog()
        {
            InitializeComponent();
            lbTitle.Text = "إضافة موظف جدید";
            btnExcute.Text = "إضافة";
            this.StartPosition = FormStartPosition.CenterParent;
            txtId.Text = (Program.dbase.CountItem("Employee") + 1).ToString();
            isAdding = true;
        }
        public StaffsDialog(int id)
        {
            InitializeComponent();
            string selectQuery = "SELECT *  FROM Employee WHERE ID ="+id+"";
            lbTitle.Text = "تعدیل بیانات موظف";
            btnExcute.Text = "تعديل";
            Dictionary<string, object> dataDictionary = Program.dbase.ReadOneRecord(selectQuery);

            if (dataDictionary.Count > 0)
            {
                txtId.Text = dataDictionary["ID"].ToString();
                txtLname.Text = dataDictionary["LastName"].ToString();
                txtFname.Text = dataDictionary["FirstName"].ToString();
                txtAddress.Text = dataDictionary["Address"].ToString();
                txtJob.Text = dataDictionary["Role"].ToString();
                txtSalary.Text = dataDictionary["Salary"].ToString();
                txtPhone.Text = dataDictionary["PhoneNumber"].ToString();
            }

            isAdding = false;
        }

        private void StaffsDialog_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
           
            this.ForeColor = Program.lineColor;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.No;
        }

        private void BtnExcute_Click(object sender, EventArgs e)
        {
            bool notTextboxesEmpty = true;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        notTextboxesEmpty = false;
                        break;
                    }
                }
            }

            if (notTextboxesEmpty)
            {


                if (isAdding)
                {
                    string insertQuery = "INSERT INTO Employee ( FirstName, LastName, Address, Role,  Nationality, Salary, PhoneNumber) " +
                    "VALUES ('" + txtFname.Text + "', '" + txtLname.Text + "', '" + txtAddress.Text + "', '" + txtJob.Text + "', 'mentiont', " + txtSalary.Text + ", '" + txtPhone.Text + "')";
                    MessageBox.Show( Program.dbase.Add(insertQuery));
                }
                else
                {
                    string updateQuery = "UPDATE Employee SET FirstName = '" + txtFname.Text + "', LastName = '" + txtLname.Text + "', Address = '" + txtAddress.Text + "', Role = '" + txtJob.Text + "', Nationality = 'mentiont', Salary = " + txtSalary.Text + ", PhoneNumber = " + txtPhone.Text + "  WHERE ID = " + txtId.Text + ";";
                    MessageBox.Show(Program.dbase.Update(updateQuery));
                }
                
               
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                lbError.Text = "یجب ان لایکون هناك اي حقل فارغ";
            }
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
