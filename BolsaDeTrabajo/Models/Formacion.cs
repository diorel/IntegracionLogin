using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class Formacion
    {
       
        public Formacion()
        {
            
        }

        public int Id { get; set; }
        //public int CandidatoId { get; set; }
        public int InstitucionEducativaId { get; set; }
        public virtual InstitucionEducativa InstitucionEducativa { get; set; }
        public int GradoEstudiosId { get; set; }
        public GradoEstudio GradosEstudio { get; set; }
        public int EstadoEstudioId { get; set; }
        public EstadoEstudio EstadoEstudio { get; set; }
        public int DocumentoValidadorId { get; set; }
        public DocumentoValidador DocumentoValidador { get; set; }
        public int CarreraId { get; set; }
        public virtual Carrera Carrera { get; set; }

        public int YearInicioId { get; set; }
        public Year YearInicio { get; set; }
        public int MonthInicioId { get; set; }
        public Month MonthInicio { get; set; }

        public int YearTerminoId { get; set; }
        public Year YearTermino { get; set; }
        public int MonthTerminoId { get; set; }
        public Month MonthTermino { get; set; }

        public int PerfilCandidatoId { get; set; }
        public PerfilCandidato PerfilCandidato { get; set; }

    }
}