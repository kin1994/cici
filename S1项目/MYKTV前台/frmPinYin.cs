using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MYKTV
{
    public partial class frmPinYin : Form
    {
        //记录窗体打开特效的参数
        public int ver;
        //搭桥用筛选器
        public string rowFilter = string.Empty;
        //记录父窗体
        public Form fatherFrm;

        DBHelper db = new DBHelper();

        DataView dv = new System.Data.DataView();

        //当前经过的lblSong是否被单击，如果单击了就设成true
        bool flag = false;

        int pageNum; //当前页数
        int totalPageNum; //总页数

        public frmPinYin()
        {
            InitializeComponent();
        }

        private void pnlReturn_Click(object sender, EventArgs e)
        {
            if (fatherFrm!=null)
            {
                fatherFrm.Show();
                this.Dispose();
            }
        }

        private void frmPinYin_Load(object sender, EventArgs e)
        {
            //窗体用何种方式打开
            Win32.AnimateWindow(this.Handle, 500, ver);
            //将视图关联到歌曲表
            dv.Table = Global.Ds.Tables["Song"];

            if (this.rowFilter != string.Empty)
            {
                dv.RowFilter = this.rowFilter;
            }

            //计算歌曲页数
            CountSongPage();
            //填充歌曲
            FillSongList();
        }

        //计算歌曲页数信息
        private void CountSongPage()
        {
            this.pageNum = 1;
            //获取总歌曲数
            int totalSongNumber = dv.ToTable().Rows.Count;

            //判断页数
            if (totalSongNumber % 10 == 0)
            {
                this.totalPageNum = totalSongNumber / 10;
            }
            else
            {
                this.totalPageNum = totalSongNumber / 10 + 1;
            }

            lblPageNum.Text = this.pageNum + "";
            lblTotalNum.Text = this.totalPageNum + "";
        }

        private void FillSongList()
        {
            //根据翻页结果，产生合适的基数
            int baseNumber = (this.pageNum - 1) * 10;

            //遍历歌曲面板中的控件
            foreach (Control control in this.pnlCenter.Controls)
            {
                //找到显示歌曲的位置
                if (control.Name.Contains("lblSong"))
                {
                    //获得当前要显示的歌曲编号
                    int i = int.Parse(control.Name.Substring(7));

                    try
                    {
                        //从dv中找到该显示的歌曲信息
                        //绑定歌名
                        control.Enabled = true;
                        control.Text = dv.ToTable().Rows[baseNumber + i]["song_name"].ToString();
                        //绑定这首歌对应的id号，注意考虑歌曲同名的情况，必须用id唯一标识一首歌
                        control.Tag = dv.ToTable().Rows[baseNumber + i][0].ToString();
                        control.ForeColor = Color.Black;
                    }
                    catch (Exception)
                    {
                        control.Enabled = false;
                        control.Text = "";
                        //绑定这首歌对应的id号，注意考虑歌曲同名的情况，必须用id唯一标识一首歌
                        control.Tag = null;
                    }

                }
            }

        }
        
        //字母按钮的单击事件
        private void pnlLetter_Click(object sender, EventArgs e)
        {
            //获取被单击的字母按钮
            Panel lbl = (Panel)sender;
            //读取按钮代表的字母
            string letter = lbl.Name.Substring(3);
            //当拼音总长度小于9时，添加新字母
            if (lblPinYing.Text.Length < 6)
            {
                lblPinYing.Text += letter;
            }
        }

        //退格事件
        private void pnlDelete_Click(object sender, EventArgs e)
        {
            //当有字母时
            if (lblPinYing.Text.Length > 0)
            {
                lblPinYing.Text = lblPinYing.Text.Substring(0, lblPinYing.Text.Length - 1);
            }
        }

        //向下翻页
        private void pnlNextPage_Click(object sender, EventArgs e)
        {
            //在有效页数内
            if (this.pageNum < this.totalPageNum)
            {
                //加1
                this.pageNum++;
                lblPageNum.Text = this.pageNum + "";
                //重新填充歌曲列表
                FillSongList();
            }
        }

        private void pnlUpPage_Click(object sender, EventArgs e)
        {
            if (pageNum>1)
            {
                //减1
                this.pageNum--;
                lblPageNum.Text = this.pageNum + "";
                //重新填充歌曲列表
                FillSongList();
            }
        }

        private void lblSong_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.Black;
            lbl.ForeColor = Color.White;
        }


        private void pnlReturn_Click_1(object sender, EventArgs e)
        {
            if (fatherFrm!=null)
            {
                fatherFrm.Show();
                this.Dispose();
            }
        }
        //筛选歌曲
        private void lblPinYing_TextChanged(object sender, EventArgs e)
        {
            //设置新的行筛选
            dv.RowFilter = string.Format("song_ab like '{0}%'", lblPinYing.Text);
            //重新计算页数
            CountSongPage();
            //重新刷新歌曲列表
            FillSongList();
        }
        //选中歌曲之后
        private void lblSong_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            int songId = int.Parse(lbl.Tag.ToString());
            string songPath = Global.SongPath;
            //要客户选中的歌曲放到OrderSong表
            foreach (DataRow row in Global.Ds.Tables["Song"].Rows)
            {
                //把字体调成红色，同时把flag设成true
                lbl.ForeColor = Color.Red;
                flag = true;
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
        //搜素栏被单击的时间
        private void pnlSearch_Click(object sender, EventArgs e)
        {
            //如果点击时键盘为不可见是设为可见，反之设为不可见
            if (pnlJianPan.Visible == true)
            {
                pnlJianPan.Visible = false;
            }
            else
            {
                pnlJianPan.Visible = true;
            }
        }

        private void lblPinYing_TextChanged_1(object sender, EventArgs e)
        {
            //设置新的行筛选
            dv.RowFilter = string.Format("song_ab like '{0}%'", lblPinYing.Text);
            //重新计算页数
            CountSongPage();
            //重新刷新歌曲列表
            FillSongList();
        }
        //鼠标离开lblSong的事件
        private void lblSong0_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = TransparencyKey;
            //如果没被点击就把字体颜色设成黑色
            if (flag==false)
            {
                lbl.ForeColor = Color.Black;
            }
            flag = false;
        }
    }
}
