using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Shared
{
    public class PersonDTO
    {
        [Required(ErrorMessage = "El numero de documento es requerido")]
        [Range(1000000, 9999999999, ErrorMessage = "El numero de documento debe ser entre 7 y 10 digitos")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El primer nombre es requerido")]
        public string FirstName { get; set; } = null!;
        
        public string? MiddleName { get; set; }
        
        [Required(ErrorMessage = "El primer apellido es requerido")]
        public string LastName { get; set; } = null!;
        
        public string? SecondLastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int? Phone { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        
        [Required(ErrorMessage = "La dirección es requerida")]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = "La edad es requerida")]
        [Range(1, 120, ErrorMessage = "La edad debe estar entre 1 y 120")]
        public int Age { get; set; }

        [Required(ErrorMessage = "El género es requerido")]
        public string Gender { get; set; } = null!;
    }
}
