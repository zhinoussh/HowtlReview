﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotelAdvice.Areas.WebSite.Models;


namespace HotelAdvice.Areas.Admin.Models
{
    public class tbl_Hotel
    {
        public tbl_Hotel()
        {
            HotelRests = new HashSet<tbl_Hotel_Restaurants>();
            HotelRooms = new HashSet<tbl_Hotel_Rooms>();
            HotelAmenities = new HashSet<tbl_hotel_amenity>();
            HotelSightSeeings = new HashSet<tbl_hotel_sightseeing>();
            HotelPhotos = new HashSet<tbl_Hotel_Photo>();
            WishList_Hotel = new HashSet<tbl_WishList>();
            Rating_Hotel = new HashSet<tbl_rating>();
        }

        [Key]
        public int HotelId { get; set; }
        
        [StringLength(100)]
        public string HotelName { get; set; }

        [StringLength(500)]
        public string HotelAddress { get; set; }
        
        [StringLength(20)]
        public string Tel { get; set; }
        [StringLength(20)]
        public string Fax { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Website { get; set; }
        public int HotelStars { get; set; }

        [StringLength(int.MaxValue)]
        public string Description { get; set; }

        [StringLength(20)]
        public string checkin { get; set; }
        [StringLength(20)]
        public string checkout { get; set; }
        
        public double? distance_citycenter { get; set; }

        public double? distance_airport { get; set; }

        public int? CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual tbl_City City { get; set; }

        public virtual ICollection<tbl_Hotel_Restaurants> HotelRests { get; set; }
        public virtual ICollection<tbl_Hotel_Rooms> HotelRooms { get; set; }
        public virtual ICollection<tbl_hotel_amenity> HotelAmenities { get; set; }
        public virtual ICollection<tbl_hotel_sightseeing> HotelSightSeeings { get; set; }
        public virtual ICollection<tbl_Hotel_Photo> HotelPhotos { get; set; }
        public virtual ICollection<tbl_WishList> WishList_Hotel { get; set; }
        public virtual ICollection<tbl_rating> Rating_Hotel { get; set; }

    }
}