using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class PerfilProfesional
    {
        public int Id { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public int AreaId { get; set; }
        public Area Area { get; set; }
        public string Descripcion { get; set; }
        public string PuestoDeseado { get; set; }
        public Decimal Salario { get; set; }

        public int CandidatoId { get; set; }
        public string SitioWeb { get; set; }

        public PerfilProfesional(int IdCandidato)
        {
            CandidatoId = IdCandidato;
        }
        public PerfilProfesional()
        {

        }

    }
}