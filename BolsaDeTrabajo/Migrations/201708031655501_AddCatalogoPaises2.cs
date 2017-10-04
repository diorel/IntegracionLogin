namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCatalogoPaises2 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT [Sist].[Paises] ON");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (1, N'Australia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (2, N'Austria')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (3, N'Azerbaiyan')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (4, N'Anguilla')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (5, N'Argentina')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (6, N'Armenia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (7, N'Bielorrusia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (8, N'Belice')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (9, N'Belgica')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (10, N'Bermudas')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (11, N'Bulgaria')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (12, N'Brasil')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (13, N'Reino Unido')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (14, N'Hungria')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (15, N'Vietnam')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (16, N'Haiti')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (17, N'Guadalupe')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (18, N'Alemania')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (19, N'Paises Bajos, Holanda')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (20, N'Grecia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (21, N'Georgia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (22, N'Dinamarca')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (23, N'Egipto')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (24, N'Israel')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (25, N'India')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (26, N'Iran')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (27, N'Irlanda')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (28, N'Espa�a')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (29, N'Italia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (30, N'Kazajstan')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (31, N'Camerun')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (32, N'Canada')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (33, N'Chipre')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (34, N'Kirguistan')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (35, N'China')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (36, N'Costa Rica')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (37, N'Kuwait')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (38, N'Letonia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (39, N'Libia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (40, N'Lituania')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (41, N'Luxemburgo')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (42, N'Mexico')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (43, N'Moldavia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (44, N'Monaco')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (45, N'Nueva Zelanda')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (46, N'Noruega')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (47, N'Polonia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (48, N'Portugal')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (49, N'Reunion')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (50, N'Rusia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (51, N'El Salvador')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (52, N'Eslovaquia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (53, N'Eslovenia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (54, N'Surinam')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (55, N'Estados Unidos')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (56, N'Tadjikistan')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (57, N'Turkmenistan')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (58, N'Islas Turcas y Caicos')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (59, N'Turquia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (60, N'Uganda')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (61, N'Uzbekistan')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (62, N'Ucrania')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (63, N'Finlandia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (64, N'Francia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (65, N'Republica Checa')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (66, N'Suiza')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (67, N'Suecia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (68, N'Estonia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (69, N'Corea del Sur')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (70, N'Japon')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (71, N'Croacia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (72, N'Rumania')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (73, N'Hong Kong')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (74, N'Indonesia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (75, N'Jordania')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (76, N'Malasia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (77, N'Singapur')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (78, N'Taiwan')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (79, N'Bosnia y Herzegovina')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (80, N'Bahamas')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (81, N'Chile')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (82, N'Colombia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (83, N'Islandia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (84, N'Corea del Norte')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (85, N'Macedonia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (86, N'Malta')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (87, N'Pakistan')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (88, N'Papua-Nueva Guinea')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (89, N'Peru')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (90, N'Filipinas')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (91, N'Arabia Saudita')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (92, N'Tailandia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (93, N'Emiratos arabes Unidos')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (94, N'Groenlandia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (95, N'Venezuela')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (96, N'Zimbabwe')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (97, N'Kenia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (98, N'Algeria')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (99, N'Libano')");
            
Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (100, N'Botsuana')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (101, N'Tanzania')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (102, N'Namibia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (103, N'Ecuador')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (104, N'Marruecos')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (105, N'Ghana')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (106, N'Siria')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (107, N'Nepal')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (108, N'Mauritania')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (109, N'Seychelles')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (110, N'Paraguay')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (111, N'Uruguay')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (112, N'Congo (Brazzaville)')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (113, N'Cuba')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (114, N'Albania')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (115, N'Nigeria')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (116, N'Zambia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (117, N'Mozambique')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (118, N'Angola')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (119, N'Sri Lanka')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (120, N'Etiopia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (121, N'Tunez')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (122, N'Bolivia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (123, N'Panama')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (124, N'Malawi')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (125, N'Liechtenstein')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (126, N'Bahrein')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (127, N'Barbados')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (128, N'Chad')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (129, N'Man, Isla de')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (130, N'Jamaica')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (131, N'Mali')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (132, N'Madagascar')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (133, N'Senegal')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (134, N'Togo')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (135, N'Honduras')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (136, N'Republica Dominicana')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (137, N'Mongolia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (138, N'Irak')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (139, N'Sudafrica')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (140, N'Aruba')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (141, N'Gibraltar')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (142, N'Afganistan')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (143, N'Andorra')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (144, N'Antigua y Barbuda')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (145, N'Bangladesh')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (146, N'Benin')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (147, N'Butan')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (148, N'Islas Virgenes Britanicas')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (149, N'Brunei')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (150, N'Burkina Faso')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (151, N'Burundi')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (152, N'Camboya')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (153, N'Cabo Verde')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (154, N'Comores')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (155, N'Congo (Kinshasa)')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (156, N'Cook, Islas')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (157, N'Costa de Marfil')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (158, N'Djibouti, Yibuti')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (159, N'Timor Oriental')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (160, N'Guinea Ecuatorial')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (161, N'Eritrea')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (162, N'Feroe, Islas')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (163, N'Fiyi')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (164, N'Polinesia Francesa')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (165, N'Gabon')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (166, N'Gambia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (167, N'Granada')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (168, N'Guatemala')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (169, N'Guernsey')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (170, N'Guinea')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (171, N'Guinea-Bissau')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (172, N'Guyana')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (173, N'Jersey')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (174, N'Kiribati')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (175, N'Laos')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (176, N'Lesotho')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (177, N'Liberia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (178, N'Maldivas')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (179, N'Martinica')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (180, N'Mauricio')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (181, N'Myanmar')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (182, N'Nauru')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (183, N'Antillas Holandesas')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (184, N'Nueva Caledonia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (185, N'Nicaragua')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (186, N'Niger')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (187, N'Norfolk Island')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (188, N'Oman')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (189, N'Isla Pitcairn')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (190, N'Qatar')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (191, N'Ruanda')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (192, N'Santa Elena')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (193, N'San Cristobal y Nevis')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (194, N'Santa Lucia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (195, N'San Pedro y Miquelon')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (196, N'San Vincente y Granadinas')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (197, N'Samoa')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (198, N'San Marino')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (199, N'San Tome y Principe')");
            
Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (200, N'Serbia y Montenegro')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (201, N'Sierra Leona')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (202, N'Islas Salomon')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (203, N'Somalia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (204, N'Sudan')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (205, N'Swazilandia')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (206, N'Tokelau')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (207, N'Tonga')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (208, N'Trinidad y Tobago')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (209, N'Tuvalu')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (210, N'Vanuatu')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (211, N'Wallis y Futuna')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (212, N'Sahara Occidental')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (213, N'Yemen')");
            Sql("INSERT [Sist].[Paises] ([Id], [pais]) VALUES (214, N'Puerto Rico')");
        }
        
        public override void Down()
        {
        }
    }
}
