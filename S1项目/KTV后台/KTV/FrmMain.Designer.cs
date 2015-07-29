namespace KTV
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiRoomServer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSongDBManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuerySong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddSinger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuerySinger = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiUpdateResourc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateSingerPhotoResoure = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateSongResoure = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSystemManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRootManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHide = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUserRoot = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNowTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbKaiFang = new System.Windows.Forms.ToolStripButton();
            this.tsbMaiDan = new System.Windows.Forms.ToolStripButton();
            this.tsnGeQuChaXun = new System.Windows.Forms.ToolStripButton();
            this.tsnGeQuShouChauXun = new System.Windows.Forms.ToolStripButton();
            this.tsQuanXian = new System.Windows.Forms.ToolStripButton();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.ilNoMove = new System.Windows.Forms.ImageList(this.components);
            this.tsmiAddWater = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomServer,
            this.tsmiSongDBManager,
            this.tsmiSystemManager,
            this.tsmiAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiRoomServer
            // 
            this.tsmiRoomServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenRoom,
            this.tsmiOrder,
            this.tsmiAddWater,
            this.tsmiQueryAccount});
            this.tsmiRoomServer.Name = "tsmiRoomServer";
            this.tsmiRoomServer.Size = new System.Drawing.Size(68, 21);
            this.tsmiRoomServer.Text = "房间服务";
            // 
            // tsmiOpenRoom
            // 
            this.tsmiOpenRoom.Name = "tsmiOpenRoom";
            this.tsmiOpenRoom.Size = new System.Drawing.Size(124, 22);
            this.tsmiOpenRoom.Text = "开房";
            this.tsmiOpenRoom.Click += new System.EventHandler(this.tsmiOpenRoom_Click);
            // 
            // tsmiOrder
            // 
            this.tsmiOrder.Name = "tsmiOrder";
            this.tsmiOrder.Size = new System.Drawing.Size(124, 22);
            this.tsmiOrder.Text = "结算";
            this.tsmiOrder.Click += new System.EventHandler(this.tsmiOrder_Click);
            // 
            // tsmiQueryAccount
            // 
            this.tsmiQueryAccount.Name = "tsmiQueryAccount";
            this.tsmiQueryAccount.Size = new System.Drawing.Size(124, 22);
            this.tsmiQueryAccount.Text = "账目查询";
            this.tsmiQueryAccount.Click += new System.EventHandler(this.tsmiQueryAccount_Click);
            // 
            // tsmiSongDBManager
            // 
            this.tsmiSongDBManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddSong,
            this.tsmiQuerySong,
            this.toolStripMenuItem1,
            this.tsmiAddSinger,
            this.tsmiQuerySinger,
            this.toolStripMenuItem2,
            this.tsmiUpdateResourc});
            this.tsmiSongDBManager.Name = "tsmiSongDBManager";
            this.tsmiSongDBManager.Size = new System.Drawing.Size(68, 21);
            this.tsmiSongDBManager.Text = "曲库管理";
            // 
            // tsmiAddSong
            // 
            this.tsmiAddSong.Name = "tsmiAddSong";
            this.tsmiAddSong.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddSong.Text = "添加歌曲";
            this.tsmiAddSong.Click += new System.EventHandler(this.tsmiAddSong_Click);
            // 
            // tsmiQuerySong
            // 
            this.tsmiQuerySong.Name = "tsmiQuerySong";
            this.tsmiQuerySong.Size = new System.Drawing.Size(148, 22);
            this.tsmiQuerySong.Text = "查询歌曲";
            this.tsmiQuerySong.Click += new System.EventHandler(this.tsmiQuerySong_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmiAddSinger
            // 
            this.tsmiAddSinger.Name = "tsmiAddSinger";
            this.tsmiAddSinger.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddSinger.Text = "添加歌手";
            this.tsmiAddSinger.Click += new System.EventHandler(this.tsmiAddSinger_Click);
            // 
            // tsmiQuerySinger
            // 
            this.tsmiQuerySinger.Name = "tsmiQuerySinger";
            this.tsmiQuerySinger.Size = new System.Drawing.Size(148, 22);
            this.tsmiQuerySinger.Text = "查询歌手";
            this.tsmiQuerySinger.Click += new System.EventHandler(this.tsmiQuerySinger_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmiUpdateResourc
            // 
            this.tsmiUpdateResourc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdateSingerPhotoResoure,
            this.tsmiUpdateSongResoure});
            this.tsmiUpdateResourc.Name = "tsmiUpdateResourc";
            this.tsmiUpdateResourc.Size = new System.Drawing.Size(148, 22);
            this.tsmiUpdateResourc.Text = "资源路径修改";
            // 
            // tsmiUpdateSingerPhotoResoure
            // 
            this.tsmiUpdateSingerPhotoResoure.Name = "tsmiUpdateSingerPhotoResoure";
            this.tsmiUpdateSingerPhotoResoure.Size = new System.Drawing.Size(148, 22);
            this.tsmiUpdateSingerPhotoResoure.Text = "歌手照片路径";
            this.tsmiUpdateSingerPhotoResoure.Click += new System.EventHandler(this.tsmiUpdateSingerPhotoResoure_Click);
            // 
            // tsmiUpdateSongResoure
            // 
            this.tsmiUpdateSongResoure.Name = "tsmiUpdateSongResoure";
            this.tsmiUpdateSongResoure.Size = new System.Drawing.Size(148, 22);
            this.tsmiUpdateSongResoure.Text = "歌曲路径";
            this.tsmiUpdateSongResoure.Click += new System.EventHandler(this.tsmiUpdateSongResoure_Click);
            // 
            // tsmiSystemManager
            // 
            this.tsmiSystemManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangePwd,
            this.tsmiRootManager,
            this.tsmiLogin,
            this.tsmiHide,
            this.tsmiVisible,
            this.tsmiExit});
            this.tsmiSystemManager.Name = "tsmiSystemManager";
            this.tsmiSystemManager.Size = new System.Drawing.Size(68, 21);
            this.tsmiSystemManager.Text = "系统管理";
            // 
            // tsmiChangePwd
            // 
            this.tsmiChangePwd.Name = "tsmiChangePwd";
            this.tsmiChangePwd.Size = new System.Drawing.Size(136, 22);
            this.tsmiChangePwd.Text = "修改密码";
            this.tsmiChangePwd.Click += new System.EventHandler(this.tsmiChangePwd_Click);
            // 
            // tsmiRootManager
            // 
            this.tsmiRootManager.Name = "tsmiRootManager";
            this.tsmiRootManager.Size = new System.Drawing.Size(136, 22);
            this.tsmiRootManager.Text = "权限管理";
            this.tsmiRootManager.Click += new System.EventHandler(this.tsmiRootManager_Click);
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(136, 22);
            this.tsmiLogin.Text = "重新登录";
            this.tsmiLogin.Click += new System.EventHandler(this.tsmiLogin_Click);
            // 
            // tsmiHide
            // 
            this.tsmiHide.Name = "tsmiHide";
            this.tsmiHide.Size = new System.Drawing.Size(136, 22);
            this.tsmiHide.Text = "隐藏工具栏";
            this.tsmiHide.Click += new System.EventHandler(this.tsmiHide_Click);
            // 
            // tsmiVisible
            // 
            this.tsmiVisible.Name = "tsmiVisible";
            this.tsmiVisible.Size = new System.Drawing.Size(136, 22);
            this.tsmiVisible.Text = "显示工具栏";
            this.tsmiVisible.Click += new System.EventHandler(this.tsmiVisible_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(136, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(44, 21);
            this.tsmiAbout.Text = "关于";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslUserName,
            this.tsslUserRoot,
            this.tsslNowTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(957, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabel1.Text = "欢迎使用KTV管理系统";
            // 
            // tsslUserName
            // 
            this.tsslUserName.AutoSize = false;
            this.tsslUserName.Name = "tsslUserName";
            this.tsslUserName.Size = new System.Drawing.Size(180, 17);
            this.tsslUserName.Text = "登录用户名：";
            this.tsslUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslUserRoot
            // 
            this.tsslUserRoot.AutoSize = false;
            this.tsslUserRoot.Name = "tsslUserRoot";
            this.tsslUserRoot.Size = new System.Drawing.Size(180, 17);
            this.tsslUserRoot.Text = "用户权限：";
            this.tsslUserRoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslNowTime
            // 
            this.tsslNowTime.AutoSize = false;
            this.tsslNowTime.Name = "tsslNowTime";
            this.tsslNowTime.Size = new System.Drawing.Size(180, 17);
            this.tsslNowTime.Text = "当前时间：";
            this.tsslNowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.Color.AliceBlue;
            this.tsMain.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbKaiFang,
            this.tsbMaiDan,
            this.tsnGeQuChaXun,
            this.tsnGeQuShouChauXun,
            this.tsQuanXian,
            this.tsClose});
            this.tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsMain.Location = new System.Drawing.Point(0, 25);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(957, 107);
            this.tsMain.TabIndex = 6;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbKaiFang
            // 
            this.tsbKaiFang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKaiFang.Image = ((System.Drawing.Image)(resources.GetObject("tsbKaiFang.Image")));
            this.tsbKaiFang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbKaiFang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKaiFang.Name = "tsbKaiFang";
            this.tsbKaiFang.Size = new System.Drawing.Size(104, 104);
            this.tsbKaiFang.Text = "开房";
            this.tsbKaiFang.Click += new System.EventHandler(this.tsbKaiFang_Click);
            this.tsbKaiFang.MouseEnter += new System.EventHandler(this.tsbKaiFang_MouseEnter);
            this.tsbKaiFang.MouseLeave += new System.EventHandler(this.tsbKaiFang_MouseLeave);
            // 
            // tsbMaiDan
            // 
            this.tsbMaiDan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMaiDan.Image = ((System.Drawing.Image)(resources.GetObject("tsbMaiDan.Image")));
            this.tsbMaiDan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMaiDan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMaiDan.Name = "tsbMaiDan";
            this.tsbMaiDan.Size = new System.Drawing.Size(104, 104);
            this.tsbMaiDan.Text = "包厢买单";
            this.tsbMaiDan.Click += new System.EventHandler(this.tsbMaiDan_Click);
            this.tsbMaiDan.MouseEnter += new System.EventHandler(this.tsbMaiDan_MouseEnter);
            this.tsbMaiDan.MouseLeave += new System.EventHandler(this.tsbMaiDan_MouseLeave);
            // 
            // tsnGeQuChaXun
            // 
            this.tsnGeQuChaXun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsnGeQuChaXun.Image = ((System.Drawing.Image)(resources.GetObject("tsnGeQuChaXun.Image")));
            this.tsnGeQuChaXun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsnGeQuChaXun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsnGeQuChaXun.Name = "tsnGeQuChaXun";
            this.tsnGeQuChaXun.Size = new System.Drawing.Size(104, 104);
            this.tsnGeQuChaXun.Text = "歌曲查询";
            this.tsnGeQuChaXun.Click += new System.EventHandler(this.tsnGeQuChaXun_Click);
            this.tsnGeQuChaXun.MouseEnter += new System.EventHandler(this.tsnGeQuChaXun_MouseEnter);
            this.tsnGeQuChaXun.MouseLeave += new System.EventHandler(this.tsnGeQuChaXun_MouseLeave);
            // 
            // tsnGeQuShouChauXun
            // 
            this.tsnGeQuShouChauXun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsnGeQuShouChauXun.Image = ((System.Drawing.Image)(resources.GetObject("tsnGeQuShouChauXun.Image")));
            this.tsnGeQuShouChauXun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsnGeQuShouChauXun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsnGeQuShouChauXun.Name = "tsnGeQuShouChauXun";
            this.tsnGeQuShouChauXun.Size = new System.Drawing.Size(104, 104);
            this.tsnGeQuShouChauXun.Text = "歌手查询";
            this.tsnGeQuShouChauXun.Click += new System.EventHandler(this.tsnGeQuShouChauXun_Click);
            this.tsnGeQuShouChauXun.MouseEnter += new System.EventHandler(this.tsnGeQuShouChauXun_MouseEnter);
            this.tsnGeQuShouChauXun.MouseLeave += new System.EventHandler(this.tsnGeQuShouChauXun_MouseLeave);
            // 
            // tsQuanXian
            // 
            this.tsQuanXian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsQuanXian.Image = ((System.Drawing.Image)(resources.GetObject("tsQuanXian.Image")));
            this.tsQuanXian.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsQuanXian.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsQuanXian.Name = "tsQuanXian";
            this.tsQuanXian.Size = new System.Drawing.Size(104, 104);
            this.tsQuanXian.Text = "权限管理";
            this.tsQuanXian.Click += new System.EventHandler(this.tsQuanXian_Click);
            this.tsQuanXian.MouseEnter += new System.EventHandler(this.tsQuanXian_MouseEnter);
            this.tsQuanXian.MouseLeave += new System.EventHandler(this.tsQuanXian_MouseLeave);
            // 
            // tsClose
            // 
            this.tsClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(104, 104);
            this.tsClose.Text = "关闭";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            this.tsClose.MouseEnter += new System.EventHandler(this.tsClose_MouseEnter);
            this.tsClose.MouseLeave += new System.EventHandler(this.tsClose_MouseLeave);
            // 
            // ilNoMove
            // 
            this.ilNoMove.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilNoMove.ImageStream")));
            this.ilNoMove.TransparentColor = System.Drawing.Color.Transparent;
            this.ilNoMove.Images.SetKeyName(0, "t01f019d731b892f402.jpg");
            this.ilNoMove.Images.SetKeyName(1, "t012d8abb45f7c950fe.jpg");
            this.ilNoMove.Images.SetKeyName(2, "t01932ac2e01af4f62d.jpg");
            this.ilNoMove.Images.SetKeyName(3, "t01c1c0ce52888e2152.jpg");
            this.ilNoMove.Images.SetKeyName(4, "t01cc4611781aa21a9b.jpg");
            this.ilNoMove.Images.SetKeyName(5, "t01ad953d4096980ea3.jpg");
            // 
            // tsmiAddWater
            // 
            this.tsmiAddWater.Name = "tsmiAddWater";
            this.tsmiAddWater.Size = new System.Drawing.Size(149, 6);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 506);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSongDBManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuerySong;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddSinger;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuerySinger;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateResourc;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateSingerPhotoResoure;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateSongResoure;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystemManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePwd;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserName;
        private System.Windows.Forms.ToolStripStatusLabel tsslNowTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiRootManager;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserRoot;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbKaiFang;
        private System.Windows.Forms.ToolStripButton tsbMaiDan;
        private System.Windows.Forms.ToolStripButton tsnGeQuChaXun;
        private System.Windows.Forms.ToolStripButton tsnGeQuShouChauXun;
        private System.Windows.Forms.ToolStripButton tsQuanXian;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomServer;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogin;
        private System.Windows.Forms.ImageList ilNoMove;
        private System.Windows.Forms.ToolStripMenuItem tsmiHide;
        private System.Windows.Forms.ToolStripMenuItem tsmiVisible;
        private System.Windows.Forms.ToolStripSeparator tsmiAddWater;
    }
}