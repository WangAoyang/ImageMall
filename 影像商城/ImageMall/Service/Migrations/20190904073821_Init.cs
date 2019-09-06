using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Service.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activityset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ActivityName = table.Column<string>(nullable: true),
                    Starting = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    ContactType = table.Column<string>(nullable: true),
                    ActivityDays = table.Column<string>(nullable: true),
                    Venue = table.Column<string>(nullable: true),
                    Deadline = table.Column<DateTime>(nullable: false),
                    TravelTime = table.Column<DateTime>(nullable: false),
                    Registered = table.Column<int>(nullable: false),
                    Places = table.Column<int>(nullable: false),
                    Intro = table.Column<string>(nullable: true),
                    Journey = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activityset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressInfoset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true),
                    Pid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressInfoset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Applicationset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ShopName = table.Column<string>(nullable: true),
                    TypeInfoId = table.Column<int>(nullable: false),
                    ShopNumber = table.Column<int>(nullable: false),
                    DictionariesId = table.Column<int>(nullable: false),
                    CurrencyType = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicationset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Collectset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    MasterId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collectset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dictionariesset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    TypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dictionariesset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DictionariesTypeset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictionariesTypeset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evaluateset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EvaluateName = table.Column<string>(nullable: true),
                    Pid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluateset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Indentset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ShopName = table.Column<string>(nullable: true),
                    TypeInfoId = table.Column<int>(nullable: false),
                    Surplus = table.Column<int>(nullable: false),
                    DictionariesId = table.Column<int>(nullable: false),
                    Currency = table.Column<decimal>(nullable: false),
                    CurrencyTypeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indentset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Informationset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    InformationName = table.Column<string>(nullable: true),
                    InformationTypeId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PictureId = table.Column<int>(nullable: false),
                    VerboseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informationset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformationTypeset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    informationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationTypeset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Integralset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    IntegralName = table.Column<string>(nullable: true),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    NeedIntegral = table.Column<int>(nullable: false),
                    Sales = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    Service = table.Column<string>(nullable: true),
                    PictureId = table.Column<int>(nullable: false),
                    Particulars = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integralset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leaseset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ShopName = table.Column<string>(nullable: true),
                    Pledge = table.Column<decimal>(nullable: false),
                    Charges = table.Column<decimal>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    Linkman = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Information = table.Column<string>(nullable: true),
                    Particulars = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaseset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterInfoset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ProductName = table.Column<string>(nullable: true),
                    MarketPrice = table.Column<decimal>(nullable: false),
                    MemberPrice = table.Column<decimal>(nullable: false),
                    Sales = table.Column<int>(nullable: false),
                    Surplus = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: false),
                    DictionariesId = table.Column<int>(nullable: false),
                    Service = table.Column<string>(nullable: true),
                    PictureId = table.Column<int>(nullable: false),
                    Particulars = table.Column<string>(nullable: true),
                    TypeInfo = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterInfoset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyBalanceset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    IntegralCount = table.Column<int>(nullable: false),
                    ExpendTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    ExpendIntegral = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyBalanceset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyIntegralset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    IntegralCount = table.Column<int>(nullable: false),
                    ExpendTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    ExpendIntegral = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyIntegralset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pictureset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    PictureUrl = table.Column<string>(nullable: true),
                    MasterId = table.Column<int>(nullable: false),
                    BreviaryUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictureset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Probationset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ShopName = table.Column<string>(nullable: true),
                    MarketPrice = table.Column<decimal>(nullable: false),
                    MemberPrice = table.Column<decimal>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Integral = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    PictureId = table.Column<int>(nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false),
                    Particulars = table.Column<string>(nullable: true),
                    Intro = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Probationset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Searchset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true),
                    TypeInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Searchset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seckillset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ShopName = table.Column<string>(nullable: true),
                    MarketPrice = table.Column<decimal>(nullable: false),
                    MemberPrice = table.Column<decimal>(nullable: false),
                    Sales = table.Column<int>(nullable: false),
                    Surplus = table.Column<int>(nullable: false),
                    DictionariesId = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seckillset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shoppingset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Masterd = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoppingset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Touristset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    TouristName = table.Column<string>(nullable: true),
                    TouristMessage = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Currency = table.Column<decimal>(nullable: false),
                    CurrencyType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Touristset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeInfoset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true),
                    Pid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeInfoset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfoset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    TrueName = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    PictureId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    Detailed = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false),
                    Integral = table.Column<int>(nullable: false),
                    Identity = table.Column<string>(nullable: true),
                    Account = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfoset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Verboseset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    VerboseName = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verboseset", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activityset");

            migrationBuilder.DropTable(
                name: "AddressInfoset");

            migrationBuilder.DropTable(
                name: "Applicationset");

            migrationBuilder.DropTable(
                name: "Collectset");

            migrationBuilder.DropTable(
                name: "Dictionariesset");

            migrationBuilder.DropTable(
                name: "DictionariesTypeset");

            migrationBuilder.DropTable(
                name: "Evaluateset");

            migrationBuilder.DropTable(
                name: "Indentset");

            migrationBuilder.DropTable(
                name: "Informationset");

            migrationBuilder.DropTable(
                name: "InformationTypeset");

            migrationBuilder.DropTable(
                name: "Integralset");

            migrationBuilder.DropTable(
                name: "Leaseset");

            migrationBuilder.DropTable(
                name: "MasterInfoset");

            migrationBuilder.DropTable(
                name: "MyBalanceset");

            migrationBuilder.DropTable(
                name: "MyIntegralset");

            migrationBuilder.DropTable(
                name: "Pictureset");

            migrationBuilder.DropTable(
                name: "Probationset");

            migrationBuilder.DropTable(
                name: "Searchset");

            migrationBuilder.DropTable(
                name: "Seckillset");

            migrationBuilder.DropTable(
                name: "Shoppingset");

            migrationBuilder.DropTable(
                name: "Touristset");

            migrationBuilder.DropTable(
                name: "TypeInfoset");

            migrationBuilder.DropTable(
                name: "UserInfoset");

            migrationBuilder.DropTable(
                name: "Verboseset");
        }
    }
}
