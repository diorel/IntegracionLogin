using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration;

namespace BolsaDeTrabajo.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region "DbSets"
            public DbSet<Pais> Paises { get; set; }
            public DbSet<Estado> Estados { get; set; }
            public DbSet<Municipio> Municipios { get; set; }
            public DbSet<Direccion> Direcciones { get; set; }
            public DbSet<Telefono> Telefonos { get; set; }
            public DbSet<TipoTelefono> TiposTelefonos { get; set; }
            public DbSet<Email> Emails { get; set; } 
            public DbSet<Genero> Generos { get; set; }
            public DbSet<EstadoCivil> EstadosCiviles { get; set; }
            public DbSet<Persona> Personas { get; set; }
            public DbSet<Candidato> Candidatos { get; set; }
            public DbSet<Cargo> Cargos { get; set; }
            public DbSet<Area> Areas { get; set; }
            public DbSet<Porcentage> Porcentages { get; set; }
            public DbSet<Idioma> Idiomas { get; set; }
            public DbSet<GiroEmpresa>  GirosEmpresa { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Year> Years { get; set; }
            public DbSet<ExperienciaProfesional> ExperienciasProfesionales { get; set; }
        public DbSet<EstadoEstudio> EstadoEstudios { get; set; }
        public DbSet<Formacion> Formaciones { get; set; }
        public DbSet<GradoEstudio> GradosEstudio { get; set; }
        public DbSet<PerfilIdioma> PerfilesIdiomas { get; set; }
            public DbSet<PerfilProfesional> PerfilesProfesionales { get; set; }
            public DbSet<ConocimientoInformatico> ConocimientosInformaticos { get; set; }
            public DbSet<CandidatoConocimientoInformatico> CandidatoCI { get; set; }
            public DbSet<Colonia> Colonias { get; set; }
            public DbSet<TipoLicencia> TiposLicencias { get; set; }
            public DbSet<TipoDiscapacidad> TiposDiscapacidades { get; set; }
            public DbSet<DireccionTipo> TipoDireccion { get; set; }
            public DbSet <FormaContacto> FormasContacto { get; set; }
            public DbSet <PalabraInconveniente> PalabrasInconvenientes { get; set; }
            public DbSet <PalabraExcluida> PalabrasExcluidas { get; set; }
            public DbSet <NombreComun> NombresComunes { get; set; }
            public DbSet <Nivel> Niveles { get; set; }
            public DbSet <InstitucionEducativa> InstitucionesEducativas { get; set; }
            public DbSet <DocumentoValidador> DocumentosValidadores { get; set; }
            public DbSet <Carrera> Carreras { get; set; }
            public DbSet <PerfilCandidato> PerfilCandidato { get; set; }
            public DbSet <AboutMe> AcercaDeMi { get; set; }
            public DbSet <AreaExperiencia> AreasExperiencia { get; set; }
            public DbSet <AreaInteres> AreasInteres { get; set; }
            public DbSet <PerfilExperiencia> PerfilExperiencia { get; set; }
            public DbSet <Curso> Cursos { get; set; }
            public DbSet <ConocimientoOHabilidad> Conocimientos { get; set; }

        #endregion
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure default schema
            #region "ModelBuilder"
            modelBuilder.HasDefaultSchema("Sist");
            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
            modelBuilder.Entity<Pais>().ToTable("Sist.Paises");
            modelBuilder.Entity<Estado>().ToTable("Sist.Estados"); 
            modelBuilder.Entity<Genero>().ToTable("Sist.Generos");
            modelBuilder.Entity<EstadoCivil>().ToTable("Sist.EstadosCiviles");
            modelBuilder.Entity<Telefono>().ToTable("Telefonos");
            modelBuilder.Entity<Direccion>().ToTable("Direcciones");

            modelBuilder.Entity<Cargo>().ToTable("Cargos");
            modelBuilder.Entity<GradoEstudio>().ToTable("GradosEstudio");
            modelBuilder.Entity<GiroEmpresa>().ToTable("GirosEmpresas");
            modelBuilder.Entity<ExperienciaProfesional>().ToTable("ExperienciasProfesionales");
            modelBuilder.Entity<PerfilProfesional>().ToTable("PerfilesProfesionales");
            modelBuilder.Entity<EstadoEstudio>().ToTable("EstadosEstudios");
            modelBuilder.Entity<Formacion>().ToTable("Formaciones");
            modelBuilder.Entity<ConocimientoInformatico>().ToTable("ConocimientosInformaticos");
            modelBuilder.Entity<CandidatoConocimientoInformatico>().ToTable("CandidatoConocimientoInformatico");
            modelBuilder.Entity<TipoLicencia>().ToTable("TiposLicencias");
            modelBuilder.Entity<TipoDiscapacidad>().ToTable("TiposDiscapacidades");
            modelBuilder.Entity<TipoTelefono>().ToTable("TiposTelefonos");

            modelBuilder.Entity<FormaContacto>().ToTable("FormasContacto");
            modelBuilder.Entity<PalabraInconveniente>().ToTable("PalabrasInconvenientes");
            modelBuilder.Entity<PalabraExcluida>().ToTable("PalabrasExcluidas");
            modelBuilder.Entity<NombreComun>().ToTable("NombresComunes");
            modelBuilder.Entity<Nivel>().ToTable("Niveles");
            modelBuilder.Entity<InstitucionEducativa>().ToTable("InstitucionesEducativas");
            modelBuilder.Entity<DocumentoValidador>().ToTable("DocumentosValidadores");
            modelBuilder.Entity<Carrera>().ToTable("Carreras");
            modelBuilder.Entity<PerfilCandidato>().ToTable("PerfilCandidato");
            modelBuilder.Entity<AboutMe>().ToTable("AcercaDeMi");
            modelBuilder.Entity<AreaExperiencia>().ToTable("AreasExperiencia");
            modelBuilder.Entity<AreaInteres>().ToTable("AreasInteres");
            modelBuilder.Entity<PerfilExperiencia>().ToTable("PerfilExperiencia");
            modelBuilder.Entity<Curso>().ToTable("Cursos");
            modelBuilder.Entity<ConocimientoOHabilidad>().ToTable("ConocimientosHabilidades");
            #endregion
            //modelBuilder.Entity<Telefono>()
            //    .HasRequired(t => t.TipoTelefono)
            //    .WithRequiredDependent()
            //.Map(m => m.MapKey("TipoTelefonoId")); ;


            modelBuilder.Configurations.Add(new PersonaMap());

            modelBuilder.Configurations.Add(new CandidatoMap());

        }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

    public class PersonaMap : EntityTypeConfiguration<Persona>
    {
        public PersonaMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Nombre);
            Property(x => x.ApellidoPaterno);
            Property(x => x.ApellidoMaterno);
            Property(x => x.FechaNacimiento);

        }
    }

    public class CandidatoMap : EntityTypeConfiguration<Candidato>
    {
        public CandidatoMap()
        {
            ToTable("Candidatos");
            Property(x => x.PaisNacimientoId);
            Property(x => x.EstadoNacimientoId);
            Property(x => x.MunicipioNacimientoId);

        }
    }
}