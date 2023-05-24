namespace WindowsFormsApp3
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label7 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn送出 = new System.Windows.Forms.Button();
            this.btn關閉 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton顧客 = new System.Windows.Forms.RadioButton();
            this.radioButton員工 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(238, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 32);
            this.label7.TabIndex = 52;
            this.label7.Text = "註    冊";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(332, 62);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 21);
            this.lblID.TabIndex = 48;
            this.lblID.Text = "00000000";
            this.lblID.Visible = false;
            // 
            // txt密碼
            // 
            this.txt密碼.Location = new System.Drawing.Point(314, 210);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(116, 22);
            this.txt密碼.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(183, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "姓名";
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(314, 128);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(116, 22);
            this.txt姓名.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(183, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "帳號";
            // 
            // txt帳號
            // 
            this.txt帳號.Location = new System.Drawing.Point(314, 169);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(116, 22);
            this.txt帳號.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(180, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "編號";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(183, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "密碼";
            // 
            // btn送出
            // 
            this.btn送出.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn送出.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn送出.ForeColor = System.Drawing.Color.White;
            this.btn送出.Location = new System.Drawing.Point(158, 333);
            this.btn送出.Name = "btn送出";
            this.btn送出.Size = new System.Drawing.Size(89, 38);
            this.btn送出.TabIndex = 53;
            this.btn送出.Text = "送出";
            this.btn送出.UseVisualStyleBackColor = false;
            this.btn送出.Click += new System.EventHandler(this.btn送出_Click);
            // 
            // btn關閉
            // 
            this.btn關閉.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn關閉.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉.ForeColor = System.Drawing.Color.White;
            this.btn關閉.Location = new System.Drawing.Point(361, 333);
            this.btn關閉.Name = "btn關閉";
            this.btn關閉.Size = new System.Drawing.Size(89, 38);
            this.btn關閉.TabIndex = 54;
            this.btn關閉.Text = "關閉";
            this.btn關閉.UseVisualStyleBackColor = false;
            this.btn關閉.Click += new System.EventHandler(this.btn關閉_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioButton顧客);
            this.groupBox1.Controls.Add(this.radioButton員工);
            this.groupBox1.Location = new System.Drawing.Point(142, 254);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(330, 55);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // radioButton顧客
            // 
            this.radioButton顧客.AutoSize = true;
            this.radioButton顧客.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton顧客.Location = new System.Drawing.Point(218, 19);
            this.radioButton顧客.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton顧客.Name = "radioButton顧客";
            this.radioButton顧客.Size = new System.Drawing.Size(72, 26);
            this.radioButton顧客.TabIndex = 1;
            this.radioButton顧客.TabStop = true;
            this.radioButton顧客.Text = "顧客";
            this.radioButton顧客.UseVisualStyleBackColor = true;
            // 
            // radioButton員工
            // 
            this.radioButton員工.AutoSize = true;
            this.radioButton員工.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton員工.Location = new System.Drawing.Point(57, 19);
            this.radioButton員工.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton員工.Name = "radioButton員工";
            this.radioButton員工.Size = new System.Drawing.Size(72, 26);
            this.radioButton員工.TabIndex = 0;
            this.radioButton員工.TabStop = true;
            this.radioButton員工.Text = "員工";
            this.radioButton員工.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn關閉);
            this.Controls.Add(this.btn送出);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt帳號);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Register";
            this.Text = "註冊";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt姓名;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn送出;
        private System.Windows.Forms.Button btn關閉;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton顧客;
        private System.Windows.Forms.RadioButton radioButton員工;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}