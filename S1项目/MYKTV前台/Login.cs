using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MYKTV
{
    public partial class Login : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cboRoomId.Text != string.Empty)
            {
                FrmMain frm = new FrmMain();
                frm.Openid = cboRoomId.SelectedValue.ToString();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("请先到后台开房!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlstr = "select Top 1 * from Room_Order where ispay=0 order by OpenData desc";
                SqlCommand command = new SqlCommand(sqlstr, DBHelper.Conn);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Room");
                cboRoomId.DataSource = ds.Tables["Room"];
                cboRoomId.DisplayMember = "RoomId";
                cboRoomId.ValueMember = "OpenId";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
