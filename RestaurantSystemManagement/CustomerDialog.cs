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
    public partial class CustomerDialog : Form
    {
        bool isAdding = false;

        public CustomerDialog()
        {
            InitializeComponent();
         
            lbTitle.Text = "إضافة موظف جدید";
            btnExcute.Text = "إضافة";
            this.StartPosition = FormStartPosition.CenterParent;
            txtId.Text = (Program.dbase.CountItem("Customer") + 1).ToString();
            isAdding = true;
           
        }
        public CustomerDialog(int id)
        {
            InitializeComponent();
            string selectQuery = "SELECT *  FROM Customer WHERE Cust_ID =" + id + "";
            lbTitle.Text = "تعدیل بیانات عميل";
            btnExcute.Text = "تعديل";
            Dictionary<string, object> dataDictionary = Program.dbase.ReadOneRecord(selectQuery);

            if (dataDictionary.Count > 0)
            {
                txtId.Text = dataDictionary["Cust_ID"].ToString();
         
                txtFname.Text = dataDictionary["Cust_Name"].ToString();
                txtAddress.Text = dataDictionary["Cust_Address"].ToString();
       
                txtPhone.Text = dataDictionary["Cust_Phone"].ToString();
             }

            isAdding = false;

        }
        private void CustomerDialog_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            btnClose.Click += BtnClose_Click;
            btnExcute.Click += BtnExcute_Click;
          
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

                
                if (!isAdding)
                {
                    string updateQuery = "UPDATE Customer SET  Cust_Name = '" + txtFname.Text + "', Cust_Address = '" + txtAddress.Text + "' , Cust_Phone = " + txtPhone.Text + " WHERE Cust_ID = " + txtId.Text;
                    MessageBox.Show(Program.dbase.Update(updateQuery));
                }
                else
                {
                    string insertQuery = "INSERT INTO Customer (Cust_Name,Cust_Address, Cust_Phone) " +
                     " VALUES ('" + txtFname.Text + "', '" + txtAddress.Text + "', " + txtPhone.Text + ")";
                    MessageBox.Show( Program.dbase.Add(insertQuery));
                }
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                lbError.Text = "یجب ان لایکون هناك اي حقل فارغ";
            }
        }
    }
}
