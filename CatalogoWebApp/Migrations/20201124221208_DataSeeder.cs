using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogoWebApp.Migrations
{
    public partial class DataSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Facultades",
                columns: new[] { "FacultadId", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 100, "100", "Ciencias  y humanidades" },
                    { 500, "500", "Facultad de ciencias de la salud" },
                    { 600, "600", "Ingenieria y arquitectura" },
                    { 800, "800", "Ciencias empresariales" }
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
                    { 5, "101", 100, "Licenciatura en periodismo y comunicación audiovisual" },
                    { 30, "601", 600, "Ingenieria industrial" },
                    { 31, "602", 600, "Arquitectura" },
                    { 32, "603", 600, "Ingenieria civil" },
                    { 33, "604", 600, "Ingenieria civil saneamiento ambiental" },
                    { 34, "605", 600, "Ingenieria en sistemas informaticos" },
                    { 35, "606", 600, "Ingenieria agronomica" },
                    { 36, "607", 600, "Ingenieria en telecomunicaciones y redes" },
                    { 37, "608", 600, "Ingenieria en desarrollo de software" },
                    { 25, "209", 600, "Ingenieria en tecnologia y procesamiento de alimentos" },
                    { 38, "698", 600, "Curso ccna academia de redes cisco unicaes" },
                    { 50, "905", 600, "Maestria en gerencia y gestion ambiental" },
                    { 29, "410", 800, "Licenciatura en sistemas informaticos administrativos" },
                    { 40, "801", 800, "Licenciatura en administracion de empresas" },
                    { 41, "802", 800, "Licenciatura en mercadeo y negocios internacionales" },
                    { 42, "803", 800, "Licenciatura en gestion y desarrollo turistico" },
                    { 43, "812", 800, "Licenciatura en contaduria publica" },
                    { 44, "890", 800, "Postgrado en estrategias para la competitividad" },
                    { 46, "901", 800, "Maestria en direccion estrategica de empresas" },
                    { 39, "699", 600, "Curso ccna academia de redes cisco unicaes" },
                    { 9, "110", 500, "Doctorado en medicina" },
                    { 7, "103", 500, "Tecnico en enfermeria" },
                    { 6, "102", 500, "Licenciatura en enfermeria" },
                    { 8, "104", 100, "Licenciatura en ciencias de la educacion con especialidad en idioma inglés" },
                    { 10, "119", 100, "Licenciatura en ciencias de la educacion con especialidad en educacion basica" },
                    { 11, "120", 100, "Profesorado en educacion basica para primero y segundo ciclo" },
                    { 12, "127", 100, "Profesorado en educación parvularia" },
                    { 13, "128", 100, "Licenciatura en ciencias religiosas" },
                    { 14, "129", 100, "Licenciatura en ciencias de la educacion con especialidad en educacion parvularia" },
                    { 15, "130", 100, "Licenciatura en educacion inicial y  parvularia" },
                    { 16, "131", 100, "Licenciatura en ciencias de la educacion especialidad en matematica semipresencial" },
                    { 17, "132", 100, "Licenciatura en ciencias de la educacion especialidad en direccion y administracion escolar - semipresencial" },
                    { 18, "133", 100, "Licenciatura en ciencias de la educacion especialidad en educacion basica semipresencial" },
                    { 19, "135", 100, "Licenciatura en idioma ingles (semipresencial)" },
                    { 20, "140", 100, "Profesorado en educacion  basica para primero y segundo ciclos" },
                    { 21, "144", 100, "Profesorado y licenciatura en educacion inicial y parvularia" },
                    { 22, "145", 100, "Licenciatura en idioma ingles" },
                    { 23, "160", 100, "Licenciatura en diseño grafico publicitario" },
                    { 26, "301", 100, "Licenciatura en ciencias juridicas" },
                    { 47, "902", 100, "Maestria en asesoria educativa" },
                    { 49, "904", 100, "Maestria en atencion integral de la primera infancia" },
                    { 52, "982", 100, "Curso de formacion pedagogica para profesionales" }
                });

            migrationBuilder.InsertData(
                table: "Carreras",
                columns: new[] { "CarreraId", "Codigo", "FacultadId", "Nombre" },
                values: new object[] { 51, "906", 800, "Maestria en gestion y desarrollo turistico" });

            migrationBuilder.InsertData(
                table: "Carreras",
                columns: new[] { "CarreraId", "Codigo", "FacultadId", "Nombre" },
                values: new object[] { 56, "805", 800, "Licenciatura en administracion de empresas - semipresencial" });

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "AutorId", "Apellidos", "CarreraId", "Codigo", "Nombres" },
                values: new object[,]
                {
                    { 19, "Escobar Hernandez", 5, "2007-EH-101", "Manuel Gonzalo" },
                    { 14, "Perez Moran", 34, "2002-PM-603", "Denice Beatriz" },
                    { 17, "España Canalez", 34, "2005-EC-603", "Glenda Maritza" },
                    { 39, "Orellana Recinos", 34, "2005-OR-601", "Marvin Ernesto" },
                    { 51, "Dueñas Marroquin", 34, "1999-DM-601", "Idalia Elizabeth" },
                    { 60, "Alabi Quinteros", 34, "2000-AQ-604", "Taufick Salvador" },
                    { 65, "Martinez Orellana", 34, "2015-MO-601", "William Alexander" },
                    { 69, "Gonzalez Magaña", 34, "2013-GM-603", "Francisco Gerardo" },
                    { 91, "Montes Fajardo", 34, "2008-MF-603", "Carlos Raul" },
                    { 94, "Yamileth Pineda Peña", 34, "2003-PP-601", "Rosa Agueda" },
                    { 105, "Alvarez Nolasco", 34, "2001-AN-601", "Karen Yesenia" },
                    { 112, "Paredes Damean", 34, "2011-PD-601", "Julio Alfonso" },
                    { 125, "Orozco Villa", 34, "2012-OV-601", "Edgar Francisco" },
                    { 127, "Moran Campos", 34, "1999-MC-605", "Billie Vladimir" },
                    { 141, "Jesus Escobar Avelar", 34, "2004-EA-603", "Manuel De" },
                    { 151, "Chavez Castillo", 34, "2005-CC-603", "Raul Guillermo" },
                    { 5, "Torres Gonzalez", 34, "1998-TG-601", "Mario Ernesto" },
                    { 33, "Martinez Lopez", 35, "2015-ML-607", "William Enrique" },
                    { 1, "Henriquez Hernandez", 34, "2013-HH-601", "Diego Fernando" },
                    { 134, "Lopez Emestica", 32, "2009-LE-601", "Efrain Antonio" },
                    { 67, "Ramos Perez", 30, "2013-RP-601", "Rene Antonio" },
                    { 72, "Martinez", 30, "1999-CM-607", "Camilo Canizalez" },
                    { 77, "Santana Quintanilla", 30, "2013-SQ-601", "Sandra Karina" },
                    { 110, "Qui¤onez Marroquin", 30, "1997-QM-601", "Jose Alfredo" },
                    { 131, "Toledo Cea", 30, "2014-TC-601", "Rene Mauricio" },
                    { 136, "Hernandez Guerra", 30, "1997-HG-601", "Iris Marisol" },
                    { 12, "Miranda", 31, "2005-MM-610", "Jimmy Patricia" },
                    { 58, "Acuña Sandoval", 31, "2000-AS-602", "Miguel Enrique" },
                    { 75, "Chavez Sandoval", 31, "1998-CS-601", "Helen Jeamileth" },
                    { 95, "Avalos Ramos", 31, "2012-AR-607", "Jose Miguel" },
                    { 108, "Vides Garcia", 31, "2013-VG-602", "Israel Jose" },
                    { 84, "Turcios Perez", 32, "2004-TP-601", "Carlos Antonio" },
                    { 96, "Flores Reyes", 32, "2008-FR-601", "Salvador Alberto" },
                    { 117, "Linares Arevalo", 32, "2011-LA-602", "Mauricio Oswaldo" },
                    { 132, "Flores Robles", 32, "1999-FR-602", "Jose Luis" },
                    { 118, "Galan Morales", 33, "1999-GM-603", "Josue Elias" },
                    { 61, "Aguilar Peñate", 30, "2001-AP-602", "Alvaro Ernesto" },
                    { 43, "Moreno Rodriguez", 35, "1998-MR-202", "Julio Eduardo" },
                    { 138, "Vasquez Rivera", 35, "2015-VR-603", "Jose Amilcar" },
                    { 104, "Anaya Marin", 40, "2000-AM-801", "Veronica Marisol" },
                    { 109, "Urquiza Henriquez", 40, "2013-UH-801", "Christian Francisco" },
                    { 113, "Castro Cordova", 40, "2004-CC-801", "Roxana Carolina" }
                });

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "AutorId", "Apellidos", "CarreraId", "Codigo", "Nombres" },
                values: new object[,]
                {
                    { 119, "Larin Nuñez", 40, "1997-LN-501", "Douglas Eduardo" },
                    { 124, "Barrera", 40, "1997-BB-801", "Rosa Armida" },
                    { 30, "Tenas Perez", 41, "2012-TP-801", "Jose Francisco" },
                    { 88, "Cerna Castillo", 41, "2012-CC-809", "Jenifer Eugenia" },
                    { 8, "Sermeño Ortiz", 42, "2012-SO-801", "Karla Isamar" },
                    { 68, "Molina Luna", 42, "2015-ML-802", "Jorge Armando" },
                    { 80, "Magaña Lopez", 42, "2013-ML-803", "Jose Mauricio" },
                    { 100, "Marroquin Chavez", 42, "2013-MC-806", "Ronald Edgardo" },
                    { 114, "Soto Carranza", 42, "2015-SC-806", "Roberto Jose" },
                    { 29, "Flores Zaldaña", 43, "2013-FZ-801", "Stephanie Beatriz" },
                    { 31, "Calles Sanchez", 43, "2015-CS-804", "Elias Vladimir" },
                    { 116, "Ortiz Pineda", 43, "2000-OP-801", "Walter Isaac" },
                    { 101, "Gomez Barrera", 40, "1998-GB-801", "Jazmin Lissette" },
                    { 87, "Guerrero Azucena", 35, "1997-GA-202", "Jose Mauricio" },
                    { 97, "Velasquez Flores", 40, "2008-VF-801", "Francisco Alfredo" },
                    { 62, "Bonilla Portillo", 40, "1997-BP-801", "Maria Ofelia" },
                    { 140, "Lopez Lopez", 35, "2013-LL-602", "Irmina Veronica" },
                    { 3, "Gonzalez Velasquez", 29, "1995-GV-401", "Marco Tulio" },
                    { 34, "Martinez Pineda", 29, "2008-MP-802", "Adriana Maria" },
                    { 47, "Caballero Vidal", 29, "2009-CV-801", "Veronica Yaneth" },
                    { 52, "Marquez Beltran", 29, "1989-MB-402", "Sandra Lissette" },
                    { 76, "Cañas Velasquez", 29, "2000-CV-802", "Brenda Maria" },
                    { 92, "Hernandez", 29, "2008-HH-801", "Henry Arnoldo" },
                    { 115, "Guerra Henriquez", 29, "1999-GH-401", "Claudia Maricely" },
                    { 139, "Linares Miranda", 29, "2000-LM-801", "Tania Ivanova" },
                    { 143, "Rivera Escobar", 29, "2004-RE-801", "Melvin Jose" },
                    { 20, "Martinez Arce", 40, "2000-MA-802", "Maria Emilia" },
                    { 23, "Sierra Fuentes", 40, "1997-SF-401", "Maria Ladys" },
                    { 45, "Barrera Hernandez", 40, "1993-BH-801", "Carmen Elena" },
                    { 48, "Guzman Moran", 40, "1993-GM-802", "Juan Carlos" },
                    { 59, "Paz Romero", 40, "2005-PR-803", "Jorge Alberto" },
                    { 70, "Mendoza Flores", 40, "1999-MF-801", "Dinora Carolina" },
                    { 121, "Rivera Quijano", 43, "2002-RQ-801", "Celia Areli" },
                    { 26, "Bolaños Rivas", 30, "2005-BR-601", "Joseias Armando" },
                    { 10, "Martinez Godinez", 30, "2005-MG-605", "Mario Ademir" },
                    { 122, "Segura Dolores", 10, "2009-SD-101", "Idvin Israel" },
                    { 21, "Chilin Duran", 11, "2007-CD-101", "Claribel Yasmin" },
                    { 57, "Garcia Medina", 11, "2009-GM-107", "Maritza Janeth" },
                    { 66, "Burgos Garcia De Lopez", 11, "2000-BL-101", "Daysi Eugenia" },
                    { 25, "Melendez Mojica", 13, "2005-MM-108", "Jose Rainiero" },
                    { 50, "Pop Teni", 13, "2016-PT-151", "Jefferson Oswaldo" },
                    { 53, "Castro Muñoz", 13, "2004-CM-101", "Julio Ruben" }
                });

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "AutorId", "Apellidos", "CarreraId", "Codigo", "Nombres" },
                values: new object[,]
                {
                    { 79, "Acu Muñoz", 13, "2005-AM-103", "Marvin Daniel" },
                    { 93, "Portillo Arbues", 13, "2011-PA-103", "Jose Amilcar" },
                    { 128, "Agreda Ortiz", 13, "2008-AO-101", "Alexis Giovanni" },
                    { 133, "Herrera Lopez", 13, "2012-HL-103", "Saul Alonso" },
                    { 135, "Salinas Sermeño", 13, "2003-SS-101", "Francisco Efrain" },
                    { 147, "Muñoz Leonor", 13, "2005-ML-103", "William Gustavo" },
                    { 15, "Trinidad Espino", 14, "2006-TE-101", "Xinia Liliana" },
                    { 18, "Cabrera Orantes", 14, "2004-CO-101", "Kenia Magdalena" },
                    { 98, "Sandoval Ramirez", 10, "2010-SR-101", "Luis Miguel" },
                    { 81, "Soriano Zelaya", 14, "2006-SZ-101", "Evelyn Xiomara" },
                    { 64, "Lopez Vasquez", 10, "2015-LV-101", "Jacqueline Guadalupe" },
                    { 32, "Jimenez Romero", 10, "2008-JR-101", "Adriana Margarita" },
                    { 28, "Lemus Caballero", 5, "2005-LC-101", "Raquel Esmeralda" },
                    { 36, "Cienfuegos Hernandez", 5, "2005-CH-101", "Jorge Ernesto" },
                    { 38, "Duran Tobar", 5, "2009-DT-101", "Joselin Yanira" },
                    { 73, "Majico Blanco", 5, "2007-MB-103", "Gustavo Adolfo" },
                    { 107, "Velasquez Paez", 5, "2014-VP-104", "Yolanda Maria" },
                    { 129, "Martinez Corleto", 5, "2011-MC-101", "Gabriela Beatriz" },
                    { 130, "Deleon Palomo", 5, "2006-DP-101", "Katherine Alexia" },
                    { 41, "Herrera Noches", 8, "2007-HN-101", "Rosa Maria" },
                    { 90, "Serrano Lopez", 8, "2008-SL-101", "Karla Maria" },
                    { 99, "Mejia Aguilar", 8, "2008-MA-104", "Marvin Alfonso" },
                    { 103, "Moran Mejia", 8, "2007-MM-107", "Diana Rebeca" },
                    { 120, "Santos Romero", 8, "2009-SR-101", "Elfida Elisa" },
                    { 123, "Orantes Lopez", 8, "2014-OL-101", "Patricia Guadalupe" },
                    { 149, "Diaz Chavez", 8, "2014-DC-101", "Raquel Eunice" },
                    { 4, "Vega Dueñas", 10, "2011-VD-101", "Joel Ernesto" },
                    { 44, "Chicas", 10, "2015-LC-101", "Adan Lopez" },
                    { 22, "Andaluz Guzman", 30, "1994-AG-602", "Jose Francisco" },
                    { 102, "Mejia Artero", 14, "2005-MA-105", "Karla Patricia" },
                    { 37, "Ramirez Santamaria", 16, "2016-RS-151", "Marcos Alexander" },
                    { 142, "Polanco Guerra", 26, "2003-PG-301", "Jose Roberto" },
                    { 7, "Rivas Ascencio", 6, "2014-RA-502", "Sonia Irene" },
                    { 42, "Perez Orellana", 6, "2011-PO-101", "Brenda Lizeth" },
                    { 56, "Mejia Zeceña", 6, "2009-MZ-102", "Karla Veronica" },
                    { 83, "Batres De Torres", 6, "2005-BB-101", "Sandra Rubidia" },
                    { 106, "Guerra Polanco", 6, "2006-GP-102", "Elvia Gabriela" },
                    { 111, "Valencia Castro", 6, "2014-VC-501", "Brenda Carolina" },
                    { 137, "Garrizano Patiño", 6, "2008-GP-102", "Andrea Patricia" },
                    { 146, "Vanegas Hernandez", 6, "2013-VH-101", "Katherinne Julissa" },
                    { 24, "Alvarado Pintin", 7, "2007-AP-103", "Jose Alejandro" },
                    { 150, "Valencia Guerrero De Lemus", 7, "2013-VG-102", "Claudia Jeanmillette" }
                });

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "AutorId", "Apellidos", "CarreraId", "Codigo", "Nombres" },
                values: new object[,]
                {
                    { 63, "Aviles De Perez", 9, "2014-AP-502", "Liliana Beatriz" },
                    { 148, "Alvarado Carranza", 9, "2017-AC-551", "Isabel Estefania" },
                    { 2, "Castillo Ramos", 30, "2000-CR-602", "Karla Iliana" },
                    { 9, "Salguero", 30, "1996-SS-602", "Manrique Alonso" },
                    { 86, "Espinoza De Paz", 26, "2010-ED-301", "Jorge Alberto" },
                    { 74, "Guzman Rosales", 15, "2014-GR-104", "Tatiana Maribel" },
                    { 78, "Leiva", 26, "2003-LL-301", "Nelson Oliverio" },
                    { 55, "Garcia Mendez", 26, "1996-GM-301", "Rebeca Fernandina" },
                    { 126, "Dina Sanchez Recinos", 16, "2010-SR-102", "Evila Yaran" },
                    { 144, "Matamoros", 16, "2011-MM-105", "Katya Jeamileth" },
                    { 85, "Sicilia Molina", 19, "2017-SM-151", "Manuel Antonio" },
                    { 11, "Aguilar Moran", 20, "2012-AM-102", "Juan Ramon" },
                    { 82, "Aragon Romero De Suarez", 20, "2012-AS-106", "Jancy Magali" },
                    { 89, "Mejia Guevara", 23, "2013-MG-109", "Eylin Adriana" },
                    { 6, "Calderon Sarmiento", 26, "1999-CS-302", "Keveen Manolo" },
                    { 13, "Roman Ortiz", 26, "2014-RO-102", "Erika Magaly" },
                    { 16, "Sandoval Alvarado", 26, "2006-SA-302", "Ana Vilma" },
                    { 27, "Quijano Rodriguez", 26, "2014-QR-101", "Carlos Ernesto" },
                    { 35, "Ramos Acu¥a", 26, "1995-RA-301", "Hugo Nelson" },
                    { 40, "Mancia Cabrera", 26, "2004-MC-302", "Claudia Mariela" },
                    { 46, "Mancia Abrego De Esquivel", 26, "2006-ME-303", "Lili Patricia" },
                    { 49, "Cruz Hernandez", 26, "1995-CH-301", "Levy Davina" },
                    { 54, "Sicilia Avila", 26, "1999-SA-301", "Gustavo Antonio" },
                    { 71, "Lopez Fuentes", 26, "1998-LF-802", "Dalila Lissette" },
                    { 145, "Gutierrez Martinez", 43, "2012-GM-805", "Brenda Seleny" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "TipoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "TipoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "TipoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Carreras",
                keyColumn: "CarreraId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Facultades",
                keyColumn: "FacultadId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Facultades",
                keyColumn: "FacultadId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Facultades",
                keyColumn: "FacultadId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Facultades",
                keyColumn: "FacultadId",
                keyValue: 800);
        }
    }
}
