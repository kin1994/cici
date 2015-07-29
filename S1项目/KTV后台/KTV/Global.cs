using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KTV
{
    class Global
    {
        DBHelper helper = new DBHelper();
        public static DataSet ds = new DataSet();
        public static SqlDataAdapter adapter = new SqlDataAdapter();
        public static string  singerPhotoUrl;
        public static string songUrl;

        #region 填充歌手信息
        /// <summary>
        /// 填充歌手信息
        /// </summary>
        public static void FillSingerInfo()
        {
            string sqlStr = "select i.*,t.singertype_name from singer_info as i,singer_type as t where i.singertype_id=t.singertype_id";
            SqlCommand command = new SqlCommand(sqlStr, DBHelper.Connection);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "singerInfo");

        } 
        #endregion

        #region 填充歌曲信息
        /// <summary>
        /// 填充歌曲信息
        /// </summary>
        public static void FillSongInfo()
        {
            string sqlStr = "select s.*,t.songtype_name,si.singer_name,l.Language_Name"
                            + " from song_info as s,singer_info as si,song_type as t,Languages as l "
                            + " where s.singer_id=si.singer_id and s.songtype_id=t.songtype_id and s.Languageid=l.Language_id";
            SqlCommand command = new SqlCommand(sqlStr, DBHelper.Connection);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "song_Info");
        } 
        #endregion

        public  void AddResource()
        {
            try
            {
                string sqlStr = "select * from resource_path";
                SqlCommand command = new SqlCommand(sqlStr,DBHelper.Connection);
                helper.OpenConnection();
                SqlDataReader  dr=command.ExecuteReader();
                dr.Read();
                singerPhotoUrl = dr["resource_path"].ToString()+@"\";
                dr.Read();
                songUrl = dr["resource_path"].ToString() + @"\";
                dr.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                helper.CloseConnection();
            }
        }

    }
}
