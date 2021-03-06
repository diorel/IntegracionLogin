﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class Colonia
    {
        public int Id { get; set; }
        public string colonia { get; set; }
        public string CP { get; set; }
        public string TipoColonia { get; set; }
        public int MunicipioId { get; set; }
        public Municipio Municipio { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
    }
}