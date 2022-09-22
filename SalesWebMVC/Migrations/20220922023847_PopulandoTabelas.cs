using Microsoft.EntityFrameworkCore.Migrations;
using SalesWebMVC.Models;

#nullable disable

namespace SalesWebMVC.Migrations
{
    public partial class PopulandoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Department(Name) VALUES('Eletronics')");
            migrationBuilder.Sql("INSERT INTO Department(Name) VALUES('Computer')");
            migrationBuilder.Sql("INSERT INTO Department(Name) VALUES('Fashion')");
            migrationBuilder.Sql("INSERT INTO Department(Name) VALUES('Books')");


            migrationBuilder.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, Department) VALUES('Bob Brown', 'bob@gmail.com', 1998/ 4/ 21), 1000.00, 'Eletronic')");
            /*migrationBuilder.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, Department) VALUES('Samuel Patrick', 'samuel@gmail.com', (1998, 4, 21), 1000.0, 'Computer')");
            migrationBuilder.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, Department) VALUES('Tiago Augusto', 'Tiago@gmail.com', (1998, 4, 21), 1000.0, 'Fashion')");
            migrationBuilder.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, Department) VALUES('Ramon Santos', 'Ramon@gmail.com', (1998, 4, 21), 1000.0, 'Books')");
            migrationBuilder.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, Department) VALUES('Sidney Abraao', 'Sid@gmail.com', (1998, 4, 21), 1000.0, 'Eletronic')");
            migrationBuilder.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, Department) VALUES('Gustavo Antonio', 'Gustavo@gmail.com', (1998, 4, 21), 1000.0, 'Eletronic')");*/


            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES((2018, 09, 25), 11000.0, 'Billed', 'Samuel Patrick')");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES((2018, 09, 25), 11000.0, 'Billed', 'Sidney Abraao')");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES((2018, 09, 25), 11000.0, 'Billed', 'Ramon Santos')");
           
            /* migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES()");*/













        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Department");

            migrationBuilder.Sql("DELETE FROM Seller");

            migrationBuilder.Sql("DELETE FROM SalesRecord");

        }
    }
}
