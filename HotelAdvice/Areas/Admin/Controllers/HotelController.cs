﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HotelAdvice.Areas.Admin.ViewModels;
using HotelAdvice.Areas.Admin.Models;
using PagedList;
using HotelAdvice.Controllers;
using HotelAdvice.DataAccessLayer;
using HotelAdvice.Filters;
using System;

namespace HotelAdvice.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class HotelController : BaseController
    {
        
        public HotelController(IServiceLayer service)
            : base(service)
        {

        }

         #region Hotel

        // GET: Hotel
        public ActionResult Index(int? page, string filter = null)
        {
            ViewBag.filter = filter;

            IPagedList paged_list_hotels = DataService.Get_HotelList(page, filter);

            if(Request.IsAjaxRequest())
                return (ActionResult)PartialView("_PartialHotelList", paged_list_hotels);
            else
                return View(paged_list_hotels);
        }

        [HttpGet]
        public ActionResult ADD_New_Hotel(int? id, int? page,string filter=null)
        {
            HotelViewModel vm = DataService.Get_AddNewHotel(this,id, page, filter);

            return PartialView("_PartialAddHotel", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ModelValidator]
        public ActionResult ADD_New_Hotel(HotelViewModel Hotel)
        {
                DataService.Post_AddNewHotel(Hotel, this);
                return Json(new { msg = "The Hotel inserted successfully.", ctrl = "/Admin/Hotel", cur_pg = Hotel.CurrentPage, filter = Hotel.CurrentFilter + "" });
        }

        [HttpGet]
        public ActionResult HotelDescription(int id)
        {
            HotelViewModel  vm = DataService.GetHotelDescription(id);

            return PartialView("_PartialDescription", vm);
        }

        [HttpGet]
        public ActionResult Delete_Hotel(int id, int? page, string filter = null)
        {
            HotelViewModel vm = DataService.Get_DeleteHotel(id,page,filter);
            return PartialView("_PartialDeleteHotel", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_Hotel(HotelViewModel Hotel)
        {
            DataService.Post_DeleteHotel(Hotel, this);

            return Json(new { msg = "Row is deleted successfully!", ctrl = "/Admin/Hotel", cur_pg = Hotel.CurrentPage, filter = Hotel.CurrentFilter + "" });
        }

         #endregion Hotel

         #region Hotel_Image
       
        [HttpGet]
        public ActionResult HotelImages(int id)
        {
            HotelImagesViewModel vm = DataService.Get_HotelImagesView(id, this);
                                       
            return View(vm);           
        }                              
                                       
        [HttpPost]
        public ActionResult DeleteMainImage(HotelImagesViewModel vm, int hotel_ID)
        {
            return Json(new { msg = "images were uploaded successfully!" });
        }


        [HttpPost]
        public ActionResult AddImage(HotelImagesViewModel vm, int hotel_ID)
        {
            DataService.Post_AddHotelPhoto(vm, hotel_ID,this);

            return Json(new { msg = "image uploaded successfully!" });
        }

        [HttpGet]
        public ActionResult Delete_HotelPhoto(string photo_name)
        {
            HotelImagesViewModel vm = DataService.Get_DeleteHotelPhoto(photo_name);

            return PartialView("_PartialDeletePhoto", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_HotelPhoto(HotelImagesViewModel photo)
        {
            DataService.Post_DeleteHotelPhoto(photo,this);
            return Json(new { msg = "Row is deleted successfully!" });
        }

        public ActionResult Show_HotelPhoto(string photo_name)
        {
            HotelImagesViewModel vm = DataService.Get_HotelPhoto(photo_name);

            return PartialView("_PartialShowImage", vm);
        }

         #endregion Hotel_Image


        [HttpPost]
        public JsonResult Get_Restaurants(string Prefix)
        {
            List<string> restList = DataService.search_restaurants_by_prefix(Prefix);
            return Json(restList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
         public JsonResult Get_Rooms(string Prefix)
         {
             List<string> RoomList = DataService.search_rooms_by_prefix(Prefix);
             return Json(RoomList, JsonRequestBehavior.AllowGet);
         }

         [HttpPost]
         public JsonResult Get_SightSeeing(string Prefix)
         {
             List<string> SightList = DataService.search_sightseeing_by_prefix(Prefix);
             return Json(SightList, JsonRequestBehavior.AllowGet);
         }
        
    }
}