using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace BookShop.Areas.Admin.Models
{
   public class Customers
   {
       [Key]
       public int CustomerNo{get;set;}
       public string Username{get;set;}
       public string Password{get;set;}
       public string EmailAddress{get;set;}
       public string FirstName{get;set;}
       public string LastName{get;set;}
       public string Address1{get;set;}
       public string Address2{get;set;}
       public int CityStateNo{get;set;}
       public string Pincode{get;set;}
       public int CountryNo{get;set;}       
       public string DOB{get;set;}
       public string NewRelease{get;set;}
       public string BookUpdates{get;set;}
       public string LastLogin{get;set;}
       public string LastIP{get;set;}
       public Countries Countries{get;set;}
       public CityState CityState{get;set;}
  }
}