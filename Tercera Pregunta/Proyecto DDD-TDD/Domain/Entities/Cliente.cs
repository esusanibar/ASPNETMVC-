using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class 
        Cliente: Entity<int>,IServicioCliente
    {
        public Cliente()
        {
         //   Movimientos = new List<MovimientoFinanciero>();
        }

        // public List <MovimientoFinanciero> Movimientos { get; set; }


        // public  int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Nombres { get; set; }
        [Required]
        [MaxLength(250)]
        public  string Apellidos { get; set; }
        [Required]
        [MaxLength(320)]
        public string Correo { get; set; }
      
        public DateTime ? FechaNacimiento { get; set; }
        [Required]
        [MaxLength(800)]
        public string Direccion { get; set; }
        [Required]

        public Boolean Activo { get; set; }
        [Required]
        public DateTime? FechaRegistro { get; set; }

        

        //public  virtual void Consignar(double valor)
        //{
        //    MovimientoFinanciero movimiento = new MovimientoFinanciero();
        //    movimiento.ValorConsignacion = valor;
        //    movimiento.FechaMovimiento = DateTime.Now;
        //    Saldo += valor;
        //    Movimientos.Add(movimiento);

        //}
        //public abstract  void Retirar(double valor);

        //public override string ToString()
        //{
        //    return ($"Su saldo disponible es {Saldo}.");
        //}



        //public void Trasladar(IServicioCliente servicioCliente, double valor)
        //{
        //    Retirar(valor);
        //    servicioCliente.Consignar(valor);
        //}
    }
}
