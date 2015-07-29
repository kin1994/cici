namespace KTV
{
    partial class FrmAddSinger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddSinger));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnBrower = new System.Windows.Forms.Button();
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.cmbSingerType = new System.Windows.Forms.ComboBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radGroup = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.picSingerPhoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ofdSingerPhoto = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSingerAb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSingerPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "歌手名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "描述：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "歌手性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "歌手类型：";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(228, 398);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCanel.Location = new System.Drawing.Point(408, 398);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(75, 27);
            this.btnCanel.TabIndex = 7;
            this.btnCanel.Text = "取消";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnBrower
            // 
            this.btnBrower.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrower.Location = new System.Drawing.Point(419, 118);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(75, 27);
            this.btnBrower.TabIndex = 8;
            this.btnBrower.Text = "浏览";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // txtSingerName
            // 
            this.txtSingerName.Location = new System.Drawing.Point(117, 39);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.Size = new System.Drawing.Size(149, 21);
            this.txtSingerName.TabIndex = 9;
            // 
            // cmbSingerType
            // 
            this.cmbSingerType.FormattingEnabled = true;
            this.cmbSingerType.Location = new System.Drawing.Point(117, 88);
            this.cmbSingerType.Name = "cmbSingerType";
            this.cmbSingerType.Size = new System.Drawing.Size(149, 20);
            this.cmbSingerType.TabIndex = 10;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(11, 25);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(43, 20);
            this.radMale.TabIndex = 11;
            this.radMale.TabStop = true;
            this.radMale.Text = "男";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radGroup
            // 
            this.radGroup.AutoSize = true;
            this.radGroup.Location = new System.Drawing.Point(166, 25);
            this.radGroup.Name = "radGroup";
            this.radGroup.Size = new System.Drawing.Size(60, 20);
            this.radGroup.TabIndex = 12;
            this.radGroup.TabStop = true;
            this.radGroup.Text = "组合";
            this.radGroup.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(93, 25);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(43, 20);
            this.radFemale.TabIndex = 13;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "女";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(115, 246);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(211, 129);
            this.txtDescription.TabIndex = 14;
            // 
            // picSingerPhoto
            // 
            this.picSingerPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.picSingerPhoto.Location = new System.Drawing.Point(387, 12);
            this.picSingerPhoto.Name = "picSingerPhoto";
            this.picSingerPhoto.Size = new System.Drawing.Size(133, 96);
            this.picSingerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSingerPhoto.TabIndex = 15;
            this.picSingerPhoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radFemale);
            this.panel1.Controls.Add(this.radGroup);
            this.panel1.Controls.Add(this.radMale);
            this.panel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(115, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 51);
            this.panel1.TabIndex = 16;
            // 
            // ofdSingerPhoto
            // 
            this.ofdSingerPhoto.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "缩写：";
            // 
            // txtSingerAb
            // 
            this.txtSingerAb.Location = new System.Drawing.Point(117, 204);
            this.txtSingerAb.Name = "txtSingerAb";
            this.txtSingerAb.Size = new System.Drawing.Size(149, 21);
            this.txtSingerAb.TabIndex = 18;
            // 
            // FrmAddSinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 461);
            this.Controls.Add(this.txtSingerAb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picSingerPhoto);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbSingerType);
            this.Controls.Add(this.txtSingerName);
            this.Controls.Add(this.btnBrower);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddSinger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加歌手";
            this.Load += new System.EventHandler(this.FrmAddSinger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSingerPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.ComboBox cmbSingerType;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radGroup;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox picSingerPhoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog ofdSingerPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSingerAb;
    }
}