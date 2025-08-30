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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(!((txtName.Text == "") && (txtPassword.Text == "")))
            {
                Program.user = Program.dbase.CheckUser(txtName.Text, txtPassword.Text);
                if (Program.user != null)
                {
                    (new Thread(()=> 
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Home());
                    }
                    )).Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("wron inputs");
                }
            }
            else
            {
                MessageBox.Show("fill the inputs");
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
