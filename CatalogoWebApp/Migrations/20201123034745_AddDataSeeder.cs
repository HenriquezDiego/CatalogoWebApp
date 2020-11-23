using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogoWebApp.Migrations
{
    public partial class AddDataSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "AutorId", "Apellidos", "CarreraId", "Codigo", "Nombres" },
                values: new object[,]
                {
                    { 3, "Castillo Ramos", 30, "2000-CR-602", "Karla Iliana" },
                    { 99, "Sandoval Ramirez", 10, "2010-SR-101", "Luis Miguel" },
                    { 100, "Mejia Aguilar", 8, "2008-MA-104", "Marvin Alfonso" },
                    { 101, "Marroquin Chavez", 42, "2013-MC-806", "Ronald Edgardo" },
                    { 102, "Gomez Barrera", 40, "1998-GB-801", "Jazmin Lissette" },
                    { 103, "Mejia Artero", 14, "2005-MA-105", "Karla Patricia" },
                    { 104, "Moran Mejia", 8, "2007-MM-107", "Diana Rebeca" },
                    { 98, "Velasquez Flores", 40, "2008-VF-801", "Francisco Alfredo" },
                    { 105, "Anaya Marin", 40, "2000-AM-801", "Veronica Marisol" },
                    { 107, "Guerra Polanco", 6, "2006-GP-102", "Elvia Gabriela" },
                    { 108, "Velasquez Paez", 5, "2014-VP-104", "Yolanda Maria" },
                    { 109, "Vides Garcia", 31, "2013-VG-602", "Israel Jose" },
                    { 110, "Urquiza Henriquez", 40, "2013-UH-801", "Christian Francisco" },
                    { 111, "Qui¤onez Marroquin", 30, "1997-QM-601", "Jose Alfredo" },
                    { 112, "Valencia Castro", 6, "2014-VC-501", "Brenda Carolina" },
                    { 106, "Alvarez Nolasco", 34, "2001-AN-601", "Karen Yesenia" },
                    { 97, "Flores Reyes", 32, "2008-FR-601", "Salvador Alberto" },
                    { 96, "Avalos Ramos", 31, "2012-AR-607", "Jose Miguel" },
                    { 95, "Yamileth Pineda Peña", 34, "2003-PP-601", "Rosa Agueda" },
                    { 80, "Acu Muñoz", 13, "2005-AM-103", "Marvin Daniel" },
                    { 81, "Magaña Lopez", 42, "2013-ML-803", "Jose Mauricio" },
                    { 82, "Soriano Zelaya", 14, "2006-SZ-101", "Evelyn Xiomara" },
                    { 83, "Aragon Romero De Suarez", 20, "2012-AS-106", "Jancy Magali" },
                    { 84, "Batres De Torres", 6, "2005-BB-101", "Sandra Rubidia" },
                    { 85, "Turcios Perez", 32, "2004-TP-601", "Carlos Antonio" },
                    { 86, "Sicilia Molina", 19, "2017-SM-151", "Manuel Antonio" },
                    { 87, "Espinoza De Paz", 26, "2010-ED-301", "Jorge Alberto" },
                    { 88, "Guerrero Azucena", 35, "1997-GA-202", "Jose Mauricio" },
                    { 89, "Cerna Castillo", 41, "2012-CC-809", "Jenifer Eugenia" },
                    { 90, "Mejia Guevara", 23, "2013-MG-109", "Eylin Adriana" },
                    { 91, "Serrano Lopez", 8, "2008-SL-101", "Karla Maria" },
                    { 92, "Montes Fajardo", 34, "2008-MF-603", "Carlos Raul" },
                    { 93, "Hernandez", 29, "2008-HH-801", "Henry Arnoldo" },
                    { 94, "Portillo Arbues", 13, "2011-PA-103", "Jose Amilcar" },
                    { 113, "Paredes Damean", 34, "2011-PD-601", "Julio Alfonso" },
                    { 114, "Castro Cordova", 40, "2004-CC-801", "Roxana Carolina" },
                    { 115, "Soto Carranza", 42, "2015-SC-806", "Roberto Jose" },
                    { 116, "Guerra Henriquez", 29, "1999-GH-401", "Claudia Maricely" },
                    { 136, "Salinas Sermeño", 13, "2003-SS-101", "Francisco Efrain" },
                    { 137, "Hernandez Guerra", 30, "1997-HG-601", "Iris Marisol" },
                    { 138, "Garrizano Patiño", 6, "2008-GP-102", "Andrea Patricia" },
                    { 139, "Vasquez Rivera", 35, "2015-VR-603", "Jose Amilcar" }
                });

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "AutorId", "Apellidos", "CarreraId", "Codigo", "Nombres" },
                values: new object[,]
                {
                    { 140, "Linares Miranda", 29, "2000-LM-801", "Tania Ivanova" },
                    { 141, "Lopez Lopez", 35, "2013-LL-602", "Irmina Veronica" },
                    { 142, "Jesus Escobar Avelar", 34, "2004-EA-603", "Manuel De" },
                    { 143, "Polanco Guerra", 26, "2003-PG-301", "Jose Roberto" },
                    { 144, "Rivera Escobar", 29, "2004-RE-801", "Melvin Jose" },
                    { 145, "Matamoros", 16, "2011-MM-105", "Katya Jeamileth" },
                    { 146, "Gutierrez Martinez", 43, "2012-GM-805", "Brenda Seleny" },
                    { 147, "Vanegas Hernandez", 6, "2013-VH-101", "Katherinne Julissa" },
                    { 148, "Muñoz Leonor", 13, "2005-ML-103", "William Gustavo" },
                    { 149, "Alvarado Carranza", 9, "2017-AC-551", "Isabel Estefania" },
                    { 150, "Diaz Chavez", 8, "2014-DC-101", "Raquel Eunice" },
                    { 135, "Lopez Emestica", 32, "2009-LE-601", "Efrain Antonio" },
                    { 79, "Leiva", 26, "2003-LL-301", "Nelson Oliverio" },
                    { 134, "Herrera Lopez", 13, "2012-HL-103", "Saul Alonso" },
                    { 132, "Toledo Cea", 30, "2014-TC-601", "Rene Mauricio" },
                    { 117, "Ortiz Pineda", 43, "2000-OP-801", "Walter Isaac" },
                    { 118, "Linares Arevalo", 32, "2011-LA-602", "Mauricio Oswaldo" },
                    { 119, "Galan Morales", 33, "1999-GM-603", "Josue Elias" },
                    { 120, "Larin Nuñez", 40, "1997-LN-501", "Douglas Eduardo" },
                    { 121, "Santos Romero", 8, "2009-SR-101", "Elfida Elisa" },
                    { 122, "Rivera Quijano", 43, "2002-RQ-801", "Celia Areli" },
                    { 123, "Segura Dolores", 10, "2009-SD-101", "Idvin Israel" },
                    { 124, "Orantes Lopez", 8, "2014-OL-101", "Patricia Guadalupe" },
                    { 125, "Barrera", 40, "1997-BB-801", "Rosa Armida" },
                    { 126, "Orozco Villa", 34, "2012-OV-601", "Edgar Francisco" },
                    { 127, "Dina Sanchez Recinos", 16, "2010-SR-102", "Evila Yaran" },
                    { 128, "Moran Campos", 34, "1999-MC-605", "Billie Vladimir" },
                    { 129, "Agreda Ortiz", 13, "2008-AO-101", "Alexis Giovanni" },
                    { 130, "Martinez Corleto", 5, "2011-MC-101", "Gabriela Beatriz" },
                    { 131, "Deleon Palomo", 5, "2006-DP-101", "Katherine Alexia" },
                    { 133, "Flores Robles", 32, "1999-FR-602", "Jose Luis" },
                    { 78, "Santana Quintanilla", 30, "2013-SQ-601", "Sandra Karina" },
                    { 77, "Cañas Velasquez", 29, "2000-CV-802", "Brenda Maria" },
                    { 76, "Chavez Sandoval", 31, "1998-CS-601", "Helen Jeamileth" },
                    { 23, "Andaluz Guzman", 30, "1994-AG-602", "Jose Francisco" },
                    { 24, "Sierra Fuentes", 40, "1997-SF-401", "Maria Ladys" },
                    { 25, "Alvarado Pintin", 7, "2007-AP-103", "Jose Alejandro" },
                    { 26, "Melendez Mojica", 13, "2005-MM-108", "Jose Rainiero" },
                    { 27, "Bolaños Rivas", 30, "2005-BR-601", "Joseias Armando" },
                    { 28, "Quijano Rodriguez", 26, "2014-QR-101", "Carlos Ernesto" },
                    { 29, "Lemus Caballero", 5, "2005-LC-101", "Raquel Esmeralda" },
                    { 30, "Flores Zaldaña", 43, "2013-FZ-801", "Stephanie Beatriz" }
                });

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "AutorId", "Apellidos", "CarreraId", "Codigo", "Nombres" },
                values: new object[,]
                {
                    { 31, "Tenas Perez", 41, "2012-TP-801", "Jose Francisco" },
                    { 32, "Calles Sanchez", 43, "2015-CS-804", "Elias Vladimir" },
                    { 33, "Jimenez Romero", 10, "2008-JR-101", "Adriana Margarita" },
                    { 34, "Martinez Lopez", 35, "2015-ML-607", "William Enrique" },
                    { 35, "Martinez Pineda", 29, "2008-MP-802", "Adriana Maria" },
                    { 36, "Ramos Acu¥a", 26, "1995-RA-301", "Hugo Nelson" },
                    { 37, "Cienfuegos Hernandez", 5, "2005-CH-101", "Jorge Ernesto" },
                    { 22, "Chilin Duran", 11, "2007-CD-101", "Claribel Yasmin" },
                    { 38, "Ramirez Santamaria", 16, "2016-RS-151", "Marcos Alexander" },
                    { 21, "Martinez Arce", 40, "2000-MA-802", "Maria Emilia" },
                    { 19, "Cabrera Orantes", 14, "2004-CO-101", "Kenia Magdalena" },
                    { 4, "Gonzalez Velasquez", 29, "1995-GV-401", "Marco Tulio" },
                    { 5, "Vega Dueñas", 10, "2011-VD-101", "Joel Ernesto" },
                    { 6, "Torres Gonzalez", 34, "1998-TG-601", "Mario Ernesto" },
                    { 7, "Calderon Sarmiento", 26, "1999-CS-302", "Keveen Manolo" },
                    { 8, "Rivas Ascencio", 6, "2014-RA-502", "Sonia Irene" },
                    { 9, "Sermeño Ortiz", 42, "2012-SO-801", "Karla Isamar" },
                    { 10, "Salguero", 30, "1996-SS-602", "Manrique Alonso" },
                    { 11, "Martinez Godinez", 30, "2005-MG-605", "Mario Ademir" },
                    { 12, "Aguilar Moran", 20, "2012-AM-102", "Juan Ramon" },
                    { 13, "Miranda", 31, "2005-MM-610", "Jimmy Patricia" },
                    { 14, "Roman Ortiz", 26, "2014-RO-102", "Erika Magaly" },
                    { 15, "Perez Moran", 34, "2002-PM-603", "Denice Beatriz" },
                    { 16, "Trinidad Espino", 14, "2006-TE-101", "Xinia Liliana" },
                    { 17, "Sandoval Alvarado", 26, "2006-SA-302", "Ana Vilma" },
                    { 18, "España Canalez", 34, "2005-EC-603", "Glenda Maritza" },
                    { 20, "Escobar Hernandez", 5, "2007-EH-101", "Manuel Gonzalo" },
                    { 151, "Valencia Guerrero De Lemus", 7, "2013-VG-102", "Claudia Jeanmillette" },
                    { 39, "Duran Tobar", 5, "2009-DT-101", "Joselin Yanira" },
                    { 41, "Mancia Cabrera", 26, "2004-MC-302", "Claudia Mariela" },
                    { 61, "Alabi Quinteros", 34, "2000-AQ-604", "Taufick Salvador" },
                    { 62, "Aguilar Peñate", 30, "2001-AP-602", "Alvaro Ernesto" },
                    { 63, "Bonilla Portillo", 40, "1997-BP-801", "Maria Ofelia" },
                    { 64, "Aviles De Perez", 9, "2014-AP-502", "Liliana Beatriz" },
                    { 65, "Lopez Vasquez", 10, "2015-LV-101", "Jacqueline Guadalupe" },
                    { 66, "Martinez Orellana", 34, "2015-MO-601", "William Alexander" },
                    { 67, "Burgos Garcia De Lopez", 11, "2000-BL-101", "Daysi Eugenia" },
                    { 68, "Ramos Perez", 30, "2013-RP-601", "Rene Antonio" },
                    { 69, "Molina Luna", 42, "2015-ML-802", "Jorge Armando" },
                    { 70, "Gonzalez Magaña", 34, "2013-GM-603", "Francisco Gerardo" },
                    { 71, "Mendoza Flores", 40, "1999-MF-801", "Dinora Carolina" },
                    { 72, "Lopez Fuentes", 26, "1998-LF-802", "Dalila Lissette" }
                });

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "AutorId", "Apellidos", "CarreraId", "Codigo", "Nombres" },
                values: new object[,]
                {
                    { 73, "Martinez", 30, "1999-CM-607", "Camilo Canizalez" },
                    { 74, "Majico Blanco", 5, "2007-MB-103", "Gustavo Adolfo" },
                    { 75, "Guzman Rosales", 15, "2014-GR-104", "Tatiana Maribel" },
                    { 60, "Paz Romero", 40, "2005-PR-803", "Jorge Alberto" },
                    { 40, "Orellana Recinos", 34, "2005-OR-601", "Marvin Ernesto" },
                    { 59, "Acuña Sandoval", 31, "2000-AS-602", "Miguel Enrique" },
                    { 57, "Mejia Zeceña", 6, "2009-MZ-102", "Karla Veronica" },
                    { 42, "Herrera Noches", 8, "2007-HN-101", "Rosa Maria" },
                    { 43, "Perez Orellana", 6, "2011-PO-101", "Brenda Lizeth" },
                    { 44, "Moreno Rodriguez", 35, "1998-MR-202", "Julio Eduardo" },
                    { 45, "Chicas", 10, "2015-LC-101", "Adan Lopez" },
                    { 46, "Barrera Hernandez", 40, "1993-BH-801", "Carmen Elena" },
                    { 47, "Mancia Abrego De Esquivel", 26, "2006-ME-303", "Lili Patricia" },
                    { 48, "Caballero Vidal", 29, "2009-CV-801", "Veronica Yaneth" },
                    { 49, "Guzman Moran", 40, "1993-GM-802", "Juan Carlos" },
                    { 50, "Cruz Hernandez", 26, "1995-CH-301", "Levy Davina" },
                    { 51, "Pop Teni", 13, "2016-PT-151", "Jefferson Oswaldo" },
                    { 52, "Dueñas Marroquin", 34, "1999-DM-601", "Idalia Elizabeth" },
                    { 53, "Marquez Beltran", 29, "1989-MB-402", "Sandra Lissette" },
                    { 54, "Castro Muñoz", 13, "2004-CM-101", "Julio Ruben" },
                    { 55, "Sicilia Avila", 26, "1999-SA-301", "Gustavo Antonio" },
                    { 56, "Garcia Mendez", 26, "1996-GM-301", "Rebeca Fernandina" },
                    { 58, "Garcia Medina", 11, "2009-GM-107", "Maritza Janeth" },
                    { 152, "Chavez Castillo", 34, "2005-CC-603", "Raul Guillermo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Autores",
                keyColumn: "AutorId",
                keyValue: 152);
        }
    }
}
