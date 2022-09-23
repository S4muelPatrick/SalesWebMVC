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


            migrationBuilder.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary) VALUES('Samuel Patrick', 'Samuel@gmail.com', '2005-03-12', 670.00)");
            migrationBuilder.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary) VALUES('Eudésio', 'eudesio@gmail.com', '1980-04-21', 2000.00)");
            migrationBuilder.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary) VALUES('Ramon', 'Ramon@gmail.com', '1990-06-13', 1000.00)");
            migrationBuilder.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary) VALUES('Tiago Martins', 'Tiago@gmail.com', '1998-05-15', 1000.00)");
            migrationBuilder.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary) VALUES('Bob Brown', 'bob@gmail.com', '1995-04-21', 4000.00)");
            

            /*migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES(2018-09-25, 11000.0, 'Billed', 'Samuel Patrick')");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES(2018-09-25, 11000.0, 'Billed', 'Sidney Abraao')");
            migrationBuilder.Sql("INSERT INTO SalesRecord(Date, Amount, Status, Seller) VALUES(2018-09-25, 11000.0, 'Billed', 'Ramon Santos')");
           */
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
