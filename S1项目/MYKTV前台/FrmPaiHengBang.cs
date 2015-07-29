using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MYKTV
{
    public partial class FrmPaiHengBang : Form
    {
        //记录父窗体
        public FrmMain fatherFrm = null;
        //记录窗体打开特效的参数
        public int ver;
        DataView dv = new System.Data.DataView();
        int pageNum;//当前页数
        int totalPageNum;//总页数
        public string rowFilter = string.Empty;//创建一个筛选器

        DBHelper db = new DBHelper();

        public FrmPaiHengBang()
        {
            InitializeComponent();
        }

        //计算歌曲页数信息
        private void CountSongPage()
        {
            this.pageNum = 1;
            //获取总歌曲数
            int totalSongNumber = dv.ToTable().Rows.Count;
            //判断页数
            if (totalSongNumber % 8 == 0)
            {
                this.totalPageNum = totalSongNumber / 8;
            }
            else
            {
                this.totalPageNum = totalSongNumber / 8 + 1;

            }
        }


        //下一页
        private void pnlXiaYiYe_Click(object sender, EventArgs e)
        {
            if (this.pageNum < this.totalPageNum)
            {
                this.pageNum++;
                //重新填词歌曲列表
                FillSongList();
            }
        }
         

        //上一页
        private void pnlShangYiYe_Click(object sender, EventArgs e)
        {
            if (this.pageNum > 1)
            {
                this.pageNum--;
                //重新填充歌曲列表
                FillSongList();
            }
        }


        //窗体加载
        private void FrmPaiHengBang_Load(object sender, EventArgs e)
        {
            string msg = string.Empty;
            dv.Table = Global.Ds.Tables["Song"];
            dv.Sort = "song_play_count desc";
            CountSongPage();
            FillSongList();
        }


        //填充歌曲
        private void FillSongList()
        {
            //根据翻页结果,产生何事的基数
            int baseNumber = (this.pageNum - 1) * 8;
            //遍历歌曲面板中的控件
            foreach (Control control in this.Controls)
            {
                //找到显示歌曲的位置
                if (control.Name.Contains("lblSong"))
                {
                    //获取当前要显示歌曲编号
                    int i = int.Parse(control.Name.Substring(7));
                    try
                    {
                        //绑定歌名
                        control.Enabled = true;
                        control.Text = dv.ToTable().Rows[i + baseNumber][1].ToString();
                        //绑歌对应的Id号，用Id唯一标识一首歌
                        control.Tag = dv.ToTable().Rows[i + baseNumber][0].ToString();
                        if (control.Text.Length>4)
                        {
                            control.Text = control.Text.Substring(0,4)+"...";
                        }
                        
                    }
                    catch (Exception)
                    {
                        control.Enabled = false;
                        control.Text = "";
                        //绑定歌对应的Id号，使用ID唯一标识一首歌
                        control.Tag = null;
                    }
                }
                else if (control.Name.Contains("lblCount"))
                {
                    //获取当前要显示歌曲编号
                    int i = int.Parse(control.Name.Substring(8));
                    try
                    {
                        //绑定歌名
                        control.Enabled = true;
                        control.Text = dv.ToTable().Rows[i + baseNumber]["song_play_count"].ToString();
                        //绑歌对应的Id号，用Id唯一标识一首歌
                        control.Tag = dv.ToTable().Rows[i + baseNumber][0].ToString();
                    }
                    catch (Exception)
                    {
                        control.Enabled = false;
                        control.Text = "";
                        //绑定歌对应的Id号，使用ID唯一标识一首歌
                        control.Tag = null;
                    }
                }
            }
        }
        //返回
        private void pnlFanHui_Click(object sender, EventArgs e)
        {
            if (fatherFrm != null)
            {
                fatherFrm.Show();
                this.Hide();
            }
        }


        private void lblSong_Click(object sender, EventArgs e)
        {
             Label lbl = (Label)sender;
             lbl.ForeColor = Color.Red;
             if (lbl.Name.Contains("lblSong"))
             {
                 int i = int.Parse(lbl.Name.Substring(7));
                 Label count = (Label)this.Controls.Find("lblCount" + i, false)[0];
                 count.ForeColor = Color.Red;
             }
             else
             {
                 int i = int.Parse(lbl.Name.Substring(8));
                 Label count = (Label)this.Controls.Find("lblSong" + i, false)[0];
                 count.ForeColor = Color.Red;
             }

            int songId = int.Parse(lbl.Tag.ToString());
            string songPath = Global.SongPath;
            //要客户选中的歌曲放到OrderSong表
            foreach (DataRow row in Global.Ds.Tables["Song"].Rows)
            {
                int sId = int.Parse(row["song_id"].ToString());
               
                if (songId == sId)
                {
                    //根据id号找到歌曲的地址、名称、歌手图片和姓名，存入到ordersong表中，形成新的点歌记录
                    DataRow newOrder = Global.Ds.Tables["orderSong"].NewRow();
                    //song_name,song_url,singer_name,singer_photo_url 
                    newOrder["song_name"] = row["song_name"];
                    newOrder["song_url"] = row["song_url"];
                    songPath += @"\" + row["song_url"].ToString();
                    newOrder["singer_name"] = row["singer_name"];
                    newOrder["singer_photo_url"] = row["singer_photo_url"];
                    Global.Ds.Tables["orderSong"].Rows.Add(newOrder);
                    db.AddPlayCount(sId);
                    this.FillSongList();
                    break;
                }
            }
            if (Global.frmPlayer == null)
            {
                Global.frmPlayer.AddSong(songPath);
                //设置播放器为开始播放状态
                Global.frmPlayer.axPlayer.settings.autoStart = true;
            }
            else
            {
                //添加新的歌曲播放路径到播放器中
                Global.frmPlayer.AddSong(songPath);
                //刷新播放歌曲界面
                Global.frmPlayer.ShowOrderSong();
                //Global.frmPlayer.Show();
            }
        } 
    }
}
