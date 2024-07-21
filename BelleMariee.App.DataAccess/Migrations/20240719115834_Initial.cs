using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BelleMariee.App.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "/images/product/default1.jpg"),
                    ImageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSaleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSaleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSaleDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSaleDetails_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1554), null, false, "After" },
                    { 2, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1556), null, false, "AKesim" },
                    { 3, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1557), null, false, "Balık" },
                    { 4, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1558), null, false, "Helen" },
                    { 5, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1558), null, false, "Modern" },
                    { 6, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1559), null, false, "Nikah" },
                    { 7, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1560), null, false, "Prenses" },
                    { 8, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1561), null, false, "UzunK" },
                    { 9, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1562), null, false, "Buket" },
                    { 10, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1563), null, false, "Duvak" },
                    { 11, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1563), null, false, "Tac" },
                    { 12, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1564), null, false, "Ayakkabı" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1390), false, "Gow" },
                    { 2, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1401), false, "Accessory" },
                    { 3, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1402), false, "Shoe" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "IsDeleted", "Name", "Price", "ProductTypeId", "Size", "Stock", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1595), "After 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "After 1", 40000m, 1, "38", 3, 0 },
                    { 2, 1, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1603), "After 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "After 2", 45000m, 1, "40", 2, 0 },
                    { 3, 1, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1605), "After 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "After 3", 42000m, 1, "36", 4, 0 },
                    { 4, 2, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1608), "AKesim 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "AKesim 1", 38000m, 1, "38", 3, 0 },
                    { 5, 2, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1609), "AKesim 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "AKesim 2", 39000m, 1, "40", 2, 0 },
                    { 6, 2, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1611), "AKesim 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "AKesim 3", 41000m, 1, "36", 4, 0 },
                    { 7, 3, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1613), "Balık 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Balık 1", 42000m, 1, "38", 3, 0 },
                    { 8, 3, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1615), "Balık 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Balık 2", 43000m, 1, "40", 2, 0 },
                    { 9, 3, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1617), "Balık 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Balık 3", 44000m, 1, "36", 4, 0 },
                    { 10, 4, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1619), "Helen 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Helen 1", 35000m, 1, "38", 3, 0 },
                    { 11, 4, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1621), "Helen 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Helen 2", 36000m, 1, "40", 2, 0 },
                    { 12, 4, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1623), "Helen 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Helen 3", 37000m, 1, "36", 4, 0 },
                    { 13, 5, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1625), "Modern 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Modern 1", 46000m, 1, "38", 3, 0 },
                    { 14, 5, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1627), "Modern 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Modern 2", 47000m, 1, "40", 2, 0 },
                    { 15, 5, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1629), "Modern 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Modern 3", 48000m, 1, "36", 4, 0 },
                    { 16, 6, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1631), "Nikah 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Nikah 1", 31000m, 1, "38", 3, 0 },
                    { 17, 6, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1633), "Nikah 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Nikah 2", 32000m, 1, "40", 2, 0 },
                    { 18, 6, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1635), "Nikah 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Nikah 3", 33000m, 1, "36", 4, 0 },
                    { 19, 7, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1663), "Prenses 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Prenses 1", 49000m, 1, "38", 3, 0 },
                    { 20, 7, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1665), "Prenses 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Prenses 2", 50000m, 1, "40", 2, 0 },
                    { 21, 7, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1667), "Prenses 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Prenses 3", 51000m, 1, "36", 4, 0 },
                    { 22, 8, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1669), "UzunK 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "UzunK 1", 34000m, 1, "38", 3, 0 },
                    { 23, 8, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1671), "UzunK 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "UzunK 2", 35000m, 1, "40", 2, 0 },
                    { 24, 8, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1673), "UzunK 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "UzunK 3", 36000m, 1, "36", 4, 0 },
                    { 25, 9, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1675), "Buket 1 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Buket 1", 2000m, 2, "Standart", 10, 0 },
                    { 26, 9, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1677), "Buket 2 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Buket 2", 2500m, 2, "Standart", 8, 0 },
                    { 27, 9, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1679), "Buket 3 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Buket 3", 3000m, 2, "Standart", 6, 0 },
                    { 28, 10, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1681), "Duvak 1 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Duvak 1", 1500m, 2, "Standart", 10, 0 },
                    { 29, 10, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1683), "Duvak 2 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Duvak 2", 2000m, 2, "Standart", 8, 0 },
                    { 30, 10, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1685), "Duvak 3 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Duvak 3", 2500m, 2, "Standart", 6, 0 },
                    { 31, 11, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1687), "Tac 1 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Tac 1", 1700m, 2, "Standart", 7, 0 },
                    { 32, 11, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1688), "Tac 2 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Tac 2", 2100m, 2, "Standart", 8, 0 },
                    { 33, 11, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1690), "Tac 3 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Tac 3", 200m, 2, "Standart", 6, 0 },
                    { 34, 12, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1692), "Ayakkabı 1", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Ayakkabı 1", 3000m, 3, "36", 5, 0 },
                    { 35, 12, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1694), "Ayakkabı 2", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Ayakkabı 2", 3500m, 3, "37", 4, 0 },
                    { 36, 12, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1696), "Ayakkabı 3", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Ayakkabı 3", 4000m, 3, "38", 3, 0 },
                    { 37, 12, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1697), "Ayakkabı 4", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", false, "Ayakkabı 4", 400m, 3, "39", 2, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSaleDetails_ProductId",
                table: "ProductSaleDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSaleDetails_SaleId",
                table: "ProductSaleDetails",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProductSaleDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
