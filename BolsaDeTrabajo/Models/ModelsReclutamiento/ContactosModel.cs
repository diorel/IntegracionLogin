using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PortalERP.Models
{
    [Table("ContactosCliente" , Schema = "sist")]
    public class ContactosModel
    {
        public ContactosModel()
        {

        }

        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [MaxLength(100)]
        [Required(ErrorMessage = "Ingrese el Nombre")]
        public string Nombre { get; set; }

        [StringLength(30)]
        [MaxLength(30)]
        [DefaultValue("")]
        public string ApellidoPaterno { get; set; }

        [StringLength(30)]
        [MaxLength(30)]
        [DefaultValue("")]
        public string ApellidoMaterno { get; set; }

        [StringLength(100)]
        [MaxLength(100)]
        public string Puesto { get; set; }

        [MaxLength(15)]
        [StringLength(15)]
        [RegularExpression(@"^[0-9]{10}", ErrorMessage = "Solo números maximo 10 digitos")]
        public string TelefonoFijo { get; set; }

        [MaxLength(15)]
        [StringLength(15)]
        [RegularExpression(@"^[0-9]{10}", ErrorMessage = "Solo números maximo 10 digitos")]
        public string TelefonoMovil { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "No contiene el formato correcto")]
        [StringLength(100)]
        [MaxLength(100)]
        public string Email { get; set; }

        public int ClienteId { get; set; }
    }
}