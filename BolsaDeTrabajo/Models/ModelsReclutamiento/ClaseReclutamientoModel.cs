using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PortalERP.Models
{
    [Table("ClasesReclutamientos" ,  Schema="sist")]
    public class ClaseReclutamientoModel
    {
        public ClaseReclutamientoModel()
        {

        }

        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        [MaxLength(20)]
        [Required]
        public string Clase { get; set; }
    }
}