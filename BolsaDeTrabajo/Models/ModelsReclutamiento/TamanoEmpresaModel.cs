using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalERP.Models
{
    [Table("TamanoEmpresa", Schema = "sist")]
    public class TamanoEmpresaModel
    {
        public TamanoEmpresaModel()
        {

        }
        public int Id { get; set; }

        [Required()]
        [StringLength(30)]
        [MaxLength(50)]
        public string TamanoEmpresa { get; set; }
    }
}