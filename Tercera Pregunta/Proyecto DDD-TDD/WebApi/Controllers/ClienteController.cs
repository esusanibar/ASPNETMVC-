using Application.Implements;
using Infraestructure.Data;
using Infraestructure.Data.Repositories;
using SirccELC.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebApi.Controllers
{
    [RoutePrefix("api/Cliente")]
    public class ClienteController : ApiController
    {
        private readonly EmpresaContext _db;
        public ClienteController()
        {
            _db = new EmpresaContext();
            
        }

        public ClienteController(EmpresaContext db)
        {
            this._db = db;
        }


      
        // POST: api/Cliente
        [ResponseType(typeof(CrearClienteResponse))]
        [Route("Crear")]
        public IHttpActionResult PostCrear(CrearClienteRequest request)
        {
            CrearClienteService _service = new CrearClienteService(new UnitOfWork(_db), new ClienteRepository(_db));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = _service.Ejecutar(request);

            return Ok(response);

        }

    }
}
