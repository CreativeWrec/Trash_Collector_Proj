using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorProj.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Zipcode")]
        public string ZipCode { get; set; }
        [Display(Name = "Customer Balance")]
        public double Balance { get; set; }
        [Display(Name = "Weekly Pick Up Date")]
        public DateTime WeeklyPickUpDate { get; set; }
        [Display(Name = "Extra Pick Up Date")]
        public DateTime ExtraPickUpDate { get; set; }
        [Display(Name = "Supend Start Date")]
        public DateTime SupendStartDate { get; set; }
        [Display(Name = "Supend End Date")]
        public DateTime SupendEndDate { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
