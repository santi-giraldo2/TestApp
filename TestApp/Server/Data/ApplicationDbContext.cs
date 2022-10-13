using Microsoft.EntityFrameworkCore;
using TestApp.Server.Models;

namespace TestApp.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1234561,
                FirstName = "Camila",
                MiddleName = null,
                LastName = "Gonzalez",
                SecondLastName = null,
                Email = "camilaGonzalez@mail.com",
                Address = "Calle 2",
                Age = 19,
                Gender = "F",
                Phone = 123456789
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1234562,
                FirstName = "Juan",
                MiddleName = null,
                LastName = "Perez",
                SecondLastName = null,
                Email = "juanPerez@mail.com",
                Address = "Calle 3",
                Age = 33,
                Gender = "M",
                Phone = 123456789
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1234563,
                FirstName = "Maria",
                MiddleName = null,
                LastName = "Gomez",
                SecondLastName = null,
                Email = "mariaGomez@mail.com",
                Address = "Calle 4",
                Age = 23,
                Gender = "F",
                Phone = 123456789
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1234564,
                FirstName = "Pedro",
                MiddleName = null,
                LastName = "Garcia",
                SecondLastName = null,
                Email = "pedroGarcia@mail.com",
                Address = "Calle 5",
                Age = 27,
                Gender = "M",
                Phone = 123456789
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1234565,
                FirstName = "Sofia",
                MiddleName = null,
                LastName = "Lopez",
                SecondLastName = null,
                Email = "sofiaLopez@mail.com",
                Address = "Calle 6",
                Age = 31,
                Gender = "F",
                Phone = 123456789
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1234566,
                FirstName = "Andres",
                MiddleName = null,
                LastName = "Martinez",
                SecondLastName = null,
                Email = "andresMartinez@mail.com",
                Address = "Calle 7",
                Age = 27,
                Gender = "M",
                Phone = 123456789
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1234567,
                FirstName = "Santiago",
                MiddleName = null,
                LastName = "Rodriguez",
                SecondLastName = null,
                Email = "santiagoRodriguez@mail.com",
                Address = "Calle 7",
                Age = 31,
                Gender = "M",
                Phone = 123456789
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1234568,
                FirstName = "Valentina",
                MiddleName = null,
                LastName = "Hernandez",
                SecondLastName = null,
                Email = "valentinaHernandez@mail.com",
                Address = "Calle 8",
                Age = 34,
                Gender = "F",
                Phone = 123456789
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1234569,
                FirstName = "Sofia",
                MiddleName = null,
                LastName = "Gonzalez",
                SecondLastName = null,
                Email = "sofiaGonzalez@mail.com",
                Address = "Calle 9",
                Age = 28,
                Gender = "F",
                Phone = 123456789
            });

            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 1,
                Name = "Pantalon",
                Description = "Blanco",
                Total = 1000,
                PersonId = 1234561
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 2,
                Name = "Camisa",
                Description = "Blanco",
                Total = 12000,
                PersonId = 1234561
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 3,
                Name = "Camisa",
                Description = "Blanco",
                Total = 12000,
                PersonId = 1234562
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 4,
                Name = "Camisa",
                Description = "Blanco",
                Total = 12000,
                PersonId = 1234562
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 5,
                Name = "Pantalon",
                Description = "Negro",
                Total = 8000,
                PersonId = 1234563
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 6,
                Name = "Zapatos",
                Description = "Alto",
                Total = 10000,
                PersonId = 1234563
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 7,
                Name = "Camisa",
                Description = "Blanco",
                Total = 18000,
                PersonId = 1234564
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 8,
                Name = "Pantalon",
                Description = "Vaquero",
                Total = 16000,
                PersonId = 1234564
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 9,
                Name = "Zapatos",
                Description = "Bajo",
                Total = 20000,
                PersonId = 1234565
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 10,
                Name = "Gorra",
                Description = "Plano",
                Total = 10000,
                PersonId = 1234565
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 11,
                Name = "Bufanda",
                Description = "Azul",
                Total = 4000,
                PersonId = 1234566
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 12,
                Name = "Bufanda",
                Description = "Roja",
                Total = 4000,
                PersonId = 1234566
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 13,
                Name = "Blusa",
                Description = "Naranja",
                Total = 4000,
                PersonId = 1234567
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 14,
                Name = "Pantalón",
                Description = "Azul",
                Total = 4000,
                PersonId = 1234567
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 15,
                Name = "Chaqueta",
                Description = "Azul",
                Total = 4000,
                PersonId = 1234568
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 16,
                Name = "Sandalias",
                Description = "Azul",
                Total = 4000,
                PersonId = 1234568
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 17,
                Name = "Bufanda",
                Description = "Rojo",
                Total = 4000,
                PersonId = 1234569
            });
            modelBuilder.Entity<Sale>().HasData(new Sale
            {
                Id = 18,
                Name = "Sandalias",
                Description = "Verde",
                Total = 4000,
                PersonId = 1234569
            });
        }
    }
}
