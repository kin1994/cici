namespace HouTai
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRoomId = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.lblRoomFee = new System.Windows.Forms.Label();
            this.lblOtherFee = new System.Windows.Forms.Label();
            this.txtRoomFee = new System.Windows.Forms.TextBox();
            this.txtOtherFee = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnJieSuan = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Location = new System.Drawing.Point(36, 25);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(53, 12);
            this.lblRoomId.TabIndex = 0;
            this.lblRoomId.Text = "房间号：";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(403, 30);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(65, 12);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "房间类型：";
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(113, 22);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(172, 21);
            this.txtRoomId.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(746, 22);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 37);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvRoom.Location = new System.Drawing.Point(29, 87);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowTemplate.Height = 23;
            this.dgvRoom.Size = new System.Drawing.Size(801, 305);
            this.dgvRoom.TabIndex = 5;
            // 
            // lblRoomFee
            // 
            this.lblRoomFee.AutoSize = true;
            this.lblRoomFee.Location = new System.Drawing.Point(38, 411);
            this.lblRoomFee.Name = "lblRoomFee";
            this.lblRoomFee.Size = new System.Drawing.Size(41, 12);
            this.lblRoomFee.TabIndex = 6;
            this.lblRoomFee.Text = "房费：";
            // 
            // lblOtherFee
            // 
            this.lblOtherFee.AutoSize = true;
            this.lblOtherFee.Location = new System.Drawing.Point(258, 411);
            this.lblOtherFee.Name = "lblOtherFee";
            this.lblOtherFee.Size = new System.Drawing.Size(59, 12);
            this.lblOtherFee.TabIndex = 7;
            this.lblOtherFee.Text = "其他费用:";
            // 
            // txtRoomFee
            // 
            this.txtRoomFee.Location = new System.Drawing.Point(87, 408);
            this.txtRoomFee.Name = "txtRoomFee";
            this.txtRoomFee.Size = new System.Drawing.Size(103, 21);
            this.txtRoomFee.TabIndex = 8;
            // 
            // txtOtherFee
            // 
            this.txtOtherFee.Location = new System.Drawing.Point(324, 408);
            this.txtOtherFee.Name = "txtOtherFee";
            this.txtOtherFee.Size = new System.Drawing.Size(103, 21);
            this.txtOtherFee.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(488, 412);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 12);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "消费时间:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(569, 408);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(103, 21);
            this.txtTime.TabIndex = 11;
            // 
            // btnJieSuan
            // 
            this.btnJieSuan.Location = new System.Drawing.Point(728, 404);
            this.btnJieSuan.Name = "btnJieSuan";
            this.btnJieSuan.Size = new System.Drawing.Size(69, 27);
            this.btnJieSuan.TabIndex = 12;
            this.btnJieSuan.Text = "结算";
            this.btnJieSuan.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(824, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 27);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // cboRoomType
            // 
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(476, 27);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(146, 20);
            this.cboRoomType.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 467);
            this.Controls.Add(this.cboRoomType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnJieSuan);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtOtherFee);
            this.Controls.Add(this.txtRoomFee);
            this.Controls.Add(this.lblOtherFee);
            this.Controls.Add(this.lblRoomFee);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomId);
            this.Name = "Form1";
            this.Text = "房费结算";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Label lblRoomFee;
        private System.Windows.Forms.Label lblOtherFee;
        private System.Windows.Forms.TextBox txtRoomFee;
        private System.Windows.Forms.TextBox txtOtherFee;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnJieSuan;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

