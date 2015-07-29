using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KTV
{
    class DBHelper
    {
        //private const string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=MyKTV;Integrated Security=True";
        //private const string connStr=@"Data Source=TIANSHUXING\MYSQL2008;Initial Catalog=MyKTV;Integrated Security=True";
        private const string connStr = @"Data Source=.;Initial Catalog=MyKTV;User ID=sa;pwd=123";

        #region 封装数据库连接字段
        /// <summary>
        /// 封装数据库连接字段
        /// </summary>
        private static SqlConnection connection;
        public static SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connStr);
                }
                return connection;
            }
        } 
        #endregion
        
        #region 打开数据库连接
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            else if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        } 
        #endregion

        #region 关闭数据库连接
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open || Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
            }
        } 
        #endregion

        #region 密码验证
        /// <summary>
        /// 密码验证
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>密码</returns>
        public string ValidPwd(string userName)
        {
            string pwd = string.Empty;
            try
            {
                string sqlStr = string.Format("select admin_pwd from admin_info where admin_name='{0}'", userName);
                SqlCommand command = new SqlCommand(sqlStr, Connection);
                OpenConnection();
                pwd = command.ExecuteScalar() + "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return pwd;
        } 
        #endregion

        public int UserTypeId(string userName)
        {
            int typeId =-1;
            try
            {
                string sqlStr = string.Format("select admintype_id from admin_info where admin_name='{0}'", userName);
                SqlCommand command = new SqlCommand(sqlStr, Connection);
                OpenConnection();
                typeId =(int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return typeId;
        }

        #region 修改密码
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="newPwd">新密码</param>
        /// <returns>是否成功</returns>
        public bool UpdatePwd(string username, string newPwd)
        {
            bool flag = false;
            string sqlStr = string.Format("update admin_info set admin_pwd='{0}'  where admin_name='{1}'", newPwd, username);
            flag = NonQuery(sqlStr);
            return flag;
        } 
        #endregion

        #region 增删改公用类
        /// <summary>
        /// 增删改公用类
        /// </summary>
        /// <param name="sqlStr">sql语句</param>
        /// <returns>是否成功</returns>
        private bool NonQuery(string sqlStr)
        {
            bool flag = false;
            try
            {
                SqlCommand command = new SqlCommand(sqlStr, Connection);
                this.OpenConnection();
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
            return flag;
        } 
        #endregion

        #region 添加歌曲信息
        /// <summary>
        /// 添加歌曲信息
        /// </summary>
        /// <param name="songInfo">歌曲类</param>
        /// <returns>是否成功</returns>
        public bool InsertSongInfo(SongInfo songInfo)
        {
            bool flag = false;
            string sqlStr = string.Format("insert song_info values ('{0}','{1}',{2},{3},{4},'{5}',0,{6},default)", songInfo.Song_Name, songInfo.Song_ab, songInfo.Song_Word_Count, songInfo.SongType_Id, songInfo.Singer_Id, songInfo.Song_url,songInfo.Language_id);
            flag = NonQuery(sqlStr);
            return flag;
        } 
        #endregion

        #region 添加歌手信息
        /// <summary>
        /// 添加歌手信息
        /// </summary>
        /// <param name="singer_name"></param>
        /// <param name="singertypeid"></param>
        /// <param name="singer_gender"></param>
        /// <param name="singer_photo"></param>
        /// <param name="description"></param>
        /// <param name="singerab"></param>
        /// <returns></returns>
        public bool InsertSingerInfo(SingerInfo singerInfo)
        {
            bool flag = false;
            string sqlStr = string.Format("insert singer_info values ('{0}',{1},'{2}','{3}','{4}','{5}')", singerInfo.Singer_Name,singerInfo.SingerType_Id,singerInfo.Singer_Gender,singerInfo.Singer_Photo_url,singerInfo.Singer_Description,singerInfo.Singer_ab);
            flag = NonQuery(sqlStr);
            return flag;
        }
        
        #endregion

        #region  修改歌曲
        /// <summary>
        /// 修改歌曲
        /// </summary>
        /// <param name="songInfo">歌曲类</param>
        /// <returns>是否成功</returns>
        public bool UpdateSongInfo(SongInfo songInfo)
        {
            bool flag = false;
            string sqlStr = string.Format("update song_info set  song_name='{0}',song_ab='{1}',song_word_count={2},songtype_id={3},singer_id={4},song_url='{5}',song_play_count={6},Languageid={8}	 where song_id={7}", songInfo.Song_Name, songInfo.Song_ab, songInfo.Song_Word_Count, songInfo.SongType_Id, songInfo.Singer_Id, songInfo.Song_url, songInfo.Song_Play_Count, songInfo.Song_Id,songInfo.Language_id);
            flag = NonQuery(sqlStr);
            return flag;
        } 
        #endregion

        #region 删除歌曲
        /// <summary>
        /// 删除歌曲
        /// </summary>
        /// <param name="songInfo">歌曲类</param>
        /// <returns>是否成功</returns>
        public bool DeleteSongInfo(SongInfo songInfo)
        {
            bool flag = false;
            string sqlStr = string.Format("delete song_info  where song_id={0}", songInfo.Song_Id);
            flag = NonQuery(sqlStr);
            return flag;
        } 
        #endregion

        #region  修改歌手照片路径
        /// <summary>
        /// 修改歌手照片路径
        /// </summary>
        /// <param name="url">照片路径</param>
        /// <returns>是否成功</returns>
        public bool UpdateSingerPhotoUrl(string url)
        {
            bool flag = false;
            string sqlStr = string.Format("update resource_path set resource_path='{0}' where resource_type='singer_photo'", url);
            flag = NonQuery(sqlStr);
            return flag;
        } 
        #endregion

        #region 修改歌曲路径
        /// <summary>
        /// 修改歌曲路径
        /// </summary>
        /// <param name="url">歌曲路径</param>
        /// <returns>是否成功</returns>
        public bool UpdateSongUrl(string url)
        {
            bool flag = false;
            string sqlStr = string.Format("update resource_path set resource_path='{0}' where resource_type='song'", url);
            flag = NonQuery(sqlStr);
            return flag;
        } 
        #endregion

        #region  修改歌手信息
        /// <summary>
        /// 修改歌手信息
        /// </summary>
        /// <param name="singerInfo"></param>
        /// <returns></returns>
        public bool UpdateSingerInfo(SingerInfo singerInfo)
        {
            bool flag = false;
            string sqlStr = string.Format("update singer_info set singer_name='{0}',singertype_id={1},singer_gender='{2}',singer_photo_url='{3}',singer_description='{4}',singer_ab='{5}' where singer_id={6}", singerInfo.Singer_Name, singerInfo.SingerType_Id, singerInfo.Singer_Gender, singerInfo.Singer_Photo_url, singerInfo.Singer_Description, singerInfo.Singer_ab, singerInfo.Singer_Id);
            flag = NonQuery(sqlStr);
            return flag;
        }
        
        #endregion

        #region 删除歌手信息
        /// <summary>
        /// 删除歌手信息
        /// </summary>
        /// <param name="singerInfo">歌手类</param>
        /// <returns>是否删除</returns>
        public bool DeleteSingerInfo(SingerInfo singerInfo)
        {
            bool flag = false;
            string sqlStr = string.Format("delete singer_Info where singer_id={0}", singerInfo.Singer_Id);
            flag = NonQuery(sqlStr);
            return flag;
        } 
        #endregion

        #region 获取歌手图片地址
        /// <summary>
        /// 获取歌手图片地址
        /// </summary>
        /// <returns>图片地址</returns>
        public string PhotoUrl()
        {
            string photoUrl = string.Empty;
            try
            {
                string sqlStr = "select resource_path from resource_path where resource_type='singer_photo'";
                SqlCommand command = new SqlCommand(sqlStr, Connection);
                this.OpenConnection();
                photoUrl = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
            return photoUrl;
        } 
        #endregion

        #region 获取歌曲名
        /// <summary>
        /// 获取歌曲名
        /// </summary>
        /// <returns>歌曲名数组</returns>
        public string[] GetSongName()
        {
            string[] songName;
            int index = 0;
            try
            {
                string sqlStr = "select count(*) from song_info";
                SqlCommand command = new SqlCommand(sqlStr, Connection);
                this.OpenConnection();
                int length = (int)command.ExecuteScalar();
                songName = new string[length];
                sqlStr = "select song_name from song_info";
                command.CommandText = sqlStr;
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        songName[index] = dr["song_name"].ToString();
                        index++;
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }

            return songName;
        } 
        #endregion

        //获取酒水费用
        public int GoodsFee(string OpenId)
        {
            int goodsPrice = 0;
            try
            {
                StringBuilder sb=new StringBuilder();
                sb.AppendLine("select sum(GoodNum*GoodPrice) from goods_order as o,goods_info as i");
                sb.AppendLine("where o.GoodId=i.GoodID ");
                sb.AppendFormat("and OpenId='{0}'",OpenId);
                SqlCommand command = new SqlCommand(sb.ToString(),Connection);
                this.OpenConnection();
                string  s = command.ExecuteScalar().ToString();
                try 
	            {
                    goodsPrice =(int)double.Parse(s);
	            }
	            catch (Exception)
	            {
                    goodsPrice = 0;
	            }
                    
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
            return goodsPrice;
        }

        //开房状态
        public bool UpdateRoomState1(int roomId)
        {
            bool flag = false;
           
            string sqlStr =string.Format("update room_info set isEmpty=1 where RoomId={0}",roomId);
            flag=this.NonQuery(sqlStr);
            return flag;
        }

        //退房状态
        public bool UpdateRoomState0(int roomId)
        {
            bool flag = false;

            string sqlStr = string.Format("update room_info set isEmpty=0 where RoomId={0}", roomId);
            flag = this.NonQuery(sqlStr);
            return flag;
        }



        //public bool AddRoomInfo(RoomInfo r)
        //{
        //    bool flag = false;
        //    string sqlStr = string.Format("insert room_info values ({0},'{1}','{2}','{3}',1)",r.RoomId,r.RoomType,r.HourFee,r.LeastFee);
        //    flag = this.NonQuery(sqlStr);
        //    return flag;
        //}

        public bool DeleteRoomInfo(int roomId)
        {
            bool flag = false;
            string sqlStr = string.Format("delete room_info where roomId={0} ", roomId);
            flag = this.NonQuery(sqlStr);
            return flag;
        }


        public bool AddGoodsInfo()
        {
            bool flag = false;
            string sqlStr = string.Format("delete room_info where roomId={0} ");
            flag = this.NonQuery(sqlStr);
            return flag;
        }

        public bool DeleteGoodsInfo(int goodsId)
        {
            bool flag = false;
            string sqlStr = string.Format("delete room_info where roomId={0} ", goodsId);
            flag = this.NonQuery(sqlStr);
            return flag;
        }

    }
}
