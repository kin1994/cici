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
    public partial class Form1 : Form
    {
        //临时数据集
        DataSet ds = new DataSet();
        //适配器
        SqlDataAdapter adapter = new SqlDataAdapter();
        //数据过滤器
        DataView dv = new DataView();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sqlstr = string.Empty;
            if (cboTime.SelectedIndex==1)
            {
                sqlstr = "select * from Room_Order where DATEDIFF(ww,CloseDate,Getdate())=0";
            }
            else if (cboTime.SelectedIndex==2)
            {
                sqlstr = "select * from Room_Order where DATEDIFF(mm,CloseDate,Getdate())=0";
            }
            else if (cboTime.SelectedIndex == 3)
            {
                sqlstr = "select * from Room_Order where DATEDIFF(mm,CloseDate,Getdate())<=6";
            }
            else
            {
                sqlstr = "select * from room_order";
            }
            this.Filldgv(sqlstr);
            if (txtRoomId.Text != "")
            {
                dv.RowFilter = string.Format("Roomid = {0}", txtRoomId.Text);
            }
            else
            {
                dv.RowFilter = "";
            }
        }

        private void Filldgv(string sqlstr)
        {
            try
            {
                if (ds.Tables["Room"]!=null)
                {
                    ds.Tables["Room"].Clear();
                }
                SqlCommand command = new SqlCommand(sqlstr, DBHelper.Connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Room");
                dv.Table = ds.Tables["Room"];
                dgvRoom.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvRoom.AutoGenerateColumns = false;
            string sqlstr="select * from room_order";
            this.Filldgv(sqlstr);
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRoom_Click(object sender, EventArgs e)
        {
            try
            {
                double RoomFee = double.Parse(dgvRoom.SelectedRows[0].Cells[4].Value.ToString());
                double OtherFee = double.Parse(dgvRoom.SelectedRows[0].Cells[5].Value.ToString());
                double totalFee = RoomFee + OtherFee;
                txtRoomFee.Text = RoomFee.ToString();
                txtOtherFee.Text = OtherFee.ToString();
                txtTotalFee.Text = totalFee.ToString();
            }
            catch (Exception)
            {
                
            }
           
        }
    }
}
