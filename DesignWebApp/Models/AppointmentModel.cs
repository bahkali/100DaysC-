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
        [DisplayName("Patient Name")]
        public string PatientName { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayName("Appointment Date")]
        public DateTime AppointmentDate { get; set; }

        [DisplayName("Net Worth")]
        [DataType(DataType.Currency)]
        public decimal PatientNetWorth { get; set; }
        [DisplayName("Primary Doctor")]
        public string DoctorName { get; set; }
        [Range(1,10)]
        [DisplayName("Patient's Perceived Level of pain (1 low to 10 high)")]
        public int PatientLevel { get; set; }
    }
}
