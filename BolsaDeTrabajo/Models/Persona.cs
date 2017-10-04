using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public abstract class Persona
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }

        [MaxLength(20)]
        [Required]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [MaxLength(20)]
        [DefaultValue("")]
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [DisplayName("Fecha Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

         public virtual ICollection<Direccion> direcciones { get; set; }
         public virtual ICollection<Telefono> telefonos { get; set; }
         public virtual ICollection<Email> emails { get; set; }

        

    }
}