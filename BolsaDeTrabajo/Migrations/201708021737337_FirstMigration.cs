namespace BolsaDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sist.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.CandidatoConocimientoInformatico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConocimientoInformaticoId = c.Int(nullable: false),
                        PorcentageId = c.Int(nullable: false),
                        CandidatoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.ConocimientosInformaticos", t => t.ConocimientoInformaticoId, cascadeDelete: true)
                .ForeignKey("Sist.Porcentages", t => t.PorcentageId, cascadeDelete: true)
                .Index(t => t.ConocimientoInformaticoId)
                .Index(t => t.PorcentageId);
            
            CreateTable(
                "Sist.ConocimientosInformaticos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.Porcentages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        porcentage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.Personas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        ApellidoPaterno = c.String(nullable: false, maxLength: 20),
                        ApellidoMaterno = c.String(maxLength: 20),
                        FechaNacimiento = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.Estados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        estado = c.String(maxLength: 50),
                        PaisId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.Paises", t => t.PaisId, cascadeDelete: true)
                .Index(t => t.PaisId);
            
            CreateTable(
                "Sist.Paises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        pais = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.EstadosCiviles",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        estadoCivil = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.Generos",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        genero = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.Municipios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        municipio = c.String(),
                        EstadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.Estados", t => t.EstadoId, cascadeDelete: true)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "Sist.Cargos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.Direcciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DirecciónTipoId = c.Int(nullable: false),
                        PersonaFisicaMoralId = c.Int(nullable: false),
                        esMoral = c.Boolean(nullable: false),
                        Calle = c.String(maxLength: 100),
                        NumeroInterior = c.String(maxLength: 10),
                        NumeroExterior = c.String(maxLength: 10),
                        PaisId = c.Int(nullable: false),
                        EstadoId = c.Int(nullable: false),
                        MunicipioId = c.Int(nullable: false),
                        Colonia = c.String(maxLength: 255),
                        CP = c.String(maxLength: 15),
                        esPrincipal = c.Boolean(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        DireccionTipo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.DireccionTipo", t => t.DireccionTipo_Id)
                .ForeignKey("Sist.Estados", t => t.EstadoId, cascadeDelete: false)
                .ForeignKey("Sist.Municipios", t => t.MunicipioId, cascadeDelete: false)
                .ForeignKey("Sist.Paises", t => t.PaisId, cascadeDelete: false)
                .Index(t => t.PaisId)
                .Index(t => t.EstadoId)
                .Index(t => t.MunicipioId)
                .Index(t => t.DireccionTipo_Id);
            
            CreateTable(
                "Sist.DireccionTipo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DireccionTipos = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.DireccionTipos, unique: true, name: "IX_Unique_TipoDireccion");
            
            CreateTable(
                "Sist.Emails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        email = c.String(nullable: false),
                        PersonaFisicaMoralId = c.Int(nullable: false),
                        esPrincipal = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.EstadosEstudios",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        EstadoEstuio = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.ExperienciasProfesionales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreEmpresa = c.String(),
                        GiroEmpresaId = c.Int(nullable: false),
                        CargoAsignado = c.String(),
                        AreaId = c.Int(nullable: false),
                        PeriodoInicio = c.String(),
                        PeriodoFin = c.String(),
                        Sueldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descripcion = c.String(),
                        CandidatoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("Sist.GirosEmpresas", t => t.GiroEmpresaId, cascadeDelete: true)
                .Index(t => t.GiroEmpresaId)
                .Index(t => t.AreaId);
            
            CreateTable(
                "Sist.GirosEmpresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        giroEmpresa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.Formaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Institucion = c.String(nullable: false),
                        GradoEstudiosId = c.Byte(nullable: false),
                        EstadoEstudioId = c.Byte(nullable: false),
                        Especialidad = c.String(nullable: false),
                        PeriodoInicio = c.String(),
                        PeriodoTermino = c.String(),
                        CandidatoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.EstadosEstudios", t => t.EstadoEstudioId, cascadeDelete: true)
                .ForeignKey("Sist.GradosEstudios", t => t.GradoEstudiosId, cascadeDelete: true)
                .Index(t => t.GradoEstudiosId)
                .Index(t => t.EstadoEstudioId);
            
            CreateTable(
                "Sist.GradosEstudios",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        GradoEstudio = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.Idiomas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        idioma = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.Months",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.PerfilIdiomas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdiomaId = c.Int(nullable: false),
                        PorcentageId = c.Byte(nullable: false),
                        CandidatoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.Idiomas", t => t.IdiomaId, cascadeDelete: true)
                .Index(t => t.IdiomaId);
            
            CreateTable(
                "Sist.PerfilesProfesionales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CargoId = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                        Descripcion = c.String(),
                        PuestoDeseado = c.String(),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CandidatoId = c.Int(nullable: false),
                        SitioWeb = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("Sist.Cargos", t => t.CargoId, cascadeDelete: true)
                .Index(t => t.CargoId)
                .Index(t => t.AreaId);
            
            //CreateTable(
            //    "Sist.IdentityRoles",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Name = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Sist.IdentityUserRoles",
            //    c => new
            //        {
            //            RoleId = c.String(nullable: false, maxLength: 128),
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            IdentityRole_Id = c.String(maxLength: 128),
            //            ApplicationUser_Id = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.RoleId, t.UserId })
            //    .ForeignKey("Sist.IdentityRoles", t => t.IdentityRole_Id)
            //    .ForeignKey("Sist.ApplicationUsers", t => t.ApplicationUser_Id)
            //    .Index(t => t.IdentityRole_Id)
            //    .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "Sist.Telefonos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClavePais = c.String(maxLength: 5),
                        telefono = c.String(nullable: false),
                        TipoTelefonoId = c.Byte(nullable: false),
                        PersonaFisicaMoralId = c.Int(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        esPrincipal = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.TipoTelefonos", t => t.TipoTelefonoId, cascadeDelete: true)
                .Index(t => t.TipoTelefonoId);
            
            CreateTable(
                "Sist.TipoTelefonos",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Sist.ApplicationUsers",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Email = c.String(),
            //            EmailConfirmed = c.Boolean(nullable: false),
            //            PasswordHash = c.String(),
            //            SecurityStamp = c.String(),
            //            PhoneNumber = c.String(),
            //            PhoneNumberConfirmed = c.Boolean(nullable: false),
            //            TwoFactorEnabled = c.Boolean(nullable: false),
            //            LockoutEndDateUtc = c.DateTime(),
            //            LockoutEnabled = c.Boolean(nullable: false),
            //            AccessFailedCount = c.Int(nullable: false),
            //            UserName = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Sist.IdentityUserClaims",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserId = c.String(),
            //            ClaimType = c.String(),
            //            ClaimValue = c.String(),
            //            ApplicationUser_Id = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Sist.ApplicationUsers", t => t.ApplicationUser_Id)
            //    .Index(t => t.ApplicationUser_Id);
            
            //CreateTable(
            //    "Sist.IdentityUserLogins",
            //    c => new
            //        {
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            LoginProvider = c.String(),
            //            ProviderKey = c.String(),
            //            ApplicationUser_Id = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.UserId)
            //    .ForeignKey("Sist.ApplicationUsers", t => t.ApplicationUser_Id)
            //    .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "Sist.Years",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sist.Candidatos",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PaisId = c.Int(nullable: false),
                        EstadoId = c.Int(nullable: false),
                        MunicipioId = c.Int(nullable: false),
                        GeneroId = c.Byte(nullable: false),
                        EstadoCivilId = c.Byte(nullable: false),
                        esDiscapacitado = c.Boolean(nullable: false),
                        puedeViajar = c.Boolean(nullable: false),
                        puedeReubicarse = c.Boolean(nullable: false),
                        tieneLicenciaConducir = c.Boolean(nullable: false),
                        tipoLicenciaConducir = c.String(),
                        tieneVehiculoPropio = c.Boolean(nullable: false),
                        CURP = c.String(),
                        RFC = c.String(),
                        NSS = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sist.Personas", t => t.Id)
                .ForeignKey("Sist.Paises", t => t.PaisId, cascadeDelete: false)
                .ForeignKey("Sist.Estados", t => t.EstadoId, cascadeDelete: false)
                .ForeignKey("Sist.Municipios", t => t.MunicipioId, cascadeDelete: false)
                .ForeignKey("Sist.Generos", t => t.GeneroId, cascadeDelete: true)
                .ForeignKey("Sist.EstadosCiviles", t => t.EstadoCivilId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.PaisId)
                .Index(t => t.EstadoId)
                .Index(t => t.MunicipioId)
                .Index(t => t.GeneroId)
                .Index(t => t.EstadoCivilId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Sist.Candidatos", "EstadoCivilId", "Sist.EstadosCiviles");
            DropForeignKey("Sist.Candidatos", "GeneroId", "Sist.Generos");
            DropForeignKey("Sist.Candidatos", "MunicipioId", "Sist.Municipios");
            DropForeignKey("Sist.Candidatos", "EstadoId", "Sist.Estados");
            DropForeignKey("Sist.Candidatos", "PaisId", "Sist.Paises");
            DropForeignKey("Sist.Candidatos", "Id", "Sist.Personas");
            DropForeignKey("Sist.IdentityUserRoles", "ApplicationUser_Id", "Sist.ApplicationUsers");
            DropForeignKey("Sist.IdentityUserLogins", "ApplicationUser_Id", "Sist.ApplicationUsers");
            DropForeignKey("Sist.IdentityUserClaims", "ApplicationUser_Id", "Sist.ApplicationUsers");
            DropForeignKey("Sist.Telefonos", "TipoTelefonoId", "Sist.TipoTelefonoes");
            DropForeignKey("Sist.IdentityUserRoles", "IdentityRole_Id", "Sist.IdentityRoles");
            DropForeignKey("Sist.PerfilesProfesionales", "CargoId", "Sist.Cargos");
            DropForeignKey("Sist.PerfilesProfesionales", "AreaId", "Sist.Areas");
            DropForeignKey("Sist.PerfilIdiomas", "IdiomaId", "Sist.Idiomas");
            DropForeignKey("Sist.Formaciones", "GradoEstudiosId", "Sist.GradosEstudios");
            DropForeignKey("Sist.Formaciones", "EstadoEstudioId", "Sist.EstadosEstudios");
            DropForeignKey("Sist.ExperienciasProfesionales", "GiroEmpresaId", "Sist.GirosEmpresas");
            DropForeignKey("Sist.ExperienciasProfesionales", "AreaId", "Sist.Areas");
            DropForeignKey("Sist.Direcciones", "PaisId", "Sist.Paises");
            DropForeignKey("Sist.Direcciones", "MunicipioId", "Sist.Municipios");
            DropForeignKey("Sist.Direcciones", "EstadoId", "Sist.Estados");
            DropForeignKey("Sist.Direcciones", "DireccionTipo_Id", "sist.DireccionTipo");
            DropForeignKey("Sist.Municipios", "EstadoId", "Sist.Estados");
            DropForeignKey("Sist.Estados", "PaisId", "Sist.Paises");
            DropForeignKey("Sist.CandidatoConocimientoInformatico", "PorcentageId", "Sist.Porcentages");
            DropForeignKey("Sist.CandidatoConocimientoInformatico", "ConocimientoInformaticoId", "Sist.ConocimientosInformaticos");
            DropIndex("Sist.Candidatos", new[] { "EstadoCivilId" });
            DropIndex("Sist.Candidatos", new[] { "GeneroId" });
            DropIndex("Sist.Candidatos", new[] { "MunicipioId" });
            DropIndex("Sist.Candidatos", new[] { "EstadoId" });
            DropIndex("Sist.Candidatos", new[] { "PaisId" });
            DropIndex("Sist.Candidatos", new[] { "Id" });
            DropIndex("Sist.IdentityUserLogins", new[] { "ApplicationUser_Id" });
            DropIndex("Sist.IdentityUserClaims", new[] { "ApplicationUser_Id" });
            DropIndex("Sist.Telefonos", new[] { "TipoTelefonoId" });
            DropIndex("Sist.IdentityUserRoles", new[] { "ApplicationUser_Id" });
            DropIndex("Sist.IdentityUserRoles", new[] { "IdentityRole_Id" });
            DropIndex("Sist.PerfilesProfesionales", new[] { "AreaId" });
            DropIndex("Sist.PerfilesProfesionales", new[] { "CargoId" });
            DropIndex("Sist.PerfilIdiomas", new[] { "IdiomaId" });
            DropIndex("Sist.Formaciones", new[] { "EstadoEstudioId" });
            DropIndex("Sist.Formaciones", new[] { "GradoEstudiosId" });
            DropIndex("Sist.ExperienciasProfesionales", new[] { "AreaId" });
            DropIndex("Sist.ExperienciasProfesionales", new[] { "GiroEmpresaId" });
            DropIndex("sist.DireccionTipo", "IX_Unique_TipoDireccion");
            DropIndex("Sist.Direcciones", new[] { "DireccionTipo_Id" });
            DropIndex("Sist.Direcciones", new[] { "MunicipioId" });
            DropIndex("Sist.Direcciones", new[] { "EstadoId" });
            DropIndex("Sist.Direcciones", new[] { "PaisId" });
            DropIndex("Sist.Municipios", new[] { "EstadoId" });
            DropIndex("Sist.Estados", new[] { "PaisId" });
            DropIndex("Sist.CandidatoConocimientoInformatico", new[] { "PorcentageId" });
            DropIndex("Sist.CandidatoConocimientoInformatico", new[] { "ConocimientoInformaticoId" });
            DropTable("Sist.Candidatos");
            DropTable("Sist.Years");
            DropTable("Sist.IdentityUserLogins");
            DropTable("Sist.IdentityUserClaims");
            DropTable("Sist.ApplicationUsers");
            DropTable("Sist.TipoTelefonoes");
            DropTable("Sist.Telefonos");
            DropTable("Sist.IdentityUserRoles");
            DropTable("Sist.IdentityRoles");
            DropTable("Sist.PerfilesProfesionales");
            DropTable("Sist.PerfilIdiomas");
            DropTable("Sist.Months");
            DropTable("Sist.Idiomas");
            DropTable("Sist.GradosEstudios");
            DropTable("Sist.Formaciones");
            DropTable("Sist.GirosEmpresas");
            DropTable("Sist.ExperienciasProfesionales");
            DropTable("Sist.EstadosEstudios");
            DropTable("Sist.Emails");
            DropTable("sist.DireccionTipo");
            DropTable("Sist.Direcciones");
            DropTable("Sist.Cargos");
            DropTable("Sist.Municipios");
            DropTable("Sist.Generos");
            DropTable("Sist.EstadosCiviles");
            DropTable("Sist.Paises");
            DropTable("Sist.Estados");
            DropTable("Sist.Personas");
            DropTable("Sist.Porcentages");
            DropTable("Sist.ConocimientosInformaticos");
            DropTable("Sist.CandidatoConocimientoInformatico");
            DropTable("Sist.Areas");
        }
    }
}
