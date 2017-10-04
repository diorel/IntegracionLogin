namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCatalogosMenores : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT [Sist].[Generos] ([Id], [genero]) VALUES (1, 'Masculino')");
            Sql("INSERT [Sist].[Generos] ([Id], [genero]) VALUES (2, 'Femenino')");
            Sql("INSERT [Sist].[Generos] ([Id], [genero]) VALUES (3, 'Indistinto')");

            Sql("INSERT [Sist].[EstadosCiviles] ([Id], [estadoCivil]) VALUES (1, N'Soltero/a')");
            Sql("INSERT [Sist].[EstadosCiviles] ([Id], [estadoCivil]) VALUES (2, N'Comprometido/a')");
            Sql("INSERT [Sist].[EstadosCiviles] ([Id], [estadoCivil]) VALUES (3, N'Casado/a')");
            Sql("INSERT [Sist].[EstadosCiviles] ([Id], [estadoCivil]) VALUES (4, N'Divorciado/a')");
            Sql("INSERT [Sist].[EstadosCiviles] ([Id], [estadoCivil]) VALUES (5, N'Viudo/a')");
            Sql("INSERT [Sist].[EstadosCiviles] ([Id], [estadoCivil]) VALUES (6, N'Indistinto')");
            Sql("INSERT [Sist].[EstadosCiviles] ([Id], [estadoCivil]) VALUES (7, N'No Aplica')");


        }

        public override void Down()
        {
        }
    }
}
