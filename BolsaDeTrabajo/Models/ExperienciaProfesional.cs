using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class ExperienciaProfesional
    {
        public int Id { get; set; }
        [Display(Name = "Empresa")]
        public string NombreEmpresa { get; set; }

        [Display(Name ="Giro")]
        public int GiroEmpresaId { get; set; }
        public GiroEmpresa GiroEmpresa { get; set; }

        [Display(Name ="Cargo Asignado")]
        public string CargoAsignado { get; set; }

        [Display(Name ="Área / Departamento")]
        public int AreaId { get; set; }
        public Area Area { get; set; }

        public string PeriodoInicio { get; set; }
        public string PeriodoFin { get; set; }
        [Display(Name ="ültimo Sueldo")]
        public decimal Sueldo { get; set; }

        [Display(Name ="Funciones y logros del cargo")]
        public string Descripcion { get; set; }

        public int CandidatoId { get; set; }
    }
}