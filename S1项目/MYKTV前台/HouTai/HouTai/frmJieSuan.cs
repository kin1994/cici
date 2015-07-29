using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HouTai
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
            if (txtRoomId.Text != "")
            {

            }
            else
            {
                MessageBox.Show("请输入房间号码");
            }
        }

    }
}
