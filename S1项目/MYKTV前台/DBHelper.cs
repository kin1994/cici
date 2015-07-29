using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MYKTV
{
    class DBHelper
    {
        //static 当用静态修饰的方法和属性，是属于整个类的，所以不需要再实例化对象去访问它
        //可以直接使用类名来访问  DBHelper.Conn
        //通过static可以实现窗体间数据的传递
        static string strCon = "Data Source=.;Initial Catalog=MyKTV;Integrated Security=True";
        //static string strCon = @"Data Source=.;Initial Catalog=MyKTV;User ID=sa;pwd=123;";
        static public SqlConnection Conn = new SqlConnection(strCon);

        static public void Open()
        {
            if (Conn.State == ConnectionState.Open
                || Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
            else if (Conn.State == ConnectionState.Closed)
                Conn.Open();
        }

        static public void Close()
        {
            if (Conn.State == ConnectionState.Open
                || Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
            }
        }

        public void AddPlayCount(int songid)
        {
            string sqlstr = string.Format("update Song_Info set Song_Play_count += 1 where song_id='{0}'",songid);
            try
            {
                SqlCommand command = new SqlCommand(sqlstr, Conn);
                Conn.Open();
                command.ExecuteNonQuery();
                Global.Ds.Tables["Song"].Clear();
                Global.FillSong();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
        }

    }
}
