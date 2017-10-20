﻿using BolsaDeTrabajo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BolsaDeTrabajo.Controllers.Api
{
    public class PerfilExperienciaController : ApiController
    {
        private ApplicationDbContext _context;
        public PerfilExperienciaController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetPerfilesExperiencia()
        {
            return Ok(_context.PerfilExperiencia.ToList());
        }
    }
}
