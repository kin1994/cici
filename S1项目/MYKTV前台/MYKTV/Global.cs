using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MYKTV
{
    class Global
    {
        //全局临时库
        public static DataSet Ds = new DataSet();
        //全局资源目录
        public static string PhotoPath;//照片目录
        public static string SongPath;//歌曲目录

        //静态窗体：播放器
         public static  Player frmPlayer = new Player();


        //获取资源目录信息
        public static void GetPath(ref string msg)
        {
            //sql，command，reader
            string sql = "select * from resource_path";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, DBHelper.Conn);
                DBHelper.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["resource_type"].ToString()
                        == "singer_photo")
                        PhotoPath =
                            reader["resource_path"].ToString();
                    else
                        SongPath =
                            reader["resource_path"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                DBHelper.Close();
            }

        }

        //填充歌手信息--临时库
        static public void FillSinger()
        {
            //sql,adapter,fill
            string sql = "select * from singer_info as s"
                + ", singer_type as t "
                + " where s.singertype_id=t.singertype_id";
            SqlDataAdapter ada =
                new SqlDataAdapter(sql, DBHelper.Conn);
            ada.Fill(Ds, "Singer");
        }
        //填充歌曲信息
        static public void FillSong()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT  song.*,singer_name,singer_photo_url ");
            sql.AppendLine(" from song_info as song,singer_info as singer ");
            sql.AppendLine(" where song.singer_id=singer.singer_id");
            SqlDataAdapter ada =
                new SqlDataAdapter(sql.ToString(), DBHelper.Conn);
            ada.Fill(Ds, "Song");
        }
        //创建已点歌曲表
        static public void FillOrderSong()
        {
            //创建临时库表结构,不添加记录
            string sql =
   "select Song_id,song_name,song_url,singer_name,singer_photo_url from singer_info,song_info where 1=2";
            SqlDataAdapter ada = new SqlDataAdapter(sql, DBHelper.Conn);
            ada.Fill(Ds, "OrderSong");
        }
    }
}
