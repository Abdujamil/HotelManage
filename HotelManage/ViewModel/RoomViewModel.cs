using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManage.ViewModel
{
    public class RoomViewModel
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string  RoomImage { get; set; }
        public decimal RoomPrice { get; set; }
        public int BookingStatusId { get; set; }
        public int RoomTypeId { get; set; }
        public int RoomCapacity { get; set; }
        public HttpPostedFileBase Image { get; set; }
        public int RoomDescription { get; set; }
        public List<SelectListItem> ListOfBookingStatus { get; set; }
        public List<SelectListItem> ListOfRoomType { get; set; }



    }
}