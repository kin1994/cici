using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KTV
{
    public partial class FrmAddSong : Form
    {
        public FrmQuerySong songtype =new FrmQuerySong();

        //歌手编号
        public string singerid = string.Empty;
        //歌手名
        public string singerName = string.Empty;
        string songLoad = string.Empty;

        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DBHelper helper = new DBHelper();

        public string state = "添加";

        public SongInfo songInfo = new SongInfo();
        public FrmAddSong()
        {
            InitializeComponent();
        }

        //添加、删除、修改方法
        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    if (txt.Text == "")
                    {
                        MessageBox.Show("信息不完整！");
                        txt.Focus();
                        return;
                    }
                }
            }
            try
            {
                songInfo.Song_Name =txtSongName.Text.Trim();
                songInfo.Song_ab = txtAb.Text.Trim();
                songInfo.Song_Word_Count = int.Parse(txtWordCount.Text);
                songInfo.SongType_Id = int.Parse(cmbSongType.SelectedValue.ToString());
                songInfo.Singer_Id=int.Parse(singerid);
                songInfo.Song_url = txtSongRoad.Text.Trim();
                songInfo.Song_Play_Count = int.Parse(txtPlayCount.Text);
                songInfo.Language_id = int.Parse(cmbLanguage.SelectedValue.ToString());
                if (songInfo.SongType_Id <= 0)
                {
                    MessageBox.Show("请选择歌曲类型！");
                    return;
                }
                bool flag=false;
                if (state == "添加")
                {
                    string fileName = songInfo.Song_Name + songInfo.Song_url.Substring(songInfo.Song_url.LastIndexOf("."));
                    songInfo.Song_url = fileName;
                    try
                    {
                        File.Copy(songLoad, Global.songUrl + fileName);
                        flag = helper.InsertSongInfo(songInfo);
                    }
                    catch (Exception)
                    {
                        DialogResult result = MessageBox.Show("已存在同名文件，是否覆盖？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            File.Copy(songLoad, Global.songUrl + fileName, true);
                            flag = helper.InsertSongInfo(songInfo);
                        }
                    }

                    //string[] songName = helper.GetSongName();
                    //bool isRepeat = false;
                    //DialogResult result=DialogResult.No;
                    ////foreach (string name in songName)
                    ////{
                    ////    if (name == songInfo.Song_Name)
                    ////    {
                    ////        result = MessageBox.Show("已存在同名歌曲，是否继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    ////        isRepeat = true;
                    ////    }
                    ////}
                    //if (isRepeat == false)
                    //{
                    //    flag = helper.InsertSongInfo(songInfo);
                    //}
                    //else if (isRepeat && result == DialogResult.Yes)
                    //{
                    //    flag = helper.InsertSongInfo(songInfo);
                    //}
                    //else
                    //{
                    //    return;
                    //}
                    
                }
                else if (state == "修改")
                {
                    DialogResult result = MessageBox.Show("是否确定修改！","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            string fileName = songInfo.Song_Name + songInfo.Song_url.Substring(songInfo.Song_url.LastIndexOf("."));
                            songInfo.Song_url = fileName;
                            File.Copy(songLoad, Global.songUrl + fileName, true);
                            flag = helper.UpdateSongInfo(songInfo);
                        }
                        catch (Exception)
                        {
                            
                        }
                   }
                    else
                    {
                        return;
                    }    
                }
                else
                {
                    DialogResult result = MessageBox.Show("是否确定删除！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        flag = helper.DeleteSongInfo(songInfo);
                    }
                    else
                    {
                        return;
                    }       
                }
                if (flag)
                {
                    MessageBox.Show(state + "成功！");
                    if(songtype!=null)
                    songtype.BindingDgv();
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

        //选择歌手方法
        private void btnSelect_Click(object sender, EventArgs e)
        {
            FrmSingerList singerListFrm = new FrmSingerList();
            singerListFrm.addSongFrm = this;
            singerListFrm.Show();
        }

        //显示歌手名
        public void ShowSingerName()
        {
            txtSingerName.Text = singerName;
        }

        //窗体加载时方法
        private void FrmAddSong_Load(object sender, EventArgs e)
        {
            string sqlStr = "select * from song_type";
           SqlCommand command = new SqlCommand(sqlStr,DBHelper.Connection);
           adapter.SelectCommand = command;
           adapter.Fill(ds,"song_type");
           cmbSongType.DataSource=ds.Tables["song_type"];
           cmbSongType.DisplayMember = "songtype_name";
           cmbSongType.ValueMember = "songtype_id";



           sqlStr = "select * from Languages";
           command.CommandText = sqlStr;
           adapter.SelectCommand = command;
           adapter.Fill(ds, "Languages");
           cmbLanguage.DataSource = ds.Tables["Languages"];
           cmbLanguage.DisplayMember = "Language_name";
           cmbLanguage.ValueMember = "Language_id";
           if (state == "修改")
           {
               txtPlayCount.ReadOnly = false;
               this.Text = "修改歌曲";
               ShowSongInfo();
           }
           if (state == "删除")
           {
               this.Text = "删除歌曲";
               ShowSongInfo();
           }
        }

        //修改，删除时显示歌曲信息
        private void ShowSongInfo()
        {
            btnAdd.Text = state;
            txtSongName.Text = songInfo.Song_Name;
            txtAb.Text = songInfo.Song_ab;
            txtWordCount.Text = songInfo.Song_Word_Count.ToString();
            cmbSongType.SelectedValue = songInfo.SongType_Id;
            txtSingerName.Text = songInfo.Singer_Name;
            singerid = songInfo.Singer_Id.ToString();
            txtSongRoad.Text = songInfo.Song_url;
            txtPlayCount.Text = songInfo.Song_Play_Count.ToString();
            cmbLanguage.SelectedValue = songInfo.Language_id;
            songLoad = Global.songUrl + songInfo.Song_url;
        }

        //取得歌曲路径
        private void btnBrower_Click(object sender, EventArgs e)
        {
            ofdSongRoad.Filter = "";
            ofdSongRoad.Filter = "歌曲文件 (*.mp3)|*.mp3|(*.mp4)|*.mp4|所有文件 (*.*)|*.*";
            ofdSongRoad.FilterIndex = 1;
            ofdSongRoad.RestoreDirectory = true;

            DialogResult result=ofdSongRoad.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = ofdSongRoad.FileName;
                songLoad = filename;
                txtSongRoad.Text =  songLoad.Substring(songLoad.LastIndexOf(@"\")+1); 
            }
            
        }

        //关闭
        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
