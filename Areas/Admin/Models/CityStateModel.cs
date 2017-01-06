using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Areas.Admin.Models
{
    public class CityState
    {
        [Key]
        public int CityStateNo{get;set;}
      
        [Required]
        [MaxLength(100)]
        public string State{get; set;}
      
        [Required]
        [MaxLength(100)]
        public string City {get; set;}

        public IList<Customers> Customers{get;set;}
    }
}