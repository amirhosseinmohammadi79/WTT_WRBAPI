using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WttCore.Models
{
    public class User
    {
        [Key]
        public string Uesrname { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string NationalCode { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Images { get; set; }

        [Required]
        public string MaritalStatus { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public int IsDeleted { get; set; }

        public List<Presence> Presences { get; set; }
        public List<Duty> Duties { get; set; }
        public List<Mission> Missions { get; set; }
        public List<Vacation> Vacations { get; set; }
        public List<OrderLunch> OrderLunchs { get; set; }
    }
}
