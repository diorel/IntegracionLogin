using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PortalERP.Models
{
    [Table("TiposReclutamientos" , Schema = "sist")]
    public class TipoReclutamientoModel
    {
        public TipoReclutamientoModel()
        {

        }

        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        [MaxLength(20)]
        [Required]
        public string TipoReclutamiento { get; set; }
    }
}