namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangueNameTableTipoTelefonos : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "Sist.TipoTelefonos", newName: "TiposTelefonos");
            Sql("INSERT [Sist].[TiposTelefonos] ([Id], [Tipo]) VALUES (1, N'Movil/Celular')");
            Sql("INSERT [Sist].[TiposTelefonos] ([Id], [Tipo]) VALUES (2, N'Casa')");
            Sql("INSERT [Sist].[TiposTelefonos] ([Id], [Tipo]) VALUES (3, N'Oficina')");
        }
        
        public override void Down()
        {
        }
    }
}
