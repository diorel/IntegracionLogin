using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalERP.Models
{
    [Table("DiasSemana", Schema = "sist")]
    public class DiasSemanaModel
    {
        public DiasSemanaModel()
        {

        }
        [Key]
        public int Id { get; set; }

        [StringLength(9)]
        [MaxLength(9)]
        [Required(AllowEmptyStrings = true , ErrorMessage = "Ingrese el dia de la semana.")]
        public string Dia { get; set; }
    }
}