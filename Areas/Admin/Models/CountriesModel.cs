using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Areas.Admin.Models
{
    public class Countries
    {
        [Key]
        public string country{get;set;}
    }
}