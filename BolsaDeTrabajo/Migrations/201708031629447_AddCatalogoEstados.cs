namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCatalogoEstados : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT [Sist].[Estados] ON");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (1, 'Aguascalientes', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (2, 'Baja California', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (3, 'Baja California Sur', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (4, 'Campeche', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (5, 'Chiapas', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (6, 'Chihuahua', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (7, 'Coahuila de Zaragoza', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (8, 'Colima', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (9, 'Ciudad de Mexico', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (10, 'Durango', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (11, 'Guanajuato', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (12, 'Guerrero', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (13, 'Hidalgo', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (14, 'Jalisco', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (15, 'Mexico', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (16, 'Michoacan de Ocampo', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (17, 'Morelos', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (18, 'Nayarit', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (19, 'Nuevo Leo', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (20, 'Oaxaca', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (21, 'Puebla', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (22, 'Queretaro', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (23, 'Quintana Roo', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (24, 'San Luis PotosI', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (25, 'Sinaloa', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (26, 'Sonora', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (27, 'Tabasco', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (28, 'Tamaulipas', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (29, 'Tlaxcala', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (30, 'Veracruz', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (31, 'Yucata', 42)");
            Sql("INSERT [Sist].[Estados] ([Id], [estado], [PaisId]) VALUES (32, 'Zacatecas', 42)");
        }
        
        public override void Down()
        {
        }
    }
}
