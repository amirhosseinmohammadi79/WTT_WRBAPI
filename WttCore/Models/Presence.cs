using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WttCore.Models
{
    public class Presence
    {
        [Key]
        public int PresenceId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string StartTime { get; set; }

        [Required]
        public string EndTime { get; set; }

        [Required]
        public string TotalTodayTime { get; set; }

        [Required]
        public string DayName { get; set; }

        [Required]
        public int IsDeleted { get; set; }

        [ForeignKey("User")]
        public string Username { get; set; }

        public User User { get; set; }

    }
}
