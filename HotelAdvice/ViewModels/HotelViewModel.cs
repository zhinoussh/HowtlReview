﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using HotelAdvice.Models;
using System.Web.Mvc;

namespace HotelAdvice.ViewModels
{
    public class HotelViewModel
    {
        public int HotelId { get; set; }
        public int RowNum { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentFilter { get; set; }
       
        [StringLength(100, ErrorMessage = "max length has been exceeded.")]
        [Required( ErrorMessage = "This field is required.")]
        public string HotelName { get; set; }

        [StringLength(500, ErrorMessage = "max length has been exceeded.")]
        public string HotelAddress { get; set; }

        [StringLength(20, ErrorMessage = "max length has been exceeded.")]
        [Phone]
        public string Tel { get; set; }
        
        [StringLength(20, ErrorMessage = "max length has been exceeded.")]
        [DataType(DataType.PhoneNumber)]
        public string Fax { get; set; }
        
        [StringLength(20, ErrorMessage = "max length has been exceeded.")]
        [EmailAddress]
        public string Email { get; set; }
        
        [StringLength(20, ErrorMessage = "max length has been exceeded.")]
        public string Website { get; set; }
        public int HotelStars { get; set; }

        [StringLength(int.MaxValue, ErrorMessage = "max length has been exceeded.")]
        public string Description { get; set; }

        [StringLength(20, ErrorMessage = "max length has been exceeded.")]
        public string checkin { get; set; }
        
        [StringLength(20, ErrorMessage = "max length has been exceeded.")]
        public string checkout { get; set; }
       
        [StringLength(20, ErrorMessage = "max length has been exceeded.")]
        public string distance_citycenter { get; set; }
        
        [StringLength(20, ErrorMessage = "max length has been exceeded.")]
        public string distance_airport { get; set; }

        public int? CityId { get; set; }
        
        public string CityName { get; set; }
        
        public SelectList lst_city { get; set; }

        public String restaurants { get; set; }

        public String rooms { get; set; }

        public String amenities { get; set; }
        public String sightseeing { get; set; }
        
        public HttpPostedFileBase PhotoFile { get; set; }

        public string imgPath;
    }
}