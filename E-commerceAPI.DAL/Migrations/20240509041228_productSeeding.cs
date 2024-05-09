using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_commerceAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class productSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "Model", "Name", "Price", "ProductImageURL" },
                values: new object[,]
                {
                    { 5, 1, "The Apple MacBook Air is a lightweight and portable laptop with excellent battery life.", 50m, "MacBook Air", "Apple MacBook Air", 40000m, "" },
                    { 6, 1, "The Apple MacBook Pro is a high-performance laptop loved by professionals.", 20m, "MacBook Pro", "Apple MacBook Pro", 80000m, "" },
                    { 7, 2, "The Dell XPS 13 is a sleek and powerful laptop with a stunning display.", 0m, "XPS 13", "Dell XPS 13", 40000m, "" },
                    { 8, 2, "The Dell Inspiron 15 is a versatile laptop suitable for everyday use.", 13m, "Inspiron 15", "Dell Inspiron 15", 35000m, "" },
                    { 9, 3, "The HP Spectre x360 is a stylish 2-in-1 laptop with powerful performance.", 15m, "Spectre x360", "HP Spectre x360", 25000m, "" },
                    { 10, 3, "The HP Pavilion 14 is a budget-friendly laptop with decent specifications.", 60m, "Pavilion 14", "HP Pavilion 14", 15000m, "" },
                    { 11, 1, "The Apple MacBook Air is a lightweight and portable laptop with excellent battery life.", 10m, "MacBook Air", "Apple MacBook Air", 28000m, "" },
                    { 12, 1, "The Apple MacBook Pro is a high-performance laptop loved by professionals.", 12m, "MacBook Pro", "Apple MacBook Pro", 30000m, "" },
                    { 13, 1, "The Apple iMac is a sleek and powerful all-in-one desktop computer.", 0m, "iMac", "Apple iMac", 16000m, "" },
                    { 14, 2, "The Dell XPS 13 is a sleek and powerful laptop with a stunning display.", 90m, "XPS 13", "Dell XPS 13", 14000m, "" },
                    { 15, 2, "The Dell Inspiron 15 is a versatile laptop suitable for everyday use.", 18m, "Inspiron 15", "Dell Inspiron 15", 30000m, "" },
                    { 16, 2, "The Dell G5 Gaming Desktop is a powerful gaming machine with immersive graphics.", 20m, "G5 Gaming Desktop", "Dell G5 Gaming Desktop", 38000m, "" },
                    { 17, 3, "The HP Spectre x360 is a stylish 2-in-1 laptop with powerful performance.", 19m, "Spectre x360", "HP Spectre x360", 26000m, "" },
                    { 18, 3, "The HP Pavilion 14 is a budget-friendly laptop with decent specifications.", 0m, "Pavilion 14", "HP Pavilion 14", 6000m, "" },
                    { 19, 3, "The HP EliteBook 840 is a business laptop with top-notch security features.", 80m, "EliteBook 840", "HP EliteBook 840", 50000m, "" },
                    { 20, 1, "The Apple MacBook Air is a lightweight and portable laptop with excellent battery life.", 15m, "MacBook Air", "Apple MacBook Air", 18000m, "" },
                    { 21, 2, "The Dell XPS 13 is a sleek and powerful laptop with a stunning display.", 5m, "XPS 13", "Dell XPS 13", 13000m, "" },
                    { 22, 3, "The HP Spectre x360 is a stylish 2-in-1 laptop with powerful performance.", 10m, "Spectre x360", "HP Spectre x360", 12000m, "" },
                    { 23, 4, "The Lenovo ThinkCentre M720 is a compact and reliable desktop computer for business use.", 6m, "ThinkCentre M720", "Lenovo ThinkCentre M720", 15000m, "" },
                    { 24, 5, "The ASUS ROG Strix G15 is a powerful gaming desktop with RGB lighting and high-performance components.", 60m, "ROG Strix G15", "ASUS ROG Strix G15", 80000m, "" },
                    { 25, 6, "The Acer Aspire TC is a budget-friendly desktop computer with decent performance.", 15m, "Aspire TC", "Acer Aspire TC", 18000m, "" },
                    { 26, 2, "The Dell Inspiron 27 is an all-in-one desktop computer with a large display and powerful performance.", 10m, "Inspiron 27", "Dell Inspiron 27", 22000m, "" },
                    { 27, 5, "The ASUS ZenBook Pro is a premium laptop with a stunning 4K display and high-performance components.", 15m, "ZenBook Pro", "ASUS ZenBook Pro", 28000m, "" },
                    { 28, 3, "The HP Pavilion Gaming Desktop is a gaming powerhouse with advanced graphics and smooth gameplay.", 80m, "Pavilion Gaming Desktop", "HP Pavilion Gaming Desktop", 15000m, "" },
                    { 29, 4, "The Lenovo Legion Y540 is a gaming laptop with powerful hardware and immersive gaming experience.", 12m, "Legion Y540", "Lenovo Legion Y540", 20000m, "" },
                    { 30, 1, "The Apple iMac is a sleek all-in-one desktop computer with a stunning Retina display and powerful performance.", 20m, "iMac", "Apple iMac", 24000m, "" },
                    { 31, 2, "The Dell G5 is a gaming laptop with high-performance hardware and immersive gaming features.", 10m, "G5 Gaming Laptop", "Dell G5 Gaming Laptop", 18000m, "" },
                    { 32, 3, "The HP Envy 15 is a premium laptop with a sleek design and powerful performance for multimedia and productivity tasks.", 15m, "Envy 15", "HP Envy 15", 16000m, "" },
                    { 33, 4, "The Lenovo IdeaCentre 5 is a compact and versatile desktop computer suitable for home and office use.", 50m, "IdeaCentre 5", "Lenovo IdeaCentre 5", 8990m, "" },
                    { 34, 5, "The ASUS VivoBook S15 is a stylish and lightweight laptop with a vibrant display and long battery life.", 0m, "VivoBook S15", "ASUS VivoBook S15", 9990m, "" },
                    { 35, 10, "The Samsung Galaxy Book Pro is a thin and lightweight laptop with a stunning AMOLED display and powerful performance.", 10m, "Galaxy Book Pro", "Samsung Galaxy Book Pro", 14990m, "" },
                    { 36, 2, "The Dell Alienware Aurora R10 is a high-performance gaming desktop with powerful hardware and customizable lighting.", 20m, "Alienware Aurora R10", "Dell Alienware Aurora R10", 28000m, "" },
                    { 37, 3, "The HP Omen 15 is a gaming laptop with a sleek design, high-refresh-rate display, and powerful performance for gaming enthusiasts.", 15m, "Omen 15", "HP Omen 15", 17999m, "" },
                    { 38, 1, "The Apple MacBook Air is a lightweight and portable laptop with a stunning Retina display and all-day battery life.", 10m, "MacBook Air", "Apple MacBook Air", 12990m, "" },
                    { 39, 9, "The Razer Blade 15 is a premium gaming laptop with a sleek design, high-refresh-rate display, and powerful performance.", 15m, "Blade 15", "Razer Blade 15", 23990m, "" },
                    { 40, 4, "The Lenovo ThinkPad X1 Carbon is a premium business laptop with a durable build, long battery life, and top-notch performance.", 60m, "ThinkPad X1 Carbon", "Lenovo ThinkPad X1 Carbon", 18990m, "" },
                    { 41, 5, "The ASUS ROG Zephyrus G14 is a powerful gaming laptop with an ultra-portable design and impressive performance.", 0m, "ROG Zephyrus G14", "ASUS ROG Zephyrus G14", 17000m, "" },
                    { 42, 8, "The MSI GS66 Stealth is a high-performance gaming laptop with a sleek design and powerful components.", 19m, "GS66 Stealth", "MSI GS66 Stealth", 23999m, "" },
                    { 43, 8, "The MSI Prestige 14 is a stylish and powerful laptop designed for creative professionals.", 17m, "Prestige 14", "MSI Prestige 14", 15990m, "" },
                    { 44, 7, "The Microsoft Surface Laptop 4 is a sleek and versatile laptop with a premium design and excellent performance.", 14m, "Surface Laptop 4", "Microsoft Surface Laptop 4", 23000m, "" },
                    { 45, 7, "The Microsoft Surface Pro 7 is a powerful 2-in-1 tablet-laptop hybrid with a detachable keyboard and versatile functionality.", 0m, "Surface Pro 7", "Microsoft Surface Pro 7", 20000m, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);
        }
    }
}
