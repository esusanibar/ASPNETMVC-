using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using PrimeraPregunta.Modelo;

namespace PrimeraPregunta
{
    public class OrdenarLista
    {
        public List<Usuario> OrdenarPorNombre(List<Usuario> request)
        {
            List<Usuario> SortedList = request.OrderBy(o => o.Nombre).ToList();

            return SortedList;
        }

        public List<Usuario> OrdenarPorNombreApellido(List<Usuario> request)
        {
            List<Usuario> SortedList = request.OrderBy(o => o.Nombre).ThenBy(o => o.Apellido).ToList();

            return SortedList;
        }
    }
}
