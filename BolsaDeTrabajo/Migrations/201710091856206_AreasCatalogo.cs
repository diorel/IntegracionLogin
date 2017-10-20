namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AreasCatalogo : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Administraci�n / Oficina')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Almac�n / Log�stica / Transporte')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Atenci�n a clientes')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('CallCenter / Telemercadeo')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Compras / Comercio Exterior')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Construcci�n y obra')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Contabilidad / Finanzas')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Direcci�n / Gerencia')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Dise�o / Artes graficas')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Docencia')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Hosteler�a / Turismo')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Inform�tica / Telecomunicaciones')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Ingenier�a')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Investigaci�n y Calidad')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Legal / Asesor�a')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Mantenimiento y Reparaciones T�cnicas')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Medicina / Salud')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Mercadotecnia / Publicidad / Comunicaci�n')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Producci�n / Operarios / Manufactura')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Recursos Humanos')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Servicios Generales, Aseo y Seguridad')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Ventas')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Otro: ')");
        }
        
        public override void Down()
        {
        }
    }
}
