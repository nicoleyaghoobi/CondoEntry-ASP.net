using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CondoEntryLogs.Models
{
    public class Visitor
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("First name")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Last name")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("Phone number")]
        [Required]
        public string PhoneNumber { get; set; }
        [DisplayName("Time of entry")]
        public DateTime? TimeOfEntry { get; set; }
        [DisplayName("Time of exit")]
        public DateTime? TimeOfExit { get; set; }
        [DisplayName("Unit number")]
        [Required]
        public int UnitNumber { get; set; }
    }
}
