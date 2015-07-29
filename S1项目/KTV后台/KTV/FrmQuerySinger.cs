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
    public partial class FrmQuerySinger : Form
    {
        //歌手信息类声明
        SingerInfo singerInfo = null;

        DataSet ds = new DataSet();
        DataView dv = new DataView();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public FrmQuerySinger()
        {
            InitializeComponent();
        }

        //窗体加载
        private void FrmQuerySingerByType_Load(object sender, EventArgs e)
        {
            dgvSingerInfo.AutoGenerateColumns = false;
            this.BindingDgv();

            string sqlStr = "select * from singer_type";
            SqlCommand command = new SqlCommand(sqlStr, DBHelper.Connection);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "singer_type");
            TreeNode root = new TreeNode("全部");
            foreach (DataRow row in ds.Tables["singer_type"].Rows)
            {
                TreeNode newNode = new TreeNode(row[1].ToString());
                newNode.Tag = row[0].ToString();
                root.Nodes.Add(newNode);
            }
            tvSingerType.Nodes.Add(root);

        }

        //绑定网格
        public void BindingDgv()
        {
            if (Global.ds.Tables != null)
            {
                Global.ds.Tables.Clear();
            }
            Global.FillSingerInfo();
            dv.Table = Global.ds.Tables["singerInfo"];
            dgvSingerInfo.DataSource = dv;
        }

        //关闭
        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //修改
        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSingerInfo.SelectedRows.Count > 0)
            {
                singerInfo = new SingerInfo();
                singerInfo.Singer_Id = int.Parse(dgvSingerInfo.SelectedRows[0].Cells[0].Value.ToString());
                singerInfo.Singer_Name = dgvSingerInfo.SelectedRows[0].Cells[1].Value.ToString();
                singerInfo.singertype_name = dgvSingerInfo.SelectedRows[0].Cells[2].Value.ToString();
                singerInfo.Singer_Gender = dgvSingerInfo.SelectedRows[0].Cells[3].Value.ToString();
                singerInfo.Singer_Photo_url = dgvSingerInfo.SelectedRows[0].Cells[4].Value.ToString();
                singerInfo.Singer_Description = dgvSingerInfo.SelectedRows[0].Cells[5].Value.ToString();
                singerInfo.Singer_ab = dgvSingerInfo.SelectedRows[0].Cells[6].Value.ToString();
                singerInfo.SingerType_Id = int.Parse(dgvSingerInfo.SelectedRows[0].Cells[7].Value.ToString());
                FrmAddSinger addSinger = new FrmAddSinger();
                addSinger.byTypeFrm = this;
                addSinger.singerInfo = singerInfo;
                addSinger.state = "修改";
                addSinger.Show();
            }
            else
            {
                MessageBox.Show("请选择一行！");
            }
        }

        //删除
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (dgvSingerInfo.SelectedRows.Count > 0)
            {
                singerInfo = new SingerInfo();
                singerInfo.Singer_Id = int.Parse(dgvSingerInfo.SelectedRows[0].Cells[0].Value.ToString());
                singerInfo.Singer_Name = dgvSingerInfo.SelectedRows[0].Cells[1].Value.ToString();
                singerInfo.singertype_name = dgvSingerInfo.SelectedRows[0].Cells[2].Value.ToString();
                singerInfo.Singer_Gender = dgvSingerInfo.SelectedRows[0].Cells[3].Value.ToString();
                singerInfo.Singer_Photo_url = dgvSingerInfo.SelectedRows[0].Cells[4].Value.ToString();
                singerInfo.Singer_Description = dgvSingerInfo.SelectedRows[0].Cells[5].Value.ToString();
                singerInfo.Singer_ab = dgvSingerInfo.SelectedRows[0].Cells[6].Value.ToString();
                singerInfo.SingerType_Id = int.Parse(dgvSingerInfo.SelectedRows[0].Cells[7].Value.ToString());
                FrmAddSinger addSinger = new FrmAddSinger();
                addSinger.singerInfo = singerInfo;
                addSinger.byTypeFrm = this;
                addSinger.state = "删除";
                addSinger.Show();
            }
            else
            {
                MessageBox.Show("请选择一行！");
            }
        }

        //根据歌手类型筛选
        private void tvSingerType_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (tvSingerType.SelectedNode.Level == 1)
            {
                dv.RowFilter = string.Format("singertype_id={0}", int.Parse(tvSingerType.SelectedNode.Tag.ToString()));
            }
            else if (tvSingerType.SelectedNode.Level == 0)
            {
                dv.RowFilter = "";
            }
        }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
