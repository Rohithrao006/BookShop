using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Areas.Countries.Models
{
    public class Countries
    {
        [Key]
        public String country{get;set;}
    }
}