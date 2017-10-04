using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class PerfilCandidato
    {
        public int Id { get; set; }
        public int CandidatoId { get; set; }
        public virtual Candidato Candidato { get; set; }
        public virtual ICollection <PerfilIdioma> Idiomas { get; set; }
        public virtual ICollection<Formacion> Formaciones { get; set; }

        public PerfilCandidato()
        {
            Idiomas = new List<PerfilIdioma>();
            Formaciones = new List<Formacion>();
        }
    }
}