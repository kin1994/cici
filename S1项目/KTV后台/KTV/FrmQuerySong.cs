using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KTV
{
    public partial class FrmQuerySong : Form
    {
        DataView dv = new DataView();
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        //实例歌曲类
        SongInfo songInfo = new SongInfo();
        public FrmQuerySong()
        {
            InitializeComponent();
        }

        //窗体加载
        private void FrmQuerySongByType_Load(object sender, EventArgs e)
        {
            dgvSongInfo.AutoGenerateColumns = false;
            BindingDgv();


            string sqlStr = "select * from song_type";
            SqlCommand command = new SqlCommand(sqlStr,DBHelper.Connection);
            adapter.SelectCommand = command;
            adapter.Fill(ds,"song_type");
            TreeNode root = new TreeNode("全部");
            foreach (DataRow row in ds.Tables["song_type"].Rows)
            {
                TreeNode newNode = new TreeNode(row[1].ToString());
                newNode.Tag = row[0].ToString();
                root.Nodes.Add(newNode);
            }
            tvSongType.Nodes.Add(root);
        }

        //绑定网格
        public void BindingDgv()
        {
            if (Global.ds.Tables != null)
            {
                Global.ds.Tables.Clear();
            }
            Global.FillSongInfo();
            dv.Table = Global.ds.Tables["song_info"];
            dgvSongInfo.DataSource = dv;
        }

        //按歌曲名模糊查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtSongName.Text != "")
            {
                dv.RowFilter = string.Format("song_name like '%{0}%'",txtSongName.Text.Trim());
            }
        }

        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //修改
        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSongInfo.SelectedRows.Count > 0)
            {
                FrmAddSong addSong = new FrmAddSong();
                addSong.songInfo = songInfo;
                addSong.state = "修改";
                addSong.songtype = this;
                addSong.Show();
            }
            else
            {
                MessageBox.Show("请选择一行！");
            }
        }

        //网格选定
        private void dgvSongInfo_Click(object sender, EventArgs e)
        {
            if (dgvSongInfo.SelectedRows.Count > 0)
            {
                songInfo.Song_Id = int.Parse(dgvSongInfo.SelectedRows[0].Cells[0].Value.ToString());
                songInfo.Song_Name = dgvSongInfo.SelectedRows[0].Cells[1].Value.ToString();
                songInfo.Song_ab = dgvSongInfo.SelectedRows[0].Cells[2].Value.ToString();
                songInfo.Song_Word_Count = int.Parse(dgvSongInfo.SelectedRows[0].Cells[3].Value.ToString());
                songInfo.SongType_Id = int.Parse(dgvSongInfo.SelectedRows[0].Cells[9].Value.ToString());
                songInfo.Singer_Name = dgvSongInfo.SelectedRows[0].Cells[5].Value.ToString();
                songInfo.Song_url = dgvSongInfo.SelectedRows[0].Cells[6].Value.ToString();
                songInfo.Song_Play_Count = int.Parse(dgvSongInfo.SelectedRows[0].Cells[7].Value.ToString());
                songInfo.Singer_Id = int.Parse(dgvSongInfo.SelectedRows[0].Cells[8].Value.ToString());
                songInfo.Language_id = int.Parse(dgvSongInfo.SelectedRows[0].Cells[11].Value.ToString());
            }
        }

        //删除
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (dgvSongInfo.SelectedRows.Count > 0)
            {
                FrmAddSong addSong = new FrmAddSong();
                addSong.songInfo = songInfo;
                addSong.state = "删除";
                addSong.songtype = this;
                addSong.Show();
            }
            else
            {
                MessageBox.Show("请选择一行！");
            }

        }

        //树状结构选择
        private void tvSongType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvSongType.SelectedNode.Level == 1)
            {
                dv.RowFilter = string.Format("songtype_id={0}", int.Parse(tvSongType.SelectedNode.Tag.ToString()));
            }
            else if (tvSongType.SelectedNode.Level == 0)
            {
                dv.RowFilter = "";
            }
        }
    }
}
