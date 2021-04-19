using Application.Base;
//using Application.Contracts;
using Domain.Abstracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implements
{

    public class CrearClienteService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IClienteRepository _clienteRepository;

        public CrearClienteService(IUnitOfWork unitOfWork, IClienteRepository clienteRepository)
        {
            _unitOfWork = unitOfWork;
            _clienteRepository = clienteRepository;
        }
        public CrearClienteResponse Ejecutar(CrearClienteRequest request)

        {
            Cliente cliente = _clienteRepository.FindBy(t => t.Activo.Equals(true) && t.Correo.Equals(request.Correo)).FirstOrDefault();
          
            if (cliente == null)
            {
                Cliente clientenuevo = new Cliente();//Debe ir un factory que determine el cliente que se va a crear
                clientenuevo.Nombres = request.Nombres;
                clientenuevo.Apellidos = request.Apellidos;
                clientenuevo.Correo = request.Correo;
                clientenuevo.Direccion = request.Direccion;
                clientenuevo.Activo = request.Activo;
                clientenuevo.FechaNacimiento = request.FechaNacimiento;
                clientenuevo.FechaRegistro = request.FechaRegistro;
               
                _clienteRepository.Add(clientenuevo);
                _unitOfWork.Commit();
                return new CrearClienteResponse() { Mensaje = $"Se creo con exito el cliente  {clientenuevo.Nombres  + '-' +  clientenuevo.Apellidos }." };
            }
            else
            {
                return new CrearClienteResponse() { Mensaje = $"El cliente ya existe" };
            }
        }

      

    }
    public class CrearClienteRequest
    {

        public string Nombres { get; set; }
       
        public string Apellidos { get; set; }
       
        public string Correo { get; set; }
      
        public DateTime FechaNacimiento { get; set; }
   
        public string Direccion { get; set; }
    
        public Boolean Activo { get; set; }
      
        public DateTime FechaRegistro { get; set; }

    }
    public class CrearClienteResponse
    {
        public string Mensaje { get; set; }
    }
}