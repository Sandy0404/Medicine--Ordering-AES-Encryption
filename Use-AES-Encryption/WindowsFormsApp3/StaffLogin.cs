using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class StaffLogin : Form
    {
        static public int id = 0;
        static public string loginusername;//全域變數

        public StaffLogin()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            label3.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlserverconnection sql = new sqlserverconnection();//class物件化
            SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
            try//檢查資料庫連線
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("無法連線到資料庫.");
                        break;
                    case 1045:
                        MessageBox.Show("使用者帳號或密碼錯誤,請再試一次.");
                        break;
                }
            }
            string 加密 = "";
            try//前端字串先加密
            {
                string Encrypt_Key = "abc";
                加密 = StringEncrypt.aesEncryptBase64(password.Text, Encrypt_Key);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string 使用者 = "";
            string strMsg = "";
            //int id = 0;
            string 帳號 = "";
            string 密碼 = "";
            string SQL = "SELECT * FROM StaffLogin where Account =@account; "; //sql指令
            SqlCommand cmd = new SqlCommand(SQL, con); //sql指令
            cmd.Parameters.AddWithValue("@account", account.Text.Trim());
            cmd.Parameters.AddWithValue("@password", password.Text.Trim());
            SqlDataReader reader = cmd.ExecuteReader();
            try//資料庫密碼解密
            {
                string Decrypt_Key = "abc";
                密碼 = StringEncrypt.aesDecryptBase64(密碼, Decrypt_Key);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            while (reader.Read() == true)
            {
                id = (int)reader["s_id"];
                使用者 = reader["user"].ToString();
                帳號 = reader["Account"].ToString();
                密碼 = reader["Password"].ToString();
                strMsg += $"{id}{使用者}{帳號}{密碼}\n";
            }
            //MessageBox.Show(strMsg);//驗證用

            if ((reader.HasRows) && (加密 == 密碼))//判定帳號是否存在
            {
                loginusername = 使用者; //全域變數紀錄使用者帳號
                Thread thread = new Thread(new ThreadStart(delegate ()//建立一個執行序
                {
                    ProductManagement form = new ProductManagement();
                    form.ShowDialog();
                }));
                LoginMain loginMain = new LoginMain();
                loginMain.Hide();
                thread.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤");
            }
            reader.Close();
            con.Close();//先開所以後關
        }

        private void btn忘記密碼_Click(object sender, EventArgs e)
        {
            string 使用者 = "";
            string strMsg = "";
            int id = 0;
            string 帳號 = "";
            string 密碼 = "";
            string SQL = "SELECT Password FROM StaffLogin where Account =@account; "; //sql指令
            sqlserverconnection sql = new sqlserverconnection();//class物件化
            SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con); //sql指令
            cmd.Parameters.AddWithValue("@account", account.Text.Trim());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                密碼 = reader["Password"].ToString();
                strMsg += $"{密碼}\n";
            }
            try//資料庫密碼解密
            {
                string Decrypt_Key = "abc";
                strMsg = StringEncrypt.aesDecryptBase64(strMsg, Decrypt_Key);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(strMsg);//驗證用
            reader.Close();
            con.Close();//先開所以後關
        }
    }
}
