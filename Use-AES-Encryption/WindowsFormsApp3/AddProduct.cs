using System;
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

namespace WindowsFormsApp3
{
    public partial class AddProduct : Form
    {
        int s_id = StaffLogin.id;

        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            sqlserverconnection sql = new sqlserverconnection();//class物件化
            SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
            Success.Text = StaffLogin.loginusername;
            LoginMain LM = new LoginMain();
            LM.Close();
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if (txt商品名稱.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
                con.Open();
                string strSQL = $"select * from AddProductManagement where AddPname like @Searchpname;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchpname", $"%{txt商品名稱.Text.Trim()}%");//幫忙檢查駭客程式碼,AddWithValue(參數名稱,$"%{txt姓名.Text}%");//Trim()去除前後空白
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["ap_id"].ToString();
                    txt商品名稱.Text = reader["AddPname"].ToString();
                    txt價格.Text = reader["AddPrice"].ToString();
                    //txt數量.Text = reader["amount"].ToString();
                    //txt商品描述.Text = reader["pdesc"].ToString();

                    //byte[] imageByte;
                    //imageByte = (byte[])reader["pimage"];
                    //MemoryStream stream = new MemoryStream(imageByte);
                    //Bitmap bitmap = new Bitmap(stream);
                    //pictureBox圖片.Image = bitmap;
                }
                else
                {
                    MessageBox.Show("查無資料");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("查無資料");
            }
        }
        void 清空欄位()
        {
            lblID.Text = "";
            txt商品名稱.Clear();
            txt價格.Clear();
            //txt數量.Clear();
            //txt商品描述.Clear();
            //pictureBox圖片.Image = null;
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);
            if ((intID > 0) && (txt商品名稱.Text != "") && (txt價格.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
                con.Open();
                string strMsg = "update AddProductManagement set  s_id=@s_id,AddPname=@Newpname,AddPrice=@Newprice where ap_id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strMsg, con);

                cmd.Parameters.AddWithValue("@Newpname", txt商品名稱.Text.Trim());
                cmd.Parameters.AddWithValue("@Newprice", txt價格.Text.Trim());
                cmd.Parameters.AddWithValue("@s_id", s_id);
                //cmd.Parameters.AddWithValue("@Newamount", txt數量.Text.Trim());
                //cmd.Parameters.AddWithValue("@Newpdesc", txt商品描述.Text.Trim());

                ////圖片轉byte
                //Image image = pictureBox圖片.Image;
                //byte[] arr;
                //ImageConverter converter = new ImageConverter();
                //arr = (byte[])converter.ConvertTo(image, typeof(byte[]));

                //cmd.Parameters.AddWithValue("@Newpimage", arr);
                ////txt圖片.Text = reader["pimage"].ToString();
                cmd.Parameters.AddWithValue("@SearchID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料新增完畢,{rows}筆資料受影響");
            }
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt價格.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
                con.Open();
                string strSQL = "insert into AddProductManagement values(@s_id,@Newpname,@Newprice);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                //圖片轉byte
                //Image image = pictureBox圖片.Image;
                //byte[] arr;
                //ImageConverter converter = new ImageConverter();
                //arr = (byte[])converter.ConvertTo(image, typeof(byte[]));

                int intPrice = 0;
                Int32.TryParse(txt價格.Text, out intPrice);

                //int intamount = 0;
                //Int32.TryParse(txt價格.Text, out intamount);

                cmd.Parameters.AddWithValue("@Newpname", txt商品名稱.Text.Trim());
                cmd.Parameters.AddWithValue("@Newprice", intPrice);
                cmd.Parameters.AddWithValue("@s_id", s_id);
                //cmd.Parameters.AddWithValue("@Newamount", intamount);
                //cmd.Parameters.AddWithValue("@Newpdesc", txt商品描述.Text.Trim());
                //cmd.Parameters.AddWithValue("@NewImage", arr);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料新增完畢,{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("商品名稱必填");
            }
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);
            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
                con.Open();
                string strSQL = "delete from AddProductManagement where ap_id=@deleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@deleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show($"資料已刪除,{rows}筆資料受影響");
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn登出_Click(object sender, EventArgs e)
        {
            LoginMain loginMain = new LoginMain();
            this.Hide();
            loginMain.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn關閉_Click(object sender, EventArgs e)
        {
            
            //ProductManagement productManagement=new ProductManagement();
            //productManagement.Hide();
            Close();
            //productManagement.ShowDialog();
        }
    }
}
