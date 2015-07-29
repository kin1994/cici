using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace MYKTV
{
    public partial class Player : Form
    {
        //记录父窗体
        public FrmMain fatherfrm = new FrmMain();
        //窗体以什么方式打开
        public int ver;
        //页号
        int pageNum = 0;
        //总歌曲数
        int totalPageNum = 0;

        DataTable orderSongTable;

        public Player()
        {
            InitializeComponent();
        }

        #region 底部小图标的图片切换
        private void picSoundOff_MouseEnter(object sender, EventArgs e)
        {
            picSoundOff.Image = Image.FromFile(@"img\静音2.png");
        }

        private void picSoundOff_MouseLeave(object sender, EventArgs e)
        {
            picSoundOff.Image = Image.FromFile(@"img\静音1.png");
        }

        private void picPause_MouseEnter(object sender, EventArgs e)
        {
            if (axPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
            if (axPlayer.playState==WMPLib.WMPPlayState.wmppsPlaying)
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

        private void picMax_MouseEnter(object sender, EventArgs e)
        {
            picaxPlay.Image = Image.FromFile(@"img\全屏2.png");
        }

        private void picMax_MouseLeave(object sender, EventArgs e)
        {
            picaxPlay.Image = Image.FromFile(@"img\全屏1.png");
        }
        private void picMain_MouseEnter(object sender, EventArgs e)
        {
            picMain.Image = Image.FromFile(@"img\主页2.png");
        }

        private void picMain_MouseLeave(object sender, EventArgs e)
        {
            picMain.Image = Image.FromFile(@"img\主页1.png");
        }
        #endregion

        private void Player_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle,500,ver);
            //初始化页号
            pageNum = 1;
            //刷新点歌列表
            ShowOrderSong();
        }

        //获取歌曲页数资料
        public void CheckSongPageInfo()
        {
            //视图中满足条件的总记录数--歌手数
            int totalRowNum = this.orderSongTable.Rows.Count;

            //获取正确的总页数，每页6个歌曲记录
            if (totalRowNum / 6 >= 0 && totalRowNum % 6 == 0)
            {
                totalPageNum = totalRowNum / 6;
            }
            else
            {
                totalPageNum = totalRowNum / 6 + 1;
            }

            //汇报当前总页数
            lblPageNum.Text = pageNum + "";
            lblTotalPage.Text = totalPageNum + "";
        }

        //显示已点歌列表
        public void ShowOrderSong()
        {
            this.axPlayer.Ctlcontrols.play();
            //重新获取点歌数据表
            orderSongTable = Global.Ds.Tables["OrderSong"];
            //重新计算点歌总页数
            CheckSongPageInfo();

            int i;

            try
            {
                //当前歌手相片为第一条歌曲记录的演唱者
                picSinger.Image = Image.FromFile(Global.PhotoPath + "\\" + orderSongTable.Rows[0]["singer_photo_url"].ToString());
            }
            catch (Exception)
            {
                //若没有歌手的图片用默认图片代替
                picSinger.Image = Image.FromFile(Global.PhotoPath + "\\nopic.png");
            }

            //先将所有顶歌、删歌的按钮设为不可用
            this.picTop2.Enabled = false;
            this.picTop3.Enabled = false;
            this.picTop4.Enabled = false;
            this.picTop5.Enabled = false;
            this.picTop6.Enabled = false;
            this.picTop2.Visible = false;
            this.picTop3.Visible = false;
            this.picTop4.Visible = false;
            this.picTop5.Visible = false;
            this.picTop6.Visible = false;
            this.picDelete2.Enabled = false;
            this.picDelete3.Enabled = false;
            this.picDelete4.Enabled = false;
            this.picDelete5.Enabled = false;
            this.picDelete6.Enabled = false;
            this.picDelete2.Visible = false;
            this.picDelete3.Visible = false;
            this.picDelete4.Visible = false;
            this.picDelete5.Visible = false;
            this.picDelete6.Visible = false;


            //设置pnlSong歌曲面板主要方便刷新歌曲列表时不用遍历过多的无关控件
            try
            {
                foreach (Control item in this.pnlList.Controls)
                {
                    //若为标签 刷新歌曲列表需要分别刷新歌曲名和演唱歌手姓名
                    if (item is Label)
                    {
                        Label lbl = (Label)item;
                        try
                        {
                            //判断是歌手资料标签
                            if (lbl.Name.Contains("lblSinger"))
                            {
                                i = int.Parse(lbl.Name.Substring(9)) - 1;
                                //保存歌手名
                                lbl.Text = orderSongTable.Rows[i + (pageNum - 1) * 6]["singer_name"].ToString();
                                //保存歌手图片
                                lbl.Tag = orderSongTable.Rows[i + (pageNum - 1) * 6]["singer_photo_url"].ToString();

                                //当有歌曲时，后面的顶歌、删歌才可以使用
                                Control con1 = this.Controls.Find(string.Format("picDelete{0}",i + 1), true)[0];
                                con1.Enabled = true;
                                con1.Visible = true;
                                Control con2 = this.Controls.Find(string.Format("picTop{0}", i + 1), true)[0];
                                con2.Enabled = true;
                                con2.Visible = true;
                                if (lbl.Text.Length>4)
                                {
                                    lbl.Text = lbl.Text.Substring(0,4) + "...";
                                }

                            }
                            //判断是歌曲资料标签
                            else if (lbl.Name.Contains("lblSong"))
                            {
                                i = int.Parse(lbl.Name.Substring(7)) - 1;
                                //保存歌名
                                lbl.Text = orderSongTable.Rows[i + (pageNum - 1) * 6]["song_name"].ToString();
                                //保存歌曲路径
                                lbl.Tag = orderSongTable.Rows[i + (pageNum - 1) * 6]["song_url"].ToString();
                            }
                            if (lbl.Text.Length>4)
                            {
                                lbl.Text = lbl.Text.Substring(0, 4) + "...";
                            }
                        }
                        catch (Exception)
                        {
                            //若超出数据表记录数，则用空白代替输出
                            lbl.Text = "";
                            lbl.Tag = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //显示正在播放和下一首
            if (orderSongTable.Rows.Count > 1)
            {
                //当前播放歌曲名
                lblPlayNow.Text = orderSongTable.Rows[0]
                    ["song_name"].ToString();
                //下一首播放歌曲名
                lblPlayNext.Text = orderSongTable.Rows[1]
                    ["song_name"].ToString();

            }
            else if (orderSongTable.Rows.Count == 1)   //若整个表只有一条记录
            {
                lblPlayNow.Text = orderSongTable.Rows[0]
                    ["song_name"].ToString();

                lblPlayNext.Text = "快点歌...";
            }
            else
            {
                //若完全没有歌曲记录
                lblPlayNow.Text = "快点歌...";
                lblPlayNext.Text = "快点歌...";
            }
        }

        //这个是搭桥方法，让点歌窗口可以调用，往播放器列表中插入新增的播放歌曲
        public void AddSong(string songPath)
        {
            axPlayer.currentPlaylist.appendItem(this.axPlayer.newMedia(songPath));

        }

        private void picTopLetter_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Image = Image.FromFile(@"img\顶1.jpg");
        }

        private void picTopLetter_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Image = Image.FromFile(@"img\顶.jpg");
        }

        private void picUpPage_MouseEnter(object sender, EventArgs e)
        {
            picUpPage.Image = Image.FromFile(@"img\上一页2.png");
        }

        private void picUpPage_MouseLeave(object sender, EventArgs e)
        {
            picUpPage.Image = Image.FromFile(@"img\上一页1.png");
        }

        private void picNextPage_MouseEnter(object sender, EventArgs e)
        {
            picNextPage.Image = Image.FromFile(@"img\下一页2.png");
        }

        private void picNextPage_MouseLeave(object sender, EventArgs e)
        {
            picNextPage.Image = Image.FromFile(@"img\下一页1.png");
        }


        //向上翻页
        private void picUpPage_Click(object sender, EventArgs e)
        {
            //判断是否不为第一页
            if (pageNum > 1)
            {
                pageNum--; //减页数
                lblPageNum.Text = pageNum + "";  //刷新输出
                ShowOrderSong();  //刷新歌曲列表
            }
        }

        private void picNextPage_Click(object sender, EventArgs e)
        {
            //判断是否为最后一页
            if (pageNum < totalPageNum)
            {
                pageNum++;  //加页数
                lblPageNum.Text = pageNum + "";
                ShowOrderSong();
            }
        }
        //删除歌曲
        private void picDelete_Click(object sender, EventArgs e)
        {
            //获取删除序号 pnlDelete1
            int index = int.Parse(((PictureBox)sender).Name.Substring(9)) - 1;

            //要删除的歌曲的行号， 要计算需要删除的歌曲在数据表中的行号
            int id = (pageNum - 1) * 6 + index;

            //删除OrderSong对应的记录
            orderSongTable.Rows.RemoveAt(id);

            //删除播放控件播放列表对应的媒体
            axPlayer.currentPlaylist.removeItem(
                axPlayer.currentPlaylist.Item[id]);

            axPlayer.Ctlcontrols.play();  //继续播放
            this.ShowOrderSong();  //刷新歌曲列表
        }
        //当播放器当前条目发生改变时，当修改currentPlaylist时触发
        private void axPlayer_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            orderSongTable = Global.Ds.Tables["OrderSong"];

            //若媒体播放器当前播放列表为0，表示无待播放歌曲时，停止事件
            if (axPlayer.currentPlaylist.count == 0)
                return;

            //若当前播放状态为正在播放中
            if (axPlayer.playState ==
                WMPLib.WMPPlayState.wmppsPlaying)
            {
                //如果正在播放的媒体不是播放列表的第一项（针对切掉当前正在唱的歌）
                if (axPlayer.currentMedia !=
                    axPlayer.currentPlaylist.Item[0])
                {
                    //删掉记录集中第一行
                    frmPinYin py=new frmPinYin();
                    orderSongTable.Rows.RemoveAt(0);
                    //删掉播放列表中的第一行
                    axPlayer.currentPlaylist.removeItem(
                        axPlayer.currentPlaylist.Item[0]);
                }
                
                //媒体播放器继续播放
                axPlayer.Ctlcontrols.play();
            }
        }
        private void axPlayer_CurrentPlaylistChange(object sender, AxWMPLib._WMPOCXEvents_CurrentPlaylistChangeEvent e)
        {
            //每次唱完一首歌，都要重新刷新播放列表
            ShowOrderSong();
        }

        //顶歌的方法
        private void picTop_Click(object sender, EventArgs e)
        {
            //要顶的歌曲的行号
            int index = int.Parse(((PictureBox)sender).Name.Substring(6)) - 1;

            //计算要顶的歌曲行号
            int id = (pageNum - 1) * 6 + index;

            if (id > 1)
            {

                //将ordersong对应的记录复制到第1 行
                DataRow dr = this.orderSongTable.NewRow();
                dr["song_name"] = this.orderSongTable.Rows[id]["song_name"];
                dr["song_url"] = this.orderSongTable.Rows[id]["song_url"];
                dr["singer_name"] = this.orderSongTable.Rows[id]["singer_name"];
                dr["singer_photo_url"] = this.orderSongTable.Rows[id]["singer_photo_url"];

                //将要顶歌曲的原来记录删除
                this.orderSongTable.Rows.RemoveAt(id);

                //将要顶歌曲放在第二行，不能放在第一行，因为第一行的歌曲正在播放，不能直接切
                this.orderSongTable.Rows.InsertAt(dr, 1);

                //将第id行的媒体移动到第1行，修改媒体播放器中歌曲的播放顺序
                axPlayer.currentPlaylist.moveItem(id, 1);

                //刷新列表
                this.ShowOrderSong();
            }
        }

        private void picMain_Click(object sender, EventArgs e)
        {
            fatherfrm.Show();
            this.Hide();
        }

        private void picDelete_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Image = Image.FromFile(@"img\删1.jpg");
        }

        private void picDelete_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Image = Image.FromFile(@"img\删.jpg");
        }

        private void picSoundOff_Click(object sender, EventArgs e)
        {
            if (axPlayer.settings.mute == false)
            {
                axPlayer.settings.mute = true;
            }
            else
            {
                axPlayer.settings.mute = false;
            }
            
        }

        private void picPause_Click(object sender, EventArgs e)
        {
            if (axPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                picPause.Image = null;
                picPause.Image = Image.FromFile(@"img\播放1.png");
                axPlayer.Ctlcontrols.pause();
            }
            else if (axPlayer.playState==WMPLib.WMPPlayState.wmppsPaused)
            {
                picPause.Image = null;
                picPause.Image = Image.FromFile(@"img\暂停1.png");
                axPlayer.Ctlcontrols.play();
            }
        }

        private void picRePlay_Click(object sender, EventArgs e)
        {
            axPlayer.Ctlcontrols.currentPosition = 0;
        }

        //播放按钮的点击事件
        private void picaxPlay_Click(object sender, EventArgs e)
        {
            try
            {
                axPlayer.fullScreen = true;
            }
            catch (Exception)
            {

                MessageBox.Show("请先点歌!");
            }
        }

        private void picUpSound_Click(object sender, EventArgs e)
        {
            if (axPlayer.settings.volume<100)
            {
                axPlayer.settings.volume += 10;
            }
        }

        private void picDownSound_Click(object sender, EventArgs e)
        {
            if (axPlayer.settings.volume >= 0)
            {
                axPlayer.settings.volume -= 10;
            }
        }

        private void PicStop_Click(object sender, EventArgs e)
        {
            axPlayer.Ctlcontrols.next();
            if (this.orderSongTable.Rows.Count>0)
            {
                axPlayer.currentPlaylist.removeItem(
                axPlayer.currentPlaylist.Item[0]);
                this.orderSongTable.Rows.RemoveAt(0);
                ShowOrderSong();
            }
        }
    }
}
