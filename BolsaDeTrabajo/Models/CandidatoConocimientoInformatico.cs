using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class CandidatoConocimientoInformatico
    {
        public int Id { get; set; }
        [Display(Name ="Conocimiento Informático")]
        public int ConocimientoInformaticoId { get; set; }
        public ConocimientoInformatico ConocimientoInformatico { get; set; }
        [Display(Name ="Nivel")]
        public int PorcentageId { get; set; }
        public Porcentage Porcentage { get; set; }

        public int CandidatoId { get; set; }

    }
    
}
