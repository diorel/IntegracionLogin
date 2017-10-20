﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class ExperienciaProfesional
    {
        public int Id { get; set; }
        public string Empresa { get; set; }

      
        public int GiroEmpresaId { get; set; }
        public GiroEmpresa GiroEmpresa { get; set; }

      
        public string CargoAsignado { get; set; }

      
        public int AreaId { get; set; }
        public Area Area { get; set; }

        public int YearInicioId { get; set; }
        public Year YearInicio { get; set; }
        public int MonthInicioId { get; set; }
        public Month MonthInicio { get; set; }

        public int YearTerminoId { get; set; }
        public Year YearTermino { get; set; }
        public int MonthTerminoId { get; set; }
        public Month MonthTermino { get; set; }

        public decimal Salario { get; set; }

        public bool TrabajoActual { get; set; }
        public string Descripcion { get; set; }

        public int PerfilCandidatoId { get; set; }
        public PerfilCandidato PerfilCandidato { get; set; }
    }
}