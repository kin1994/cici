using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KTV
{
    public class RoomInfo
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public double HourFee { get; set; }
        public double LeastFee { get; set; }
        public bool IsEmpty { get; set; }
    }
}
