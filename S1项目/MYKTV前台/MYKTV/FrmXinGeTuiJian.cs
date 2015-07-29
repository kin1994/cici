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
    public partial class FrmXinGeTuiJian : Form
    {
        //记录父窗体
        public FrmMain fatherFrm = null;
        //记录窗体打开特效的参数
        public int ver;
        DataView dv = new System.Data.DataView();
        int pageNum;//当前页数
        int totalPageNum=2;//总页数
        public string rowFilter = string.Empty;//创建一个筛选器

        DBHelper db = new DBHelper();

        public FrmXinGeTuiJian()
        {
            InitializeComponent();
        }


        //歌曲页数信息
        private void CountSongPage()
        {
            this.pageNum = 1;
            lblDiJiYe.Text = pageNum.ToString();
            lblYeShu.Text ="2";
        }


        //下一页
        private void pnlXiaYiYe_Click(object sender, EventArgs e)
        {
            if (this.pageNum < this.totalPageNum)
            {
                this.pageNum++;
                lblDiJiYe.Text = pageNum.ToString();
                //重新填词歌曲列表
                FillMessage();
            }
        }


        //上一页
        private void pnlShangYiYe_Click(object sender, EventArgs e)
        {
            if (this.pageNum > 1)
            {
                this.pageNum--;
                lblDiJiYe.Text = pageNum.ToString();
                //重新填充歌曲列表
                FillMessage();
            }
        }


        //窗体加载
        private void FrmXinGeTuiJian_Load(object sender, EventArgs e)
        {
            string msg = string.Empty;
            dv.Table = Global.Ds.Tables["Song"];
            dv.Sort= "AddDate desc";
            CountSongPage();//页数
            FillMessage();//填充歌曲
        }

        //填充歌曲信息
        private void FillMessage()
        {
            //根据翻页结果,产生何事的基数
            int baseNumber = (this.pageNum - 1) * 12;
            //遍历歌曲面板中的控件
            foreach (Control control in pnlXinGeTuiJian.Controls)
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
                        //绑定歌对应的Id号，用Id唯一标识一首歌
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
                else if (control.Name.Contains("lblSinger"))
                {
                    //获取当前要显示歌曲编号
                    int j = int.Parse(control.Name.Substring(9));
                    try
                    {
                        //绑定歌名
                        control.Enabled = true;
                        control.Text = dv.ToTable().Rows[j + baseNumber]["singer_name"].ToString();
                        //绑定歌对应的Id号，用Id唯一标识一首歌
                        control.Tag = dv.ToTable().Rows[j + baseNumber][0].ToString();
                    }
                    catch (Exception)
                    {
                        control.Enabled = false;
                        control.Text = "";
                        control.Tag = null;
                    }
                }
            }
        }

        //返回
        private void pnlFanHiu_Click(object sender, EventArgs e)
        {
            if (fatherFrm != null)
            {
                fatherFrm.Show();
                this.Dispose();
            }
        }

        //点歌
        private void lblSong_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string songPath = Global.SongPath;
            lbl.ForeColor = Color.Red;
            if (lbl.Name.Contains("lblSong"))
            {
                int i = int.Parse(lbl.Name.Substring(7));
                Label Singer = (Label)this.pnlXinGeTuiJian.Controls.Find("lblSinger" + i, false)[0];
                Singer.ForeColor = Color.Red;
            }
            else
            {
                int i = int.Parse(lbl.Name.Substring(9));
                Label Singer = (Label)this.pnlXinGeTuiJian.Controls.Find("lblSong" + i, false)[0];
                Singer.ForeColor = Color.Red;
            }
            //要客户选中的歌曲放到OrderSong表
            foreach (DataRow row in Global.Ds.Tables["Song"].Rows)
            {
                int songId = int.Parse(lbl.Tag.ToString());
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
