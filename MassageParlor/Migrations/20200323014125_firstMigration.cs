using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MassageParlor.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Massages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Massages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    MassageId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyProperty_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyProperty_Massages_MassageId",
                        column: x => x.MassageId,
                        principalTable: "Massages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), "Alex", "Down" },
                    { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "Brandon", "Ten" }
                });

            migrationBuilder.InsertData(
                table: "Massages",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Swedish massage is a gentle type of full-body massage.", "Swedish" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Hot stone massage is best for people who have muscle pain and tension or who simply want to relax.", "Hot stone massage" }
                });

            migrationBuilder.InsertData(
                table: "MyProperty",
                columns: new[] { "Id", "EmployeeId", "MassageId" },
                values: new object[] { new Guid("5b1c3c4d-48c7-402a-80c3-cc796ad49c6b"), new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96") });

            migrationBuilder.InsertData(
                table: "MyProperty",
                columns: new[] { "Id", "EmployeeId", "MassageId" },
                values: new object[] { new Guid("1b3c3c4d-48c7-402a-80c3-cc796ad49c6b"), new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96") });

            migrationBuilder.InsertData(
                table: "MyProperty",
                columns: new[] { "Id", "EmployeeId", "MassageId" },
                values: new object[] { new Guid("1b3c3c4d-48c7-402a-70c5-cc796ad49c6b"), new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96") });

            migrationBuilder.CreateIndex(
                name: "IX_MyProperty_EmployeeId",
                table: "MyProperty",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MyProperty_MassageId",
                table: "MyProperty",
                column: "MassageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyProperty");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Massages");
        }
    }
}
