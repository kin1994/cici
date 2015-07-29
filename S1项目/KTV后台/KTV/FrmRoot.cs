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
    public partial class FrmRoot : Form
    {
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DBHelper helpr = new DBHelper();
        public FrmRoot()
        {
            InitializeComponent();
        }

        private void cbOperator_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb=(CheckBox)sender;
            string sqlStr = string.Empty;
            if(cb.Name.Contains("Operator"))
            {
                string name = cb.Name.Substring(10).Trim();
                if (cb.Checked)
                {
                    sqlStr = string.Format("update rootmanager set {0}=1 where admintype_id=3", name);
                }
                else
                {
                    sqlStr = string.Format("update rootmanager set {0}=0 where admintype_id=3", name);
                }
            }
            if (cb.Name.Contains("Common"))
            {
                string name = cb.Name.Substring(8).Trim();
                if (cb.Checked)
                {
                    sqlStr = string.Format("update rootmanager set {0}=1 where admintype_id=2", name);
                }
                else
                {
                    sqlStr = string.Format("update rootmanager set {0}=0 where admintype_id=2", name);
                }
            }
            try
            {
                SqlCommand command = new SqlCommand(sqlStr, DBHelper.Connection);
                helpr.OpenConnection();
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                helpr.CloseConnection();
            }
        }

        private void FrmRoot_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                }
            }

            string sqlStr = "select * from rootmanager";
            SqlCommand command = new SqlCommand(sqlStr,DBHelper.Connection);
            adapter.SelectCommand = command;
            adapter.Fill(ds,"common");

            foreach (DataRow row in ds.Tables["common"].Rows)
            {
                if (row[8].ToString() == "2")
                {
                    if (row[1].ToString() == "1")
                    {
                        cbCommonBookRoom.Checked = true;
                    }
                    if (row[2].ToString() == "1")
                    {
                        cbCommonGetRoom.Checked = true;
                    }
                    if (row[3].ToString() == "1")
                    {
                        cbCommonSongManager.Checked = true;
                    } 
                    if (row[4].ToString() == "1")
                    {
                        cbCommonChangePwd.Checked = true;
                    } 
                    if (row[5].ToString() == "1")
                    {
                        cbCommonQueryBook.Checked = true;
                    }
                    if (row[6].ToString() == "1")
                    {
                        cbCommonRoomMoney.Checked = true;
                    }
                    if (row[7].ToString() == "1")
                    {
                        cbCommonUpdateResource.Checked = true;
                    }
                }
                if (row[8].ToString() == "3")
                {
                    if (row[1].ToString() == "1")
                    {
                        cbOperatorBookRoom.Checked = true;
                    }
                    if (row[2].ToString() == "1")
                    {
                        cbOperatorGetRoom.Checked = true;
                    }
                    if (row[3].ToString() == "1")
                    {
                        cbOperatorSongManager.Checked = true;
                    }
                    if (row[4].ToString() == "1")
                    {
                        cbOperatorChangePwd.Checked = true;
                    }
                    if (row[5].ToString() == "1")
                    {
                        cbOperatorQueryBook.Checked = true;
                    }
                    if (row[6].ToString() == "1")
                    {
                        cbOperatorRoomMoney.Checked = true;
                    }
                    if (row[7].ToString() == "1")
                    {
                        cbOperatorUpdateResource.Checked = true;
                    }
                }
            }

        }
    }
}
