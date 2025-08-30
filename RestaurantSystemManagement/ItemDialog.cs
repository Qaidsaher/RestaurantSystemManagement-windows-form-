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
    public partial class ItemDialog : Form
    {
        bool isAdding = false;
        public ItemDialog()
        {
            InitializeComponent();
            lbTitle.Text = "إضافة صنف جدید";
            btnExcute.Text = "إضافة";
            this.StartPosition = FormStartPosition.CenterParent;
            txtId.Text = (Program.dbase.CountItem("Item") + 1).ToString();
            isAdding = true;
            comboBox1.Enabled = true;
            Dictionary<string, string> dataDictionary = Program.dbase.ReadRelations("select * from Sections;");
            comboBox1.DataSource =new BindingSource(dataDictionary,null);
            comboBox1.DisplayMember = "value";
            comboBox1.ValueMember = "key";
            // Assuming you have a ComboBox named comboBox
           

        }
        public ItemDialog(int id)
        {
            InitializeComponent();
            string selectQuery = "SELECT *  FROM Item WHERE ItemID =" + id + "";
            lbTitle.Text = "تعدیل بیانات صنف";
            btnExcute.Text = "تعديل";
            Dictionary<string, object> dataDictionary = Program.dbase.ReadOneRecord(selectQuery);

            if (dataDictionary.Count > 0)
            {
                txtId.Text = dataDictionary["ItemID"].ToString();
                txtFname.Text = dataDictionary["ItemName"].ToString();
                txtPrice.Text = dataDictionary["Price"].ToString();
                
            }

            isAdding = false;
        }

        private void ItemDialog_Load(object sender, EventArgs e)
        {
            
            this.ForeColor = Program.lineColor;
            this.StartPosition = FormStartPosition.CenterParent;
            btnClose.Click += BtnClose_Click;
            //btnExcute.Click += BtnExcute_Click_1;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.No;
        }

        
        string selectedKey;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedKey = (string)((KeyValuePair<string, string>)comboBox1.SelectedItem).Key;
           
        }

        private void BtnExcute_Click_1(object sender, EventArgs e)
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
                    string insertQuery = "INSERT INTO Item (ItemName, Price, SectionID) " +
                     "VALUES ('" + txtFname.Text + "', " + txtPrice.Text + ", " + selectedKey + ")";
                    //MessageBox.Show(Program.dbase.Add(insertQuery));
                }
                else
                {
                    string updateQuery = "UPDATE Item SET  ItemName = '" + txtFname.Text + "', ItemPrice = " + txtPrice.Text + "WHERE ItemID = " + txtId.Text;
                    //MessageBox.Show(Program.dbase.Update(updateQuery));
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
