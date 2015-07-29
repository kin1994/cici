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
    public partial class FrmSingerList : Form
    {
        //回传窗体
        public FrmAddSong addSongFrm = null;

        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataView dv = new DataView();
        public FrmSingerList()
        {
            InitializeComponent();
        }

        //加载窗体
        private void FrmSingerList_Load(object sender, EventArgs e)
        {
            dgvSingerList.AutoGenerateColumns = false;
            try
            {
                string sqlStr = "select i.*,t.* from singer_info as i "
                                +"left join singer_type as t on (i.singertype_id=t.singertype_id) ";
                SqlCommand command = new SqlCommand(sqlStr,DBHelper.Connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds,"singer_info");
                dv.Table=ds.Tables["singer_info"];
                dgvSingerList.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //按歌手名模糊查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtSingerName.Text == "")
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = string.Format("singer_name like '%{0}%'",txtSingerName.Text.Trim());
            }
        }

        //网格单击事件
        private void dgvSingerList_Click(object sender, EventArgs e)
        {
            if (dgvSingerList.SelectedRows.Count > 0)
            {
                txtSingerId.Text = dgvSingerList.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvSingerList.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        //确认选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvSingerList.SelectedRows.Count > 0)
            {
                this.addSongFrm.singerid = dgvSingerList.SelectedRows[0].Cells[0].Value.ToString();
                this.addSongFrm.singerName = dgvSingerList.SelectedRows[0].Cells[1].Value.ToString();
                this.addSongFrm.ShowSingerName();
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择一行！");
            }
        }

        //取消
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
