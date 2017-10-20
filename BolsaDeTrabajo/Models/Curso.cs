using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string curso { get; set; }

        public int InstitucionEducativaId { get; set; }
        public virtual InstitucionEducativa InstitucionEducativa { get; set; }

        public int? YearInicioId { get; set; }
        public Year YearInicio { get; set; }
        public int? MonthInicioId { get; set; }
        public Month MonthInicio { get; set; }

        public int? YearTerminoId { get; set; }
        public Year YearTermino { get; set; }
        public int? MonthTerminoId { get; set; }
        public Month MonthTermino { get; set; }

        public int PerfilCandidatoId { get; set; }
        public PerfilCandidato PerfilCandidato { get; set; }
    }
}