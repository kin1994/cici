using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KTV
{
    public partial class frmLanding : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter sdacbo = new SqlDataAdapter();

        DBHelper helper = new DBHelper();

        //验证码
        String validCode = string.Empty;

        //错误次数
        int i;
        public frmLanding()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }//退出


        private void btnQingKong_Click(object sender, EventArgs e)
        {
            this.txtUserName.Clear();
            this.txtPwd.Clear();
            this.txtYanzhen.Clear();
        }//清空


        public bool yanzhen()
        {

            if (txtUserName.Text.Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名");
                return false;

            }
            else if (txtPwd.Text.Equals(string.Empty))
            {
                MessageBox.Show("请输入密码");
                return false;
            }
            else if (cboType.Text.Equals(string.Empty))
            {
                MessageBox.Show("请输入类型");
                return false;
            }
            else if (txtYanzhen.Text == "")
            {
                MessageBox.Show("请输入验证码！");
                return false;
            }
            else
            {
                return true;
            }
        }//验证是否输入了用户,密码,类型，验证码


        public void Login()
        {
            if(yanzhen())
            {
                string name = txtUserName.Text.Trim();
                string pwd = txtPwd.Text.Trim();
                int id=int.Parse(cboType.SelectedValue.ToString());
                try
                {
                    i++;
                    string returnPwd = helper.ValidPwd(name);
                    int typeId = helper.UserTypeId(name);
                    if (returnPwd != pwd || id !=typeId)
                    {
                        if (string.IsNullOrEmpty(returnPwd))
                        {
                            MessageBox.Show("无此用户！");
                        }
                        else if (returnPwd != pwd)
                        {
                            MessageBox.Show("密码错误！");
                        }
                        else if (id != typeId)
                        {
                            MessageBox.Show("用户类型错误！");
                        }

                        if (i == 3)
                        {
                            Application.Exit();
                        }
                        MessageBox.Show("还有" + (3 - i) + "次机会！");
                        picValidWord.Image = this.PaintImage();
                        return;
                    }
                    else
                    {
                        //MessageBox.Show("登录成功！");
                        if (txtYanzhen.Text.ToLower() != validCode.ToLower())
                        {
                            MessageBox.Show("验证码错误！");
                            return;
                        }
                        FrmMain mainFrm = new FrmMain();
                        mainFrm.userName = name;
                        mainFrm.userType = cboType.Text;
                        mainFrm.landing = this;
                        mainFrm.Show();
                        this.txtUserName.Clear();
                        this.txtPwd.Clear();
                        this.txtYanzhen.Clear();
                        picValidWord.Image = this.PaintImage();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
                
            }
        }//登录代码


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
                     

        }//登录


        private void frmLanding_Load(object sender, EventArgs e)
        {
            i = 0;
            try
            {
                string sql = "select * from admin_type";
                sdacbo = new SqlDataAdapter(sql,DBHelper.Connection);
                sdacbo.Fill(ds, "admin_type");
                this.cboType.DataSource = ds.Tables["admin_type"];
                this.cboType.DisplayMember = "admintype_name";
                this.cboType.ValueMember = "admintype_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            picValidWord.Image = this.PaintImage();
        }

        //点击图片换验证码
        private void picValidWord_Click(object sender, EventArgs e)
        {
            picValidWord.Image = this.PaintImage();    
        }

        //生成验证码图片
        public Image PaintImage()
        {
            Random random = new Random();

            int MyWidth = 116;
            int MyHeight = 38;
            Image img = new Bitmap(MyWidth, MyHeight);
            Graphics g = Graphics.FromImage(img);
            int p1 = random.Next(3, 50);
            int p2 = random.Next(3, 15);
            int len = 20;
            int x1, x2, y1, y2;

            validCode = "";
            string drawString = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(0, drawString.Length);
                validCode += drawString.Substring(index, 1);
            }
            FontStyle fstyle = FontStyle.Bold;
            Font drawFont = new Font("宋体", 16,fstyle);

            SolidBrush drawBrush = new SolidBrush(Color.Blue);

            #region 划线
            g.DrawString(validCode, drawFont, drawBrush, new Point(p1, p2));
            for (int i = 0; i < 20; i++)
            {
                x1 = random.Next(0, 116);
                y1 = random.Next(0, 38);
                int tem = random.Next(0, len);
                if (random.Next(0, 2) == 0)
                {
                    x2 = x1 - tem;
                }
                else
                {
                    x2 = x1 + tem;
                }
                if (random.Next(0, 2) == 0)
                {
                    y2 = y1 - (int)Math.Sqrt(len * len - tem * tem);
                }
                else
                {
                    y2 = y1 + (int)Math.Sqrt(len * len - tem * tem);
                }
                int argb = random.Next(-13777216, -10000);
                Color color = Color.FromArgb(argb);
                Pen pen = new Pen(color);
                g.DrawLine(pen, x1, y1, x2, y2);
            }
            #endregion

            #region 画点
            Color col = Color.White;
            Color co = Color.Black;

            //int argb=random.Next(-16777216, -1);

            for (int i = 0; i < 26; i++)
            {
                int argb = random.Next(-13777216, -10000);
                Color color = Color.FromArgb(argb);
                Pen pen = new Pen(color);
                x1 = random.Next(0, 116);
                y1 = random.Next(0, 38);
                g.DrawLine(pen, x1, y1, x1 + 1, y1);
            }
            #endregion

            return img;
        }
    }
}
