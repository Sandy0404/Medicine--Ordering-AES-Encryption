using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string image_name = "";
        int 所選數量;
        List<int> list商品數量 = new List<int>();   //value
        List<string> list商品圖片 = new List<string>();   //value
        string 所選圖片 = "";

        List<string> list商品 = new List<string>();//key
        List<int> list商品價格 = new List<int>();   //value
        List<string> list不限金額加購價 = new List<string>();//key
        List<int> list加購價格 = new List<int>();//value
        List<int> list商品數量1 = new List<int>();//value
        int 所選商品數量;
        int 所選單價;
        int 所選加購單價;//新增
        int 所選商品數量1;//新增
        int 所選商品總價;
        int 所選商品總價半價;
        string 所選商品;
        string 所選加購商品;
        int 所選加購商品價格;
        bool isMy購物袋;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//執行一次
        {
            string image_dir = @"C:\Users\iSpan\Desktop\adonet視窗資料庫程式20230206-2\";//圖檔目錄
            //商品push到前端開始
            SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
            con.Open();
            string strSQL1 = $"SELECT pname FROM ProductManagement; ";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string num = reader1["pname"].ToString();
                list商品.Add(num);
            }
            reader1.Close();
            con.Close();
            //商品push到前端結束

            //商品價格push到前端開始
            //SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
            con.Open();
            string strSQL = $"SELECT price,amount,pimage FROM ProductManagement; ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int num = (int)reader["price"];
                int amount= (int)reader["amount"];
                list商品價格.Add(num);
                list商品數量.Add(amount);

                image_name = reader["pimage"].ToString();
                string 圖檔完整路徑 = image_dir + image_name;
                pictureBox商品圖.Image = Image.FromFile(圖檔完整路徑);

                //image_name = reader["pimage"].ToString();
                //string 圖檔完整路徑 = GlobalVar1.image_dir + image_name;
                //pictureBox商品圖.Image = Image.FromFile(圖檔完整路徑);
                //byte[] imageByte;
                //imageByte = (byte[])reader["pimage"];
                //MemoryStream stream = new MemoryStream(imageByte);
                //Bitmap bitmap = new Bitmap(stream);
                list商品圖片.Add(圖檔完整路徑);
                //pictureBox商品圖.Image = bitmap;
            }
            reader.Close();
            con.Close();
            //商品價格push到前端結束

            //不限金額加購商品push到前端開始
            con.Open();
            string strSQL4 = $"SELECT AddPname FROM AddProductManagement; ";
            SqlCommand cmd4 = new SqlCommand(strSQL4, con);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                string num = reader4["AddPname"].ToString();
                list不限金額加購價.Add(num);
            }
            reader4.Close();
            con.Close();
            //不限金額加購商品push到前端結束

            //不限金額加購價push到前端開始
            con.Open();
            string strSQL5 = $"SELECT AddPrice FROM AddProductManagement; ";
            SqlCommand cmd5 = new SqlCommand(strSQL5, con);
            SqlDataReader reader5 = cmd5.ExecuteReader();
            while (reader5.Read())
            {
                int num = (int)reader5["AddPrice"];
                list加購價格.Add(num);
            }
            reader5.Close();
            con.Close();
            //不限金額加購價push到前端結束

            //資料庫商品push到前端開始
            con.Open();
            string strSQL3 = $"SELECT pname,price FROM ProductManagement; ";
            SqlCommand cmd3 = new SqlCommand(strSQL3, con);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                string name = reader3["pname"].ToString();
                string num = reader3["price"].ToString();
                string mix = $"一個{name},{num}元";
                listBox商品.Items.Add(mix);
            }
            reader3.Close();
            con.Close();
            //資料庫商品push到前端結束

            //資料庫加購商品push到前端開始
            con.Open();
            string strSQL2 = $"SELECT AddPname,AddPrice FROM AddProductManagement; ";
            SqlCommand cmd2 = new SqlCommand(strSQL2, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string name = reader2["AddPname"].ToString();
                string num = reader2["AddPrice"].ToString();
                string mix = $"一個{name},{num}元";
                combo加購.Items.Add(mix);
            }
            reader.Close();
            con.Close();
            //資料庫加購商品push到前端結束

            //預設值
            txt數量.Text = "1";
            所選商品數量 = 1;
            chk買購物袋.Checked = false;
            isMy購物袋 = false;
            combo加購.SelectedIndex = 0;
            所選加購商品 = list不限金額加購價[combo加購.SelectedIndex];
            comboBox數量.SelectedIndex= -1;

            //新增說明
            string items = "全品項消費不含購物袋滿300元打八折，衛生紙第二件半價，維他命C買二送一，每人不限購買數量，歡迎選購。";
            richTextBox說明.Text = items;
            //顯示
            Success.Text = CustomerLogin.loginusername;
            lbl會員.Text = GlobalVar.訂購人資訊;
            txt訂購人.Visible= true;
        }

        void 計算所選品項總價()
        {
            if (listBox商品.SelectedIndex > -1)//SelectedIndex所選項目索引直
            {//衛生紙第二件半價list商品[0].Contains("衛生紙")
                所選加購單價 = list加購價格[combo加購.SelectedIndex];
                
                if (list商品[listBox商品.SelectedIndex] == "衛生紙")
                {
                    //所選商品數量 = list商品數量[comboBox數量.SelectedIndex];
                    int bulkDiscount = Convert.ToInt32(所選商品數量) / 2;
                    所選商品總價 = (int)(所選單價 * (所選商品數量 - bulkDiscount)) + (int)(所選單價 * 0.5 * bulkDiscount) + 所選加購單價;
                }
                else
                {
                    //所選商品數量 = list商品數量[comboBox數量.SelectedIndex];
                    所選商品總價 = (所選單價 * 所選商品數量) + 所選加購單價;
                }
                lbl品項總價.Text = String.Format("{0}元", 所選商品總價);
            }
        }

        private void txt杯數_TextChanged(object sender, EventArgs e)
        {
            if (txt數量.Text != "")
            {
                bool is數量正確 = Int32.TryParse(txt數量.Text, out 所選商品數量);
                if (is數量正確 ==false || (所選商品數量 <= 0))
                {
                    MessageBox.Show("輸入不正確,最少一商品");
                    所選商品數量 = 1;
                    txt數量.Text = "1";
                }
                計算所選品項總價();
            }
        }

        private void chk買購物袋_CheckedChanged(object sender, EventArgs e)
        {
            if (chk買購物袋.Checked == true)
            {
                GlobalVar.is購物袋 = true;
            }
            else
            {
                GlobalVar.is購物袋 =false;
            }
        }

        private void btn加入訂購單_Click(object sender, EventArgs e)
        {
            int txtNum;
            int.TryParse(txt數量.Text, out txtNum);
            if (txt訂購人.Text != "")
            {
                if (txtNum <= 所選數量)
                {
                    ArrayList 單品項訂購資訊 = new ArrayList();
                    單品項訂購資訊.Add(所選商品);
                    單品項訂購資訊.Add(所選單價);
                    單品項訂購資訊.Add(所選商品數量);
                    單品項訂購資訊.Add(所選商品總價);
                    單品項訂購資訊.Add(所選加購商品);
                    單品項訂購資訊.Add(所選加購商品價格);

                    GlobalVar.訂購人資訊 = txt訂購人.Text;
                    GlobalVar.list訂購品項資料.Add(單品項訂購資訊);
                    if (chk買購物袋.Checked == true)
                    {
                        GlobalVar.is購物袋 = true;
                    }
                    MessageBox.Show("品項加入訂購單");
                }
                else
                {
                    MessageBox.Show($"庫存剩餘{所選數量}");
                }
            } else
            {
                MessageBox.Show("請輸入訂購人");
            }
        }

        private void btn查看訂購單_Click(object sender, EventArgs e)
        {
            FormOrderList myOrderListForm = new FormOrderList();
            GlobalVar.訂購人資訊 = txt訂購人.Text;
            //this.Hide();
            myOrderListForm.ShowDialog();//獨佔開啟
        }

        //取消購買塑膠袋解決
        private void Form1_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Form Active.....");//可操作狀態(可執行多次,用來更新表單資料)
            if (GlobalVar.is購物袋 == true)
            {
                chk買購物袋.Checked = true;
            }
            else
            {
                chk買購物袋.Checked=false;
            }
        }

        private void listBox商品_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listBox商品.SelectedIndex > -1))
            {
                所選商品 = list商品[listBox商品.SelectedIndex];
                所選單價 = list商品價格[listBox商品.SelectedIndex];//+ list加購價格[combo加購.SelectedIndex] 
                所選加購商品價格 = list加購價格[combo加購.SelectedIndex];
                所選數量 = list商品數量[listBox商品.SelectedIndex];
                所選圖片= list商品圖片[listBox商品.SelectedIndex];
                pictureBox商品圖.Image = Image.FromFile(所選圖片);
                lbl品項單價.Text = String.Format("{0}元", 所選單價);
                lbl數量.Text = String.Format("{0}", 所選數量);
                for (int i = 1; i <= 所選數量; i++)
                {
                    comboBox數量.Items.Add(i.ToString());
                }
                //if (comboBox數量.SelectedIndex>-1)
                //{
                    計算所選品項總價();
                //}
                
            }
        }

        private void richTextBox說明_TextChanged(object sender, EventArgs e)
        {//字居中對齊
            richTextBox說明.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void combo加購_SelectedIndexChanged(object sender, EventArgs e)
        {//SelectedIndex > -1:不選商品
            if (listBox商品.SelectedIndex > -1)//SelectedIndex所選項目索引直
            {
                //所選加購商品 = list不限金額加購價[combo加購.SelectedIndex];
                所選加購商品價格 = list加購價格[combo加購.SelectedIndex];
                所選單價 = list商品價格[listBox商品.SelectedIndex];
                //所選數量 = list商品數量[listBox商品.SelectedIndex];
                lbl品項單價.Text = String.Format("{0}元", 所選單價);
                //lbl數量.Text = String.Format("{0}", 所選數量);
            }
            計算所選品項總價();
        }

        private void btn登出_Click(object sender, EventArgs e)
        {
            LoginMain loginMain=new LoginMain();
            this.Hide();
            loginMain.ShowDialog();
        }

        public void comboBox數量_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbl數量_Click(object sender, EventArgs e)
        {
        }
    }
}