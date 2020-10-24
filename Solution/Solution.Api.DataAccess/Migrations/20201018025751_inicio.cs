using Microsoft.EntityFrameworkCore.Migrations;

namespace Solution.Api.DataAccess.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EMPRESAS",
                columns: table => new
                {
                    EmpresaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaNombre = table.Column<string>(nullable: true),
                    EmpresaEstado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPRESAS", x => x.EmpresaID);
                });

            migrationBuilder.CreateTable(
                name: "TIPODOCUMENTO",
                columns: table => new
                {
                    TipoDocumentoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumentoNombre = table.Column<string>(nullable: true),
                    EmpresaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPODOCUMENTO", x => x.TipoDocumentoID);
                    table.ForeignKey(
                        name: "FK_TIPODOCUMENTO_EMPRESAS_EmpresaID",
                        column: x => x.EmpresaID,
                        principalTable: "EMPRESAS",
                        principalColumn: "EmpresaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PERSONA",
                columns: table => new
                {
                    PersonaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaNombre = table.Column<string>(nullable: true),
                    PersonaApelliso = table.Column<string>(nullable: true),
                    PersonaNroDocumento = table.Column<string>(nullable: true),
                    EmpresaID = table.Column<int>(nullable: false),
                    TipoDocumentoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONA", x => x.PersonaID);
                    table.ForeignKey(
                        name: "FK_PERSONA_EMPRESAS_EmpresaID",
                        column: x => x.EmpresaID,
                        principalTable: "EMPRESAS",
                        principalColumn: "EmpresaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PERSONA_TIPODOCUMENTO_TipoDocumentoID",
                        column: x => x.TipoDocumentoID,
                        principalTable: "TIPODOCUMENTO",
                        principalColumn: "TipoDocumentoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UBICACION",
                columns: table => new
                {
                    UbicacionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UbicacionLongitud = table.Column<string>(nullable: true),
                    UbicacionLatitud = table.Column<string>(nullable: true),
                    UbicacionObservaciones = table.Column<string>(nullable: true),
                    PersonaID = table.Column<int>(nullable: false),
                    EmpresaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UBICACION", x => x.UbicacionID);
                    table.ForeignKey(
                        name: "FK_UBICACION_EMPRESAS_EmpresaID",
                        column: x => x.EmpresaID,
                        principalTable: "EMPRESAS",
                        principalColumn: "EmpresaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UBICACION_PERSONA_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "PERSONA",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PERSONA_EmpresaID",
                table: "PERSONA",
                column: "EmpresaID");

            migrationBuilder.CreateIndex(
                name: "IX_PERSONA_TipoDocumentoID",
                table: "PERSONA",
                column: "TipoDocumentoID");

            migrationBuilder.CreateIndex(
                name: "IX_TIPODOCUMENTO_EmpresaID",
                table: "TIPODOCUMENTO",
                column: "EmpresaID");

            migrationBuilder.CreateIndex(
                name: "IX_UBICACION_EmpresaID",
                table: "UBICACION",
                column: "EmpresaID");

            migrationBuilder.CreateIndex(
                name: "IX_UBICACION_PersonaID",
                table: "UBICACION",
                column: "PersonaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UBICACION");

            migrationBuilder.DropTable(
                name: "PERSONA");

            migrationBuilder.DropTable(
                name: "TIPODOCUMENTO");

            migrationBuilder.DropTable(
                name: "EMPRESAS");
        }
    }
}
