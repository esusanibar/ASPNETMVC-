using Application.Base;
using Application.Contracts;
using Domain.Abstracts;
using Domain.Entities;
using Infraestructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implements
{

    public class ClienteService : EntityService<Cliente>, IClienteService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IClienteRepository _clienteRepository;

        public ClienteService(IUnitOfWork unitOfWork, IClienteRepository clienteRepository)
            : base(unitOfWork, clienteRepository)
        {
            _unitOfWork = unitOfWork;
            _clienteRepository = clienteRepository;
        }

    }
}