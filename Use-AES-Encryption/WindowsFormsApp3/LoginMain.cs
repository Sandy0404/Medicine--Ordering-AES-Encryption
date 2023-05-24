using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class LoginMain : Form
    {
        public LoginMain()
        {
            InitializeComponent();
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
        }

        private void Staff_Click(object sender, EventArgs e)
        {

            StaffLogin loginStaff = new StaffLogin();
            this.Hide();
            loginStaff.ShowDialog();//獨佔開啟
            
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            CustomerLogin loginCustomer = new CustomerLogin(this);
            this.Hide();
            loginCustomer.ShowDialog();//獨佔開啟
           
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            Register RegisterOk = new Register();
            this.Hide();
            RegisterOk.ShowDialog();//獨佔開啟
        }
    }
}
