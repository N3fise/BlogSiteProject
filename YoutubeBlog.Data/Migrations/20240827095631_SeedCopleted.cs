using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCopleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategooryId",
                table: "Articles");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedTime", "Name" },
                values: new object[,]
                {
                    { new Guid("27fe0e34-5996-4727-8aaf-8ec6f8950563"), "Admin test", new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(6629), null, null, false, null, new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(6627), "Visual studio deneme makalesi 1" },
                    { new Guid("4642999a-e595-42c7-aacf-1d7201b5c45a"), "Admin test", new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(6624), null, null, false, null, new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(6609), "Asp.net core deneme makalesi 1" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("3013b78e-c011-4c50-9498-6885ed538514"), "Admin test", new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(8189), null, null, "image/testimage", "jpg", false, null, new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(8177) },
                    { new Guid("c55d0cb5-2188-4725-afd9-430e3dc7893d"), "Admin test", new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(8195), null, null, "image/vstestimage", "jpg", false, null, new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(8193) }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedTime", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("28c3296f-92b5-4c54-a0f9-b31733a62e91"), new Guid("27fe0e34-5996-4727-8aaf-8ec6f8950563"), "visual studio A custom launcher and content management app for Assetto Corsa. Still in development. From the authors of Cars Manager.\r\n\r\nBasic (Lite) version is free and contains all features listed below as key features and more. If you want to support development and get the access to WIP features and pre-release builds, please consider making a donation (any amount), and you’ll get an app key enabling new features.", "Admin test", new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(4892), null, null, new Guid("c55d0cb5-2188-4725-afd9-430e3dc7893d"), false, null, new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(4886), "visual studio deneme makalesi 1", "15" },
                    { new Guid("c99b31d9-21aa-441a-8bb1-15e8c0c7235e"), new Guid("4642999a-e595-42c7-aacf-1d7201b5c45a"), "ASP.NET CORE A custom launcher and content management app for Assetto Corsa. Still in development. From the authors of Cars Manager.\r\n\r\nBasic (Lite) version is free and contains all features listed below as key features and more. If you want to support development and get the access to WIP features and pre-release builds, please consider making a donation (any amount), and you’ll get an app key enabling new features.", "Admin test", new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(4882), null, null, new Guid("3013b78e-c011-4c50-9498-6885ed538514"), false, null, new DateTime(2024, 8, 27, 12, 56, 31, 559, DateTimeKind.Local).AddTicks(4745), "ASP.NET CORE deneme makalesi 1", "15" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("28c3296f-92b5-4c54-a0f9-b31733a62e91"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c99b31d9-21aa-441a-8bb1-15e8c0c7235e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27fe0e34-5996-4727-8aaf-8ec6f8950563"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4642999a-e595-42c7-aacf-1d7201b5c45a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3013b78e-c011-4c50-9498-6885ed538514"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("c55d0cb5-2188-4725-afd9-430e3dc7893d"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "CategooryId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
