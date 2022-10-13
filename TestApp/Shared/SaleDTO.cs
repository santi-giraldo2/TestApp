using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Shared
{
    public class SaleDTO
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "El nombre es requerido")]
        public string? Name { get; set; }
        public string? Description { get; set; }

        [Required(ErrorMessage = "El total es requerido")]
        [Range(1, 9999999999, ErrorMessage = "El total debe ser mayor a 0")]
        public int Total { get; set; }
        public int PersonId { get; set; }
    }
}
