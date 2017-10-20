namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogosAboutMe : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Administraci�n / Oficina')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Almac�n / Log�stica / Transporte')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Atenci�n a clientes')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('CallCenter / Telemercadeo')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Compras / Comercio Exterior')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Construcci�n y obra')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Contabilidad / Finanzas')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Direcci�n / Gerencia')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Dise�o / Artes gr�ficas')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Docencia')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Hosteler�a / Turismo')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Inform�tica / Telecomunicaciones')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Ingenier�a')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Investigaci�n y Calidad')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Legal / Asesor�a')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Mantenimiento y Reparaciones T�cnicas')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Medicina / Salud')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Mercadotecnia / Publicidad / Comunicaci�n')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Producci�n / Operarios / Manufactura')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Recursos Humanos')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Servicios Generales, Aseo y Seguridad')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Ventas')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Otro:')");

            Sql("INSERT INTO [Sist].[PerfilExperiencia] VALUES ('Persona sin experiencia')");
            Sql("INSERT INTO [Sist].[PerfilExperiencia] VALUES ('Estudiante')");
            Sql("INSERT INTO [Sist].[PerfilExperiencia] VALUES ('Becario o practicante')");
            Sql("INSERT INTO [Sist].[PerfilExperiencia] VALUES ('Operativo')");
            Sql("INSERT INTO [Sist].[PerfilExperiencia] VALUES ('T�cnico')");
            Sql("INSERT INTO [Sist].[PerfilExperiencia] VALUES ('Profesionista')");

            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Administrativos')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Biolog�a')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Comunicaciones')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Construcci�n')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Contabilidad')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Creatividad, Producci�n y Dise�o Comercial')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Derecho y Leyes')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Educaci�n')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Ingenier�a')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Log�stica, Transportaci�n y Distribuci�n')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Manufactura, Producci�n y Operaci�n')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Mercadotecnia, Publicidad y Relaciones P�blicas.')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Recursos Humanos')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Salud y Belleza')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Sector Salud')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Seguro y Reaseguro')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Tecnolog�as de la Informaci�n / Sistemas')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Turismo, Hospitalidad y Gastronom�a')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Ventas')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Veterinaria / Zoolog�a')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Otro')");

        }

        public override void Down()
        {
        }
    }
}
