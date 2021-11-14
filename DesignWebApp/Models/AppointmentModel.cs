using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignWebApp.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20, MinimumLength =4)]
        [DisplayName("Patient's Full Name")]
        public string PatientName { get; set; }


        [DisplayName("Patient's Full Address")]
        public string PatientAddress { get; set; }

        [DataType(DataType.EmailAddress)]
        public string PatientEmail { get; set; }

        public int PatientPhone { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime AppointmentDate { get; set; }

        [DisplayName("Patient's Net Worth")]
        [DataType(DataType.Currency)]
        [Range(90000,2000000 )]
        public decimal PatientNetWorth { get; set; }
        [DisplayName("Primary Doctor's Last name")]
        public string DoctorName { get; set; }
        [Range(5,10)]
        [DisplayName("Patient's Perceived Level of pain (1 low to 10 high)")]
        public int PatientLevel { get; set; }
    }
}
