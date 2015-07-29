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
    public partial class Room : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter data = new SqlDataAdapter();
        DataView dv = new DataView();

        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            BinDingdgv();
            this.BinDingcbo(); 
        }
        //绑定cboRoomType
        private void BinDingcbo()
        {
            string sqlstr = "select distinct RoomType from Room_info";
            SqlCommand command = new SqlCommand(sqlstr,DBHelper.Connection);
            data.SelectCommand = command;
            data.Fill(ds, "Room_info");
            DataRow row = ds.Tables["Room_info"].NewRow();
            row["RoomType"] = "全部";
            
            cmbRoomType.DataSource=ds.Tables["Room_info"];
            cmbRoomType.DisplayMember = "RoomType";
            ds.Tables["Room_info"].Rows.InsertAt(row, 0);
            
        }

        //绑定dgvroom的方法
        private void BinDingdgv()
        {
            try
            {
                dgvRoom.AutoGenerateColumns = false;
                string str = "select * from Room_Order as o ,room_Info as i where o.roomid=i.roomid";
                SqlCommand commad = new SqlCommand(str,DBHelper.Connection);
                data.SelectCommand = commad;
                data.Fill(ds, "Room_Order");
                dv.Table = ds.Tables["Room_Order"];
                dgvRoom.DataSource = dv;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnQuay_Click(object sender, EventArgs e)
        {
              
            if (txtFangHao.Text == string.Empty)
            {
               if (cmbRoomType.SelectedIndex>=0)
                {
                    if (cmbRoomType.Text == "全部")
                    {
                        dv.RowFilter = "";
                    }else
                    dv.RowFilter = string.Format("roomtype= '{0}'",cmbRoomType.Text);
                }else
                   dv.RowFilter = "";
            }
            else{
                if (cmbRoomType.SelectedIndex >= 0)
                {
                    dv.RowFilter += string.Format("RoomId = {0}and  roomtype= '{1}'", txtFangHao.Text, cmbRoomType.Text);
                }else
                dv.RowFilter = string.Format("RoomId = {0}", txtFangHao.Text);
              
            }                                                                

        }

        private void dgvRoom_Click(object sender, EventArgs e)
        {
          if(dgvRoom.SelectedRows.Count>0){
              try
              {
                  txtFangFei.Text = dgvRoom.SelectedRows[0].Cells[3].Value.ToString();
                  txtJiuFei.Text = dgvRoom.SelectedRows[0].Cells[4].Value.ToString();
                  double shi1 = Convert.ToDouble(this.txtFangFei.Text.ToString());
                  double jiu1 = Convert.ToDouble(this.txtJiuFei.Text.ToString());
                  this.txtHeJi.Text = (shi1 + jiu1).ToString();
              }
              catch (Exception)
              {
                 
              }
             
          }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
    }
}
