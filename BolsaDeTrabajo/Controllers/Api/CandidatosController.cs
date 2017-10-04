using AutoMapper;
using BolsaDeTrabajo.Dtos;
using BolsaDeTrabajo.Models;
using System;
using System.Linq;
using System.Data.Entity;
using System.Web.Http;
using BolsaDeTrabajo.Utilities;
using System.Collections.Generic;

namespace BolsaDeTrabajo.Controllers.Api
{
    public class CandidatosController : ApiController
    {
              private Dictionary<string, byte> TiposTelefonos = new Dictionary<string, byte>()
        {
            { "Movil", 1 },
            { "Casa", 2 },
            { "Oficina", 3 }
        };
        private Dictionary<string, byte> TiposDirecciones = new Dictionary<string, byte>()
        {
            { "Personal", 1 }
        };
        private ApplicationDbContext _Context;
        public CandidatosController()
        {
            _Context = new ApplicationDbContext();
        }

        public IHttpActionResult GetCandidatos()
        {
            var candidatos = _Context.Candidatos
                    .Include(a => a.direcciones)
                    .Include(e => e.emails)
                    .Include(t => t.telefonos)
                    .ToList();

            return Ok(candidatos);
        }

        public IHttpActionResult GetCandidato(int id)
        {
            var candidato = _Context.Candidatos
                .Include(p=> p.paisNacimiento)                
                .Include(e=> e.estadoNacimiento)                
                .Include(m=> m.municipioNacimiento)
                .SingleOrDefault(c => c.Id == id);

            var candidatoDto = new CandidatoDto();
            candidatoDto.Id = candidato.Id;
            candidatoDto.ApellidoPaterno = candidato.ApellidoPaterno;
            candidatoDto.ApellidoMaterno = candidato.ApellidoMaterno;
            candidatoDto.Nombre = candidato.Nombre;
            candidatoDto.ImgProfileUrl = candidato.ImgProfileUrl;
            candidatoDto.email = _Context.Emails.First(c => c.PersonaFisicaMoralId == candidatoDto.Id).email;
            candidatoDto.datospersonales = Mapper.Map<Candidato, DatosPersonales>(candidato); 
            var direccion = _Context.Direcciones
                .Include(p=>p.Pais)
                .Include(e=>e.Estado)
                .Include(m=>m.Municipio)
                .Include(c=>c.Colonia)
                .SingleOrDefault(d => d.PersonaFisicaMoralId == candidatoDto.Id);
            candidatoDto.Direccion = Mapper.Map < Direccion, DireccionDto >(direccion);
            candidatoDto.identificaciones = Mapper.Map<Candidato, IdentificacionesDto>(candidato);
            var TiposTelefono = TiposTelefonos["Casa"];
            var telcasa = _Context.Telefonos
                .FirstOrDefault(t => t.PersonaFisicaMoralId == candidatoDto.Id && t.TipoTelefonoId == TiposTelefono);
            candidatoDto.datospersonales.telCasa = (telcasa != null) ? telcasa.telefono : null;
            TiposTelefono = TiposTelefonos["Movil"];
            var telcelular = _Context.Telefonos
               .FirstOrDefault(t => t.PersonaFisicaMoralId == candidatoDto.Id && t.TipoTelefonoId == TiposTelefono);
            candidatoDto.datospersonales.telCelular = (telcelular != null) ? telcelular.telefono : null;
            TiposTelefono = TiposTelefonos["Oficina"];
            var teloficina = _Context.Telefonos
              .FirstOrDefault(t => t.PersonaFisicaMoralId == candidatoDto.Id && t.TipoTelefonoId == TiposTelefono);
            candidatoDto.datospersonales.telOficina = (teloficina != null) ? teloficina.telefono : null;

            var metodosContacto = _Context.FormasContacto.FirstOrDefault(fc => fc.CandidatoId == candidatoDto.Id);
                candidatoDto.datospersonales.CorreoElectronico = metodosContacto.CorreoElectronico;
                candidatoDto.datospersonales.Celular = metodosContacto.Celular;
                candidatoDto.datospersonales.WhatsApp = metodosContacto.WhatsApp;
                candidatoDto.datospersonales.TelLocal = metodosContacto.TelLocal;
            

            return Ok(candidatoDto);

        }

        [HttpPost]
        public IHttpActionResult CreateCandidato(CandidatoDto candidatoDto)
         {
            //if (!ModelState.IsValid)
            //    return BadRequest();              

            var candidatoID=CrearCandidato(candidatoDto);
            candidatoDto.Id = candidatoID;

            var email = new Email(candidatoDto.email, candidatoID);
            _Context.Emails.Add(email);
            _Context.SaveChanges();            

            CreateDireccion(candidatoDto.Direccion, candidatoID); 

            CreateTelefono("+52", candidatoDto.datospersonales.telCasa, TiposTelefonos["Casa"], candidatoID);
            CreateTelefono("+52", candidatoDto.datospersonales.telCelular, TiposTelefonos["Movil"], candidatoID);
            CreateTelefono("+52", candidatoDto.datospersonales.telOficina, TiposTelefonos["Oficina"], candidatoID);     

            var metodosContacto = new FormaContacto(candidatoID, candidatoDto.datospersonales.CorreoElectronico, candidatoDto.datospersonales.Celular,
                candidatoDto.datospersonales.WhatsApp, candidatoDto.datospersonales.TelLocal);
            _Context.FormasContacto.Add(metodosContacto);
            _Context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + candidatoID), candidatoDto);
        }
     
        [HttpPut]
        public IHttpActionResult UpdateCandidato(int id, CandidatoDto candidatoDto)
        {
            UpdateCandidato(candidatoDto, id);
          

            UpdateEmail(candidatoDto.email, id);   

            UpdateDireccion(candidatoDto.Direccion, id);

            UpdateTelefono(id, candidatoDto.datospersonales.telCasa, TiposTelefonos["Casa"]);
            UpdateTelefono(id, candidatoDto.datospersonales.telCelular, TiposTelefonos["Movil"]);
            UpdateTelefono(id, candidatoDto.datospersonales.telOficina, TiposTelefonos["Oficina"]);              

            UpdateFormaContacto(id, candidatoDto.datospersonales.CorreoElectronico, candidatoDto.datospersonales.Celular, candidatoDto.datospersonales.WhatsApp, candidatoDto.datospersonales.TelLocal);
           

            return Ok();
        }

      

        [HttpDelete]
        public IHttpActionResult DeleteCandidato(int id)
        {
            var candidatoInDB = _Context.Candidatos.SingleOrDefault(c => c.Id == id);
            if (candidatoInDB == null)
                return NotFound();

            var emailInDB = _Context.Emails.SingleOrDefault(c => c.PersonaFisicaMoralId == id);
            _Context.Emails.Remove(emailInDB);
            _Context.SaveChanges();
            var direccioInDB = _Context.Direcciones.SingleOrDefault(c => c.PersonaFisicaMoralId == id);
            _Context.Direcciones.Remove(direccioInDB);
            _Context.SaveChanges();
            var formaContactoInDB = _Context.FormasContacto.SingleOrDefault(c => c.CandidatoId == id);
            _Context.FormasContacto.Remove(formaContactoInDB);
            _Context.SaveChanges();

            var telefonosInDB = _Context.Telefonos.RemoveRange(_Context.Telefonos.Where(c => c.PersonaFisicaMoralId == id));
            _Context.SaveChanges();

            _Context.Candidatos.Remove(candidatoInDB);
            _Context.SaveChanges();

            return Ok();
        }

        private void CreateTelefono(string clavePais, string telefono, int tipoTelefono, int idPersona)
        {
            if (string.IsNullOrEmpty(telefono))
                return;

            var Telefono=  new Telefono(clavePais, telefono, Convert.ToByte(tipoTelefono), idPersona);
            _Context.Telefonos.Add(Telefono);
            _Context.SaveChanges();


        }

        private int CrearCandidato(CandidatoDto candidatoDto)
        {
            var candidato = Mapper.Map<DatosPersonales, Candidato>(candidatoDto.datospersonales);
            candidato.Nombre = candidatoDto.Nombre.ToUpper();
            candidato.ApellidoPaterno = candidatoDto.ApellidoPaterno.ToUpper();
            candidato.ApellidoMaterno = candidatoDto.ApellidoMaterno.ToUpper();
            candidato.FechaNacimiento = candidatoDto.datospersonales.fechaNacimiento;
            candidato.PaisNacimientoId = candidatoDto.datospersonales.paisNacimiento.Id;
            candidato.EstadoNacimientoId = candidatoDto.datospersonales.estadoNacimiento.Id;
            candidato.MunicipioNacimientoId = candidatoDto.datospersonales.municipioNacimiento.Id;
            candidato.tieneLicenciaConducir = candidatoDto.identificaciones.tieneLicenciaConducir;
            candidato.TipoLicenciaId = candidato.tieneLicenciaConducir ? candidatoDto.identificaciones.TipoLicenciaId : null;
            candidato.RFC = candidatoDto.identificaciones.RFC;
            candidato.CURP = candidatoDto.identificaciones.CURP;
            candidato.NSS = candidatoDto.identificaciones.NSS;
            _Context.Entry(candidato.paisNacimiento).State = EntityState.Unchanged;
            _Context.Entry(candidato.estadoNacimiento).State = EntityState.Unchanged;
            _Context.Entry(candidato.municipioNacimiento).State = EntityState.Unchanged; 
            _Context.Candidatos.Add(candidato);
            _Context.SaveChanges();

            return candidato.Id;

        }

        private void CreateDireccion(DireccionDto direccionDto, int candidatoId)
        {
            var direccion = Mapper.Map<DireccionDto, Direccion>(direccionDto);            
            direccion.esMoral = false;
            direccion.DireccionTipoId = TiposDirecciones["Personal"];
            direccion.PaisId = direccion.Pais.Id;
            direccion.EstadoId = direccion.Estado.Id;
            direccion.MunicipioId = direccion.Municipio.Id;
            direccion.ColoniaId = direccion.Colonia.Id;
            direccion.PersonaFisicaMoralId = candidatoId;
            direccion.Pais=null;
            direccion.Estado = null;
            direccion.Municipio = null;
            direccion.Colonia = null;
            //_Context.Entry(direccion.Pais).State = EntityState.Unchanged;
            //_Context.Entry(direccion.Estado).State = EntityState.Unchanged;
            //_Context.Entry(direccion.Municipio).State = EntityState.Unchanged;
            //_Context.Entry(direccion.Colonia).State = EntityState.Unchanged;
            _Context.Direcciones.Add(direccion);
            _Context.SaveChanges(); 
        }

        private void UpdateDireccion(DireccionDto direccionDto, int id)
        {
            var direccion = _Context.Direcciones.SingleOrDefault(d => d.PersonaFisicaMoralId == id);
            direccionDto.Id = direccion.Id;
            direccionDto.PaisId = direccionDto.Pais.Id;
            direccionDto.EstadoId = direccionDto.Estado.Id;
            direccionDto.MunicipioId = direccionDto.Municipio.Id;
            direccionDto.ColoniaId = direccionDto.Colonia.Id;
            Mapper.Map(direccionDto, direccion);
            _Context.Entry(direccion.Pais).State = EntityState.Unchanged;
            _Context.Entry(direccion.Estado).State = EntityState.Unchanged;
            _Context.Entry(direccion.Municipio).State = EntityState.Unchanged;
            _Context.Entry(direccion.Colonia).State = EntityState.Unchanged;
            _Context.Direcciones.Attach(direccion);
            _Context.Entry(direccion).State = EntityState.Modified;
            _Context.SaveChanges();


        }

        private void UpdateEmail(string email, int idCandidato)
        {
            var emailInDB = _Context.Emails.SingleOrDefault(e => e.PersonaFisicaMoralId == idCandidato);
            emailInDB.email = email;
            emailInDB.PersonaFisicaMoralId = idCandidato;
            _Context.Emails.Attach(emailInDB);
            _Context.Entry(emailInDB).State = EntityState.Modified;
            _Context.SaveChanges();
           
        }

       private void UpdateFormaContacto(int candidatoId, bool correoElectronico, bool celular, bool whatsApp, bool telLocal)
        {
            var formasContacto = _Context.FormasContacto.SingleOrDefault(fc => fc.CandidatoId == candidatoId);
            formasContacto.CorreoElectronico = correoElectronico;
            formasContacto.Celular = celular;
            formasContacto.WhatsApp = whatsApp;
            formasContacto.TelLocal = telLocal;
            _Context.FormasContacto.Attach(formasContacto);
            _Context.Entry(formasContacto).State = EntityState.Modified;
            _Context.SaveChanges();
        }

        private void UpdateTelefono(int candidatoId, string telefono, int tipoTelefono)
        {
            var telephone = _Context.Telefonos.SingleOrDefault(e => e.PersonaFisicaMoralId == candidatoId && e.TipoTelefonoId == tipoTelefono);
            if (telefono == null && telephone!=null)
            {
                _Context.Telefonos.Remove(telephone);
                _Context.SaveChanges();

            }
            else if (telefono != null && telephone != null)
            {
                var tel = _Context.Telefonos.FirstOrDefault(e => e.PersonaFisicaMoralId == candidatoId && e.TipoTelefonoId == tipoTelefono);
                tel.telefono = telefono;
                _Context.Telefonos.Attach(tel);
                _Context.Entry(tel).State = EntityState.Modified;
                _Context.SaveChanges();
            }
            else if (telefono != null)
            {
                CreateTelefono("+52", telefono, tipoTelefono, candidatoId);
            }
        }

        private int UpdateCandidato(CandidatoDto candidatoDto, int candidatoId)
        {
            var candidato = Mapper.Map<DatosPersonales, Candidato>(candidatoDto.datospersonales);
            candidato.Nombre = candidatoDto.Nombre.ToUpper();
            candidato.ApellidoPaterno = candidatoDto.ApellidoPaterno.ToUpper();
            candidato.ApellidoMaterno = candidatoDto.ApellidoMaterno.ToUpper();
            candidato.FechaNacimiento = candidatoDto.datospersonales.fechaNacimiento;
            candidato.PaisNacimientoId = candidatoDto.datospersonales.paisNacimiento.Id;
            candidato.EstadoNacimientoId = candidatoDto.datospersonales.estadoNacimiento.Id;
            candidato.MunicipioNacimientoId = candidatoDto.datospersonales.municipioNacimiento.Id;
            candidato.tieneLicenciaConducir = candidatoDto.identificaciones.tieneLicenciaConducir;
            candidato.TipoLicenciaId = candidato.tieneLicenciaConducir ? candidatoDto.identificaciones.TipoLicenciaId : null;
            candidato.RFC = candidatoDto.identificaciones.RFC;
            candidato.CURP = candidatoDto.identificaciones.CURP;
            candidato.NSS = candidatoDto.identificaciones.NSS;
            candidato.Id = candidatoId;
            _Context.Entry(candidato.paisNacimiento).State = EntityState.Unchanged;
            _Context.Entry(candidato.estadoNacimiento).State = EntityState.Unchanged;
            _Context.Entry(candidato.municipioNacimiento).State = EntityState.Unchanged;            
            _Context.Candidatos.Attach(candidato);
            _Context.Entry(candidato).State = EntityState.Modified;
            _Context.SaveChanges();

            return candidato.Id;

        }
    }
}
