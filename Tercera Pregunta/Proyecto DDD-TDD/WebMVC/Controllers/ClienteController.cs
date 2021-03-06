using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Domain.Entities;
using Infraestructure.Data;
using Application.Contracts;
using Application.Implements;
using SirccELC.Infraestructura.Data;
using Infraestructure.Data.Repositories;

namespace WebMVC.Controllers
{
    public class ClienteController : Controller
    {
        readonly IClienteService _service;
    

        public ClienteController()
        {
            EmpresaContext _db = new EmpresaContext();
            _service = new ClienteService(new UnitOfWork(_db), new ClienteRepository(_db));
        }

        public ClienteController(IClienteService service)
        {
            this._service = service;
        }


        // GET: Country
        public ActionResult Index()
        {
            return View(_service.GetAll());

        }

        // GET: Country/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = _service.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // GET: Country/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Country/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nombres,Apellidos,Direccion,Correo,FechaNacimiento,Activo,FechaRegistro")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _service.Create(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Country/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente country = _service.Find(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        // POST: Country/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Cliente country)
        {
            if (ModelState.IsValid)
            {
                _service.Update(country);
                return RedirectToAction("Index");
            }
            return View(country);
        }

        // GET: Country/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = _service.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Country/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = _service.Find(id);
            _service.Delete(cliente);
            return RedirectToAction("Index");
        }
        
    }
}
