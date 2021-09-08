using HotelManage.Models;
using HotelManage.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManage.Controllers
{
    public class RoomController : Controller
    {
        private HotelDbEntities objHotelDbEntities;
        public RoomController()
        {
            objHotelDbEntities = new HotelDbEntities();
        }
        public ActionResult Index()
        {
            RoomViewModel objroomviewModel = new RoomViewModel();
            objroomviewModel.ListOfBookingStatus = (from obj in objHotelDbEntities.BookingStatus
                                                    select new SelectListItem()
                                                    {
                                                        Text = obj.BookingStatus1,
                                                        Value = obj.BookingStatusId.ToString()
                                                    }).ToList();

            objroomviewModel.ListOfRoomType = (from obj in objHotelDbEntities.RoomTypes
                                               select new SelectListItem()
                                               {
                                                   Text = obj.RoomType,
                                                   Value = obj.RoomTypeId.ToString()
                                               }).ToList();

            return View(objroomviewModel);
        }
        [HttpPost]
        public ActionResult Index(RoomViewModel objroomViewModel)
        {
            string imageUniqName = Guid.NewGuid().ToString();
            string ActualImageName = imageUniqName + Path.GetExtension(objroomViewModel.Image.FileName);


            objroomViewModel.Image.SaveAs(Server.MapPath("~/RoomImage/" + ActualImageName));

            Rooms objroom = new Rooms() 
            { 
            RoomCapacity = objroomViewModel.RoomCapacity,
            RoomDescription = objroomViewModel.RoomDescription,
            RoomId = objroomViewModel.RoomId,
            RoomImage = ActualImageName,
            RoomNumber = objroomViewModel.RoomNumber,
            BookingStatusId = objroomViewModel.BookingStatusId,
            IsActive = true,
            RoomPrice = objroomViewModel.RoomPrice,
            RoomTypeId = objroomViewModel.RoomTypeId
            };
            objHotelDbEntities.Rooms.Add(objroom);
            objHotelDbEntities.SaveChanges();
            return Json(new { message="Room succesfully added.", success = true}, JsonRequestBehavior.AllowGet);
        }
    }
}