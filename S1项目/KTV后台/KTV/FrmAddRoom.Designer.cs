namespace KTV
{
    partial class FrmAddRoom
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.txtLeastFee = new System.Windows.Forms.TextBox();
            this.txtHourFee = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvRoomInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "最低消费：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "但小时费用：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "房间类型：";
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Location = new System.Drawing.Point(95, 35);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(137, 21);
            this.txtRoomNum.TabIndex = 6;
            // 
            // txtLeastFee
            // 
            this.txtLeastFee.Location = new System.Drawing.Point(95, 178);
            this.txtLeastFee.Name = "txtLeastFee";
            this.txtLeastFee.Size = new System.Drawing.Size(137, 21);
            this.txtLeastFee.TabIndex = 9;
            // 
            // txtHourFee
            // 
            this.txtHourFee.Location = new System.Drawing.Point(95, 130);
            this.txtHourFee.Name = "txtHourFee";
            this.txtHourFee.Size = new System.Drawing.Size(137, 21);
            this.txtHourFee.TabIndex = 11;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(95, 76);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(137, 21);
            this.txtRoomType.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(157, 239);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvRoomInfo
            // 
            this.dgvRoomInfo.AllowUserToAddRows = false;
            this.dgvRoomInfo.AllowUserToDeleteRows = false;
            this.dgvRoomInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvRoomInfo.Location = new System.Drawing.Point(258, 43);
            this.dgvRoomInfo.Name = "dgvRoomInfo";
            this.dgvRoomInfo.ReadOnly = true;
            this.dgvRoomInfo.RowTemplate.Height = 23;
            this.dgvRoomInfo.Size = new System.Drawing.Size(358, 201);
            this.dgvRoomInfo.TabIndex = 15;
            this.dgvRoomInfo.Click += new System.EventHandler(this.dgvRoomInfo_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "roomId";
            this.Column1.HeaderText = "房间号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "roomType";
            this.Column2.HeaderText = "房间类型";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "hourRoomFee";
            this.Column3.HeaderText = "但小时费用";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "leastRoomFee";
            this.Column4.HeaderText = "最低消费";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "isEmpty";
            this.Column5.HeaderText = "是否空闲";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FrmAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 331);
            this.Controls.Add(this.dgvRoomInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtHourFee);
            this.Controls.Add(this.txtLeastFee);
            this.Controls.Add(this.txtRoomNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddRoom";
            this.Text = "添加房间";
            this.Load += new System.EventHandler(this.FrmAddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.TextBox txtLeastFee;
        private System.Windows.Forms.TextBox txtHourFee;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvRoomInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}