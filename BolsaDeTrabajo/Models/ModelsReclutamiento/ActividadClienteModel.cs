using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PortalERP.Models
{
    [Table("ActivadadClientes" , Schema = "sist")]
    public class ActividadClienteModel
    {
        public ActividadClienteModel()
        {

        }

        [Key]
        public int Id { get; set; }

        public int GiroEmpresaId { get; set; }

        [StringLength(30)]
        [MaxLength(30)]
        [Required]
        public string Actividad { get; set; }
    }
}