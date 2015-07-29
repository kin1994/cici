using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;

namespace MYKTV
{
    public partial class FrmMain : Form
    {
        public string Openid = string.Empty;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        //筛选商品类别
        DataView dv = new DataView();
        //记录窗体打开特效的参数
        public int ver;
        //记录父窗体
        public FrmMain fatherFrm = null;
        SoundPlayer LikeSound = new SoundPlayer("欢呼.wav");
        SoundPlayer KouShaoSound = new SoundPlayer("口哨.wav");
        SoundPlayer DaoCaiSound = new SoundPlayer("倒彩.wav");

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            pnlQiFen.Visible = false;
            pnlQiFen.Enabled = false;
            pnlFuWu.Visible = false;
            pnlFuWu.Visible = false;
            //把字幕初始位置设成最右边
            tmrZiMu.Enabled = true;
            //加载窗体，就把资源路径+歌手、歌曲信息全部注入到全局的DS中
            try
            {
                Win32.AnimateWindow(this.Handle, 500, ver);
                string msg = string.Empty;
                Global.GetPath(ref msg);
                Global.FillOrderSong();
                Global.FillSinger();
                Global.FillSong();
                this.bindingGoodType();
                cboType.SelectedValue = -1;
                this.bindingGoodInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //获取商品类型并绑定cbo
        private void bindingGoodType()
        {
            try
            {
                string sqlstr = "select * from Good_Type";
                SqlCommand command = new SqlCommand(sqlstr, DBHelper.Conn);
                adapter.SelectCommand = command;
                adapter.Fill(ds,"GoodType");
                cboType.DataSource=ds.Tables["GoodType"];
                cboType.DisplayMember = "GoodType";
                cboType.ValueMember = "id";
                DataRow  row = ds.Tables["GoodType"].NewRow();
                row["id"] = -1;
                row["goodType"] = "全部";
                ds.Tables["GoodType"].Rows.InsertAt(row, 0);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //绑定商品信息
        private void bindingGoodInfo()
        {
            string sqlstr = "select * from Goods_info";
            SqlCommand command = new SqlCommand(sqlstr,DBHelper.Conn);
            adapter.SelectCommand = command;
            adapter.Fill(ds,"GoodInfo");
            dv.Table = ds.Tables["GoodInfo"];
            cboName.DataSource = dv;
            cboName.DisplayMember = "goodname";
            cboName.ValueMember = "goodid";
        }

        #region 拼音点歌
        private void picPinYinDianGe_Click(object sender, EventArgs e)
        {

            frmPinYin PinYinfrm = new frmPinYin();
            PinYinfrm.fatherFrm = this;
            PinYinfrm.ver = Win32.AW_CENTER;
            PinYinfrm.Show();
            this.Hide();
        } 
        #endregion

        #region 歌星点歌
        private void PicGeXingDianGe_Click(object sender, EventArgs e)
        {
            frmAllSinger allSingerfrm = new frmAllSinger();
            allSingerfrm.fatherFrm = this;
            allSingerfrm.ver = Win32.AW_CENTER;
            allSingerfrm.Show();
            this.Hide();
        } 
        #endregion


        #region 进入静音
        private void picSoundOff_MouseEnter(object sender, EventArgs e)
        {
            picSoundOff.Image = Image.FromFile(@"img\静音2.png");
        } 
        #endregion

        #region 离开静音
        private void picSoundOff_MouseLeave(object sender, EventArgs e)
        {
            picSoundOff.Image = Image.FromFile(@"img\静音1.png");
        } 
        #endregion

        #region 底部小按键的进入和离开事件
        private void picPause_MouseEnter(object sender, EventArgs e)
        {
            if (Global.frmPlayer.axPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                picPause.Image = Image.FromFile(@"img\暂停2.png");
            }
            else
            {
                picPause.Image = Image.FromFile(@"img\播放2.png");
            }
        }

        private void picPause_MouseLeave(object sender, EventArgs e)
        {
            if (Global.frmPlayer.axPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                picPause.Image = Image.FromFile(@"img\暂停1.png");
            }
            else
            {
                picPause.Image = Image.FromFile(@"img\播放1.png");
            }
        }

        private void picRePlay_MouseEnter(object sender, EventArgs e)
        {
            picRePlay.Image = Image.FromFile(@"img\重播.png");
        }

        private void picRePlay_MouseLeave(object sender, EventArgs e)
        {
            picRePlay.Image = Image.FromFile(@"img\重播2.png");
        }

        private void picUpSound_MouseEnter(object sender, EventArgs e)
        {
            picUpSound.Image = Image.FromFile(@"img\音量加2.png");
        }

        private void picUpSound_MouseLeave(object sender, EventArgs e)
        {
            picUpSound.Image = Image.FromFile(@"img\音量加.png");
        }

        private void picDownSound_MouseEnter(object sender, EventArgs e)
        {
            picDownSound.Image = Image.FromFile(@"img\音量减2.png");
        }

        private void picDownSound_MouseLeave(object sender, EventArgs e)
        {
            picDownSound.Image = Image.FromFile(@"img\音量减1.png");
        }

        private void PicStop_MouseEnter(object sender, EventArgs e)
        {
            PicStop.Image = Image.FromFile(@"img\切歌2.png");
        }

        private void PicStop_MouseLeave(object sender, EventArgs e)
        {
            PicStop.Image = Image.FromFile(@"img\切歌1.png");
        }

        private void picFuWu_MouseEnter(object sender, EventArgs e)
        {
            picFuWu.Image = Image.FromFile(@"img\服务2.png");
        }

        private void picFuWu_MouseLeave(object sender, EventArgs e)
        {
            picFuWu.Image = Image.FromFile(@"img\服务1.png");
        }

        private void picMax_MouseEnter(object sender, EventArgs e)
        {
            picaxPlay.Image = Image.FromFile(@"img\全屏2.png");
        }

        private void picMax_MouseLeave(object sender, EventArgs e)
        {
            picaxPlay.Image = Image.FromFile(@"img\全屏1.png");
        }

        private void picQiFen_MouseEnter(object sender, EventArgs e)
        {
            picQiFen.Image = Image.FromFile(@"img\气氛2.png");
        }
        private void picQiFen_MouseLeave(object sender, EventArgs e)
        {
            picQiFen.Image = Image.FromFile(@"img\气氛1.png");
        } 
        #endregion

        #region 曲种点歌
        private void picQuZongDianGe_Click(object sender, EventArgs e)
        {
            FrmYuZhongDianGe yuzhong = new FrmYuZhongDianGe();
            yuzhong.ver = Win32.AW_CENTER;
            yuzhong.fatherFrm = this;
            yuzhong.Show();
            this.Hide();
        } 
        #endregion

        private void picLetter_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BringToFront();
            pic.Left -= 10;
            pic.Top -= 10;
            pic.Height += 10;
            pic.Width += 10;
        }

        private void picLetter_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Left += 10;
            pic.Top += 10;
            pic.Height -= 10;
            pic.Width -= 10;
        }

        private void picTVShow_Click(object sender, EventArgs e)
        {
            Global.frmPlayer.fatherfrm = this;
            Global.frmPlayer.ver = Win32.AW_CENTER;
            Global.frmPlayer.Show();
            this.Hide();
        }

        private void picShuZiDianGe_Click(object sender, EventArgs e)
        {
            FrmWordNumbercs numfrm = new FrmWordNumbercs();
            numfrm.ver = Win32.AW_CENTER;
            numfrm.fatherFrm = this;
            numfrm.Show();
            this.Hide();
        }

        private void picDiQuDianGe_Click(object sender, EventArgs e)
        {
            FrmDiQuDianGe DiQufrm = new FrmDiQuDianGe();
            DiQufrm.father = this;
            DiQufrm.ver = Win32.AW_CENTER;
            DiQufrm.Show();
            this.Hide();
        }

        private void picSoundOff_Click(object sender, EventArgs e)
        {
            if (Global.frmPlayer.axPlayer.settings.mute == false)
            {
                Global.frmPlayer.axPlayer.settings.mute = true;
            }
            else
            {
                Global.frmPlayer.axPlayer.settings.mute = false;
            }

        }

        private void picPause_Click(object sender, EventArgs e)
        {
            //判断播放器的当前状态，切换对应图片
            if (Global.frmPlayer.axPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                picPause.Image = null;
                picPause.Image = Image.FromFile(@"img\播放1.png");
                Global.frmPlayer.axPlayer.Ctlcontrols.pause();
            }
            else if (Global.frmPlayer.axPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                picPause.Image = null;
                picPause.Image = Image.FromFile(@"img\暂停1.png");
                Global.frmPlayer.axPlayer.Ctlcontrols.play();
            }
        }

        private void picRePlay_Click(object sender, EventArgs e)
        {
            Global.frmPlayer.axPlayer.Ctlcontrols.currentPosition = 0;
        }

        private void picaxPlay_Click(object sender, EventArgs e)
        {
            try
            {
                Global.frmPlayer.axPlayer.fullScreen = true;
            }
            catch (Exception)
            {

                MessageBox.Show("请先点歌!");
            }
        }

        private void picUpSound_Click(object sender, EventArgs e)
        {
            if (Global.frmPlayer.axPlayer.settings.volume < 100)
            {
                Global.frmPlayer.axPlayer.settings.volume += 10;
            }
        }

        private void picDownSound_Click(object sender, EventArgs e)
        {
            if (Global.frmPlayer.axPlayer.settings.volume >= 0)
            {
                Global.frmPlayer.axPlayer.settings.volume -= 10;
            }
        }

        private void PicStop_Click(object sender, EventArgs e)
        {
            Global.frmPlayer.axPlayer.Ctlcontrols.next();
            if (Global.Ds.Tables["OrderSong"].Rows.Count > 0)
            {
                Global.frmPlayer.axPlayer.currentPlaylist.removeItem(
                Global.frmPlayer.axPlayer.currentPlaylist.Item[0]);
                Global.Ds.Tables["OrderSong"].Rows.RemoveAt(0);
                Global.frmPlayer.ShowOrderSong();
            }
        }

        private void picFuWu_Click(object sender, EventArgs e)
        {
            if (pnlFuWu.Visible == true)
            {
                pnlFuWu.Visible = false;
            }
            else
            {
                pnlFuWu.BringToFront();
                pnlFuWu.Visible = true;
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex > 0)
            {
                int id = int.Parse(cboType.SelectedValue.ToString());
                dv.RowFilter = string.Format("goodTypeid = {0}",id);
                
            }
            else
            {
                dv.RowFilter = "";
            }
        }
        //有效性验证
        private bool Check()
        {
            bool flag = false;
            if (cboName.Text == string.Empty)
            {
                MessageBox.Show("请选择商品！");
            }
            else if (txtNum.Text != string.Empty)
            {
                try
                {
                    int num = int.Parse(txtNum.Text);
                    if (num > 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        MessageBox.Show("输入的数量必须大于0!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请输入数字!");
                }
            }
            else
            {
                MessageBox.Show("请输入数量!");
            }

            return flag;
        }

        //按添加按钮的事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("goodid = '{0}'",cboName.SelectedValue);
            //新建一个dataTable获取里面的商品价格
            DataTable dt = dv.ToTable();
            int num = int.Parse(txtNum.Text);
            float price = float.Parse(dt.Rows[0][2].ToString()); 
            //调用验证的方法
            bool flag = this.Check();
            //如果全部都不为空就把数据加到lvGood里面去
            if (flag)
            {
                ListViewItem newrows = new ListViewItem();
                newrows.ImageIndex = 0;
                newrows.Text = cboName.Text;
                newrows.Tag = cboName.SelectedValue.ToString();
                newrows.SubItems.Add(txtNum.Text);
                newrows.SubItems.Add(price.ToString());
                newrows.SubItems.Add(cboName.SelectedValue.ToString());
                lvGoods.Items.Add(newrows);
                //如果商品类型不是全部就按类型筛选
                if (cboType.SelectedIndex > 0)
                {
                    dv.RowFilter = string.Format("goodtypeid = '{0}'", cboType.SelectedValue);
                }
                else
                {
                    dv.RowFilter = "";
                }
            }
        }

        private void tmrZiMu_Tick(object sender, EventArgs e)
        {
            //每次都向左移动移到全部字都消失之后字幕重新从窗体最右边出现
            lblInfo.Text = "当前播放：" + Global.frmPlayer.lblPlayNow.Text + "                下一首:" + Global.frmPlayer.lblPlayNext.Text;
            lblInfo.Left = lblInfo.Left - 3;
            if (lblInfo.Right < 0)
            {
                lblInfo.Left = this.Width;
            }
        }

        private void lblInfo_MouseEnter(object sender, EventArgs e)
        {
            //进入时字体变红色
            lblInfo.ForeColor = Color.Red;
        }

        private void lblInfo_MouseLeave(object sender, EventArgs e)
        {
            //进入时字体变白色
            lblInfo.ForeColor = Color.White;
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            //点击字幕时跳转到视频播放页面
            Global.frmPlayer.fatherfrm = this;
            Global.frmPlayer.Show();
            this.Hide();
        }

        private void picXingGeTuiJian_Click(object sender, EventArgs e)
        {
            FrmXinGeTuiJian NewSong = new FrmXinGeTuiJian();
            NewSong.fatherFrm = this;
            NewSong.ver = Win32.AW_CENTER;
            NewSong.Show();
            this.Hide();
        }

        private void picGeQuPaiHang_Click(object sender, EventArgs e)
        {
            FrmPaiHengBang paiHang = new FrmPaiHengBang();
            paiHang.fatherFrm = this;
            paiHang.ver = Win32.AW_CENTER;
            paiHang.Show();
            this.Hide();
        }

        #region 清空按钮的单击事件
        private void btnClear_Click(object sender, EventArgs e)
        {
            //清空lvgood的内容
            lvGoods.Items.Clear();
        } 
        #endregion

        #region 提交按钮的单击事件
        private void btnTiJiao_Click(object sender, EventArgs e)
        {

            if (lvGoods.Items.Count > 0)
            {
                int j = 0;
                try
                {
                    for (int i = 0; i < lvGoods.Items.Count; i++)
                    {
                        //获取商品ID
                        int goodid = int.Parse(lvGoods.Items[i].Tag.ToString());
                        //获取下单数量
                        int num = int.Parse(lvGoods.Items[i].SubItems[1].Text);
                        //构造sql语句
                        string sqlstr = string.Format("insert Goods_Order values('{0}',{1},{2})", this.Openid, goodid, num);
                        //执行数据库插入
                        SqlCommand command = new SqlCommand(sqlstr, DBHelper.Conn);
                        DBHelper.Conn.Open();
                        j = command.ExecuteNonQuery();
                        DBHelper.Conn.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBHelper.Conn.Close();
                    if (j > 0)
                    {
                        MessageBox.Show("提交成功!请耐心等候!");
                        lvGoods.Items.Clear();
                    }
                }
            }
        } 
        #endregion

        #region 气氛按钮的单击事件
        private void picQiFen_Click(object sender, EventArgs e)
        {
            //如果气氛按钮被单击时判断气氛面板的状态是否可见
            if (pnlQiFen.Enabled == false)
            {
                pnlQiFen.Enabled = true;
                pnlQiFen.Visible = true;
            }
            else
            {
                pnlQiFen.Enabled = false;
                pnlQiFen.Visible = false;
            }
        } 
        #endregion

        #region 喜欢按钮的单击事件
        private void picLike_Click(object sender, EventArgs e)
        {
            this.LikeSound.Play();
        } 
        #endregion

        #region 口哨按钮的单击时间
        private void picKouShao_Click(object sender, EventArgs e)
        {
            this.KouShaoSound.Play();
        } 
        #endregion

        #region 嘘声按钮的单击事件
        private void picXuShen_Click(object sender, EventArgs e)
        {
            this.DaoCaiSound.Play();
        } 
        #endregion

      
    }
}
