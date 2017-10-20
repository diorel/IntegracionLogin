namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AreasCatalogo : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Administración / Oficina')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Almacén / Logística / Transporte')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Atención a clientes')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('CallCenter / Telemercadeo')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Compras / Comercio Exterior')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Construcción y obra')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Contabilidad / Finanzas')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Dirección / Gerencia')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Diseño / Artes graficas')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Docencia')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Hostelería / Turismo')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Informática / Telecomunicaciones')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Ingeniería')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Investigación y Calidad')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Legal / Asesoría')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Mantenimiento y Reparaciones Técnicas')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Medicina / Salud')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Mercadotecnia / Publicidad / Comunicación')");
            Sql("INSERT INTO [Sist].[Areas] VALUES ('Producción / Operarios / Manufactura')");
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
