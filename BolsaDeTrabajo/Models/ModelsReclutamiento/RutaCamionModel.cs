using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PortalERP.Models
{
    [Table("RutasCamiones" , Schema = "sist")]
    public class RutaCamionModel
    {
        public RutaCamionModel()
        {

        }

        [Key]
        public int Id { get; set; }

        [StringLength(10)]
        [MaxLength(10)]
        public string Ruta { get; set; }

        [StringLength(100)]
        [MaxLength(100)]
        public string Via { get; set; }

        public int ClienteId { get; set; }
    }
}