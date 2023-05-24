using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Imaging;
using System.Security.Policy;

namespace WindowsFormsApp3
{
    public partial class ProductManagement : Form
    {
        int s_id = StaffLogin.id;

        SqlConnectionStringBuilder scsb;//命名為scsb
        string strDBConnectionString = "";
        List<int> searchIDs = new List<int>();//儲存搜尋結果id
        string image_dir = @"C:\Users\iSpan\Desktop\adonet視窗資料庫程式20230206-2\";//圖檔目錄
        string image_path = "";
        string image_name = "";
        bool is已修改圖檔 = false;

        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            lblID.Parent = pictureBox1;

            sqlserverconnection sql = new sqlserverconnection();//class物件化
            SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);

            Success.Text = StaffLogin.loginusername;
            LoginMain LM=new LoginMain();
            LM.Close();
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if (txt商品名稱.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
                con.Open();
                string strSQL = $"select * from ProductManagement where pname like @Searchpname;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchpname", $"%{txt商品名稱.Text.Trim()}%");//幫忙檢查駭客程式碼,AddWithValue(參數名稱,$"%{txt姓名.Text}%");//Trim()去除前後空白
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["pm_id"].ToString();
                    txt商品名稱.Text = reader["pname"].ToString();
                    txt價格.Text = reader["price"].ToString();
                    txt數量.Text = reader["amount"].ToString();
                    txt商品描述.Text = reader["pdesc"].ToString();

                    //image_name = reader["pimage"].ToString();
                    //string 圖檔完整路徑 = GlobalVar.image_dir + image_name;
                    //Image img商品圖檔 = Image.FromFile(圖檔完整路徑);
                    //imageList產品圖檔.Images.Add(img商品圖檔);

                    image_name = reader["pimage"].ToString();
                    string 圖檔完整路徑 = image_dir + image_name;
                    pictureBox圖片.Image = Image.FromFile(圖檔完整路徑);

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
            txt數量.Clear();
            txt商品描述.Clear();
            pictureBox圖片.Image = null;
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);
            if ((intID > 0) && (txt商品名稱.Text != "") && (txt價格.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
                con.Open();
                string strMsg = "update ProductManagement set s_id=@s_id,pname=@Newpname,price=@Newprice,amount=@Newamount,pdesc=@Newpdesc,pimage=@Newpimage where pm_id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strMsg, con);

                cmd.Parameters.AddWithValue("@s_id", s_id);
                cmd.Parameters.AddWithValue("@Newpname", txt商品名稱.Text.Trim());
                cmd.Parameters.AddWithValue("@Newprice", txt價格.Text.Trim());
                cmd.Parameters.AddWithValue("@Newamount", txt數量.Text.Trim());
                cmd.Parameters.AddWithValue("@Newpdesc", txt商品描述.Text.Trim());

                //圖片轉byte
                //Image image = pictureBox圖片.Image;
                //byte[] arr;
                //ImageConverter converter = new ImageConverter();
                //arr = (byte[])converter.ConvertTo(image, typeof(byte[]));

                //cmd.Parameters.AddWithValue("@Newpimage", arr);
                cmd.Parameters.AddWithValue("@Newpimage", image_name);
                //txt圖片.Text = reader["pimage"].ToString();
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
                if (is已修改圖檔 == true)
                {
                    pictureBox圖片.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
                con.Open();
                string strSQL = "insert into ProductManagement values(@s_id,@Newpname,@Newprice,@Newamount,@Newpdesc,@NewImage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                //圖片轉byte
                //Image image = pictureBox圖片.Image;
                //byte[] arr;
                //ImageConverter converter = new ImageConverter();
                //arr = (byte[])converter.ConvertTo(image, typeof(byte[]));

                int intPrice=0 ;
                Int32.TryParse(txt價格.Text, out intPrice);

                int intamount=0 ;
                Int32.TryParse(txt數量.Text, out intamount);

                //int intPrice = 0;
                //Int32.TryParse(txt商品價格.Text, out intPrice);
                //cmd.Parameters.AddWithValue("@NewPrice", intPrice);

                cmd.Parameters.AddWithValue("@s_id", s_id);
                cmd.Parameters.AddWithValue("@Newpname", txt商品名稱.Text.Trim());
                cmd.Parameters.AddWithValue("@Newprice", intPrice);
                cmd.Parameters.AddWithValue("@Newamount", intamount);
                cmd.Parameters.AddWithValue("@Newpdesc", txt商品描述.Text.Trim());
                //cmd.Parameters.AddWithValue("@NewImage", arr);
                cmd.Parameters.AddWithValue("@NewImage", image_name);

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
                string strSQL = "delete from ProductManagement where pm_id=@deleteID;";
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

        private void btn選取商品圖片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "檔案類型(*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";

            Thread t = new Thread((ThreadStart)(() =>
            {
                DialogResult r = f.ShowDialog();
                if (r == DialogResult.OK)
                {
                    pictureBox圖片.Image = Image.FromFile(f.FileName);
                    //f.safefilename只有檔名
                    string 檔案副檔名 = System.IO.Path.GetExtension(f.SafeFileName);//GetExtension副檔名
                    Random myrandom = new Random();
                    image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myrandom.Next(1000, 1000).ToString() + 檔案副檔名;
                    is已修改圖檔 = true;
                    Console.WriteLine(image_name);
                }
            }
            ));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

        private void btn新增加購商品_Click(object sender, EventArgs e)
        {
            AddProduct addProduct= new AddProduct();
            addProduct.ShowDialog();
            //this.Hide();
        }

        private void btn查看營業額_Click(object sender, EventArgs e)
        {
            int strMsg =0;
            SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
            con.Open();
            string strSQL = $"select sum(money) as money from revenue; ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Searchpname", $"%{txt商品名稱.Text.Trim()}%");//幫忙檢查駭客程式碼,AddWithValue(參數名稱,$"%{txt姓名.Text}%");//Trim()去除前後空白
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                strMsg = (int)reader["money"];
            }
            //MessageBox.Show(strMsg.ToString());//驗證用
            lbl營業額.Text = $"營業額:{strMsg.ToString()}元";
            reader.Close();
            con.Close();
        }
    }
}
