namespace KTV
{
    partial class FrmRoot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoot));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOperatorGetRoom = new System.Windows.Forms.CheckBox();
            this.cbOperatorSongManager = new System.Windows.Forms.CheckBox();
            this.cbOperatorChangePwd = new System.Windows.Forms.CheckBox();
            this.cbOperatorQueryBook = new System.Windows.Forms.CheckBox();
            this.cbOperatorRoomMoney = new System.Windows.Forms.CheckBox();
            this.cbOperatorUpdateResource = new System.Windows.Forms.CheckBox();
            this.cbOperatorBookRoom = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCommonGetRoom = new System.Windows.Forms.CheckBox();
            this.cbCommonSongManager = new System.Windows.Forms.CheckBox();
            this.cbCommonChangePwd = new System.Windows.Forms.CheckBox();
            this.cbCommonQueryBook = new System.Windows.Forms.CheckBox();
            this.cbCommonRoomMoney = new System.Windows.Forms.CheckBox();
            this.cbCommonUpdateResource = new System.Windows.Forms.CheckBox();
            this.cbCommonBookRoom = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbOperatorGetRoom);
            this.groupBox1.Controls.Add(this.cbOperatorSongManager);
            this.groupBox1.Controls.Add(this.cbOperatorChangePwd);
            this.groupBox1.Controls.Add(this.cbOperatorQueryBook);
            this.groupBox1.Controls.Add(this.cbOperatorRoomMoney);
            this.groupBox1.Controls.Add(this.cbOperatorUpdateResource);
            this.groupBox1.Controls.Add(this.cbOperatorBookRoom);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作员权限";
            // 
            // cbOperatorGetRoom
            // 
            this.cbOperatorGetRoom.AutoSize = true;
            this.cbOperatorGetRoom.Location = new System.Drawing.Point(177, 46);
            this.cbOperatorGetRoom.Name = "cbOperatorGetRoom";
            this.cbOperatorGetRoom.Size = new System.Drawing.Size(85, 19);
            this.cbOperatorGetRoom.TabIndex = 6;
            this.cbOperatorGetRoom.Text = "KTV开房";
            this.cbOperatorGetRoom.UseVisualStyleBackColor = true;
            this.cbOperatorGetRoom.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // cbOperatorSongManager
            // 
            this.cbOperatorSongManager.AutoSize = true;
            this.cbOperatorSongManager.Location = new System.Drawing.Point(306, 46);
            this.cbOperatorSongManager.Name = "cbOperatorSongManager";
            this.cbOperatorSongManager.Size = new System.Drawing.Size(90, 19);
            this.cbOperatorSongManager.TabIndex = 5;
            this.cbOperatorSongManager.Text = "歌曲管理";
            this.cbOperatorSongManager.UseVisualStyleBackColor = true;
            this.cbOperatorSongManager.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // cbOperatorChangePwd
            // 
            this.cbOperatorChangePwd.AutoSize = true;
            this.cbOperatorChangePwd.Location = new System.Drawing.Point(438, 46);
            this.cbOperatorChangePwd.Name = "cbOperatorChangePwd";
            this.cbOperatorChangePwd.Size = new System.Drawing.Size(90, 19);
            this.cbOperatorChangePwd.TabIndex = 4;
            this.cbOperatorChangePwd.Text = "修改密码";
            this.cbOperatorChangePwd.UseVisualStyleBackColor = true;
            this.cbOperatorChangePwd.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // cbOperatorQueryBook
            // 
            this.cbOperatorQueryBook.AutoSize = true;
            this.cbOperatorQueryBook.Location = new System.Drawing.Point(46, 110);
            this.cbOperatorQueryBook.Name = "cbOperatorQueryBook";
            this.cbOperatorQueryBook.Size = new System.Drawing.Size(90, 19);
            this.cbOperatorQueryBook.TabIndex = 3;
            this.cbOperatorQueryBook.Text = "歌手管理";
            this.cbOperatorQueryBook.UseVisualStyleBackColor = true;
            this.cbOperatorQueryBook.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // cbOperatorRoomMoney
            // 
            this.cbOperatorRoomMoney.AutoSize = true;
            this.cbOperatorRoomMoney.Location = new System.Drawing.Point(177, 110);
            this.cbOperatorRoomMoney.Name = "cbOperatorRoomMoney";
            this.cbOperatorRoomMoney.Size = new System.Drawing.Size(58, 19);
            this.cbOperatorRoomMoney.TabIndex = 2;
            this.cbOperatorRoomMoney.Text = "结算";
            this.cbOperatorRoomMoney.UseVisualStyleBackColor = true;
            this.cbOperatorRoomMoney.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // cbOperatorUpdateResource
            // 
            this.cbOperatorUpdateResource.AutoSize = true;
            this.cbOperatorUpdateResource.Location = new System.Drawing.Point(306, 110);
            this.cbOperatorUpdateResource.Name = "cbOperatorUpdateResource";
            this.cbOperatorUpdateResource.Size = new System.Drawing.Size(122, 19);
            this.cbOperatorUpdateResource.TabIndex = 1;
            this.cbOperatorUpdateResource.Text = "修改资源路径";
            this.cbOperatorUpdateResource.UseVisualStyleBackColor = true;
            this.cbOperatorUpdateResource.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // cbOperatorBookRoom
            // 
            this.cbOperatorBookRoom.AutoSize = true;
            this.cbOperatorBookRoom.Location = new System.Drawing.Point(46, 46);
            this.cbOperatorBookRoom.Name = "cbOperatorBookRoom";
            this.cbOperatorBookRoom.Size = new System.Drawing.Size(90, 19);
            this.cbOperatorBookRoom.TabIndex = 0;
            this.cbOperatorBookRoom.Text = "房间结算";
            this.cbOperatorBookRoom.UseVisualStyleBackColor = true;
            this.cbOperatorBookRoom.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbCommonGetRoom);
            this.groupBox2.Controls.Add(this.cbCommonSongManager);
            this.groupBox2.Controls.Add(this.cbCommonChangePwd);
            this.groupBox2.Controls.Add(this.cbCommonQueryBook);
            this.groupBox2.Controls.Add(this.cbCommonRoomMoney);
            this.groupBox2.Controls.Add(this.cbCommonUpdateResource);
            this.groupBox2.Controls.Add(this.cbCommonBookRoom);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "普通管理员权限";
            // 
            // cbCommonGetRoom
            // 
            this.cbCommonGetRoom.AutoSize = true;
            this.cbCommonGetRoom.Location = new System.Drawing.Point(200, 51);
            this.cbCommonGetRoom.Name = "cbCommonGetRoom";
            this.cbCommonGetRoom.Size = new System.Drawing.Size(85, 19);
            this.cbCommonGetRoom.TabIndex = 13;
            this.cbCommonGetRoom.Text = "KTV开房";
            this.cbCommonGetRoom.UseVisualStyleBackColor = true;
            this.cbCommonGetRoom.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // cbCommonSongManager
            // 
            this.cbCommonSongManager.AutoSize = true;
            this.cbCommonSongManager.Location = new System.Drawing.Point(329, 51);
            this.cbCommonSongManager.Name = "cbCommonSongManager";
            this.cbCommonSongManager.Size = new System.Drawing.Size(90, 19);
            this.cbCommonSongManager.TabIndex = 12;
            this.cbCommonSongManager.Text = "歌曲管理";
            this.cbCommonSongManager.UseVisualStyleBackColor = true;
            this.cbCommonSongManager.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // cbCommonChangePwd
            // 
            this.cbCommonChangePwd.AutoSize = true;
            this.cbCommonChangePwd.Location = new System.Drawing.Point(461, 51);
            this.cbCommonChangePwd.Name = "cbCommonChangePwd";
            this.cbCommonChangePwd.Size = new System.Drawing.Size(90, 19);
            this.cbCommonChangePwd.TabIndex = 11;
            this.cbCommonChangePwd.Text = "修改密码";
            this.cbCommonChangePwd.UseVisualStyleBackColor = true;
            this.cbCommonChangePwd.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // cbCommonQueryBook
            // 
            this.cbCommonQueryBook.AutoSize = true;
            this.cbCommonQueryBook.Location = new System.Drawing.Point(69, 115);
            this.cbCommonQueryBook.Name = "cbCommonQueryBook";
            this.cbCommonQueryBook.Size = new System.Drawing.Size(90, 19);
            this.cbCommonQueryBook.TabIndex = 10;
            this.cbCommonQueryBook.Text = "歌手管理";
            this.cbCommonQueryBook.UseVisualStyleBackColor = true;
            this.cbCommonQueryBook.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // cbCommonRoomMoney
            // 
            this.cbCommonRoomMoney.AutoSize = true;
            this.cbCommonRoomMoney.Location = new System.Drawing.Point(200, 115);
            this.cbCommonRoomMoney.Name = "cbCommonRoomMoney";
            this.cbCommonRoomMoney.Size = new System.Drawing.Size(58, 19);
            this.cbCommonRoomMoney.TabIndex = 9;
            this.cbCommonRoomMoney.Text = "结算";
            this.cbCommonRoomMoney.UseVisualStyleBackColor = true;
            this.cbCommonRoomMoney.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // cbCommonUpdateResource
            // 
            this.cbCommonUpdateResource.AutoSize = true;
            this.cbCommonUpdateResource.Location = new System.Drawing.Point(329, 115);
            this.cbCommonUpdateResource.Name = "cbCommonUpdateResource";
            this.cbCommonUpdateResource.Size = new System.Drawing.Size(122, 19);
            this.cbCommonUpdateResource.TabIndex = 8;
            this.cbCommonUpdateResource.Text = "修改资源路径";
            this.cbCommonUpdateResource.UseVisualStyleBackColor = true;
            this.cbCommonUpdateResource.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // cbCommonBookRoom
            // 
            this.cbCommonBookRoom.AutoSize = true;
            this.cbCommonBookRoom.Location = new System.Drawing.Point(69, 51);
            this.cbCommonBookRoom.Name = "cbCommonBookRoom";
            this.cbCommonBookRoom.Size = new System.Drawing.Size(90, 19);
            this.cbCommonBookRoom.TabIndex = 7;
            this.cbCommonBookRoom.Text = "房间结算";
            this.cbCommonBookRoom.UseVisualStyleBackColor = true;
            this.cbCommonBookRoom.CheckedChanged += new System.EventHandler(this.cbOperator_CheckedChanged);
            // 
            // FrmRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "权限管理";
            this.Load += new System.EventHandler(this.FrmRoot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbOperatorGetRoom;
        private System.Windows.Forms.CheckBox cbOperatorSongManager;
        private System.Windows.Forms.CheckBox cbOperatorChangePwd;
        private System.Windows.Forms.CheckBox cbOperatorQueryBook;
        private System.Windows.Forms.CheckBox cbOperatorRoomMoney;
        private System.Windows.Forms.CheckBox cbOperatorUpdateResource;
        private System.Windows.Forms.CheckBox cbOperatorBookRoom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbCommonGetRoom;
        private System.Windows.Forms.CheckBox cbCommonSongManager;
        private System.Windows.Forms.CheckBox cbCommonChangePwd;
        private System.Windows.Forms.CheckBox cbCommonQueryBook;
        private System.Windows.Forms.CheckBox cbCommonRoomMoney;
        private System.Windows.Forms.CheckBox cbCommonUpdateResource;
        private System.Windows.Forms.CheckBox cbCommonBookRoom;
    }
}