using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MYKTV
{
    public partial class FrmYuZhongDianGe : Form
    {
        //窗体用什么方式打开
        public int ver;
        //记录父窗体
        public FrmMain fatherFrm = null;

        DataView dv = new System.Data.DataView();
        int pageNum; //当前页数
        int totalPageNum; //总页数
        public FrmYuZhongDianGe()
        {
            InitializeComponent();
        }
        private void picYuZhong_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int id = int.Parse(pic.Name.Substring(10));
            frmPinYin py = new frmPinYin();
            py.ver = Win32.AW_CENTER;
            py.rowFilter = "Languageid = "+id;
            py.fatherFrm = this;
            py.Show();
            this.Hide();
        }
        /// <summary>
        /// 获取语言表
        /// </summary>
        private void GetLanguage()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sqlstr = "select * from Languages";
            SqlCommand command = new SqlCommand(sqlstr,DBHelper.Conn);
            adapter.SelectCommand = command;
            adapter.Fill(Global.Ds,"Language");

        }
        private void FrmYuZhongDianGe_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle,500,ver);
            this.GetLanguage();
            dv.Table = Global.Ds.Tables["Language"];
            //计算语种页数
            CountLanguagePage();
        }
        //计算语种页数信息
        private void CountLanguagePage()
        {
            this.pageNum = 1;
            //获取总歌曲数
            int totalLanguageNumber = dv.ToTable().Rows.Count;
            //判断页数
            if (totalLanguageNumber % 8 == 0)
            {
                this.totalPageNum = totalLanguageNumber / 8;
            }
            else if (totalPageNum > 8)
            {
                this.totalPageNum = totalLanguageNumber / 8 + 1;
            }
            else
            {
                totalPageNum = 1;
            }

            lblPageNum.Text = this.pageNum + "";
            lblTotalNum.Text = this.totalPageNum + "";
        }


        private void pnlReturn2_Click(object sender, EventArgs e)
        {
            if (this.fatherFrm != null)
            {
                this.fatherFrm.Show();
                this.Dispose();
            }
        }

        private void btnUpPage_Click(object sender, EventArgs e)
        {
            if (this.pageNum > 1)
            {
                //减1
                this.pageNum--;
                lblPageNum.Text = this.pageNum + "";
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            //在有效页数内
            if (this.pageNum > this.totalPageNum)
            {
                //加1
                this.pageNum++;
                lblPageNum.Text = this.pageNum + "";
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (fatherFrm!=null)
            {
                fatherFrm.Show();
                this.Dispose(); 
            }
        }

    }
}
