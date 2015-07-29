namespace KTV
{
    partial class Room
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
            this.lblFangHao = new System.Windows.Forms.Label();
            this.txtFangHao = new System.Windows.Forms.TextBox();
            this.btnQuay = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFangFei = new System.Windows.Forms.Label();
            this.lblHeJi = new System.Windows.Forms.Label();
            this.txtFangFei = new System.Windows.Forms.TextBox();
            this.txtHeJi = new System.Windows.Forms.TextBox();
            this.txtJiuFei = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFangHao
            // 
            this.lblFangHao.AutoSize = true;
            this.lblFangHao.Location = new System.Drawing.Point(55, 36);
            this.lblFangHao.Name = "lblFangHao";
            this.lblFangHao.Size = new System.Drawing.Size(41, 12);
            this.lblFangHao.TabIndex = 0;
            this.lblFangHao.Text = "房间号";
            // 
            // txtFangHao
            // 
            this.txtFangHao.Location = new System.Drawing.Point(109, 33);
            this.txtFangHao.Name = "txtFangHao";
            this.txtFangHao.Size = new System.Drawing.Size(139, 21);
            this.txtFangHao.TabIndex = 1;
            // 
            // btnQuay
            // 
            this.btnQuay.Location = new System.Drawing.Point(507, 30);
            this.btnQuay.Name = "btnQuay";
            this.btnQuay.Size = new System.Drawing.Size(75, 23);
            this.btnQuay.TabIndex = 2;
            this.btnQuay.Text = "查询";
            this.btnQuay.UseVisualStyleBackColor = true;
            this.btnQuay.Click += new System.EventHandler(this.btnQuay_Click);
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
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvRoom.Location = new System.Drawing.Point(34, 77);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowTemplate.Height = 23;
            this.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoom.Size = new System.Drawing.Size(543, 254);
            this.dgvRoom.TabIndex = 3;
            this.dgvRoom.Click += new System.EventHandler(this.dgvRoom_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomerName";
            this.Column1.HeaderText = "开房姓名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "RoomId";
            this.Column2.HeaderText = "房间号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "isPay";
            this.Column3.HeaderText = "消费数据";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RoomFee";
            this.Column4.HeaderText = "房间消费";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "OtherFee";
            this.Column5.HeaderText = "酒水消费";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "roomtype";
            this.Column6.HeaderText = "roomtype";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // lblFangFei
            // 
            this.lblFangFei.AutoSize = true;
            this.lblFangFei.Location = new System.Drawing.Point(64, 372);
            this.lblFangFei.Name = "lblFangFei";
            this.lblFangFei.Size = new System.Drawing.Size(53, 12);
            this.lblFangFei.TabIndex = 4;
            this.lblFangFei.Text = "房间消费";
            // 
            // lblHeJi
            // 
            this.lblHeJi.AutoSize = true;
            this.lblHeJi.Location = new System.Drawing.Point(64, 431);
            this.lblHeJi.Name = "lblHeJi";
            this.lblHeJi.Size = new System.Drawing.Size(29, 12);
            this.lblHeJi.TabIndex = 5;
            this.lblHeJi.Text = "合计";
            // 
            // txtFangFei
            // 
            this.txtFangFei.Location = new System.Drawing.Point(121, 369);
            this.txtFangFei.Name = "txtFangFei";
            this.txtFangFei.Size = new System.Drawing.Size(127, 21);
            this.txtFangFei.TabIndex = 6;
            // 
            // txtHeJi
            // 
            this.txtHeJi.Location = new System.Drawing.Point(121, 428);
            this.txtHeJi.Name = "txtHeJi";
            this.txtHeJi.Size = new System.Drawing.Size(127, 21);
            this.txtHeJi.TabIndex = 7;
            // 
            // txtJiuFei
            // 
            this.txtJiuFei.Location = new System.Drawing.Point(340, 369);
            this.txtJiuFei.Name = "txtJiuFei";
            this.txtJiuFei.Size = new System.Drawing.Size(127, 21);
            this.txtJiuFei.TabIndex = 9;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(283, 372);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 12);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "酒水消费";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(474, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "关闭";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(271, 39);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 12);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "房间类型";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(336, 33);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(152, 20);
            this.cmbRoomType.TabIndex = 13;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 474);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtJiuFei);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtHeJi);
            this.Controls.Add(this.txtFangFei);
            this.Controls.Add(this.lblHeJi);
            this.Controls.Add(this.lblFangFei);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.btnQuay);
            this.Controls.Add(this.txtFangHao);
            this.Controls.Add(this.lblFangHao);
            this.Name = "Room";
            this.Text = "账单查询";
            this.Load += new System.EventHandler(this.Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFangHao;
        private System.Windows.Forms.TextBox txtFangHao;
        private System.Windows.Forms.Button btnQuay;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Label lblFangFei;
        private System.Windows.Forms.Label lblHeJi;
        private System.Windows.Forms.TextBox txtFangFei;
        private System.Windows.Forms.TextBox txtHeJi;
        private System.Windows.Forms.TextBox txtJiuFei;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}