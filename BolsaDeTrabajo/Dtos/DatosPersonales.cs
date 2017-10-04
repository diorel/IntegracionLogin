using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Dtos
{
    public class DatosPersonales
    {
        public string telCasa { get; set; }
        public string telCelular { get; set; } 
        public string telOficina { get; set; }

        public Boolean esDiscapacitado { get; set; }
        public Boolean puedeRehubicarse { get; set; }
        public Boolean puedeViajar { get; set; }

        public Boolean CorreoElectronico { get; set; }
        public Boolean Celular { get; set; }
        public Boolean WhatsApp { get; set; }
        public Boolean TelLocal { get; set; }

        public byte EstadoCivilId { get; set; }
        public byte GeneroId { get; set; }
        public int TipoDiscapacidadId { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public int PaisNacimientoId { get; set; } 
        public int EstadoNacimientoId { get; set; } 
        public int MunicipioNacimientoId { get; set; } 

        public PaisDto paisNacimiento { get; set; }
        public EstadoDto estadoNacimiento { get; set; }
        public MunicipioDto municipioNacimiento { get; set; }

        public string CodigoPostal { get; set; }

        public DatosPersonales()
        {
            
        }

       

    }
}