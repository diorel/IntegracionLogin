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
        public ICollection<AboutMe> AboutMe { get; set; }
        public ICollection<Curso> Cursos { get; set; }
        public ICollection<ConocimientoOHabilidad> Conocimientos { get; set; }
        public virtual ICollection <PerfilIdioma> Idiomas { get; set; }
        public virtual ICollection<Formacion> Formaciones { get; set; }
        public virtual ICollection<ExperienciaProfesional> Experiencias { get; set; }

        public PerfilCandidato()
        {
            AboutMe = new List<AboutMe>();
            Idiomas = new List<PerfilIdioma>();
            Formaciones = new List<Formacion>();
            Cursos = new List<Curso>();
            Conocimientos = new List<ConocimientoOHabilidad>();
            Experiencias = new List<ExperienciaProfesional>();
        }
    }
}