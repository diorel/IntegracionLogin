using BolsaDeTrabajo.Dtos;
using BolsaDeTrabajo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BolsaDeTrabajo.Controllers.Api
{
    public class PerfilCandidatoController : ApiController
    {
        private ApplicationDbContext _context;
        public PerfilCandidatoController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetPerfilCandidato(int id)
        {
            if (id <= 0)
                return Ok();            

            var PerfilCantidato = _context.PerfilCandidato
                .Include("AboutMe")
                .Include("Idiomas")
                .Include("Formaciones")
                .Include("Experiencias")
                .Include("Cursos")
                .Include("Conocimientos")
                                .SingleOrDefault(p => p.CandidatoId == id);                          

            return Ok(PerfilCantidato);
        }

        [HttpPost]
        public IHttpActionResult CreatePerfilCandidato( PerfilCandidato perfil)
        {
           if( _context.PerfilCandidato.Any(p => p.Id == perfil.Id))
            {
                _context.PerfilCandidato.Remove(_context.PerfilCandidato.Single(p => p.Id == perfil.Id));
               var x = _context.SaveChanges();
            }
            perfil.Id = 0;
            
            _context.PerfilCandidato.Add(perfil);
            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + perfil.CandidatoId), perfil);
        }

    }
}
