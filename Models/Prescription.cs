using System.ComponentModel.DataAnnotations;

namespace PrescriptionApp.Models
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }

        [Required(ErrorMessage = "Please enter the medication name.")]
        public string MedicationName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select the fill status.")]
        public string FillStatus { get; set; } = "New"; // default to New

        [Required(ErrorMessage = "Please enter the cost.")]
        [Range(0, 10000, ErrorMessage = "Cost must be a positive number.")]
        public double Cost { get; set; }

        [Required]
        [Display(Name = "Request Date")]
        public DateTime RequestTime { get; set; } = DateTime.Now;
    }
}