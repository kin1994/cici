using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KTV
{
    public class SongInfo
    {
        //歌曲编号
        public int Song_Id { get; set; }
        //歌名
        public string Song_Name { get; set; }
        //歌曲缩写
        public string Song_ab { get; set; }
        //歌曲字数
        public int Song_Word_Count { get; set; }
        //歌曲类型编号
        public int SongType_Id { get; set; }
        //歌手编号
        public int Singer_Id { get; set; }
        //歌曲地址
        public string Song_url { get; set; }
        //歌曲播放次数
        public int Song_Play_Count { get; set; }
        //歌手名
        public string Singer_Name { get; set; }
        //歌曲语言
        public string Song_Language { get; set; }
        //语言编号
        public int Language_id { get; set; }
    }
}