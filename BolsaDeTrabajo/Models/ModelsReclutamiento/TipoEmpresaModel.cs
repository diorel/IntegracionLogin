using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalERP.Models
{
    [Table("TipoEmpresa", Schema = "sist")]
    public class TipoEmpresaModel
    {
        public TipoEmpresaModel()
        {

        }
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [MaxLength(20)]
        [Index("IX_Unique_TipoEmpresa", IsUnique = true)]
        public string TipoEmpresa { get; set; }
    }
}