using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Frangao.Data.Models
{
    public class Granja
    {
        public int Id { get; set; }

        [Display(Name = "Date of Creation")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfCreation { get; set; }

        [Required(ErrorMessage = "Farm Name is required")]
        [StringLength(100, ErrorMessage = "Farm Name cannot exceed 100 characters")]
        public string FarmName { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(50, ErrorMessage = "State cannot exceed 50 characters")]
        public string State { get; set; }

        [Required(ErrorMessage = "Municipality is required")]
        [StringLength(50, ErrorMessage = "Municipality cannot exceed 50 characters")]
        public string Municipality { get; set; }

        [Required(ErrorMessage = "Production System is required")]
        [StringLength(50, ErrorMessage = "Production System cannot exceed 50 characters")]
        public string ProductionSystem { get; set; }
    }
}
