using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public interface IServicioCliente
    {

       // int Id { get; set; }
         string Nombres { get; set; }
         string Apellidos { get; set; }
         string Correo { get; set; }

         DateTime? FechaNacimiento { get; set; }
         string Direccion { get; set; }
         Boolean Activo { get; set; }
         DateTime? FechaRegistro { get; set; }

        //void Retirar(double valor);
        //void Consignar(double valor);
        //void Trasladar(IServicioCliente servicioCliente, double valor);

    }
}
