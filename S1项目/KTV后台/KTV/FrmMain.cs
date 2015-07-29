using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KTV
{
    public partial class FrmMain : Form
    {
        public string userName = string.Empty;
        //public string managerName = string.Empty;
        public string userType = string.Empty;

        public frmLanding landing = null;

        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public FrmMain()
        {
            InitializeComponent();
        }
        //添加歌曲        
        private void tsmiAddSong_Click(object sender, EventArgs e)
        {
            FrmAddSong addSong = new FrmAddSong();
            addSong.MdiParent = this;
            addSong.Show();
        }

        //添加歌手
        private void tsmiAddSinger_Click(object sender, EventArgs e)
        {
            FrmAddSinger addSinger = new FrmAddSinger();
            addSinger.MdiParent = this;
            addSinger.Show();
        }

        //修改歌手照片路径
        private void tsmiUpdateSingerPhotoResoure_Click(object sender, EventArgs e)
        {
            FrmSingerPhotoResource photoRoadFrm = new FrmSingerPhotoResource();
            photoRoadFrm.MdiParent = this;
            photoRoadFrm.Show();
        }

        //修改歌曲路径
        private void tsmiUpdateSongResoure_Click(object sender, EventArgs e)
        {
            FrmSongResource songRoadFrm = new FrmSongResource();
            songRoadFrm.MdiParent = this;
            songRoadFrm.Show();
        }

        //修改密码
        private void tsmiChangePwd_Click(object sender, EventArgs e)
        {
            FrmChangePwd updatePwdFrm = new FrmChangePwd();
            updatePwdFrm.userName = userName;
            updatePwdFrm.MdiParent = this;
            updatePwdFrm.Show();
        }

        //退出
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //窗体加载
        private void FrmMain_Load(object sender, EventArgs e)
        {
            tsslUserName.Text = tsslUserName.Text + userName;
            tsslNowTime.Text = tsslNowTime.Text + DateTime.Now.ToShortDateString();
            tsslUserRoot.Text += userType;
            Global g = new Global();
            try
            {
                g.AddResource();

                string sqlStr = "select * from rootmanager";
                SqlCommand command = new SqlCommand(sqlStr, DBHelper.Connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "common");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (userType == "操作员")
            {
                tsmiRootManager.Enabled = false;
                foreach (DataRow row in ds.Tables["common"].Rows)
                {
                    if (row[8].ToString() == "3")
                    {
                        if (row[1].ToString() == "0")
                        {
                            tsmiOrder.Enabled =false;
                        }
                        if (row[2].ToString() == "0")
                        {
                            tsmiOpenRoom.Enabled = false;
                        }
                        if (row[3].ToString() == "0")
                        {
                            tsmiQuerySong.Enabled = false;
                            tsmiAddSong.Enabled = false;
                        }
                        if (row[4].ToString() == "0")
                        {
                            tsmiChangePwd.Enabled = false;
                            
                        }
                        if (row[5].ToString() == "0")
                        {
                            tsmiAddSinger.Enabled = false;
                            tsmiQuerySinger.Enabled = false;
                        }
                        if (row[6].ToString() == "0")
                        {
                            //cbCommonRoomMoney.Checked = true;
                        }
                        if (row[7].ToString() == "0")
                        {
                            tsmiUpdateResourc.Enabled = false;
                        }
                    }
                }
            }
            else if (userType == "普通管理员")
            {
                tsmiRootManager.Enabled = false;
                foreach (DataRow row in ds.Tables["common"].Rows)
                {
                    if (row[8].ToString() == "2")
                    {
                        if (row[1].ToString() == "0")
                        {
                            tsmiOrder.Enabled = false;
                        }
                        if (row[2].ToString() == "0")
                        {
                            tsmiOpenRoom.Enabled = false;
                        }
                        if (row[3].ToString() == "0")
                        {
                            tsmiAddSong.Enabled = false;
                            tsmiAddSong.Enabled = false;
                        }
                        if (row[4].ToString() == "0")
                        {
                            tsmiChangePwd.Enabled = false;
                           
                        }
                        if (row[5].ToString() == "0")
                        {
                            tsmiAddSinger.Enabled = false;
                            tsmiQuerySinger.Enabled = false;
                        }
                        if (row[6].ToString() == "0")
                        {
                            //cbCommonRoomMoney.Checked = true;
                        }
                        if (row[7].ToString() == "0")
                        {
                            tsmiUpdateResourc.Enabled = false;
                        }
                    }
                }
            }

        }

        //查询歌曲信息
        private void tsmiQuerySong_Click(object sender, EventArgs e)
        {
            FrmQuerySong songTypeFrm = new FrmQuerySong();
            songTypeFrm.MdiParent = this;
            songTypeFrm.Show();
        }

        //权限管理
        private void tsmiRootManager_Click(object sender, EventArgs e)
        {
            FrmRoot rootFrm = new FrmRoot();
            rootFrm.ShowDialog();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            FrmAbout aboutFrm = new FrmAbout();
            aboutFrm.ShowDialog();
        }

        //歌手查询
        private void tsmiQuerySinger_Click(object sender, EventArgs e)
        {
            FrmQuerySinger singerFrm = new FrmQuerySinger();
            singerFrm.MdiParent = this;
            singerFrm.Show();
        }

        //开房
        private void tsmiOpenRoom_Click(object sender, EventArgs e)
        {
            frmRoom room = new frmRoom();
            room.MdiParent = this;
            room.Text = "开房";
            room.Show();
        }

        //买单
        private void tsmiOrder_Click(object sender, EventArgs e)
        {
            frmRoom room = new frmRoom();
            room.MdiParent = this;
            room.Text = "买单";
            room.Show();
        }

        //重新登录
        private void tsmiLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            landing.Show();
        }

        private void tsbKaiFang_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                tsbKaiFang.Image = Image.FromFile("1.gif");
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            
        }

        private void tsbKaiFang_MouseLeave(object sender, EventArgs e)
        {
            tsbKaiFang.Image = ilNoMove.Images[0];
        }

        private void tsbMaiDan_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                tsbMaiDan.Image = Image.FromFile("2.gif");
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
           
        }

        private void tsbMaiDan_MouseLeave(object sender, EventArgs e)
        {
            tsbMaiDan.Image = ilNoMove.Images[1];
        }

        private void tsnGeQuChaXun_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                tsnGeQuChaXun.Image = Image.FromFile("3.gif");
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
           
        }

        private void tsnGeQuChaXun_MouseLeave(object sender, EventArgs e)
        {
            tsnGeQuChaXun.Image = ilNoMove.Images[2];
        }

        private void tsnGeQuShouChauXun_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                tsnGeQuShouChauXun.Image = Image.FromFile("4.gif");
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            
        }

        private void tsnGeQuShouChauXun_MouseLeave(object sender, EventArgs e)
        {
            tsnGeQuShouChauXun.Image = ilNoMove.Images[3];
        }

        private void tsQuanXian_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                tsQuanXian.Image = Image.FromFile("5.gif");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            
        }

        private void tsQuanXian_MouseLeave(object sender, EventArgs e)
        {
            tsQuanXian.Image = ilNoMove.Images[4];
        }

        private void tsClose_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                tsClose.Image = Image.FromFile("6.gif");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            
        }

        private void tsClose_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                tsClose.Image = ilNoMove.Images[5];
            }
            catch (Exception)
            {
                
            }
           
        }

        //开房
        private void tsbKaiFang_Click(object sender, EventArgs e)
        {
            frmRoom room = new frmRoom();
            room.MdiParent = this;
            room.Text = "开房";
            room.Show();
        }
        //买单
        private void tsbMaiDan_Click(object sender, EventArgs e)
        {
            frmRoom room = new frmRoom();
            room.MdiParent = this;
            room.Text = "买单";
            room.Show();
        }
        //歌曲查询
        private void tsnGeQuChaXun_Click(object sender, EventArgs e)
        {
            FrmQuerySong songTypeFrm = new FrmQuerySong();
            songTypeFrm.MdiParent = this;
            songTypeFrm.Show();
        }

        //歌手查询
        private void tsnGeQuShouChauXun_Click(object sender, EventArgs e)
        {
            FrmQuerySinger singerFrm = new FrmQuerySinger();
            singerFrm.MdiParent = this;
            singerFrm.Show();
        }

        //权限管理
        private void tsQuanXian_Click(object sender, EventArgs e)
        {
            FrmRoot rootFrm = new FrmRoot();
            rootFrm.ShowDialog();
        }

        private void tsmiHide_Click(object sender, EventArgs e)
        {
            tsMain.Visible = false;
        }

        private void tsmiVisible_Click(object sender, EventArgs e)
        {
            tsMain.Visible = true;
        }

        private void tsmiQueryAccount_Click(object sender, EventArgs e)
        {
           //Form1 f = new Form1();
           //f.MdiParent = this;
           // f.Show();

            Room r = new Room();
            r.MdiParent = this;
            r.Show();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
