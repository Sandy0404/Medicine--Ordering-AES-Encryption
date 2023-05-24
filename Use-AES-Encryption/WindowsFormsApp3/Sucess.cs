using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Sucess : Form
    {
        int c_id = CustomerLogin.id;
        public Sucess()
        {
            InitializeComponent();
        }

        private void Sucess_Load(object sender, EventArgs e)
        {
            //Success.Text = login.loginusername;
            label1.Parent = pictureBox1;
        }

        private void btn關閉_Click(object sender, EventArgs e)
        {
            Form1 form1=new Form1();
            
            form1.Hide();
            Close();
        }

        private void btn送出_Click(object sender, EventArgs e)
        {
            if ((txt評論.Text != ""))
            {
                sqlserverconnection sql = new sqlserverconnection();//class物件化
                SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
                con.Open();
                string strSQL = "insert into CustomerComment values(@c_id,@NewComment);";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@NewComment", txt評論.Text.Trim());
                cmd.Parameters.AddWithValue("@c_id", c_id);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料新增完畢,{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("評論必填");
            }
            Close();
        }
    }
}
