using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BolsaDeTrabajo.Models;

namespace PortalERP.Models
{
    [Table("Clientes", Schema = "sist")]
    public class ClientesModel 
    {
        public ClientesModel()
        {

        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [MaxLength(50)]
        public string RazonSocial { get; set; }

        [Required]
        [StringLength(100)]
        [MaxLength(100)]
        public string NombreComercial { get; set; }

        [Required]
        [StringLength(15)]
        [MaxLength(15)]
        [Index("IX_UNIQUE_ClienteRFC", IsUnique = true)]
        public string RFC { get; set; }

        public int GiroEmpresaId { get; set; }
        [ForeignKey("GiroEmpresaId")]
        public virtual GiroEmpresa GirosEmpresa { get; set; }

        public int TamanoEmpresaId { get; set; }
        [ForeignKey("TamanoEmpresaId")]
        public virtual TamanoEmpresaModel TamanosEmpresa { get; set; }
                
        public int TipoEmpresaId { get; set; }
        [ForeignKey("TipoEmpresaId")]
        public virtual TipoEmpresaModel TiposEmpresa { get; set; }

        public int? IdPersonaFisicaMoral { get; set; }

        [Required]
        [DefaultValue(0)]
        public bool esMoral { get; set; }
    }
}