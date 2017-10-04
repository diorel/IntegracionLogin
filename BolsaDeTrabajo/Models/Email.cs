using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class Email
    {
        public int Id { get; set; }
        [Display(Name = "Email")]
        [Required]        
        public string email { get; set; }
        public bool esPrincipal { get; set; }
        public int PersonaFisicaMoralId { get; set; }
        public virtual Persona PersonaFisicaMoral { get; set; }

        public Email(string correo, int idPersona)
        {
            email = correo;
            PersonaFisicaMoralId = idPersona;
        }

        public Email()
        {

        }
    }
}