using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BolsaDeTrabajo.Models
{
    public class FormaContacto
    {
        public int Id { get; set; }
        public int CandidatoId { get; set; }
        public Candidato candidato { get; set; }
        public Boolean CorreoElectronico { get; set; }
        public Boolean Celular { get; set; }
        public Boolean WhatsApp { get; set; }
        public Boolean TelLocal { get; set; }

        public FormaContacto()
        {

        }

        public FormaContacto(int candidatoId, bool correo, bool celular, bool whatsapp, bool telLocal )
        {
            CandidatoId = candidatoId;
            CorreoElectronico = correo;
            Celular = celular;
            WhatsApp = whatsapp;
            TelLocal = telLocal;
        }
    }

}