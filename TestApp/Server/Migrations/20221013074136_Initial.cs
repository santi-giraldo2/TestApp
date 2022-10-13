using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApp.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "Age", "Email", "FirstName", "Gender", "LastName", "MiddleName", "Phone", "SecondLastName" },
                values: new object[,]
                {
                    { 1234561, "Calle 2", 19, "camilaGonzalez@mail.com", "Camila", "F", "Gonzalez", null, 123456789, null },
                    { 1234562, "Calle 3", 33, "juanPerez@mail.com", "Juan", "M", "Perez", null, 123456789, null },
                    { 1234563, "Calle 4", 23, "mariaGomez@mail.com", "Maria", "F", "Gomez", null, 123456789, null },
                    { 1234564, "Calle 5", 27, "pedroGarcia@mail.com", "Pedro", "M", "Garcia", null, 123456789, null },
                    { 1234565, "Calle 6", 31, "sofiaLopez@mail.com", "Sofia", "F", "Lopez", null, 123456789, null },
                    { 1234566, "Calle 7", 27, "andresMartinez@mail.com", "Andres", "M", "Martinez", null, 123456789, null },
                    { 1234567, "Calle 7", 31, "santiagoRodriguez@mail.com", "Santiago", "M", "Rodriguez", null, 123456789, null },
                    { 1234568, "Calle 8", 34, "valentinaHernandez@mail.com", "Valentina", "F", "Hernandez", null, 123456789, null },
                    { 1234569, "Calle 9", 28, "sofiaGonzalez@mail.com", "Sofia", "F", "Gonzalez", null, 123456789, null }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Description", "Name", "PersonId", "Total" },
                values: new object[,]
                {
                    { 1, "Blanco", "Pantalon", 1234561, 1000 },
                    { 2, "Blanco", "Camisa", 1234561, 12000 },
                    { 3, "Blanco", "Camisa", 1234562, 12000 },
                    { 4, "Blanco", "Camisa", 1234562, 12000 },
                    { 5, "Negro", "Pantalon", 1234563, 8000 },
                    { 6, "Alto", "Zapatos", 1234563, 10000 },
                    { 7, "Blanco", "Camisa", 1234564, 18000 },
                    { 8, "Vaquero", "Pantalon", 1234564, 16000 },
                    { 9, "Bajo", "Zapatos", 1234565, 20000 },
                    { 10, "Plano", "Gorra", 1234565, 10000 },
                    { 11, "Azul", "Bufanda", 1234566, 4000 },
                    { 12, "Roja", "Bufanda", 1234566, 4000 },
                    { 13, "Naranja", "Blusa", 1234567, 4000 },
                    { 14, "Azul", "Pantalón", 1234567, 4000 },
                    { 15, "Azul", "Chaqueta", 1234568, 4000 },
                    { 16, "Azul", "Sandalias", 1234568, 4000 },
                    { 17, "Rojo", "Bufanda", 1234569, 4000 },
                    { 18, "Verde", "Sandalias", 1234569, 4000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_PersonId",
                table: "Sales",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
