using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class FormOrderList : Form
    {
        int c_id = CustomerLogin.id;
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

        sqlserverconnection sql = new sqlserverconnection();//class物件化
        SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
        public string 訂購人資訊 = "";
        int 訂單總價原始價差 = 0;
        int 訂單總價 = 0;
        string 商品 = "";
        int 單價 = 0;
        int 數量 = 0;
        int 商品總價 = 0;
        string 加購 = "";
        int 加購價格 = 0;

        public FormOrderList()
        {
            InitializeComponent();
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            lbl訂購人資料.Text = 訂購人資訊;
            lbl訂購人資料.Text = "購買人(會員):"+GlobalVar.訂購人資訊;//全域變數
            
            foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資料)
            {
                商品 = (string)訂購品項[0];
                單價 = (int)訂購品項[1];
                數量 = (int)訂購品項[2];
                商品總價 = (int)訂購品項[3];
                加購 = (string)訂購品項[4];
                加購價格 = (int)訂購品項[5];

                string 單品資料 = "";
                //指定品項買二送一
                if (商品 == "維他命C")
                {
                    數量 += (數量 / 2);
                    單品資料 = string.Format("商品:{0}, 單價:{1}元, 數量:{2},  品項總價:{3}元, 加購商品:{4}{5}元", 商品, 單價, 數量, 商品總價, 加購, 加購價格);
                }
                else
                {
                    單品資料 = string.Format("商品:{0}, 單價:{1}元, 數量:{2},  品項總價:{3}元, 加購商品:{4}{5}元", 商品, 單價, 數量, 商品總價, 加購, 加購價格);
                }
                list訂購品項明細.Items.Add(單品資料);
            }
            計算訂單總價();
        }

        void 計算訂單總價()
        {
            //int 訂單總價 = 0;
            string 商品 = "";
            int 單價;
            int 數量 ;
            int 商品總價 = 0;
            string 加購;
            foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資料)
            {
                商品 = (string)訂購品項[0];
                單價 = (int)訂購品項[1];
                數量 = (int)訂購品項[2];
                商品總價 = (int)訂購品項[3];
                加購 = (string)訂購品項[4];
                int 加購價格 = (int)訂購品項[5];
                訂單總價 += 商品總價;
            }
            //滿300打八折
            if (訂單總價 >= 300 && ((GlobalVar.is購物袋 == true) && (GlobalVar.list訂購品項資料.Count > 0)))
            {
                訂單總價 = (int)(訂單總價 * 0.8)+3;
                訂單總價原始價差 = (int)(訂單總價 / 0.8) - 訂單總價;
                lbl訂單總價.Text = String.Format("訂單總價:{0}元", 訂單總價);
                lbl折扣.Text = String.Format("滿300折扣:-{0}元", 訂單總價原始價差);
                lbl購物袋.Text = "買購物袋";
            }
            else if (訂單總價 >= 300 && ((GlobalVar.is購物袋 == false) && (GlobalVar.list訂購品項資料.Count > 0)))
            {
                訂單總價 = (int)(訂單總價 * 0.8);
                訂單總價原始價差 = (int)(訂單總價 / 0.8) - 訂單總價;
                lbl訂單總價.Text = String.Format("訂單總價:{0}元", 訂單總價);
                lbl折扣.Text = String.Format("滿300折扣:-{0}元", 訂單總價原始價差);
                lbl購物袋.Text = " ";
            }
            else
            {
                lbl訂單總價.Text = String.Format("訂單總價:{0}元", 訂單總價);
                lbl折扣.Text = String.Format("滿300折扣:0元");
            }
        }

        private void list訂購品項列表_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            //多選
            if (list訂購品項明細.SelectedIndices.Count > 0)//index複數
            {
                for (int i= (list訂購品項明細.SelectedIndices.Count-1); i>=0; i--)
                {//SelectedIndices由小排到大     索引每刪掉一個list就會重整一次   所以要重後面開始刪不能重前面開始刪
                    GlobalVar.list訂購品項資料.RemoveAt(list訂購品項明細.SelectedIndices[i]);
                    list訂購品項明細.Items.RemoveAt(list訂購品項明細.SelectedIndices[i]);
                }
                計算訂單總價();
            }
            else
            {
                MessageBox.Show("請選擇移除品項");
            }
        }

        //練習
        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
                list訂購品項明細.Items.Clear();
                GlobalVar.list訂購品項資料.Clear();
                GlobalVar.訂購人資訊 = "";
                GlobalVar.is購物袋 = false;
                lbl訂購人資料.Text = "";
                計算訂單總價();
        }

        private void btn輸出訂購單_Click(object sender, EventArgs e)
        {
            foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資料)
            {
                訂購人資訊 = GlobalVar.訂購人資訊;
                商品 = (string)訂購品項[0];
                單價 = (int)訂購品項[1];
                數量 = (int)訂購品項[2];
                商品總價 = (int)訂購品項[3];
                加購 = (string)訂購品項[4];
                加購價格 = (int)訂購品項[5];
                string 單品資料 = "";
                //指定品項買二送一
                if (商品 == "維他命C")
                {
                    數量 += (數量 / 2);
                }
                //進資料庫
                sqlserverconnection sql = new sqlserverconnection();//class物件化
                SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
                //新增進資料庫
                con.Open();
                string strSQL = "insert into Orderlist values(@c_id,@NewCustomerName,@Newpname,@Newprice,@Newamount,@NewTotalPrice,@NewAddPname,@NewAddPrice,@Newdate); " + "UPDATE ProductManagement SET amount=amount-@Newamount WHERE pname=@Newpname;" + "insert into revenue values(@c_id, @discount, @money,@Newdate); ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@c_id", c_id);
                cmd.Parameters.AddWithValue("@NewCustomerName", 訂購人資訊);
                cmd.Parameters.AddWithValue("@Newpname", 商品);
                cmd.Parameters.AddWithValue("@Newprice", 單價);
                cmd.Parameters.AddWithValue("@Newamount", 數量);
                cmd.Parameters.AddWithValue("@NewTotalPrice", 商品總價);
                cmd.Parameters.AddWithValue("@NewAddPname", 加購);
                cmd.Parameters.AddWithValue("@NewAddPrice", 加購價格);
                cmd.Parameters.AddWithValue("@Newdate", date);
                cmd.Parameters.AddWithValue("@discount", 訂單總價原始價差);//打8哲所扣掉金額
                cmd.Parameters.AddWithValue("@money", 訂單總價);//實收金額
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料新增完畢,{rows}筆資料受影響");
            }
            //設定PDF的名稱
            Random myRnd = new Random();
            int rndNum = myRnd.Next(1000, 10000);
            string str檔名 = $"{DateTime.Now.ToString("yyMMddHHmmss")}{rndNum}{GlobalVar.訂購人資訊}的訂單.pdf";

            //設定中文字體           
            string fontsfolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Fonts);
            string chFontPath = fontsfolder + "\\KAIU.ttf";//windows內建的SimHei字體(中易黑體)                            
            BaseFont chBaseFont = BaseFont.CreateFont(chFontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            Phrase helloPhrase = new Phrase();
            iTextSharp.text.Font twFont = new iTextSharp.text.Font(chBaseFont, 14);
            iTextSharp.text.Font twFont_bold = new iTextSharp.text.Font(chBaseFont, 14, 1);

            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(new float[] { 2, 1, 1, 1, 1, 1 });
            pdfTable.DefaultCell.Padding = 4;
            pdfTable.AddCell(new Paragraph("商品名稱", twFont_bold));
            pdfTable.AddCell(new Paragraph("單價", twFont_bold));
            pdfTable.AddCell(new Paragraph("數量", twFont_bold));
            pdfTable.AddCell(new Paragraph("商品總價", twFont_bold));
            pdfTable.AddCell(new Paragraph("加購", twFont_bold));
            pdfTable.AddCell(new Paragraph("加購價格", twFont_bold));
            foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資料)
            {
                商品 = (string)訂購品項[0];
                單價 = (int)訂購品項[1];
                數量 = (int)訂購品項[2];
                商品總價 = (int)訂購品項[3];
                加購 = (string)訂購品項[4];
                加購價格 = (int)訂購品項[5];
                pdfTable.AddCell(new Paragraph($"{商品}", twFont));
                pdfTable.AddCell(new Paragraph($"{單價}", twFont));
                //指定品項買二送一
                if (商品 == "維他命C")
                {
                    數量 += (數量 / 2);
                }
                pdfTable.AddCell(new Paragraph($"{數量}", twFont));
                pdfTable.AddCell(new Paragraph($"{商品總價}", twFont));
                pdfTable.AddCell(new Paragraph($"{加購}", twFont));
                pdfTable.AddCell(new Paragraph($"{加購價格}", twFont));
            }
            List<string> list訂單資訊 = new List<string>();
            foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資料)
            {
                商品 = (string)訂購品項[0];
                單價 = (int)訂購品項[1];
                數量 = (int)訂購品項[2];
                商品總價 = (int)訂購品項[3];
                加購 = (string)訂購品項[4];
                加購價格 = (int)訂購品項[5];
            }
            if (GlobalVar.is購物袋 == true)
            {
                list訂單資訊.Add($"{lbl購物袋.Text}:3元 ");
            }
            else
            {
                list訂單資訊.Add("");
            }
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Exporting to PDF
            //string folderPath = Environment.CurrentDirectory + "\\";
            string folderPath = @"C:\PDF\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + str檔名, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 50, 50, 25, 0);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                iTextSharp.text.Font twFont1 = new iTextSharp.text.Font(chBaseFont, 20);
                var paragraph = new Paragraph($"藥品購買明細\n\n", twFont1);
                paragraph.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(paragraph);

                pdfDoc.Add(new Paragraph($"購買時間:{DateTime.Now.ToString()}\n\n", twFont));
                pdfDoc.Add(new Paragraph($"客戶姓名:{GlobalVar.訂購人資訊,-30}\n\n", twFont));
                pdfDoc.Add(pdfTable);

                foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資料)
                {
                    商品 = (string)訂購品項[0];
                    數量 = (int)訂購品項[2];
                    //有邏輯bug
                    if ((商品 == "維他命C" && 數量 > 1) && (商品 == "衛生紙" && 數量 > 1))
                    {
                        pdfDoc.Add(new Paragraph($"維他命C買兩瓶送一瓶\n\n", twFont));
                        pdfDoc.Add(new Paragraph($"折扣:衛生紙第二件半價 \n\n", twFont));//金額:-45
                    }
                    else if (商品 == "衛生紙" && 數量 > 1)
                    {
                        pdfDoc.Add(new Paragraph($"折扣:衛生紙第二件半價 \n\n", twFont));//金額:-45
                    }
                    else if (商品 == "維他命C" && 數量 > 1)
                    {
                        pdfDoc.Add(new Paragraph($"維他命C買兩瓶送一瓶\n\n", twFont));
                    }
                }
                pdfDoc.Add(new Paragraph($"8折折扣:-{訂單總價原始價差}元\n\n", twFont));
                pdfDoc.Add(new Paragraph($"總計:{訂單總價}元\n\n", twFont));
                pdfDoc.Close();
                stream.Close();
                System.Diagnostics.Process.Start(@"C:\PDF\" + str檔名);
            }

            //資料清空
            GlobalVar.訂購人資訊 = "";
            list訂購品項明細.Items.Clear();
            lbl訂單總價.Text = "";
            lbl折扣.Text = "";
            Close();
            MessageBox.Show("存檔成功");
            Sucess success = new Sucess();
            this.Hide();
            success.ShowDialog();
        }

        private void btn關閉表單_Click(object sender, EventArgs e)
        {
            //foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資料)
            //{
            //    訂購人資訊 = GlobalVar.訂購人資訊;
            //    商品 = (string)訂購品項[0];
            //    單價 = (int)訂購品項[1];
            //    數量 = (int)訂購品項[2];
            //    商品總價 = (int)訂購品項[3];
            //    加購 = (string)訂購品項[4];
            //    加購價格 = (int)訂購品項[5];
            //    sqlserverconnection sql = new sqlserverconnection();//class物件化
            //    SqlConnection con = new SqlConnection(GlobalVar1.strMyDBConnectionString);
            //    //新增進資料庫
            //        con.Open();
            //        string strSQL = "insert into Orderlist values(@NewCustomerName,@Newpname,@Newprice,@Newamount,@NewTotalPrice,@NewAddPname,@NewAddPrice,1); ";
            //        SqlCommand cmd = new SqlCommand(strSQL, con);

            //        cmd.Parameters.AddWithValue("@NewCustomerName", 訂購人資訊);
            //        cmd.Parameters.AddWithValue("@Newpname", 商品);
            //        cmd.Parameters.AddWithValue("@Newprice", 單價);
            //        cmd.Parameters.AddWithValue("@Newamount", 數量);
            //        cmd.Parameters.AddWithValue("@NewTotalPrice", 商品總價);
            //        cmd.Parameters.AddWithValue("@NewAddPname", 加購);
            //        cmd.Parameters.AddWithValue("@NewAddPrice", 加購價格);
            //        int rows = cmd.ExecuteNonQuery();
            //        con.Close();
            //        MessageBox.Show($"資料新增完畢,{rows}筆資料受影響");
            //    Close();//可儲存資料
            //}
            //string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //MessageBox.Show(date);
            Close();
        }

        private void FormOrderList_FormClosing(object sender, FormClosingEventArgs e)//關閉ing
        {
            DialogResult R = MessageBox.Show("你要確定關閉表單","關閉表單確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question);//MessageBox.Show有回傳直  MessageBoxIcon.Question:圖示

            if (R == DialogResult.Yes)
            {
                e.Cancel = false;//close
            }
            else
            {
                e.Cancel = true;//cancel
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn回到訂購單_Click(object sender, EventArgs e)
        {
            //Form1 form= new Form1();
            //this.Hide();
            //form.ShowDialog();
            //form.txt訂購人
            //string date = DateTime.Now.Tostring("yyyy-MM-dd hh:mm:ss");
            
        }
    }
}
