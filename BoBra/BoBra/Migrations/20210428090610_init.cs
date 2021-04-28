using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoBra.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Broker",
                columns: table => new
                {
                    BrokerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Business = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Broker", x => x.BrokerID);
                });

            migrationBuilder.CreateTable(
                name: "BrokerLogin",
                columns: table => new
                {
                    MKID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrokerLogin", x => x.MKID);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    PropertyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LivingArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rooms = table.Column<int>(type: "int", nullable: false),
                    BuildYear = table.Column<int>(type: "int", nullable: false),
                    HouseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlotArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BiArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.PropertyID);
                });

            migrationBuilder.CreateTable(
                name: "Broker_Property",
                columns: table => new
                {
                    PropertyID = table.Column<int>(type: "int", nullable: false),
                    BrokerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Broker_Property", x => new { x.BrokerID, x.PropertyID });
                    table.ForeignKey(
                        name: "FK_Broker_Property_Broker_BrokerID",
                        column: x => x.BrokerID,
                        principalTable: "Broker",
                        principalColumn: "BrokerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Broker_Property_Property_PropertyID",
                        column: x => x.PropertyID,
                        principalTable: "Property",
                        principalColumn: "PropertyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interest_Reg",
                columns: table => new
                {
                    PropertyID = table.Column<int>(type: "int", nullable: false),
                    AccountEmail = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interest_Reg", x => new { x.PropertyID, x.AccountEmail });
                    table.ForeignKey(
                        name: "FK_Interest_Reg_Account_AccountEmail",
                        column: x => x.AccountEmail,
                        principalTable: "Account",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interest_Reg_Property_PropertyID",
                        column: x => x.PropertyID,
                        principalTable: "Property",
                        principalColumn: "PropertyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Broker_Property_PropertyID",
                table: "Broker_Property",
                column: "PropertyID");

            migrationBuilder.CreateIndex(
                name: "IX_Interest_Reg_AccountEmail",
                table: "Interest_Reg",
                column: "AccountEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Broker_Property");

            migrationBuilder.DropTable(
                name: "BrokerLogin");

            migrationBuilder.DropTable(
                name: "Interest_Reg");

            migrationBuilder.DropTable(
                name: "Broker");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Property");
        }
    }
}
