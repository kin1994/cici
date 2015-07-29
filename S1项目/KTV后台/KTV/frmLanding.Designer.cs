namespace KTV
{
    partial class frmLanding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLanding));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnQingKong = new System.Windows.Forms.Button();
            this.txtYanzhen = new System.Windows.Forms.TextBox();
            this.lblYanzhen = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picValidWord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValidWord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(594, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 25);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQingKong
            // 
            this.btnQingKong.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQingKong.Location = new System.Drawing.Point(476, 419);
            this.btnQingKong.Name = "btnQingKong";
            this.btnQingKong.Size = new System.Drawing.Size(81, 25);
            this.btnQingKong.TabIndex = 29;
            this.btnQingKong.Text = "清空";
            this.btnQingKong.UseVisualStyleBackColor = true;
            this.btnQingKong.Click += new System.EventHandler(this.btnQingKong_Click);
            // 
            // txtYanzhen
            // 
            this.txtYanzhen.Location = new System.Drawing.Point(443, 364);
            this.txtYanzhen.Name = "txtYanzhen";
            this.txtYanzhen.Size = new System.Drawing.Size(88, 21);
            this.txtYanzhen.TabIndex = 28;
            // 
            // lblYanzhen
            // 
            this.lblYanzhen.AutoSize = true;
            this.lblYanzhen.BackColor = System.Drawing.Color.Transparent;
            this.lblYanzhen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblYanzhen.Location = new System.Drawing.Point(362, 367);
            this.lblYanzhen.Name = "lblYanzhen";
            this.lblYanzhen.Size = new System.Drawing.Size(47, 12);
            this.lblYanzhen.TabIndex = 27;
            this.lblYanzhen.Text = "验证码:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(347, 419);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(81, 25);
            this.btnLogin.TabIndex = 26;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(443, 314);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(142, 20);
            this.cboType.TabIndex = 25;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(443, 262);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(142, 21);
            this.txtPwd.TabIndex = 24;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(443, 210);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(142, 21);
            this.txtUserName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(353, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "登录类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(377, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(365, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "用户名：";
            // 
            // picValidWord
            // 
            this.picValidWord.BackColor = System.Drawing.Color.White;
            this.picValidWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picValidWord.Location = new System.Drawing.Point(547, 353);
            this.picValidWord.Name = "picValidWord";
            this.picValidWord.Size = new System.Drawing.Size(116, 38);
            this.picValidWord.TabIndex = 31;
            this.picValidWord.TabStop = false;
            this.picValidWord.Click += new System.EventHandler(this.picValidWord_Click);
            // 
            // frmLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 463);
            this.Controls.Add(this.picValidWord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQingKong);
            this.Controls.Add(this.txtYanzhen);
            this.Controls.Add(this.lblYanzhen);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLanding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV欢迎你";
            this.Load += new System.EventHandler(this.frmLanding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picValidWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnQingKong;
        private System.Windows.Forms.TextBox txtYanzhen;
        private System.Windows.Forms.Label lblYanzhen;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picValidWord;
    }
}