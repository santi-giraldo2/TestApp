using System.ComponentModel.DataAnnotations;

namespace TestApp.Server.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string? SecondLastName { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        public string Address { get; set; } = null!;
        public int Age { get; set; }
        public string Gender { get; set; } = null!;

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
