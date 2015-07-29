namespace KTV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRoomFee = new System.Windows.Forms.Label();
            this.lblOtherFee = new System.Windows.Forms.Label();
            this.txtRoomFee = new System.Windows.Forms.TextBox();
            this.txtOtherFee = new System.Windows.Forms.TextBox();
            this.txtTotalFee = new System.Windows.Forms.TextBox();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.btnColse = new System.Windows.Forms.Button();
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
            this.lblRoomType.Size = new System.Drawing.Size(41, 12);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "时间：";
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
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dgvRoom.Location = new System.Drawing.Point(29, 87);
            this.dgvRoom.MultiSelect = false;
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowTemplate.Height = 23;
            this.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoom.Size = new System.Drawing.Size(801, 305);
            this.dgvRoom.TabIndex = 5;
            this.dgvRoom.Click += new System.EventHandler(this.dgvRoom_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Openid";
            this.Column1.HeaderText = "订单号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "roomid";
            this.Column4.HeaderText = "房间号";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "opendata";
            this.Column2.HeaderText = "开房时间";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "closedate";
            dataGridViewCellStyle7.NullValue = "正在使用中";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column3.HeaderText = "退房时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "RoomFee";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column5.HeaderText = "房费";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "OtherFee";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column6.HeaderText = "其他费用";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
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
            // txtTotalFee
            // 
            this.txtTotalFee.Location = new System.Drawing.Point(569, 408);
            this.txtTotalFee.Name = "txtTotalFee";
            this.txtTotalFee.Size = new System.Drawing.Size(103, 21);
            this.txtTotalFee.TabIndex = 11;
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "全部",
            "一周之内",
            "一月之内",
            "半年之内"});
            this.cboTime.Location = new System.Drawing.Point(476, 27);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(146, 20);
            this.cboTime.TabIndex = 14;
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Location = new System.Drawing.Point(504, 411);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(41, 12);
            this.lblTotalFee.TabIndex = 15;
            this.lblTotalFee.Text = "合计：";
            // 
            // btnColse
            // 
            this.btnColse.Location = new System.Drawing.Point(745, 411);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(85, 29);
            this.btnColse.TabIndex = 16;
            this.btnColse.Text = "关闭";
            this.btnColse.UseVisualStyleBackColor = true;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 467);
            this.Controls.Add(this.btnColse);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.txtTotalFee);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox txtTotalFee;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

