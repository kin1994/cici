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
    public partial class frmRoom : Form
    {
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        SqlDataAdapter adapter = new SqlDataAdapter();

        DBHelper helper = new DBHelper();

        //退房时间
        DateTime closeTime = new DateTime();
        public frmRoom()
        {
            InitializeComponent();
        }


        //窗体加载
        private void frmRoom_Load(object sender, EventArgs e)
        {
            dgvOpenZhuanTai.AutoGenerateColumns = false;
            if(this.Text=="开房")
            {
                this.gbOpen.Visible = true;
                this.gbPay.Visible = false;
                this.panOpen.Visible = true;
                this.panPay.Visible = false;
            }
            if (this.Text == "买单")
            {
                this.gbOpen.Visible = false;
                this.gbPay.Visible = true;
                this.panOpen.Visible = false;
                this.panPay.Visible = true;
            }

            string sqlStr = "select * from room_info where isEmpty=1";
            SqlCommand command = new SqlCommand(sqlStr,DBHelper.Connection);
            adapter.SelectCommand = command;
            adapter.Fill(ds,"room_info");
            dgvOpenZhuanTai.DataSource = ds.Tables["room_info"];

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select o.OpenId,i.RoomId,o.OpenDate,o.CustomerName,i.RoomType,o.remark,i.LeastRoomFee,i.HourRoomFee");
            sb.AppendLine("from Room_Order as o,room_info AS i  ");
            sb.AppendLine("where i.RoomId=O.RoomId and O.isPay=0");
            command.CommandText = sb.ToString();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "room_order");
            dv.Table = ds.Tables["room_order"];
            dgvOrder.DataSource=dv;

        }

        //关闭开房窗体
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭买单窗体
        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //买单网格单击事件
        private void dgvOpenZhuanTai_Click(object sender, EventArgs e)
        {
            if (dgvOpenZhuanTai.SelectedRows.Count > 0)
            {
                txtRoomType.Text = dgvOpenZhuanTai.SelectedRows[0].Cells[1].Value.ToString();
                txtFangJianPrice.Text = "最低消费：" + dgvOpenZhuanTai.SelectedRows[0].Cells[2].Value.ToString() + "，单小时费用：" + dgvOpenZhuanTai.SelectedRows[0].Cells[3].Value.ToString();
                txtFangJianHao.Text = dgvOpenZhuanTai.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        //开房事件
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvOpenZhuanTai.SelectedRows.Count > 0)
            {
                //insert Room_Order values ('s0001','2002-01-02 13:15:00',DEFAULT,'',201,DEFAULT,DEFAULT,DEFAULT,'')
                string openDate = dtpKaiFangRiQi.Value.ToShortDateString() + " " + dtpKaiFangRiQi.Value.ToShortTimeString();
                //MessageBox.Show(openDate);
                string customerName = txtUserName.Text.Trim()+"";
                int roomid = int.Parse(txtFangJianHao.Text.Trim());
                string remark = txtBeiZhu.Text.Trim()+"";
                string orderNo = "s"+ DateTime.Now.DayOfYear+DateTime.Now.Hour+DateTime.Now.Minute+DateTime.Now.Second;
                MessageBox.Show(orderNo);
                try
                {
                    string sqlStr = string.Format("insert Room_Order values ('{0}','{1}',DEFAULT,'{2}',{3},DEFAULT,DEFAULT,DEFAULT,'{4}')",orderNo,openDate,customerName,roomid,remark);
                    SqlCommand command = new SqlCommand(sqlStr,DBHelper.Connection);
                    helper.OpenConnection();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("开房成功！");
                        helper.UpdateRoomState0(roomid);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    helper.CloseConnection();
                }

            }
            else
            {
                MessageBox.Show("请选择房间号！");
            }
            
        }

        //买单事件
        private void dgvOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                txtPayNo.Text = dgvOrder.SelectedRows[0].Cells[0].Value.ToString();
                txtOpenTime.Text = dgvOrder.SelectedRows[0].Cells[2].Value.ToString();
                closeTime = DateTime.Now;
                DateTime dt = DateTime.Parse(dgvOrder.SelectedRows[0].Cells[2].Value.ToString());
                int date=(closeTime.Day * 24 + closeTime.Hour) * 60 + closeTime.Minute - ((dt.Day * 24 + dt.Hour) * 60 + dt.Minute);
                if (date % 60 == 0)
                {
                    txtUseTime.Text = date / 60 + "";
                }
                else 
                {
                    txtUseTime.Text = date / 60 +1+ "";
                }

                int time=int.Parse(txtUseTime.Text.Trim());
                txtRoomTyp.Text = dgvOrder.SelectedRows[0].Cells[4].Value.ToString();
                try
                {
                    txtFoodPrice.Text = helper.GoodsFee(txtPayNo.Text.Trim()) + "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtUser.Text = dgvOrder.SelectedRows[0].Cells[3].Value.ToString();
                txtRoomNo.Text = dgvOrder.SelectedRows[0].Cells[1].Value.ToString();
                //double d = double.Parse(dgvOrder.SelectedRows[0].Cells[6].Value.ToString());
                int hourFee = (int)double.Parse(dgvOrder.SelectedRows[0].Cells[7].Value.ToString());
                int leastFee = (int)double.Parse(dgvOrder.SelectedRows[0].Cells[6].Value.ToString());
                if (time * hourFee < leastFee)
                {
                    if (txtFoodPrice.Text.Trim() == "")
                    {
                        txtFoodPrice.Text = "0";
                    }
                    txtAllMoney.Text = (leastFee + int.Parse(txtFoodPrice.Text.Trim())) + "";
                }
                else
                {
                    if (txtFoodPrice.Text.Trim() == "")
                    {
                        txtFoodPrice.Text = "0";
                    }
                    txtAllMoney.Text = (time * hourFee + int.Parse(txtFoodPrice.Text.Trim())) + "";
                }
                txtBeiZhuShuoMing.Text = dgvOrder.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        //实付时文本改变事件
        private void txtPayMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtReturnMoney.Text = (int.Parse(txtPayMoney.Text) - int.Parse(txtAllMoney.Text)) + "";
            }
            catch (Exception)
            {
                
            }
            
        }

        //打印
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtPayMoney.Text == "")
            {
                return;
            }
            if (dgvOrder.SelectedRows.Count > 0)
            {
                int foodFee = int.Parse(txtFoodPrice.Text);
                int roomFee = int.Parse(txtAllMoney.Text) - foodFee;
                int roomid = int.Parse(txtRoomNo.Text);
                try
                {
                    string sqlStr = string.Format("update Room_Order set CloseDate='{0}',isPay=1,RoomFee={1},OtherFee={2} WHERE OpenId='{3}'",closeTime,roomFee,foodFee,txtPayNo.Text);
                    SqlCommand command = new SqlCommand(sqlStr,DBHelper.Connection);
                    helper.OpenConnection();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("打印成功！");
                        helper.UpdateRoomState1(roomid);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    helper.CloseConnection();
                }
            }
        }
        
        //按房间号模糊查询        
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtRoomId.Text == "")
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = string.Format("roomid={0}", txtRoomId.Text.Trim());
            }
        }
       
    }
}
