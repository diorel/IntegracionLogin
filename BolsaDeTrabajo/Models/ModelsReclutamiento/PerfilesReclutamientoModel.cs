using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PortalERP.Models
{
    [Table("AltasPerfiles" , Schema = "sist")]
    public class PerfilesReclutamientoModel
    {
        public PerfilesReclutamientoModel()
        {
            this.Horas = new HashSet<HorarioPerfilModel>();
        }
        [Key]
        public Guid PerfilesId { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public int giroClienteId { get; set; }
        [Required]
        public int actividadClienteId { get; set; }
        [Required]
        public int tipoReclutamientoId { get; set; }
        [Required]
        public int claseReclutamientoId { get; set; }
        [Required]
        [StringLength(50)]
        [MaxLength(50)]
        public string nombrePerfil { get; set; }
        [Required]
        public int sexoId { get; set; }
        [Required]
        public int edadMinima { get; set; }
        [Required]
        public int edadMaxima { get; set; }
        [Required]
        public int estadoCivilId { get; set; }
        [Required]
        public int areaId { get; set; }
        [StringLength(250)]
        [MaxLength(250)]
        [DefaultValue("")]
        //Cambiar por una coleccion de escolaridades.
        public string escolaridades { get; set; }
        public int nivelEscolarId { get; set; }
        [StringLength(500)]
        [MaxLength(500)]
        [DefaultValue("")]
        //En espera de modificacion para coleccion de aptitudes.
        public string aptitudes { get; set; }
        [StringLength(500)]
        [MaxLength(500)]
        [DefaultValue("")]
        public string experiencia { get; set; }


        public virtual ICollection<HorarioPerfilModel> Horas { get; set; }

    }
}