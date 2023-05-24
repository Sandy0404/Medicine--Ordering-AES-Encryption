namespace WindowsFormsApp3
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt價格 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn登出 = new System.Windows.Forms.Button();
            this.Success = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.btn新增資料 = new System.Windows.Forms.Button();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn關閉 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(413, 158);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(124, 28);
            this.lblID.TabIndex = 43;
            this.lblID.Text = "00000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(245, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "商品名稱";
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.Location = new System.Drawing.Point(420, 238);
            this.txt商品名稱.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(227, 25);
            this.txt商品名稱.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(245, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 42;
            this.label3.Text = "價格";
            // 
            // txt價格
            // 
            this.txt價格.Location = new System.Drawing.Point(420, 314);
            this.txt價格.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt價格.Name = "txt價格";
            this.txt價格.Size = new System.Drawing.Size(227, 25);
            this.txt價格.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(245, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 40;
            this.label4.Text = "商品編號";
            // 
            // btn登出
            // 
            this.btn登出.BackColor = System.Drawing.Color.White;
            this.btn登出.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登出.Location = new System.Drawing.Point(853, 20);
            this.btn登出.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn登出.Name = "btn登出";
            this.btn登出.Size = new System.Drawing.Size(91, 46);
            this.btn登出.TabIndex = 48;
            this.btn登出.Text = "登出";
            this.btn登出.UseVisualStyleBackColor = false;
            this.btn登出.Click += new System.EventHandler(this.btn登出_Click);
            // 
            // Success
            // 
            this.Success.AutoSize = true;
            this.Success.BackColor = System.Drawing.Color.White;
            this.Success.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Success.Location = new System.Drawing.Point(20, 30);
            this.Success.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(123, 33);
            this.Success.TabIndex = 47;
            this.Success.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(339, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 40);
            this.label1.TabIndex = 46;
            this.label1.Text = "加購商品管理";
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn清空欄位.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.ForeColor = System.Drawing.Color.Navy;
            this.btn清空欄位.Location = new System.Drawing.Point(642, 416);
            this.btn清空欄位.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(141, 39);
            this.btn清空欄位.TabIndex = 53;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = false;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn刪除資料
            // 
            this.btn刪除資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn刪除資料.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除資料.ForeColor = System.Drawing.Color.Navy;
            this.btn刪除資料.Location = new System.Drawing.Point(492, 416);
            this.btn刪除資料.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(142, 39);
            this.btn刪除資料.TabIndex = 52;
            this.btn刪除資料.Text = "刪除資料";
            this.btn刪除資料.UseVisualStyleBackColor = false;
            this.btn刪除資料.Click += new System.EventHandler(this.btn刪除資料_Click);
            // 
            // btn新增資料
            // 
            this.btn新增資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn新增資料.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增資料.ForeColor = System.Drawing.Color.Navy;
            this.btn新增資料.Location = new System.Drawing.Point(333, 416);
            this.btn新增資料.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn新增資料.Name = "btn新增資料";
            this.btn新增資料.Size = new System.Drawing.Size(151, 39);
            this.btn新增資料.TabIndex = 51;
            this.btn新增資料.Text = "新增資料";
            this.btn新增資料.UseVisualStyleBackColor = false;
            this.btn新增資料.Click += new System.EventHandler(this.btn新增資料_Click);
            // 
            // btn資料修改
            // 
            this.btn資料修改.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn資料修改.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料修改.ForeColor = System.Drawing.Color.Navy;
            this.btn資料修改.Location = new System.Drawing.Point(176, 416);
            this.btn資料修改.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn資料修改.Name = "btn資料修改";
            this.btn資料修改.Size = new System.Drawing.Size(149, 39);
            this.btn資料修改.TabIndex = 50;
            this.btn資料修改.Text = "資料修改";
            this.btn資料修改.UseVisualStyleBackColor = false;
            this.btn資料修改.Click += new System.EventHandler(this.btn資料修改_Click);
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn資料搜尋.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料搜尋.ForeColor = System.Drawing.Color.Navy;
            this.btn資料搜尋.Location = new System.Drawing.Point(18, 416);
            this.btn資料搜尋.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(150, 39);
            this.btn資料搜尋.TabIndex = 49;
            this.btn資料搜尋.Text = "資料搜尋";
            this.btn資料搜尋.UseVisualStyleBackColor = false;
            this.btn資料搜尋.Click += new System.EventHandler(this.btn資料搜尋_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(953, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn關閉
            // 
            this.btn關閉.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn關閉.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉.ForeColor = System.Drawing.Color.Navy;
            this.btn關閉.Location = new System.Drawing.Point(793, 416);
            this.btn關閉.Margin = new System.Windows.Forms.Padding(4);
            this.btn關閉.Name = "btn關閉";
            this.btn關閉.Size = new System.Drawing.Size(143, 39);
            this.btn關閉.TabIndex = 55;
            this.btn關閉.Text = "關閉";
            this.btn關閉.UseVisualStyleBackColor = false;
            this.btn關閉.Click += new System.EventHandler(this.btn關閉_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 499);
            this.Controls.Add(this.btn關閉);
            this.Controls.Add(this.btn清空欄位);
            this.Controls.Add(this.btn刪除資料);
            this.Controls.Add(this.btn新增資料);
            this.Controls.Add(this.btn資料修改);
            this.Controls.Add(this.btn資料搜尋);
            this.Controls.Add(this.btn登出);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt價格);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProduct";
            this.Text = "加購商品";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt商品名稱;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt價格;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn登出;
        private System.Windows.Forms.Label Success;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn刪除資料;
        private System.Windows.Forms.Button btn新增資料;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn關閉;
    }
}