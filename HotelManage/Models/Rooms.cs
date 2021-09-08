using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManage.Models
{
    public class Rooms
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public string RoomImage { get; set; }
        public decimal RoomPrice { get; set; }
        public int BookingStatusId { get; set; }
        public int RoomTypeId { get; set; }
        public int RoomCapacity { get; set; }
        public string RoomDescription { get; set; }
        public bool IsActive { get; set; }
    }
}