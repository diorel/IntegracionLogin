using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Dtos
{
    public class DireccionDto
    {
        public int Id { get; set; } 
                 
        public string Calle { get; set; }
        public string NumeroInterior { get; set; }
        public string NumeroExterior { get; set; }
        public int PaisId { get; set; }
        public PaisDto Pais { get; set; }
        public int? EstadoId { get; set; }
        public EstadoDto Estado { get; set; } 
        public int? MunicipioId { get; set; }
        public MunicipioDto Municipio { get; set; }
        public int? ColoniaId { get; set; }
        public ColoniaDto Colonia { get; set; }
        public string CodigoPostal { get; set; }

        public DireccionDto()
        {

        }
    }
}