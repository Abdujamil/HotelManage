using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManage.Models
{
    public class Payments
    {
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public int PaymentTypeId { get; set; }
        public decimal PaymentAmount { get; set; }
        public bool isActive { get; set; }
    }
}