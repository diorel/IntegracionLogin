using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class AboutMe
    {
        public int Id { get; set; }
        public string AcercaDeMi { get; set; }
        public string PuestoDeseado { get; set; }
        public decimal SalarioAceptable { get; set; }
        public decimal SalarioDeseado { get; set; }
        public int AreaExperienciaId { get; set; }
        public virtual AreaExperiencia AreaExperiencia { get; set; }
        public int AreaInteresId { get; set; }
        public virtual AreaInteres AreaInteres { get; set; }
        public int PerfilExperienciaId { get; set; }
        public virtual PerfilExperiencia PerfilExperiencia { get; set; }

        public int PerfilCandidatoId { get; set; }
        public PerfilCandidato PerfilCandidato { get; set; }
    }
}