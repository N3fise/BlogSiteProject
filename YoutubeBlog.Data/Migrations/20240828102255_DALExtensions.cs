using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("28c3296f-92b5-4c54-a0f9-b31733a62e91"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c99b31d9-21aa-441a-8bb1-15e8c0c7235e"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedTime", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("593c6e51-5ca4-484f-a6ec-5479c4817dc5"), new Guid("4642999a-e595-42c7-aacf-1d7201b5c45a"), "ASP.NET CORE A custom launcher and content management app for Assetto Corsa. Still in development. From the authors of Cars Manager.\r\n\r\nBasic (Lite) version is free and contains all features listed below as key features and more. If you want to support development and get the access to WIP features and pre-release builds, please consider making a donation (any amount), and you’ll get an app key enabling new features.", "Admin test", new DateTime(2024, 8, 28, 13, 22, 55, 605, DateTimeKind.Local).AddTicks(864), null, null, new Guid("3013b78e-c011-4c50-9498-6885ed538514"), false, null, new DateTime(2024, 8, 28, 13, 22, 55, 605, DateTimeKind.Local).AddTicks(803), "ASP.NET CORE deneme makalesi 1", "15" },
                    { new Guid("7914f8ae-f8a8-4bd2-ab27-d782a9e566e1"), new Guid("27fe0e34-5996-4727-8aaf-8ec6f8950563"), "visual studio A custom launcher and content management app for Assetto Corsa. Still in development. From the authors of Cars Manager.\r\n\r\nBasic (Lite) version is free and contains all features listed below as key features and more. If you want to support development and get the access to WIP features and pre-release builds, please consider making a donation (any amount), and you’ll get an app key enabling new features.", "Admin test", new DateTime(2024, 8, 28, 13, 22, 55, 605, DateTimeKind.Local).AddTicks(880), null, null, new Guid("c55d0cb5-2188-4725-afd9-430e3dc7893d"), false, null, new DateTime(2024, 8, 28, 13, 22, 55, 605, DateTimeKind.Local).AddTicks(868), "visual studio deneme makalesi 1", "15" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27fe0e34-5996-4727-8aaf-8ec6f8950563"),
                columns: new[] { "CreatedDate", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 8, 28, 13, 22, 55, 605, DateTimeKind.Local).AddTicks(3361), new DateTime(2024, 8, 28, 13, 22, 55, 605, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4642999a-e595-42c7-aacf-1d7201b5c45a"),
                columns: new[] { "CreatedDate", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 8, 28, 13, 22, 55, 605, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 8, 28, 13, 22, 55, 605, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3013b78e-c011-4c50-9498-6885ed538514"),
                columns: new[] { "CreatedDate", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 8, 28, 13, 22, 55, 605, DateTimeKind.Local).AddTicks(5148), new DateTime(2024, 8, 28, 13, 22, 55, 605, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c55d0cb5-2188-4725-afd9-430e3dc7893d"),
                columns: new[] { "CreatedDate", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 8, 28, 13, 22, 55, 605, DateTimeKind.Local).AddTicks(5156), new DateTime(2024, 8, 28, 13, 22, 55, 605, DateTimeKind.Local).AddTicks(5153) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("593c6e51-5ca4-484f-a6ec-5479c4817dc5"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7914f8ae-f8a8-4bd2-ab27-d782a9e566e1"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedTime", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("28c3296f-92b5-4c54-a0f9-b31733a62e91"), new Guid("27fe0e34-5996-4727-8aaf-8ec6f8950563"), "visual studio A custom launcher and content management app for Assetto Corsa. Still in development. From the authors of Cars Manager.\r\n\r\nBasic (Lite) version is free and contains all features listed below as key features and more. If you want to support development and get the access to WIP features and pre-release builds, please consider making a donation (any amount), and you’ll get an app key enabling new features.", "Admin test", new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(4892), null, null, new Guid("c55d0cb5-2188-4725-afd9-430e3dc7893d"), false, null, new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(4886), "visual studio deneme makalesi 1", "15" },
                    { new Guid("c99b31d9-21aa-441a-8bb1-15e8c0c7235e"), new Guid("4642999a-e595-42c7-aacf-1d7201b5c45a"), "ASP.NET CORE A custom launcher and content management app for Assetto Corsa. Still in development. From the authors of Cars Manager.\r\n\r\nBasic (Lite) version is free and contains all features listed below as key features and more. If you want to support development and get the access to WIP features and pre-release builds, please consider making a donation (any amount), and you’ll get an app key enabling new features.", "Admin test", new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(4882), null, null, new Guid("3013b78e-c011-4c50-9498-6885ed538514"), false, null, new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(4745), "ASP.NET CORE deneme makalesi 1", "15" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27fe0e34-5996-4727-8aaf-8ec6f8950563"),
                columns: new[] { "CreatedDate", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(6629), new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4642999a-e595-42c7-aacf-1d7201b5c45a"),
                columns: new[] { "CreatedDate", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(6624), new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3013b78e-c011-4c50-9498-6885ed538514"),
                columns: new[] { "CreatedDate", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(8189), new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c55d0cb5-2188-4725-afd9-430e3dc7893d"),
                columns: new[] { "CreatedDate", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(8195), new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(8193) });
        }
    }
}
