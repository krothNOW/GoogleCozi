using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoogleCozi.Models
{
    public class TimeOffRequest
    {
        public long ID { get; set; }

        [Display(Name = "Full Name")]
        [Required]
        public string DriverName { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string DriverEmail { get; set; }

        [Display(Name = "Driver ID")]
        [Required]
        public string DriverID { get; set; }

        [Display(Name = "Date Your Unavailability Begins")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime BeginDate { get; set; }

        [Display(Name = "Specific Time?")]
        [DataType(DataType.Time)]
        [Required]
        public DateTime BeginTime { get; set; }

        [Display(Name = "Date Your Unavailability Ends")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime EndDate { get; set; }

        [Display(Name = "Specific Time?")]
        [DataType(DataType.Time)]
        [Required]
        public DateTime EndTime { get; set; }

        [Display(Name = "Your assigned Route ID (if necessary)")]
        public string SpecificRoute { get; set; }

        [Display(Name = "Additional Details:")]
        public string AdditionalDetails { get; set; }
    }
}
