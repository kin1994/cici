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
    public partial class FrmWordNumbercs : Form
    {
        //记录父窗体
        public FrmMain fatherFrm = null;
        public int ver;
        
        public FrmWordNumbercs()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (fatherFrm != null)
            {
                fatherFrm.Show();
                this.Dispose();
            }
        }

   
        private void FrmWordNumbercs_Load_1(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 500, ver);
            //把字幕初始位置设成最右边
            tmrZiMu.Enabled = true;
        }

        private void picEnglish_Click(object sender, EventArgs e)
        {
            frmPinYin py = new frmPinYin();
            py.rowFilter = "languageid = 3";
            py.fatherFrm = this;
            py.Show();
            this.Hide();
        }

        private void picNums_Click(object sender, EventArgs e)
        {
            PictureBox pic=(PictureBox)sender;
            int num = int.Parse(pic.Name.Substring(3));
            frmPinYin py = new frmPinYin();
            py.fatherFrm = this;
            if (num == 7)
            {
                py.rowFilter = string.Format("song_word_count >= {0}", num);
            }
            else
            {
                py.rowFilter = string.Format("song_word_count = {0}", num);
            }
            py.Show();
            this.Hide();
        }

        private void tmrZiMu_Tick(object sender, EventArgs e)
        {
            lblInfo.Text = "当前播放：" + Global.frmPlayer.lblPlayNow.Text + "                下一首:" + Global.frmPlayer.lblPlayNext.Text;
            lblInfo.Left = lblInfo.Left - 3;
            if (lblInfo.Right < 0)
            {
                lblInfo.Left = this.Width;
            }
        }
    }
}
