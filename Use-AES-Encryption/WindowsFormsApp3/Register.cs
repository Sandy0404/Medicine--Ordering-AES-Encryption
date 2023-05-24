using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            label7.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label5.Parent = pictureBox1;
        }

        private void btn送出_Click(object sender, EventArgs e)
        {
            if (radioButton顧客.Checked==true)
            {
                //檢查帳號密碼長度
                if (txt帳號.Text.Length >= 5 && txt密碼.Text.Length >= 5)
                {
                    sqlserverconnection obj = new sqlserverconnection();
                    try
                    {
                        //檢查帳號密碼是否重複
                        if ((txt姓名.Text != "") && (txt帳號.Text != ""))
                        {
                            SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
                            con.Open();

                            string checkSQL = "SELECT COUNT(*) FROM CustomerLogin WHERE Account=@phone AND Password=@password";
                            SqlCommand checkCmd = new SqlCommand(checkSQL, con);
                            checkCmd.Parameters.AddWithValue("@phone", txt帳號.Text.Trim());
                            checkCmd.Parameters.AddWithValue("@password", txt密碼.Text.Trim());
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("帳號密碼已經存在，請重新輸入");
                            }
                            else
                            {
                                try//加密
                                {
                                    string Encrypt_Key = "abc";
                                    txt密碼.Text = StringEncrypt.aesEncryptBase64(txt密碼.Text, Encrypt_Key);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                                //資料庫寫入帳號密碼
                                string strSQL = "insert into CustomerLogin values(@NewName,@Newphone,@NewAddress); ";
                                SqlCommand cmd = new SqlCommand(strSQL, con);

                                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text.Trim());
                                cmd.Parameters.AddWithValue("@Newphone", txt帳號.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewAddress", txt密碼.Text.Trim());

                                int rows = cmd.ExecuteNonQuery();
                                MessageBox.Show($"會員資料新增完畢,{rows}筆資料受影響");
                            }
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("資料必填");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("帳號長度必須在6~12之間，密碼長度必須在8~16之間");
                }
            }else//員工註冊
            {
                //檢查帳號密碼長度
                if (txt帳號.Text.Length >= 5 && txt密碼.Text.Length >= 5)
                {
                    sqlserverconnection obj = new sqlserverconnection();
                    try
                    {
                        //檢查帳號密碼是否重複
                        if ((txt姓名.Text != "") && (txt帳號.Text != ""))
                        {
                            SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
                            con.Open();

                            string checkSQL = "SELECT COUNT(*) FROM StaffLogin WHERE Account=@phone AND Password=@password";
                            SqlCommand checkCmd = new SqlCommand(checkSQL, con);
                            checkCmd.Parameters.AddWithValue("@phone", txt帳號.Text.Trim());
                            checkCmd.Parameters.AddWithValue("@password", txt密碼.Text.Trim());
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("帳號密碼已經存在，請重新輸入");
                            }
                            else
                            {
                                try//加密
                                {
                                    string Encrypt_Key = "abc";
                                    txt密碼.Text = StringEncrypt.aesEncryptBase64(txt密碼.Text, Encrypt_Key);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                                //資料庫寫入帳號密碼
                                string strSQL = "insert into StaffLogin values(@NewName,@Newphone,@NewAddress); ";
                                SqlCommand cmd = new SqlCommand(strSQL, con);

                                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text.Trim());
                                cmd.Parameters.AddWithValue("@Newphone", txt帳號.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewAddress", txt密碼.Text.Trim());

                                int rows = cmd.ExecuteNonQuery();
                                MessageBox.Show($"會員資料新增完畢,{rows}筆資料受影響");
                            }
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("資料必填");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("帳號長度必須在6~12之間，密碼長度必須在8~16之間");
                }
            }
        }

        private void btn關閉_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
