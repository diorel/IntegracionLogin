using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class PalabraInconveniente
    {
        public int Id { get; set; }
        public string Palabra { get; set; }
        public string Sustituto { get; set; }
    }
}