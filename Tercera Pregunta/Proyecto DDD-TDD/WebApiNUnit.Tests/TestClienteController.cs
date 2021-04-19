using Application.Contracts;
using Application.Implements;
using Domain.Abstracts;
using Domain.Entities;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApi.Controllers;
using System.Web.Http;
using System.Web.Http.Hosting;
using System.Web.Http.Results;
using System.Net;
using System.Threading;

namespace WebApiNUnit.Tests
{
    [TestFixture]
    public class TestClienteController
    {
        private Mock<IClienteRepository> _mockRepository;
        private IClienteService _service;
        Mock<IUnitOfWork> _mockUnitWork;
        List<Cliente> listCountry;
        ClienteController controller;

        [SetUp]
        public void Initialize()
        {
            _mockRepository = new Mock<IClienteRepository>();
            _mockUnitWork = new Mock<IUnitOfWork>();
            _service = new ClienteService(_mockUnitWork.Object, _mockRepository.Object);
            listCountry = new List<Cliente>() {
               new Cliente() {  Nombres = "Elvis", Apellidos ="Aguirre" },
               new Cliente() { Nombres = "Pedro" , Apellidos = "Del Solar"},
               new Cliente() {  Nombres = "Juan", Apellidos ="Susanibar" }
            };
            var ServiceBaseURL = "http://localhost:65413/";
            //Arrange
            _mockRepository.Setup(x => x.GetAll()).Returns(listCountry);

            controller = new ClienteController(_service)
            {
                Request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(ServiceBaseURL + "api/Country")
                }
            };

            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
        }


        //[Test]
        //public void Test_ClienteController_Get()
        //{
        //    // Act
        //    var response = controller.Get().ExecuteAsync(CancellationToken.None);

        //    // Assert
        //    Assert.IsNotNull(response);
        //    Assert.IsTrue(response.IsCompleted);
        //    Assert.AreEqual(HttpStatusCode.OK, response.Result.StatusCode);

        //    // Assertions on returned data
        //    List<Cliente> models;
        //    Assert.IsTrue(response.Result.TryGetContentValue<List<Cliente>>(out models));
        //    Assert.AreEqual(3, models.Count);

        //    Assert.AreEqual(1, models.First().Id);
        //}
    }
    }
