using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelleMariee.App.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 891, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "ImageUrl2", "ImageUrl3" },
                values: new object[] { new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(453), "/images/product/after3.1.webp", "/images/product/after3.2.webp", "/images/product/after3.3.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 20, 13, 24, 53, 892, DateTimeKind.Local).AddTicks(634));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "ImageUrl2", "ImageUrl3" },
                values: new object[] { new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1222), "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 23, 46, 39, 290, DateTimeKind.Local).AddTicks(1443));
        }
    }
}
