namespace KTV
{
    partial class FrmAddSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddSong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.txtWordCount = new System.Windows.Forms.TextBox();
            this.txtAb = new System.Windows.Forms.TextBox();
            this.cmbSongType = new System.Windows.Forms.ComboBox();
            this.txtSongRoad = new System.Windows.Forms.TextBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.ofdSongRoad = new System.Windows.Forms.OpenFileDialog();
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlayCount = new System.Windows.Forms.TextBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "歌曲名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "歌曲类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "字数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "缩写：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(70, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "文件名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(70, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "歌手名：";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(294, 464);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCanel.Location = new System.Drawing.Point(411, 464);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(75, 28);
            this.btnCanel.TabIndex = 7;
            this.btnCanel.Text = "取消";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(141, 43);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(160, 21);
            this.txtSongName.TabIndex = 8;
            // 
            // txtWordCount
            // 
            this.txtWordCount.Location = new System.Drawing.Point(141, 168);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.Size = new System.Drawing.Size(160, 21);
            this.txtWordCount.TabIndex = 9;
            // 
            // txtAb
            // 
            this.txtAb.Location = new System.Drawing.Point(141, 103);
            this.txtAb.Name = "txtAb";
            this.txtAb.Size = new System.Drawing.Size(160, 21);
            this.txtAb.TabIndex = 10;
            // 
            // cmbSongType
            // 
            this.cmbSongType.FormattingEnabled = true;
            this.cmbSongType.Location = new System.Drawing.Point(141, 226);
            this.cmbSongType.Name = "cmbSongType";
            this.cmbSongType.Size = new System.Drawing.Size(160, 20);
            this.cmbSongType.TabIndex = 11;
            // 
            // txtSongRoad
            // 
            this.txtSongRoad.Location = new System.Drawing.Point(141, 371);
            this.txtSongRoad.Name = "txtSongRoad";
            this.txtSongRoad.ReadOnly = true;
            this.txtSongRoad.Size = new System.Drawing.Size(160, 21);
            this.txtSongRoad.TabIndex = 13;
            // 
            // btnBrower
            // 
            this.btnBrower.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrower.Location = new System.Drawing.Point(326, 369);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(75, 23);
            this.btnBrower.TabIndex = 14;
            this.btnBrower.Text = "浏览";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // ofdSongRoad
            // 
            this.ofdSongRoad.FileName = "openFileDialog1";
            // 
            // txtSingerName
            // 
            this.txtSingerName.Location = new System.Drawing.Point(141, 314);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.ReadOnly = true;
            this.txtSingerName.Size = new System.Drawing.Size(160, 21);
            this.txtSingerName.TabIndex = 15;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(326, 312);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "播放次数：";
            // 
            // txtPlayCount
            // 
            this.txtPlayCount.Location = new System.Drawing.Point(141, 426);
            this.txtPlayCount.Name = "txtPlayCount";
            this.txtPlayCount.ReadOnly = true;
            this.txtPlayCount.Size = new System.Drawing.Size(160, 21);
            this.txtPlayCount.TabIndex = 18;
            this.txtPlayCount.Text = "0";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(141, 272);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(160, 20);
            this.cmbLanguage.TabIndex = 20;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguage.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Location = new System.Drawing.Point(58, 275);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(82, 14);
            this.lblLanguage.TabIndex = 19;
            this.lblLanguage.Text = "歌曲语言：";
            // 
            // FrmAddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(538, 530);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.txtPlayCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtSingerName);
            this.Controls.Add(this.btnBrower);
            this.Controls.Add(this.txtSongRoad);
            this.Controls.Add(this.cmbSongType);
            this.Controls.Add(this.txtAb);
            this.Controls.Add(this.txtWordCount);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加歌曲";
            this.Load += new System.EventHandler(this.FrmAddSong_Load);
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.TextBox txtWordCount;
        private System.Windows.Forms.TextBox txtAb;
        private System.Windows.Forms.ComboBox cmbSongType;
        private System.Windows.Forms.TextBox txtSongRoad;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.OpenFileDialog ofdSongRoad;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlayCount;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblLanguage;
    }
}