using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CarLicences.Migrations
{
    public partial class CreateBasises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Licences",
                table: "Licences");

            migrationBuilder.RenameTable(
                name: "Licences",
                newName: "licencePlates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_licencePlates",
                table: "licencePlates",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_licencePlates",
                table: "licencePlates");

            migrationBuilder.RenameTable(
                name: "licencePlates",
                newName: "Licences");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Licences",
                table: "Licences",
                column: "Id");
        }
    }
}
