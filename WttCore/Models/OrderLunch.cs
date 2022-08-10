using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WttCore.Models
{
    public class OrderLunch
    {
        [Key]
        public int OrderLunchId { get; set; }

        [Required]
        public DateTime Date { get; set; }

     
        [Required]
        public string DayName { get; set; }

        [Required]
        public string FoodType { get; set; }

        [Required]
        public string Price { get; set; }

        [Required]
        public int IsDeleted { get; set; }

        [ForeignKey("User")]
        public string Username { get; set; }
        public User User { get; set; }
    }
}
