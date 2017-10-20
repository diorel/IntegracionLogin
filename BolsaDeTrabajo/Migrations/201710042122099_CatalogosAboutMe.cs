namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatalogosAboutMe : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Administración / Oficina')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Almacén / Logística / Transporte')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Atención a clientes')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('CallCenter / Telemercadeo')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Compras / Comercio Exterior')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Construcción y obra')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Contabilidad / Finanzas')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Dirección / Gerencia')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Diseño / Artes gráficas')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Docencia')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Hostelería / Turismo')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Informática / Telecomunicaciones')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Ingeniería')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Investigación y Calidad')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Legal / Asesoría')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Mantenimiento y Reparaciones Técnicas')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Medicina / Salud')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Mercadotecnia / Publicidad / Comunicación')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Producción / Operarios / Manufactura')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Recursos Humanos')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Servicios Generales, Aseo y Seguridad')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Ventas')");
            Sql("INSERT INTO [Sist].[AreasExperiencia] VALUES ('Otro:')");

            Sql("INSERT INTO [Sist].[PerfilExperiencia] VALUES ('Persona sin experiencia')");
            Sql("INSERT INTO [Sist].[PerfilExperiencia] VALUES ('Estudiante')");
            Sql("INSERT INTO [Sist].[PerfilExperiencia] VALUES ('Becario o practicante')");
            Sql("INSERT INTO [Sist].[PerfilExperiencia] VALUES ('Operativo')");
            Sql("INSERT INTO [Sist].[PerfilExperiencia] VALUES ('Técnico')");
            Sql("INSERT INTO [Sist].[PerfilExperiencia] VALUES ('Profesionista')");

            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Administrativos')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Biología')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Comunicaciones')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Construcción')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Contabilidad')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Creatividad, Producción y Diseño Comercial')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Derecho y Leyes')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Educación')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Ingeniería')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Logística, Transportación y Distribución')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Manufactura, Producción y Operación')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Mercadotecnia, Publicidad y Relaciones Públicas.')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Recursos Humanos')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Salud y Belleza')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Sector Salud')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Seguro y Reaseguro')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Tecnologías de la Información / Sistemas')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Turismo, Hospitalidad y Gastronomía')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Ventas')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Veterinaria / Zoología')");
            Sql("INSERT INTO [Sist].[AreasInteres] VALUES ('Otro')");

        }

        public override void Down()
        {
        }
    }
}
