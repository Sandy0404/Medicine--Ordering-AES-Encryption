namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl品項總價 = new System.Windows.Forms.Label();
            this.lbl品項單價 = new System.Windows.Forms.Label();
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.listBox商品 = new System.Windows.Forms.ListBox();
            this.combo加購 = new System.Windows.Forms.ComboBox();
            this.btn加入訂購單 = new System.Windows.Forms.Button();
            this.btn查看訂購單 = new System.Windows.Forms.Button();
            this.chk買購物袋 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox說明 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Success = new System.Windows.Forms.Label();
            this.lbl會員 = new System.Windows.Forms.Label();
            this.btn登出 = new System.Windows.Forms.Button();
            this.comboBox數量 = new System.Windows.Forms.ComboBox();
            this.lbl數量 = new System.Windows.Forms.Label();
            this.pictureBox商品圖 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(273, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "藥品訂購Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "購買人(會員)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(20, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品總類";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(454, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "數量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(564, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "單價";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(652, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "品項總價";
            // 
            // lbl品項總價
            // 
            this.lbl品項總價.AutoSize = true;
            this.lbl品項總價.BackColor = System.Drawing.Color.White;
            this.lbl品項總價.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl品項總價.Location = new System.Drawing.Point(654, 391);
            this.lbl品項總價.Name = "lbl品項總價";
            this.lbl品項總價.Size = new System.Drawing.Size(79, 19);
            this.lbl品項總價.TabIndex = 9;
            this.lbl品項總價.Text = "00000元";
            // 
            // lbl品項單價
            // 
            this.lbl品項單價.AutoSize = true;
            this.lbl品項單價.BackColor = System.Drawing.Color.White;
            this.lbl品項單價.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl品項單價.Location = new System.Drawing.Point(559, 391);
            this.lbl品項單價.Name = "lbl品項單價";
            this.lbl品項單價.Size = new System.Drawing.Size(69, 19);
            this.lbl品項單價.TabIndex = 10;
            this.lbl品項單價.Text = "0000元";
            // 
            // txt訂購人
            // 
            this.txt訂購人.Location = new System.Drawing.Point(26, 93);
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.Size = new System.Drawing.Size(197, 22);
            this.txt訂購人.TabIndex = 11;
            // 
            // txt數量
            // 
            this.txt數量.Location = new System.Drawing.Point(441, 389);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(81, 22);
            this.txt數量.TabIndex = 12;
            this.txt數量.TextChanged += new System.EventHandler(this.txt杯數_TextChanged);
            // 
            // listBox商品
            // 
            this.listBox商品.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox商品.FormattingEnabled = true;
            this.listBox商品.ItemHeight = 16;
            this.listBox商品.Location = new System.Drawing.Point(25, 150);
            this.listBox商品.Name = "listBox商品";
            this.listBox商品.Size = new System.Drawing.Size(424, 148);
            this.listBox商品.TabIndex = 13;
            this.listBox商品.SelectedIndexChanged += new System.EventHandler(this.listBox商品_SelectedIndexChanged);
            // 
            // combo加購
            // 
            this.combo加購.FormattingEnabled = true;
            this.combo加購.Location = new System.Drawing.Point(270, 389);
            this.combo加購.Name = "combo加購";
            this.combo加購.Size = new System.Drawing.Size(132, 20);
            this.combo加購.TabIndex = 16;
            this.combo加購.SelectedIndexChanged += new System.EventHandler(this.combo加購_SelectedIndexChanged);
            // 
            // btn加入訂購單
            // 
            this.btn加入訂購單.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn加入訂購單.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn加入訂購單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn加入訂購單.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入訂購單.Location = new System.Drawing.Point(336, 448);
            this.btn加入訂購單.Name = "btn加入訂購單";
            this.btn加入訂購單.Size = new System.Drawing.Size(127, 31);
            this.btn加入訂購單.TabIndex = 18;
            this.btn加入訂購單.Text = "加入訂單";
            this.btn加入訂購單.UseVisualStyleBackColor = false;
            this.btn加入訂購單.Click += new System.EventHandler(this.btn加入訂購單_Click);
            // 
            // btn查看訂購單
            // 
            this.btn查看訂購單.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn查看訂購單.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn查看訂購單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn查看訂購單.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查看訂購單.Location = new System.Drawing.Point(563, 448);
            this.btn查看訂購單.Name = "btn查看訂購單";
            this.btn查看訂購單.Size = new System.Drawing.Size(135, 31);
            this.btn查看訂購單.TabIndex = 19;
            this.btn查看訂購單.Text = "查看訂購";
            this.btn查看訂購單.UseVisualStyleBackColor = false;
            this.btn查看訂購單.Click += new System.EventHandler(this.btn查看訂購單_Click);
            // 
            // chk買購物袋
            // 
            this.chk買購物袋.AutoSize = true;
            this.chk買購物袋.BackColor = System.Drawing.Color.White;
            this.chk買購物袋.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk買購物袋.Location = new System.Drawing.Point(107, 399);
            this.chk買購物袋.Name = "chk買購物袋";
            this.chk買購物袋.Size = new System.Drawing.Size(108, 23);
            this.chk買購物袋.TabIndex = 20;
            this.chk買購物袋.Text = "買購物袋";
            this.chk買購物袋.UseVisualStyleBackColor = false;
            this.chk買購物袋.Visible = false;
            this.chk買購物袋.CheckedChanged += new System.EventHandler(this.chk買購物袋_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(257, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "不限金額加購價";
            // 
            // richTextBox說明
            // 
            this.richTextBox說明.Font = new System.Drawing.Font("標楷體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox說明.Location = new System.Drawing.Point(488, 150);
            this.richTextBox說明.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox說明.Name = "richTextBox說明";
            this.richTextBox說明.Size = new System.Drawing.Size(187, 146);
            this.richTextBox說明.TabIndex = 24;
            this.richTextBox說明.Text = "";
            this.richTextBox說明.TextChanged += new System.EventHandler(this.richTextBox說明_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(590, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Success
            // 
            this.Success.AutoSize = true;
            this.Success.BackColor = System.Drawing.Color.White;
            this.Success.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Success.Location = new System.Drawing.Point(22, 26);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(82, 22);
            this.Success.TabIndex = 26;
            this.Success.Text = "label3";
            // 
            // lbl會員
            // 
            this.lbl會員.AutoSize = true;
            this.lbl會員.BackColor = System.Drawing.Color.White;
            this.lbl會員.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員.Location = new System.Drawing.Point(290, 74);
            this.lbl會員.Name = "lbl會員";
            this.lbl會員.Size = new System.Drawing.Size(80, 27);
            this.lbl會員.TabIndex = 27;
            this.lbl會員.Text = "label3";
            this.lbl會員.Visible = false;
            // 
            // btn登出
            // 
            this.btn登出.BackColor = System.Drawing.Color.White;
            this.btn登出.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登出.Location = new System.Drawing.Point(690, 22);
            this.btn登出.Margin = new System.Windows.Forms.Padding(2);
            this.btn登出.Name = "btn登出";
            this.btn登出.Size = new System.Drawing.Size(62, 26);
            this.btn登出.TabIndex = 28;
            this.btn登出.Text = "登出";
            this.btn登出.UseVisualStyleBackColor = false;
            this.btn登出.Click += new System.EventHandler(this.btn登出_Click);
            // 
            // comboBox數量
            // 
            this.comboBox數量.FormattingEnabled = true;
            this.comboBox數量.Location = new System.Drawing.Point(404, 402);
            this.comboBox數量.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox數量.Name = "comboBox數量";
            this.comboBox數量.Size = new System.Drawing.Size(31, 20);
            this.comboBox數量.TabIndex = 29;
            this.comboBox數量.Visible = false;
            this.comboBox數量.SelectedIndexChanged += new System.EventHandler(this.comboBox數量_SelectedIndexChanged);
            // 
            // lbl數量
            // 
            this.lbl數量.AutoSize = true;
            this.lbl數量.BackColor = System.Drawing.Color.White;
            this.lbl數量.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl數量.Location = new System.Drawing.Point(163, 390);
            this.lbl數量.Name = "lbl數量";
            this.lbl數量.Size = new System.Drawing.Size(19, 19);
            this.lbl數量.TabIndex = 30;
            this.lbl數量.Text = "0";
            this.lbl數量.Visible = false;
            this.lbl數量.Click += new System.EventHandler(this.lbl數量_Click);
            // 
            // pictureBox商品圖
            // 
            this.pictureBox商品圖.BackColor = System.Drawing.Color.White;
            this.pictureBox商品圖.Location = new System.Drawing.Point(40, 310);
            this.pictureBox商品圖.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox商品圖.Name = "pictureBox商品圖";
            this.pictureBox商品圖.Size = new System.Drawing.Size(212, 179);
            this.pictureBox商品圖.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox商品圖.TabIndex = 31;
            this.pictureBox商品圖.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(776, 538);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(775, 535);
            this.Controls.Add(this.pictureBox商品圖);
            this.Controls.Add(this.lbl數量);
            this.Controls.Add(this.comboBox數量);
            this.Controls.Add(this.btn登出);
            this.Controls.Add(this.lbl會員);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox說明);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chk買購物袋);
            this.Controls.Add(this.btn查看訂購單);
            this.Controls.Add(this.btn加入訂購單);
            this.Controls.Add(this.combo加購);
            this.Controls.Add(this.listBox商品);
            this.Controls.Add(this.txt數量);
            this.Controls.Add(this.txt訂購人);
            this.Controls.Add(this.lbl品項單價);
            this.Controls.Add(this.lbl品項總價);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "訂購單";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl品項總價;
        private System.Windows.Forms.Label lbl品項單價;
        private System.Windows.Forms.TextBox txt訂購人;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.ListBox listBox商品;
        private System.Windows.Forms.ComboBox combo加購;
        private System.Windows.Forms.Button btn加入訂購單;
        private System.Windows.Forms.Button btn查看訂購單;
        private System.Windows.Forms.CheckBox chk買購物袋;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox說明;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Success;
        private System.Windows.Forms.Label lbl會員;
        private System.Windows.Forms.Button btn登出;
        private System.Windows.Forms.ComboBox comboBox數量;
        private System.Windows.Forms.Label lbl數量;
        private System.Windows.Forms.PictureBox pictureBox商品圖;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

