using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class Telefono
    {
        public int Id { get; set; }
        [MaxLength(5)]
        [DefaultValue("")]
        [Display(Name = "Clave País")]
        public string ClavePais { get; set; }

        [Required]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "El campo solo acepta números con longitud de 10 digitos")]
        public string telefono { get; set; }
        public byte TipoTelefonoId { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
      
        [DefaultValue(true)]
        public bool Activo { get; set; }
        public bool esPrincipal { get; set; }

        public int PersonaFisicaMoralId { get; set; }
        public virtual Persona PersonaFisicaMoral { get; set; }

        public Telefono(string clavePais, string telefono, byte tipoTelefono, int idPersona)
        {
            ClavePais = clavePais;
            this.telefono = telefono;
            TipoTelefonoId = tipoTelefono;
            PersonaFisicaMoralId = idPersona;
        }

        public Telefono()
        {

        }
    }
}