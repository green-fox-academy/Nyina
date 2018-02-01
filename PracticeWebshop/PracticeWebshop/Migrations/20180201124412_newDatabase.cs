using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PracticeWebshop.Migrations
{
    public partial class newDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse");

            migrationBuilder.RenameTable(
                name: "Warehouse",
                newName: "PracticeWarehouse");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PracticeWarehouse",
                table: "PracticeWarehouse",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PracticeWarehouse",
                table: "PracticeWarehouse");

            migrationBuilder.RenameTable(
                name: "PracticeWarehouse",
                newName: "Warehouse");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse",
                column: "Id");
        }
    }
}
