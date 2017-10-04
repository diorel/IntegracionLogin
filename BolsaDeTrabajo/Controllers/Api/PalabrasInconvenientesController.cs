using BolsaDeTrabajo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace BolsaDeTrabajo.Controllers.Api
{
    public class PalabrasInconvenientesController : ApiController
    {
        private ApplicationDbContext _context;
        public PalabrasInconvenientesController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetPalabraInconveniente(string palabra)
        {

            var sustituto = _context.PalabrasInconvenientes.FirstOrDefault(p => p.Palabra == palabra);
            //sustituto = string.IsNullOrEmpty(sustituto) ? string.Empty : sustituto;

            return Ok(sustituto);
        }


        public IHttpActionResult GetPalabraInconveniente(string palabra, int opt)
        {
            var palabras = palabra.ToUpper().Split(' ');
            ValidateState myAnonymousType= new ValidateState(palabras[0]); 
            switch (opt)
            {
                case 1:
                    for (var i = 0; i < palabras.Length; i++)
                    {
                        var str = palabras[i];
                        var excluir = _context.PalabrasExcluidas.Any(p => p.Palabra == str) ||
                            _context.NombresComunes.Any(n => n.Nombre == str) ? true : false;
                        if (!excluir)
                        {
                             myAnonymousType = new ValidateState(str);
                            return Ok(myAnonymousType);
                        }
                    }
                    break;  
                case 2:
                    for (var i = 0; i < palabras.Length; i++)
                    {
                        var str = palabras[i];
                        var excluir=_context.PalabrasExcluidas.Any(p => p.Palabra == str) ? true : false;
                        if (!excluir)
                        {
                             myAnonymousType = new ValidateState(str); 
                            return Ok(myAnonymousType);
                        }                           
                       
                    }
                    break;
            }
             
            return Ok(myAnonymousType );            
        }

        
    }

    public class ValidateState
    {
        public string valid { get; set; }
        public ValidateState(string str)
        {
            valid = str;
        }
    }
}
