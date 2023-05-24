namespace WindowsFormsApp3
{
    partial class FormOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderList));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl訂購人資料 = new System.Windows.Forms.Label();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.list訂購品項明細 = new System.Windows.Forms.ListBox();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.btn輸出訂購單 = new System.Windows.Forms.Button();
            this.lbl購物袋 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn關閉表單 = new System.Windows.Forms.Button();
            this.lbl折扣 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn回到訂購單 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(214, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂購品項列表(購物車結帳單)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl訂購人資料
            // 
            this.lbl訂購人資料.AutoSize = true;
            this.lbl訂購人資料.BackColor = System.Drawing.Color.White;
            this.lbl訂購人資料.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人資料.Location = new System.Drawing.Point(31, 75);
            this.lbl訂購人資料.Name = "lbl訂購人資料";
            this.lbl訂購人資料.Size = new System.Drawing.Size(135, 24);
            this.lbl訂購人資料.TabIndex = 1;
            this.lbl訂購人資料.Text = "訂購人資料";
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.AutoSize = true;
            this.lbl訂單總價.BackColor = System.Drawing.Color.White;
            this.lbl訂單總價.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.Location = new System.Drawing.Point(497, 357);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(200, 24);
            this.lbl訂單總價.TabIndex = 2;
            this.lbl訂單總價.Text = "訂單總價00000元";
            // 
            // list訂購品項明細
            // 
            this.list訂購品項明細.BackColor = System.Drawing.Color.LightYellow;
            this.list訂購品項明細.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.list訂購品項明細.FormattingEnabled = true;
            this.list訂購品項明細.ItemHeight = 16;
            this.list訂購品項明細.Location = new System.Drawing.Point(24, 118);
            this.list訂購品項明細.Name = "list訂購品項明細";
            this.list訂購品項明細.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list訂購品項明細.Size = new System.Drawing.Size(812, 212);
            this.list訂購品項明細.TabIndex = 3;
            this.list訂購品項明細.SelectedIndexChanged += new System.EventHandler(this.list訂購品項列表_SelectedIndexChanged);
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.BackColor = System.Drawing.Color.PeachPuff;
            this.btn移除所選品項.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn移除所選品項.FlatAppearance.BorderSize = 0;
            this.btn移除所選品項.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn移除所選品項.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.ForeColor = System.Drawing.Color.Black;
            this.btn移除所選品項.Location = new System.Drawing.Point(67, 413);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(156, 33);
            this.btn移除所選品項.TabIndex = 4;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = false;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.BackColor = System.Drawing.Color.PeachPuff;
            this.btn清除所有品項.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn清除所有品項.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn清除所有品項.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.Location = new System.Drawing.Point(302, 413);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(161, 33);
            this.btn清除所有品項.TabIndex = 5;
            this.btn清除所有品項.Text = "清除所有品項";
            this.btn清除所有品項.UseVisualStyleBackColor = false;
            this.btn清除所有品項.Click += new System.EventHandler(this.btn清除所有品項_Click);
            // 
            // btn輸出訂購單
            // 
            this.btn輸出訂購單.BackColor = System.Drawing.Color.PeachPuff;
            this.btn輸出訂購單.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn輸出訂購單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn輸出訂購單.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn輸出訂購單.Location = new System.Drawing.Point(65, 465);
            this.btn輸出訂購單.Name = "btn輸出訂購單";
            this.btn輸出訂購單.Size = new System.Drawing.Size(161, 33);
            this.btn輸出訂購單.TabIndex = 6;
            this.btn輸出訂購單.Text = "輸出訂購單";
            this.btn輸出訂購單.UseVisualStyleBackColor = false;
            this.btn輸出訂購單.Click += new System.EventHandler(this.btn輸出訂購單_Click);
            // 
            // lbl購物袋
            // 
            this.lbl購物袋.AutoSize = true;
            this.lbl購物袋.BackColor = System.Drawing.Color.White;
            this.lbl購物袋.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl購物袋.Location = new System.Drawing.Point(40, 357);
            this.lbl購物袋.Name = "lbl購物袋";
            this.lbl購物袋.Size = new System.Drawing.Size(110, 24);
            this.lbl購物袋.TabIndex = 22;
            this.lbl購物袋.Text = "買購物袋";
            this.lbl購物袋.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(10, 499);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "折扣活動";
            this.groupBox1.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(101, 22);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "無折扣";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "第二件半價";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "打八折";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "買二送一";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn關閉表單
            // 
            this.btn關閉表單.BackColor = System.Drawing.Color.PeachPuff;
            this.btn關閉表單.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn關閉表單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn關閉表單.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉表單.Location = new System.Drawing.Point(302, 465);
            this.btn關閉表單.Name = "btn關閉表單";
            this.btn關閉表單.Size = new System.Drawing.Size(161, 33);
            this.btn關閉表單.TabIndex = 24;
            this.btn關閉表單.Text = "關閉表單";
            this.btn關閉表單.UseVisualStyleBackColor = false;
            this.btn關閉表單.Click += new System.EventHandler(this.btn關閉表單_Click);
            // 
            // lbl折扣
            // 
            this.lbl折扣.AutoSize = true;
            this.lbl折扣.BackColor = System.Drawing.Color.White;
            this.lbl折扣.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl折扣.Location = new System.Drawing.Point(203, 357);
            this.lbl折扣.Name = "lbl折扣";
            this.lbl折扣.Size = new System.Drawing.Size(150, 24);
            this.lbl折扣.TabIndex = 25;
            this.lbl折扣.Text = "折扣00000元";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btn回到訂購單
            // 
            this.btn回到訂購單.BackColor = System.Drawing.Color.PeachPuff;
            this.btn回到訂購單.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn回到訂購單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn回到訂購單.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回到訂購單.Location = new System.Drawing.Point(219, 514);
            this.btn回到訂購單.Name = "btn回到訂購單";
            this.btn回到訂購單.Size = new System.Drawing.Size(161, 33);
            this.btn回到訂購單.TabIndex = 27;
            this.btn回到訂購單.Text = "回到訂購單";
            this.btn回到訂購單.UseVisualStyleBackColor = false;
            this.btn回到訂購單.Visible = false;
            this.btn回到訂購單.Click += new System.EventHandler(this.btn回到訂購單_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(864, 592);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(864, 589);
            this.Controls.Add(this.btn輸出訂購單);
            this.Controls.Add(this.btn回到訂購單);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl折扣);
            this.Controls.Add(this.btn關閉表單);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl購物袋);
            this.Controls.Add(this.btn清除所有品項);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.list訂購品項明細);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.lbl訂購人資料);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormOrderList";
            this.Text = "訂購品項明細";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrderList_FormClosing);
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl訂購人資料;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.ListBox list訂購品項明細;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.Button btn輸出訂購單;
        private System.Windows.Forms.Label lbl購物袋;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn關閉表單;
        private System.Windows.Forms.Label lbl折扣;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn回到訂購單;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}