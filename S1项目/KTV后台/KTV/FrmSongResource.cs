using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KTV
{
    public partial class FrmSongResource : Form
    {
        public FrmSongResource()
        {
            InitializeComponent();
        }

       //取消
        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //浏览路径
        private void btnBrower_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdSongUrl.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = ofdSongUrl.FileName;
                file = file.Substring(0, file.LastIndexOf(@"\"));
                txtSongRoad.Text = file;
            }
        }

        //修改路径
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper helper = new DBHelper();
                bool flag = helper.UpdateSongUrl(txtSongRoad.Text.Trim());
                if (flag)
                {
                    MessageBox.Show("修改成功！");
                    Global g = new Global();
                    g.AddResource();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
