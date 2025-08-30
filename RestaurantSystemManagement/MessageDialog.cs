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
    public partial class MessageDialog : Form
    {
        public static DialogResult ShowDialog(string title )
        {
            return (new MessageDialog(title)).ShowDialog();
        }
        public MessageDialog()
        {
            InitializeComponent();
        }
        public MessageDialog(string title)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            lbTitle.Text = title;
            if(title == "delete")
            {
                pictureBox1.Image = Properties.Resources.bin;
                lbTitle.Text = "هل متاكد من عميلة الحذف ؟";
            }
            else if(title == "ensure")
            {
                pictureBox1.Image = Properties.Resources.bin;
                lbTitle.Text = "هل انت متاكد ؟";
            }


        }

        private void MessageDialog_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
