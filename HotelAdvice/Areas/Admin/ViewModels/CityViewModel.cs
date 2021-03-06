﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HotelAdvice.Areas.Admin.ViewModels
{
    public class CityViewModel
    {
        public int cityID { get; set; }
        public int RowNum { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentFilter { get; set; }
       
        [StringLength(100, ErrorMessage = "max length has been exceeded.")]
        [Required(ErrorMessage = "This field is required.")]
        public string cityName { get; set; }
                
        public string cityAttractions { get; set; }

        public HttpPostedFileBase PhotoFile { get; set; }

        public string imgPath;

        public int hotel_count { get; set; }

    }
}