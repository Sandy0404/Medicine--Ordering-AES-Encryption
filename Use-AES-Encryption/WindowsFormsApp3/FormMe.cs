using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormMe : Form
    {
        public FormMe()
        {
            InitializeComponent();
        }

        private void 訂購單_Click(object sender, EventArgs e)
        {
            Form1 myOrderListForm = new Form1();
            //myOrderListForm.訂購人資訊 = txt訂購人.Text;
            //GlobalVar.訂購人資訊 = txt訂購人.Text;
            //myOrderListForm.Show();
            myOrderListForm.ShowDialog();//獨佔開啟
            //btn查看訂購單.Enabled = false;//
            //btn查看訂購單.Visible = false;//消失的功能
        }

        private void btn會員表單_Click(object sender, EventArgs e)
        {
            StaffLogin openlogin = new StaffLogin();
            openlogin.ShowDialog();//獨佔開啟
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            FormOrderList FormOrderList1 = new FormOrderList();
            FormOrderList1.ShowDialog();//獨佔開啟
        }

        private void FormMe_Load(object sender, EventArgs e)
        {

        }
    }
}
