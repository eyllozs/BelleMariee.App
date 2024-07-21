using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BelleMariee.App.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5102), "CARNELIAN\r\nÜrün Kodu:\r\n4XLWBM1870W", "/images/product/after1.1.webp", "/images/product/after1.2.webp", "/images/product/after3.3.webp", "Tek Omuzlu After Party Elbisesi", 5000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5110), "Ürün Kodu:\r\nWHT0002TR|WH", "/images/product/after2.1.webp", "/images/product/after2.2.webp", "/images/product/after2.3.webp", "Straplez After Party Elbisesi", 9000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5113), "Ürün Kodu:\r\nWHT00AAH", "Askılı After Party Elbisesi", 7000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5115), "Ürün Kodu:\r\n4XLSWG989|SOLID/IV_38", "/images/product/AKesim1.1.webp", "/images/product/AKesim1.2.webp", "/images/product/AKesim1.3.webp", "A Kesim Kol Detaylı Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5117), "Ürün Kodu:\r\n4XLSWG76557ID/I8", "/images/product/AKesim2.1.webp", "/images/product/AKesim2.2.webp", "/images/product/AKesim2.3.webp", "A Kesim Tül Detaylı Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5119), "Ürün Kodu:\r\n4XRHDZTX8", "/images/product/AKesim3.1.webp", "/images/product/AKesim3.2.webp", "/images/product/AKesim3.3.webp", "A Kesim Straplez Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5121), "Ürün Kodu:\r\nSWGHBFHD38", "/images/product/balık1.1.webp", "/images/product/balık1.2.webp", "/images/product/balık1.3.webp", "V Yaka Balık Model Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5123), "Ürün Kodu:\r\nSWG970|SOLID/IV_38", "/images/product/balık2.1.webp", "/images/product/balık2.2.webp", "/images/product/balık2.3.webp", "Straplez Balık ModelGelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5125), "Ürün Kodu:\r\nSWFHFHHGS38", "/images/product/balık3.1.webp", "/images/product/balık3.2.webp", "/images/product/balık3.3.webp", "Straplez Balık Model Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5128), "AMELIE\r\nÜrün Kodu:\r\n1028|KEMİK_40", "/images/product/helen1.1.webp", "/images/product/helen1.2.webp", "/images/product/helen1.3.webp", "Derin Yırtmaçlı Sırt Detaylı Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5130), "CAMILLA\r\nÜrün Kodu:\r\n1020|KEMİK_40", "/images/product/helen2.1.webp", "/images/product/helen2.2.webp", "/images/product/helen2.3.webp", "V Yaka Payet İşlemeli Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5132), "EDITH\r\nÜrün Kodu:\r\n1029|KEMİK_40", "/images/product/helen3.1.webp", "/images/product/helen3.2.webp", "/images/product/helen3.3.webp", "Düşük Omuzlu Büzgülü Kol Detaylı Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5134), "Gelinlik\r\nÜrün Kodu:\r\n4XLSDWG1052|SOFT WHITE_40", "/images/product/Modern1.1.webp", "/images/product/Modern1.2.webp", "/images/product/dModern1.3.webp", "Önü Kısa Arkası Uzun Krep Dar Kesim" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5136), "HARMONIA\r\nÜrün Kodu:\r\n4XLWPD26986|IVORY_38", "/images/product/Modern2.1.webp", "/images/product/Modern2.2.webp", "/images/product/Modern2.3.webp", "Fiyonk Detaylı Saten Dar Kesim Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5138), "CARINO\r\nÜrün Kodu:\r\n1017|KEMİK_40", "/images/product/Modern3.1.webp", "/images/product/Modern3.2.webp", "/images/product/Modern3.3.webp", "Boncuk İşlemeli Kuyruklu Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5140), "Ürün Kodu:\r\nMA-B5625-001-INF|A29_0", "/images/product/nikah1.1.webp", "/images/product/nikah1.2.webp", "/images/product/nikah1.3.webp", "Yırtmaçlı Midi Boy Jarse Nikah Elbisesi" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5142), "Ürün Kodu:\r\nVC5595WHT|IVORY_34", "/images/product/nkah2.1.webp", "/images/product/nikah2.2.webp", "/images/product/nikah2.3.webp", "Arkası Yırtmaçlı Balon Kol Detaylı Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5144), "Ürün Kodu:\r\nVC5592WHT|IVORY_34", "/images/product/nikah3.1.webp", "/images/product/nikah3.2.webp", "/images/product/nikah3.3.webp", "Fiyonk Detaylı Yırtmaçlı Krep Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5146), " ÜRÜN KODU: 34066 700GG", "/images/product/prenses1.1.webp", "/images/product/prenses1.2.webp", "/images/product/prenses1.3.webp", "Dantel İşlemeli Straplez Balo Tipi Kuyruklu Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5148), " ÜRÜN KODU: 34067 701GG", "/images/product/prenses2.1.webp", "/images/product/prenses2.2.webp", "/images/product/prenses2.3.webp", "İnci İşlemeli Askılı A Kesim Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5150), " ÜRÜN KODU: 34068 702GG", "/images/product/prenses3.1.webp", "/images/product/prenses3.2.webp", "/images/product/prenses3.3.webp", "Saten Dantel İşlemeli V Yaka Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5152), "FRANCESCA\r\nÜrün Kodu:\r\n4XLWPD30119|IVORY/OLEG_42", "/images/product/uzunk1.1.webp", "/images/product/uzunk1.2.webp", "/images/product/uzunk1.3.webp", "Düşük Omuzlu Uzun Kollu Dar Kesim Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5154), "NORA\r\nÜrün Kodu:\r\n4XLMS251270|IVORY/STON_40", "/images/product/uzunk2.1.webp", "/images/product/uzunk2.2.webp", "/images/product/uzunk2.3.webp", "Uzun Kollu Dar Kesim Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5156), "VALENTINA\r\nÜrün Kodu:\r\n4XLWPD30203|IVORY/N N_42", "/images/product/uzunk3.1.webp", "/images/product/uzunk3.2.webp", "/images/product/uzunk3.3.webp", "Uzun Kollu Işıltılı Tül Dar Kesim Gelinlik" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5158), "Buket 1 Aksesuar, ÜRÜN KODU: 45001 800AK", "/images/product/b1.1.webp", "/images/product/b1.2.webp", "/images/product/b1.3.webp", "GRAND MAGNOLIA" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5160), "Buket 2 Aksesuar, ÜRÜN KODU: 45002 801AK", "/images/product/b2.1.webp", "/images/product/b2.2.webp", "/images/product/b2.3.webp", "GLORIA" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5164), "Buket 3 Aksesuar, ÜRÜN KODU: 45003 802AK", "/images/product/b3.1.webp", "/images/product/b3.2.webp", "/images/product/b3.3.webp", "ECROU" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5166), "Buket 4 Aksesuar, ÜRÜN KODU: 45004 803AK", "/images/product/b4.1.webp", "/images/product/b4.2.webp", "/images/product/b4.3.webp", "SPRING", 2200m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5168), "Buket 5 Aksesuar, ÜRÜN KODU: 45005 804AK", "/images/product/b5.1.webp", "/images/product/b5.2.webp", "/images/product/b5.3.webp", "MÜRDÜM", 2700m, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5169), "Buket 6 Aksesuar, ÜRÜN KODU: 45006 805AK", "/images/product/b6.1.webp", "/images/product/b6.2.webp", "/images/product/b6.3.webp", "V E L V E T", 2900m, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5171), "Ürün Kodu:\r\nWPD27227|IVORY_U", "/images/product/duvak1.1.webp", "/images/product/duvak1.2.webp", "/images/product/duvak1.3.webp", "Dantel ve Pul İşlemeli Katedral Boy Gelin Duvağı", 1500m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5173), "Ürün Kodu:\r\nINCILIDUVAKV2|IVORY_U", "/images/product/duvak2.1", "/images/product/duvak2.2.webp", "/images/product/duvak2.3.webp", "Uzun Tül Tamamı İnci Detaylı Duvak", 2000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5175), "Ürün Kodu:\r\nWPD28215V2|IVORY_U", "/images/product/duvak3.1.webp", "/images/product/duvak3.2.webp", "/images/product/duvak3.3.webp", "Taş İşlemeli Kısa Duvak", 2500m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "ProductTypeId", "Size", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5177), "Ürün Kodu:\r\nV1810B|IVORY_U", "/images/product/duvak4.1.webp", "/images/product/duvak4.2.webp", "/images/product/duvak4.3.webp", "Çiçek Motif Dantel İşlemeli Tül Gelin Duvağı", 2500m, 2, "Standart", 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "ProductTypeId", "Size", "Stock" },
                values: new object[] { 11, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5180), "Ürün Kodu:\r\nVGR191101001|IVORY_U", "/images/product/tac1.1.webp", "/images/product/tac1.2.webp", "/images/product/tac1.3.webp", "Kırık Beyaz İncili Gelin Tacı", 1700m, 2, "Standart", 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "ProductTypeId", "Size", "Stock" },
                values: new object[] { 11, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5181), "Ürün Kodu:\r\nH42235|SILVER_U", "/images/product/tac2.1.webp", "/images/product/tac2.2.webp", "/images/product/tac2.3.webp", "Yapay Elmas Gelin Tacı", 2100m, 2, "Standart", 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "ProductTypeId", "Size", "Stock" },
                values: new object[] { 11, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5183), "Ürün Kodu:\r\nWPD20601|IVORY_U", "/images/product/tac3.1.webp", "/images/product/tac3.2.webp", "/images/product/tac3.3.webp", "İnci Detaylı Yapay Elmas Gelin Tacı", 200m, 2, "Standart", 6 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "IsDeleted", "Name", "Price", "ProductTypeId", "Size", "Stock", "UserId" },
                values: new object[,]
                {
                    { 38, 12, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5186), "ÜRÜN KODU : 35060 206G", "/images/product/1.1.jpg", "/images/product/1.2.jpg", "/images/product/1.3.jpg", false, "SEDEF SATEN BLOOM GELİN AYAKKABISI", 2850m, 3, "36", 6, 0 },
                    { 39, 12, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5188), "ÜRÜN KODU : 35060 0250G\r\n", "/images/product/2.1.jpg", "/images/product/2.2.jpg", "/images/product/2.3.jpg", false, "SEDEF SATEN FLORENCE MİNİ TOPUK GELİN AYAKKABISI\r\n", 4500m, 3, "37", 9, 0 },
                    { 40, 12, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5190), "ÜRÜN KODU : 34210 2233G", "/images/product/3.1.jpg", "/images/product/3.2.jpg", "/images/product/3.3.jpg", false, "SEDEF NİNA İNCE TOPUK GELİN AYAKKABISI\r\n", 4500m, 3, "38", 3, 0 },
                    { 41, 12, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5192), "ÜRÜN KODU : 35072 1159G\r\n", "/images/product/4.1.jpg", "/images/product/4.2.jpg", "/images/product/4.3.jpg", false, "SEDEF SATEN LEROY TEK BANT GELİN AYAKKABISI\r\n", 2250m, 3, "39", 7, 0 },
                    { 42, 12, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5195), "ÜRÜN KODU : 34066 700GG\r\n", "/images/product/5.1.jpg", "/images/product/5.2.jpg", "/images/product/5.3.jpg", false, "SEDEF SO VERA GELİN AYAKKABISI\r\n", 4500m, 3, "40", 6, 0 },
                    { 43, 12, new DateTime(2024, 7, 19, 17, 7, 34, 33, DateTimeKind.Local).AddTicks(5202), "ÜRÜN KODU : 35060 202G\r\n", "/images/product/6.1.jpg", "/images/product/6.2.jpg", "/images/product/6.3.jpg", false, "SEDEF SATEN BLOOM GELİN AYAKKABISI\r\n", 2850m, 3, "41", 7, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1595), "After 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "After 1", 40000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1603), "After 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "After 2", 45000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Name", "Price" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1605), "After 3 Gelinlik", "After 3", 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1608), "AKesim 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "AKesim 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1609), "AKesim 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "AKesim 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1611), "AKesim 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "AKesim 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1613), "Balık 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Balık 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1615), "Balık 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Balık 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1617), "Balık 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Balık 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1619), "Helen 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Helen 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1621), "Helen 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Helen 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1623), "Helen 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Helen 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1625), "Modern 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Modern 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1627), "Modern 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Modern 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1629), "Modern 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Modern 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1631), "Nikah 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Nikah 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1633), "Nikah 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Nikah 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1635), "Nikah 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Nikah 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1663), "Prenses 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Prenses 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1665), "Prenses 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Prenses 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1667), "Prenses 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Prenses 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1669), "UzunK 1 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "UzunK 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1671), "UzunK 2 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "UzunK 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1673), "UzunK 3 Gelinlik", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "UzunK 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1675), "Buket 1 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Buket 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1677), "Buket 2 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Buket 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name" },
                values: new object[] { new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1679), "Buket 3 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Buket 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1681), "Duvak 1 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Duvak 1", 1500m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1683), "Duvak 2 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Duvak 2", 2000m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1685), "Duvak 3 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Duvak 3", 2500m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "Stock" },
                values: new object[] { 11, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1687), "Tac 1 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Tac 1", 1700m, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price" },
                values: new object[] { 11, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1688), "Tac 2 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Tac 2", 2100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price" },
                values: new object[] { 11, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1690), "Tac 3 Aksesuar", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Tac 3", 200m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "ProductTypeId", "Size", "Stock" },
                values: new object[] { 12, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1692), "Ayakkabı 1", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Ayakkabı 1", 3000m, 3, "36", 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "ProductTypeId", "Size", "Stock" },
                values: new object[] { 12, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1694), "Ayakkabı 2", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Ayakkabı 2", 3500m, 3, "37", 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "ProductTypeId", "Size", "Stock" },
                values: new object[] { 12, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1696), "Ayakkabı 3", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Ayakkabı 3", 4000m, 3, "38", 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedDate", "Description", "ImageUrl", "ImageUrl2", "ImageUrl3", "Name", "Price", "ProductTypeId", "Size", "Stock" },
                values: new object[] { 12, new DateTime(2024, 7, 19, 14, 58, 33, 452, DateTimeKind.Local).AddTicks(1697), "Ayakkabı 4", "/images/product/default1.jpg", "/images/product/default2.jpg", "/images/product/default3.jpg", "Ayakkabı 4", 400m, 3, "39", 2 });
        }
    }
}
