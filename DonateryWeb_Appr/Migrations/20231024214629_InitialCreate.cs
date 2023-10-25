using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DonateryWeb_Appr.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActiveDisasters",
                columns: table => new
                {
                    DisasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisasterLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisasterDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisasterStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisasterEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisasterAidTypeWanted = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveDisasters", x => x.DisasterId);
                });

            migrationBuilder.CreateTable(
                name: "AuthorisedUsers",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorisedUsers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "DonationOfGoodsCategories",
                columns: table => new
                {
                    DonationCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonationCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationOfGoodsCategories", x => x.DonationCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "DonationsOfMoneys",
                columns: table => new
                {
                    DonationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DonationAmount = table.Column<double>(type: "float", nullable: false),
                    DonationDonor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationsOfMoneys", x => x.DonationId);
                });

            migrationBuilder.CreateTable(
                name: "AllocationOfMoneys",
                columns: table => new
                {
                    AllocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfAllocation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountAllocated = table.Column<double>(type: "float", nullable: false),
                    DisasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllocationOfMoneys", x => x.AllocationId);
                    table.ForeignKey(
                        name: "FK_AllocationOfMoneys_ActiveDisasters_DisasterId",
                        column: x => x.DisasterId,
                        principalTable: "ActiveDisasters",
                        principalColumn: "DisasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllocationOfGoods",
                columns: table => new
                {
                    AllocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfAllocation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfItemsAllocated = table.Column<int>(type: "int", nullable: false),
                    DonationOfGoodsCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllocationOfGoods", x => x.AllocationId);
                    table.ForeignKey(
                        name: "FK_AllocationOfGoods_ActiveDisasters_DisasterId",
                        column: x => x.DisasterId,
                        principalTable: "ActiveDisasters",
                        principalColumn: "DisasterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllocationOfGoods_DonationOfGoodsCategories_DonationOfGoodsCategoryId",
                        column: x => x.DonationOfGoodsCategoryId,
                        principalTable: "DonationOfGoodsCategories",
                        principalColumn: "DonationCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonationOfGoods",
                columns: table => new
                {
                    DonationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DonationNumberOfItems = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonationDonor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationOfGoods", x => x.DonationId);
                    table.ForeignKey(
                        name: "FK_DonationOfGoods_DonationOfGoodsCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "DonationOfGoodsCategories",
                        principalColumn: "DonationCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchasesOfGoods",
                columns: table => new
                {
                    PurchaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfPurchase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountRequired = table.Column<double>(type: "float", nullable: false),
                    NumberOfItemsPurchased = table.Column<int>(type: "int", nullable: false),
                    DonationOfGoodsCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasesOfGoods", x => x.PurchaseId);
                    table.ForeignKey(
                        name: "FK_PurchasesOfGoods_ActiveDisasters_DisasterId",
                        column: x => x.DisasterId,
                        principalTable: "ActiveDisasters",
                        principalColumn: "DisasterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchasesOfGoods_DonationOfGoodsCategories_DonationOfGoodsCategoryId",
                        column: x => x.DonationOfGoodsCategoryId,
                        principalTable: "DonationOfGoodsCategories",
                        principalColumn: "DonationCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllocationOfGoods_DisasterId",
                table: "AllocationOfGoods",
                column: "DisasterId");

            migrationBuilder.CreateIndex(
                name: "IX_AllocationOfGoods_DonationOfGoodsCategoryId",
                table: "AllocationOfGoods",
                column: "DonationOfGoodsCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AllocationOfMoneys_DisasterId",
                table: "AllocationOfMoneys",
                column: "DisasterId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationOfGoods_CategoryId",
                table: "DonationOfGoods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesOfGoods_DisasterId",
                table: "PurchasesOfGoods",
                column: "DisasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesOfGoods_DonationOfGoodsCategoryId",
                table: "PurchasesOfGoods",
                column: "DonationOfGoodsCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllocationOfGoods");

            migrationBuilder.DropTable(
                name: "AllocationOfMoneys");

            migrationBuilder.DropTable(
                name: "AuthorisedUsers");

            migrationBuilder.DropTable(
                name: "DonationOfGoods");

            migrationBuilder.DropTable(
                name: "DonationsOfMoneys");

            migrationBuilder.DropTable(
                name: "PurchasesOfGoods");

            migrationBuilder.DropTable(
                name: "ActiveDisasters");

            migrationBuilder.DropTable(
                name: "DonationOfGoodsCategories");
        }
    }
}
