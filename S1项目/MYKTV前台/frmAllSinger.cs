using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MYKTV
{
    
    public partial class frmAllSinger : Form
    {
        //记录窗体打开特效的参数
        public int ver;
        //搭桥用筛选器
        public string rowFilter = string.Empty;
        //记录父窗体
        public Form fatherFrm = null;

        DataView dv = new System.Data.DataView();
        int pageNum; //当前页数
        int totalPageNum; //总页数

        public frmAllSinger()
        {
            InitializeComponent();
        }

        private void frmAllSinger_Load(object sender, EventArgs e)
        {
            //窗体用何种方式打开
            Win32.AnimateWindow(this.Handle, 500, ver);

            //将视图关联到歌曲表
            dv.Table = Global.Ds.Tables["Singer"];

            if (this.rowFilter != string.Empty)
            {
                dv.RowFilter = this.rowFilter;
            }


            //计算歌手页数
            CountSingerPage();
            //填充歌手
            FillSingerList();
        }

        private void FillSingerList()
        {
            //根据翻页结果，产生合适的基数
            int baseNumber = (this.pageNum - 1) * 8;

            //遍历歌曲面板中的控件
            foreach (Control control in this.pnlSinger.Controls)
            {
                //找到显示歌曲的位置
                if (control.Name.Contains("lblSinger"))
                {
                    //获得当前要显示的歌曲编号
                    int i = int.Parse(control.Name.Substring(9));

                    try
                    {
                        //从dv中找到该显示的歌曲信息
                        //绑定歌名
                        control.Enabled = true;
                        string name = dv.ToTable().Rows[baseNumber + i]["singer_name"].ToString();
                        if (name.Length > 6)
                        {
                            control.Text = name.Substring(0, 3) + "...";
                        }
                        else
                        {
                            control.Text = name;
                        }

                        //绑定这首歌对应的id号，注意考虑歌曲同名的情况，必须用id唯一标识一首歌
                        control.Tag = dv.ToTable().Rows[baseNumber + i]["singer_id"].ToString();
                    }
                    catch (Exception)
                    {
                        control.Enabled = false;
                        control.Text = "";
                        //绑定这首歌对应的id号，注意考虑歌曲同名的情况，必须用id唯一标识一首歌
                        control.Tag = null;
                    }
                }
                else if (control.Name.Contains("picSinger"))
                {
                    //负责填充头像
                    PictureBox pic = (PictureBox)control;
                    int i = int.Parse(pic.Name.Substring(9));

                    try
                    {
                        pic.Enabled = true;
                        pic.Visible = true;
                        string picUrl = Global.PhotoPath + @"\" + dv.ToTable().Rows[baseNumber + i]["singer_photo_url"].ToString();
                        pic.Image = Image.FromFile(picUrl);
                        pic.Tag = dv.ToTable().Rows[baseNumber + i]["singer_id"].ToString();
                    }
                    //多重异常
                    catch (FileNotFoundException)
                    {
                        string picUrl = Global.PhotoPath + @"\nopic.png";
                        pic.Image = Image.FromFile(picUrl);
                        pic.Tag = dv.ToTable().Rows[baseNumber + i]["singer_id"].ToString();
                    }
                    catch (Exception)
                    {
                        pic.Enabled = false;
                        pic.Visible = false;
                        pic.Tag = null;
                    }
                }
            }

        }

        //计算歌曲页数信息
        private void CountSingerPage()
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

            lblPageNum.Text = this.pageNum + "";
            lblTotalNum.Text = this.totalPageNum + "";
        }

        //返回按钮的单击事件
        private void pnlReturn2_Click(object sender, EventArgs e)
        {
            if (this.fatherFrm != null)
            {
                this.fatherFrm.Show();
                this.Dispose();
            }
        }

        private void picSinger_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            //获得头像后面代表的歌手id
            int singerId = int.Parse(pic.Tag.ToString());

            frmPinYin py = new frmPinYin();
            py.fatherFrm = this;
            py.ver = this.ver;
            //设置显示歌曲的筛选器
            py.rowFilter = "singer_id=" + singerId;
            py.Show();
            this.Hide();
        }

        private void lblSinger_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            //获得头像后面代表的歌手id
            int singerId = int.Parse(lbl.Tag.ToString());

            frmPinYin py = new frmPinYin();
            py.fatherFrm = this.fatherFrm;
            py.ver = this.ver;
            //设置显示歌曲的筛选器
            py.rowFilter = "singer_id=" + singerId;
            py.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (fatherFrm!=null)
            {
                fatherFrm.Show();
                this.Dispose();
            }
        }
        //上一页
        private void btnUpPage_Click(object sender, EventArgs e)
        {
            //在有效页数内
            if (this.pageNum > 1)
            {
                //加1
                this.pageNum--;
                lblPageNum.Text = this.pageNum + "";
                //重新填充歌手列表
                FillSingerList();
            }
        }
        //下一页
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            //在有效页数内
            if (this.pageNum < this.totalPageNum)
            {
                //加1
                this.pageNum++;
                lblPageNum.Text = this.pageNum + "";
                //重新填充歌手列表
                FillSingerList();
            }
        }

        private void picMale_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "singer_gender = '男'";
            //重新计算页数
            CountSingerPage();
            //重新填充歌手列表
            FillSingerList();
        }

        private void picFeMale_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "singer_gender = '女'";
            //重新计算页数
            CountSingerPage();
            //重新填充歌手列表
            FillSingerList();
        }

        private void picGroup_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "singer_gender = '组合'";
            //重新计算页数
            CountSingerPage();
            //重新填充歌手列表
            FillSingerList();
        }

        private void pnlSearch_Click(object sender, EventArgs e)
        {
            if (pnlJianPan.Visible == true)
            {
                pnlJianPan.Visible = false;
            }
            else
            {
                pnlJianPan.Visible = true;
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

        private void lblPinYing_TextChanged(object sender, EventArgs e)
        {
            //设置新的行筛选
            dv.RowFilter = string.Format("singer_ab like '{0}%'", lblPinYing.Text);
            //重新计算页数
            CountSingerPage();
            //重新刷新手曲列表
            FillSingerList();
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

    }
}
