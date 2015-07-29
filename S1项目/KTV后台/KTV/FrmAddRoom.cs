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
    public partial class FrmAddRoom : Form
    {
        DBHelper helper = new DBHelper();
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        SqlDataAdapter adapter;
        public FrmAddRoom()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        MessageBox.Show("信息不完整！");
                        return;
                    }
                }
            }
            RoomInfo r=new RoomInfo();
            
            try 
	        {
                r.RoomId = int.Parse(txtRoomNum.Text.Trim());
                r.HourFee = double.Parse(txtHourFee.Text.Trim());
                r.LeastFee= double.Parse(txtLeastFee.Text.Trim());
	        }
	        catch (Exception ex)
	        {
                MessageBox.Show(ex.Message);
	        }
            r.RoomType = txtRoomType.Text.Trim();
            try
            {
                bool flag = helper.AddRoomInfo(r);
                if (flag)
                {
                    MessageBox.Show("添加成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddRoom_Load(object sender, EventArgs e)
        {
            string sqlStr = "select * from room_info";
            adapter = new SqlDataAdapter(sqlStr, DBHelper.Connection);
            adapter.Fill(ds,"roomInfo");
            dgvRoomInfo.DataSource=ds.Tables["roomInfo"];


        }

        private void dgvRoomInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
