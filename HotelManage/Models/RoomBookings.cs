using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManage.Models
{
    public class RoomBookings
    {
        public int BookingId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public System.DateTime BookingFrom { get; set; }
        public System.DateTime BookingTo { get; set; }
        public int AssignRoomId { get; set; }
        public int NoOfMembers { get; set; }
    }
}