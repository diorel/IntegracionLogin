using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class PerfilIdioma
    {
        public int Id { get; set; }
        public int IdiomaId { get; set; }
        public virtual Idioma Idioma { get; set; }
        public byte NivelId { get; set; }
        public virtual Nivel nivel { get; set; }

        public int PerfilCandidatoId { get; set; }
        public PerfilCandidato PerfilCandidato { get; set; }
    }
}