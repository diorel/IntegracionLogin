using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class ConocimientoOHabilidad
    {
        public int Id { get; set; }
        public string Conocimiento { get; set; }
        public string Herramienta { get; set; }

        public int? InstitucionEducativaId { get; set; }
        public virtual InstitucionEducativa InstitucionEducativa { get; set; }

        public byte? NivelId { get; set; }
        public virtual Nivel nivel { get; set; }

        public int PerfilCandidatoId { get; set; }
        public PerfilCandidato PerfilCandidato { get; set; }
    }
}