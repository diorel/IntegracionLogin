using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BolsaDeTrabajo.Models
{
    [Table("DireccionTipo", Schema= "sist")]
    public class DireccionTipo
    {
        public DireccionTipo()
        {

        }
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [MaxLength(30)]
        [Index("IX_Unique_TipoDireccion", IsUnique = true)]
        public string DireccionTipos { get; set; }
    }
}