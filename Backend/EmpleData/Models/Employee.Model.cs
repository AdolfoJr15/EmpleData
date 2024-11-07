using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeData.Models
{
    public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(45, ErrorMessage = "El nombre no puede exceder los 45 caracteres.")]
        public string Employee_Name { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(45, ErrorMessage = "El apellido no puede exceder los 45 caracteres.")]
        public string Employee_Surname { get; set; }

        [Required(ErrorMessage = "El Cargo es obligatorio.")]
        [StringLength(45, ErrorMessage = "El cargo no puede exceder los 45 caracteres.")]
        public string Employee_Position { get; set; }

        [Required(ErrorMessage = "La fecha de ingreso es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime Entry_Date { get; set; }
    }
}
