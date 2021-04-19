using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeraPregunta;

using PrimeraPregunta.Modelo;

namespace unitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OrdenarLista ordenar = new OrdenarLista();

            List<Usuario> listausuario = new List<Usuario>();

            Usuario usuario = new Usuario();

            usuario.Nombre = "Carlos";
            usuario.Apellido = "Alcantara ";
            
            listausuario.Add(usuario);

            Usuario usuario1 = new Usuario();

            usuario1.Nombre = "Luis";
            usuario1.Apellido = "Reyes ";

            listausuario.Add(usuario1);

            Usuario usuario2 = new Usuario();

            usuario2.Nombre = "Marcos";
            usuario2.Apellido = "Pinillos ";

            listausuario.Add(usuario2);

            Usuario usuario3 = new Usuario();
            usuario3.Nombre = "Marcos";
            usuario3.Apellido = "Buis ";

            listausuario.Add(usuario3);

            Usuario usuario4 = new Usuario();

            usuario4.Nombre = "Alberto";
            usuario4.Apellido = "Coronel ";

            listausuario.Add(usuario4);

          var rpta=  ordenar.OrdenarPorNombre(listausuario);
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            OrdenarLista ordenar = new OrdenarLista();

            List<Usuario> listausuario = new List<Usuario>();

            Usuario usuario = new Usuario();

            usuario.Nombre = "Carlos";
            usuario.Apellido = "Alcantara ";

            listausuario.Add(usuario);

            Usuario usuario1 = new Usuario();

            usuario1.Nombre = "Luis";
            usuario1.Apellido = "Reyes ";

            listausuario.Add(usuario1);

            Usuario usuario2 = new Usuario();

            usuario2.Nombre = "Marcos";
            usuario2.Apellido = "Pinillos ";

            listausuario.Add(usuario2);

            Usuario usuario3 = new Usuario();
            usuario3.Nombre = "Marcos";
            usuario3.Apellido = "Buis ";

            listausuario.Add(usuario3);

            Usuario usuario4 = new Usuario();

            usuario4.Nombre = "Alberto";
            usuario4.Apellido = "Coronel ";

            listausuario.Add(usuario4);

          var rpta=  ordenar.OrdenarPorNombreApellido(listausuario);
        }

    }
}
