using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogoWebApp.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facultades",
                columns: table => new
                {
                    FacultadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultades", x => x.FacultadId);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.TipoId);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    CarreraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacultadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.CarreraId);
                    table.ForeignKey(
                        name: "FK_Carreras_Facultades_FacultadId",
                        column: x => x.FacultadId,
                        principalTable: "Facultades",
                        principalColumn: "FacultadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    AutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarreraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.AutorId);
                    table.ForeignKey(
                        name: "FK_Autores_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "CarreraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrabajosDeGraduacion",
                columns: table => new
                {
                    TrabajoDeGraduacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutorId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathImagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CarreraId = table.Column<int>(type: "int", nullable: false),
                    TipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrabajosDeGraduacion", x => x.TrabajoDeGraduacionId);
                    table.ForeignKey(
                        name: "FK_TrabajosDeGraduacion_Autores_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autores",
                        principalColumn: "AutorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrabajosDeGraduacion_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "TipoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Facultades",
                columns: new[] { "FacultadId", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "NA", "NO ASIGNADA" },
                    { 100, "100", "CIENCIAS  Y HUMANIDADES" },
                    { 500, "500", "FACULTAD DE CIENCIAS DE LA SALUD" },
                    { 600, "600", "INGENIERIA Y ARQUITECTURA" },
                    { 800, "800", "CIENCIAS EMPRESARIALES" },
                    { 900, "900", "DEPARTAMENTO DE IDIOMAS" },
                    { 906, null, "BIBLIOTECA" }
                });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "TipoId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Pasantia" },
                    { 2, "Proyecto" },
                    { 3, "Tesis" }
                });

            migrationBuilder.InsertData(
                table: "Carreras",
                columns: new[] { "CarreraId", "Codigo", "FacultadId", "Nombre" },
                values: new object[,]
                {
                    { 1, "000", 1, "GENERAL" },
                    { 25, "209", 600, "INGENIERIA EN TECNOLOGIA Y PROCESAMIENTO DE ALIMENTOS" },
                    { 30, "601", 600, "INGENIERIA INDUSTRIAL" },
                    { 31, "602", 600, "ARQUITECTURA" },
                    { 32, "603", 600, "INGENIERIA CIVIL" },
                    { 33, "604", 600, "INGENIERIA CIVIL SANEAMIENTO AMBIENTAL" },
                    { 34, "605", 600, "INGENIERIA EN SISTEMAS INFORMATICOS" },
                    { 35, "606", 600, "INGENIERIA AGRONOMICA" },
                    { 36, "607", 600, "INGENIERIA EN TELECOMUNICACIONES Y REDES" },
                    { 9, "110", 500, "DOCTORADO EN MEDICINA" },
                    { 37, "608", 600, "INGENIERIA EN DESARROLLO DE SOFTWARE" },
                    { 29, "410", 800, "LICENCIATURA EN SISTEMAS INFORMATICOS ADMINISTRATIVOS" },
                    { 40, "801", 800, "LICENCIATURA EN ADMINISTRACION DE EMPRESAS" },
                    { 41, "802", 800, "LICENCIATURA EN MERCADEO Y NEGOCIOS INTERNACIONALES" },
                    { 42, "803", 800, "LICENCIATURA EN GESTION Y DESARROLLO TURISTICO" },
                    { 43, "812", 800, "LICENCIATURA EN CONTADURIA PUBLICA" },
                    { 44, "890", 800, "POSTGRADO EN ESTRATEGIAS PARA LA COMPETITIVIDAD" },
                    { 46, "901", 800, "MAESTRIA EN DIRECCION ESTRATEGICA DE EMPRESAS" },
                    { 51, "906", 800, "MAESTRIA EN GESTION Y DESARROLLO TURISTICO" },
                    { 50, "905", 600, "MAESTRIA EN GERENCIA Y GESTION AMBIENTAL" },
                    { 7, "103", 500, "TECNICO EN ENFERMERIA" },
                    { 6, "102", 500, "LICENCIATURA EN ENFERMERIA" },
                    { 52, "982", 100, "CURSO DE FORMACION PEDAGOGICA PARA PROFESIONALES" },
                    { 5, "101", 100, "LICENCIATURA EN PERIODISMO Y COMUNICACIÓN AUDIOVISUAL" },
                    { 8, "104", 100, "LICENCIATURA EN CIENCIAS DE LA EDUCACION CON ESPECIALIDAD EN IDIOMA INGLÉS" },
                    { 10, "119", 100, "LICENCIATURA EN CIENCIAS DE LA EDUCACION CON ESPECIALIDAD EN EDUCACION BASICA" },
                    { 11, "120", 100, "PROFESORADO EN EDUCACION BASICA PARA PRIMERO Y SEGUNDO CICLO" },
                    { 12, "127", 100, "PROFESORADO EN EDUCACIÓN PARVULARIA" },
                    { 13, "128", 100, "LICENCIATURA EN CIENCIAS RELIGIOSAS" },
                    { 14, "129", 100, "LICENCIATURA EN CIENCIAS DE LA EDUCACION CON ESPECIALIDAD EN EDUCACION PARVULARIA" },
                    { 15, "130", 100, "LICENCIATURA EN EDUCACION INICIAL Y  PARVULARIA" },
                    { 16, "131", 100, "LICENCIATURA EN CIENCIAS DE LA EDUCACION ESPECIALIDAD EN MATEMATICA SEMIPRESENCIAL" },
                    { 17, "132", 100, "LICENCIATURA EN CIENCIAS DE LA EDUCACION ESPECIALIDAD EN DIRECCION Y ADMINISTRACION ESCOLAR - SEMIPRESENCIAL" },
                    { 18, "133", 100, "LICENCIATURA EN CIENCIAS DE LA EDUCACION ESPECIALIDAD EN EDUCACION BASICA SEMIPRESENCIAL" },
                    { 19, "135", 100, "LICENCIATURA EN IDIOMA INGLES (SEMIPRESENCIAL)" },
                    { 20, "140", 100, "PROFESORADO EN EDUCACION  BASICA PARA PRIMERO Y SEGUNDO CICLOS" },
                    { 21, "144", 100, "PROFESORADO Y LICENCIATURA EN EDUCACION INICIAL Y PARVULARIA" },
                    { 22, "145", 100, "LICENCIATURA EN IDIOMA INGLES" },
                    { 23, "160", 100, "LICENCIATURA EN DISEÑO GRAFICO PUBLICITARIO" },
                    { 26, "301", 100, "LICENCIATURA EN CIENCIAS JURIDICAS" },
                    { 47, "902", 100, "MAESTRIA EN ASESORIA EDUCATIVA" },
                    { 49, "904", 100, "MAESTRIA EN ATENCION INTEGRAL DE LA PRIMERA INFANCIA" }
                });

            migrationBuilder.InsertData(
                table: "Carreras",
                columns: new[] { "CarreraId", "Codigo", "FacultadId", "Nombre" },
                values: new object[] { 56, "805", 800, "LICENCIATURA EN ADMINISTRACION DE EMPRESAS - SEMIPRESENCIAL" });

            migrationBuilder.InsertData(
                table: "Carreras",
                columns: new[] { "CarreraId", "Codigo", "FacultadId", "Nombre" },
                values: new object[] { 45, "900", 900, "DEPARTAMENTO DE IDIOMAS" });

            migrationBuilder.CreateIndex(
                name: "IX_Autores_CarreraId",
                table: "Autores",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_FacultadId",
                table: "Carreras",
                column: "FacultadId");

            migrationBuilder.CreateIndex(
                name: "IX_TrabajosDeGraduacion_AutorId",
                table: "TrabajosDeGraduacion",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TrabajosDeGraduacion_TipoId",
                table: "TrabajosDeGraduacion",
                column: "TipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrabajosDeGraduacion");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "Facultades");
        }
    }
}
