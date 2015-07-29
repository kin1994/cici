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
    public partial class FrmChangePwd : Form
    {
        public string userName = string.Empty;
        public FrmChangePwd()
        {
            InitializeComponent();
        }

        //取消
        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //修改密码
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldpwd=txtOldPwd.Text.Trim();
            string newpwd1=txtNewPwd1.Text.Trim();
            string newpwd2=txtNewPwd2.Text.Trim();
            if(oldpwd==""||newpwd1==""||newpwd2=="")
            {
                MessageBox.Show("资料不完整");
                return;
            }
           
            try
            {
                DBHelper helper = new DBHelper();
                string pwd = helper.ValidPwd(userName);
                if (pwd != oldpwd)
                {
                    MessageBox.Show("原密码错误，请重新输入！");
                    return;
                }
                if (newpwd1 != newpwd2)
                {
                    MessageBox.Show("两次密码不一致！");
                    return;
                }
                //调用DBHelper修改密码方法
                bool flag = helper.UpdatePwd(userName, newpwd1);
                if (flag)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
