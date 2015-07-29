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
    public partial class FrmSingerPhotoResource : Form
    {
        public FrmSingerPhotoResource()
        {
            InitializeComponent();
        }

        //浏览路径
        private void btnBrower_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdSingerPhoto.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = ofdSingerPhoto.FileName;
                file=file.Substring(0,file.LastIndexOf(@"\"));
                txtPhotoUrl.Text = file;
            }
        }

        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //保存路径
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper helper = new DBHelper();
                bool flag = helper.UpdateSingerPhotoUrl(txtPhotoUrl.Text.Trim());
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
