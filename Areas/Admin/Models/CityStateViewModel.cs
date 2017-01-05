using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Areas.Admin.Models
{
    public class CityState
    {
        [Key]
        public int CSNo{get;set;}

        public string State{get; set;}

        public string City {get; set;}
    }
}