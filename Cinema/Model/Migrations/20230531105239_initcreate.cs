using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class initcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "E_COUNTRIES",
                columns: table => new
                {
                    NAME = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E_COUNTRIES", x => x.NAME);
                });

            migrationBuilder.CreateTable(
                name: "E_STATES",
                columns: table => new
                {
                    NAME = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E_STATES", x => x.NAME);
                });

            migrationBuilder.CreateTable(
                name: "MOVIES",
                columns: table => new
                {
                    MOVIE_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TITLE = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DIRECTOR = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LENGTH = table.Column<int>(type: "INTEGER", maxLength: 900, nullable: false),
                    SHORT_DESCRIPTION = table.Column<string>(type: "TEXT", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOVIES", x => x.MOVIE_ID);
                });

            migrationBuilder.CreateTable(
                name: "PERSONS",
                columns: table => new
                {
                    PERSON_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FIRST_NAME = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    LAST_NAME = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    DISCRIMINATOR = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONS", x => x.PERSON_ID);
                });

            migrationBuilder.CreateTable(
                name: "ADDRESSES",
                columns: table => new
                {
                    ADDRESS_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    POSTAL_CODE = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    LOCATION = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    STREET = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    STATE = table.Column<string>(type: "TEXT", nullable: false),
                    COUNTRY = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADDRESSES", x => x.ADDRESS_ID);
                    table.ForeignKey(
                        name: "FK_ADDRESSES_E_COUNTRIES_COUNTRY",
                        column: x => x.COUNTRY,
                        principalTable: "E_COUNTRIES",
                        principalColumn: "NAME",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ADDRESSES_E_STATES_STATE",
                        column: x => x.STATE,
                        principalTable: "E_STATES",
                        principalColumn: "NAME",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DOCU_MOVIES",
                columns: table => new
                {
                    MOVIE_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TOPIC = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOCU_MOVIES", x => x.MOVIE_ID);
                    table.ForeignKey(
                        name: "FK_DOCU_MOVIES_MOVIES_MOVIE_ID",
                        column: x => x.MOVIE_ID,
                        principalTable: "MOVIES",
                        principalColumn: "MOVIE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ENTERTAINMENT_MOVIES",
                columns: table => new
                {
                    MOVIE_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CATEGORY = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENTERTAINMENT_MOVIES", x => x.MOVIE_ID);
                    table.ForeignKey(
                        name: "FK_ENTERTAINMENT_MOVIES_MOVIES_MOVIE_ID",
                        column: x => x.MOVIE_ID,
                        principalTable: "MOVIES",
                        principalColumn: "MOVIE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CINEMAS",
                columns: table => new
                {
                    CINEMA_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LABEL = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ADDRESS_ID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CINEMAS", x => x.CINEMA_ID);
                    table.ForeignKey(
                        name: "FK_CINEMAS_ADDRESSES_ADDRESS_ID",
                        column: x => x.ADDRESS_ID,
                        principalTable: "ADDRESSES",
                        principalColumn: "ADDRESS_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HALLS",
                columns: table => new
                {
                    HALL_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CAPACITY = table.Column<int>(type: "INTEGER", nullable: false),
                    NAME = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    CODE = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    CINEMA_ID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HALLS", x => x.HALL_ID);
                    table.ForeignKey(
                        name: "FK_HALLS_CINEMAS_CINEMA_ID",
                        column: x => x.CINEMA_ID,
                        principalTable: "CINEMAS",
                        principalColumn: "CINEMA_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADDRESSES_COUNTRY",
                table: "ADDRESSES",
                column: "COUNTRY");

            migrationBuilder.CreateIndex(
                name: "IX_ADDRESSES_STATE",
                table: "ADDRESSES",
                column: "STATE");

            migrationBuilder.CreateIndex(
                name: "IX_CINEMAS_ADDRESS_ID",
                table: "CINEMAS",
                column: "ADDRESS_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HALLS_CINEMA_ID",
                table: "HALLS",
                column: "CINEMA_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOCU_MOVIES");

            migrationBuilder.DropTable(
                name: "ENTERTAINMENT_MOVIES");

            migrationBuilder.DropTable(
                name: "HALLS");

            migrationBuilder.DropTable(
                name: "PERSONS");

            migrationBuilder.DropTable(
                name: "MOVIES");

            migrationBuilder.DropTable(
                name: "CINEMAS");

            migrationBuilder.DropTable(
                name: "ADDRESSES");

            migrationBuilder.DropTable(
                name: "E_COUNTRIES");

            migrationBuilder.DropTable(
                name: "E_STATES");
        }
    }
}
