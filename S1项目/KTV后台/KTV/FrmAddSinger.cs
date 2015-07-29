using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KTV
{
    public partial class FrmAddSinger : Form
    {
        //照片路径
        string imageRoad = string.Empty;

        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DBHelper helper = new DBHelper();

        public SingerInfo singerInfo = new SingerInfo();

        //父窗体
        public FrmQuerySinger byTypeFrm = null;

        //功能变量
        public string state = "添加";

        public FrmAddSinger()
        {
            InitializeComponent();
        }
         
        //窗体加载
        private void FrmAddSinger_Load(object sender, EventArgs e)
        {
            
            try
            {
                string file = Global.singerPhotoUrl + "nopic.png";
                picSingerPhoto.Image = Image.FromFile("nopic.png");
                string sqlStr = "select * from singer_type ";
                SqlCommand command = new SqlCommand(sqlStr, DBHelper.Connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "singer_type");
                cmbSingerType.DataSource = ds.Tables["singer_type"];
                cmbSingerType.DisplayMember = "singertype_name";
                cmbSingerType.ValueMember = "singertype_id";
                if (state == "修改")
                {
                    btnAdd.Text = state;
                    this.Text = "修改歌手信息";
                    file = Global.singerPhotoUrl + singerInfo.Singer_Photo_url;
                    picSingerPhoto.Image = Image.FromFile(file);
                    AddSingerInfo();
                }
                if (state == "删除")
                {
                    btnAdd.Text = state;
                    this.Text = "删除歌手信息";
                    file = Global.singerPhotoUrl + singerInfo.Singer_Photo_url;
                    picSingerPhoto.Image = Image.FromFile(file);
                    AddSingerInfo();
                }
            
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //string file = Global.singerPhotoUrl + "nopic.png";
                //picSingerPhoto.Image = Image.FromFile(file);
                picSingerPhoto.Image = Image.FromFile("nopic.png");
            }
            
        }

        //修改、删除时，歌手信息预览
        private void AddSingerInfo()
        {
            txtSingerName.Text = singerInfo.Singer_Name;
            cmbSingerType.SelectedValue = singerInfo.SingerType_Id;
            if (singerInfo.Singer_Gender == "男")
            {
                radMale.Checked = true;
            }
            else if (singerInfo.Singer_Gender == "女")
            {
                radFemale.Checked = true;
            }
            else
            {
                radGroup.Checked = true;
            }
            txtSingerAb.Text = singerInfo.Singer_ab;
            imageRoad = Global.singerPhotoUrl + singerInfo.Singer_Photo_url;
            txtDescription.Text = singerInfo.Singer_Description;
            string str = helper.PhotoUrl();
            string url = helper.PhotoUrl() + @"\" + singerInfo.Singer_Photo_url;
            try
            {
                picSingerPhoto.Image = Image.FromFile(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //浏览照片
        private void btnBrower_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdSingerPhoto.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename=ofdSingerPhoto.FileName;
                picSingerPhoto.Image = Image.FromFile(filename);
                imageRoad = filename;
            }
        }

        //添加歌手信息
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSingerName.Text == "")
            {
                MessageBox.Show("歌手名不能为空！");
                return;
            }
            if (txtSingerAb.Text == "")
            {
                MessageBox.Show("歌手名缩写不能为空！");
                return;
            }
           
            try
            {
                singerInfo.Singer_Name= txtSingerName.Text.Trim();
                singerInfo.SingerType_Id = int.Parse(cmbSingerType.SelectedValue.ToString());
                if (radFemale.Checked == true)
                {
                    singerInfo.Singer_Gender = "女";
                }
                else if (radMale.Checked)
                {
                    singerInfo.Singer_Gender = "男";
                }
                else
                {
                    singerInfo.Singer_Gender = "组合";
                }
                singerInfo.Singer_Description = txtDescription.Text.Trim();
                singerInfo.Singer_ab = txtSingerAb.Text.Trim();
                if (string.IsNullOrEmpty(imageRoad))
                {
                    imageRoad = Global.singerPhotoUrl+"nopic.png";
                }
                singerInfo.Singer_Photo_url = txtSingerName.Text.Trim() + imageRoad.Substring(imageRoad.LastIndexOf(".")); 
               
                bool flag=false;
                if (state == "修改")
                {
                    try
                    {
                        string fileName = singerInfo.Singer_Name + singerInfo.Singer_Photo_url.Substring(singerInfo.Singer_Photo_url.LastIndexOf("."));
                        File.Copy(imageRoad, Global.singerPhotoUrl + fileName, true);
                        flag = helper.UpdateSingerInfo(singerInfo);
                    }
                    catch (Exception ex)
                    {
                        
                    }
                    
                }
                else if (state == "删除")
                {
                    flag = helper.DeleteSingerInfo(singerInfo);
                }
                else
                {
                    string fileName = singerInfo.Singer_Name + singerInfo.Singer_Photo_url.Substring(singerInfo.Singer_Photo_url.LastIndexOf("."));
                    try
                    {
                        File.Copy(imageRoad, Global.singerPhotoUrl + fileName);
                        flag = helper.InsertSingerInfo(singerInfo);
                    }
                    catch (Exception)
                    {
                        DialogResult result = MessageBox.Show("已存在同名文件，是否覆盖？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            File.Copy(imageRoad, Global.singerPhotoUrl + fileName, true);
                            flag = helper.InsertSingerInfo(singerInfo);
                        }
                    }
                    
                }
                
                if (flag)
                {
                    MessageBox.Show(state + "成功！");
                    if (byTypeFrm != null)
                    {
                        byTypeFrm.BindingDgv();
                    }

                }
                else
                {
                    MessageBox.Show(state+"失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //取消
        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
