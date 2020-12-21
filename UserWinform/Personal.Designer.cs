
namespace UserWinform
{
    partial class Personal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.rdoNan = new System.Windows.Forms.RadioButton();
            this.rdoNv = new System.Windows.Forms.RadioButton();
            this.comProvince = new System.Windows.Forms.ComboBox();
            this.comCity = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.BtnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(275, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "个人资料";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(162, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "年龄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(162, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(162, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "省份：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(162, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "城市：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(162, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Url:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(162, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "图片:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(253, 102);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(204, 21);
            this.txtAge.TabIndex = 7;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Age_KeyPress);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(253, 528);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(77, 24);
            this.BtnRegister.TabIndex = 8;
            this.BtnRegister.Text = "完成";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // rdoNan
            // 
            this.rdoNan.AutoSize = true;
            this.rdoNan.Location = new System.Drawing.Point(253, 171);
            this.rdoNan.Name = "rdoNan";
            this.rdoNan.Size = new System.Drawing.Size(35, 16);
            this.rdoNan.TabIndex = 9;
            this.rdoNan.TabStop = true;
            this.rdoNan.Text = "男";
            this.rdoNan.UseVisualStyleBackColor = true;
            // 
            // rdoNv
            // 
            this.rdoNv.AutoSize = true;
            this.rdoNv.Location = new System.Drawing.Point(325, 171);
            this.rdoNv.Name = "rdoNv";
            this.rdoNv.Size = new System.Drawing.Size(35, 16);
            this.rdoNv.TabIndex = 10;
            this.rdoNv.TabStop = true;
            this.rdoNv.Text = "女";
            this.rdoNv.UseVisualStyleBackColor = true;
            // 
            // comProvince
            // 
            this.comProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comProvince.FormattingEnabled = true;
            this.comProvince.Location = new System.Drawing.Point(253, 229);
            this.comProvince.Name = "comProvince";
            this.comProvince.Size = new System.Drawing.Size(204, 20);
            this.comProvince.TabIndex = 11;
            this.comProvince.SelectedIndexChanged += new System.EventHandler(this.comProvince_SelectedIndexChanged);
            // 
            // comCity
            // 
            this.comCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCity.FormattingEnabled = true;
            this.comCity.Location = new System.Drawing.Point(253, 287);
            this.comCity.Name = "comCity";
            this.comCity.Size = new System.Drawing.Size(204, 20);
            this.comCity.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(253, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(253, 475);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(204, 21);
            this.txtUrl.TabIndex = 14;
            // 
            // BtnImage
            // 
            this.BtnImage.Location = new System.Drawing.Point(253, 337);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(77, 24);
            this.BtnImage.TabIndex = 15;
            this.BtnImage.Text = "选择图片";
            this.BtnImage.UseVisualStyleBackColor = true;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 630);
            this.Controls.Add(this.BtnImage);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comCity);
            this.Controls.Add(this.comProvince);
            this.Controls.Add(this.rdoNv);
            this.Controls.Add(this.rdoNan);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Personal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.RadioButton rdoNan;
        private System.Windows.Forms.RadioButton rdoNv;
        private System.Windows.Forms.ComboBox comProvince;
        private System.Windows.Forms.ComboBox comCity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button BtnImage;
    }
}