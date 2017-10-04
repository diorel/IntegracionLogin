using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PortalERP.Models
{
    [Table("HorariosPerfiles", Schema = "sist")]
    public partial class HorarioPerfilModel
    {
        public HorarioPerfilModel()
        {

        }
        public int Id { get; set; }
        public Guid PerfilId { get; set; }
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string DeDia { get; set; }
        public string aDia { get; set; }
        public string deHora { get; set; }
        public string aHora { get; set; }
        public Int16 NumeroVacantes { get; set; }
        public string Especificaciones { get; set; }
        public bool Activo { get; set; }

        public virtual PerfilesReclutamientoModel PerfilReclutamiento { get; set; }
    }
}