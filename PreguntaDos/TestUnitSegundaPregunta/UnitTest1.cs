using Microsoft.VisualStudio.TestTools.UnitTesting;
using PreguntaDos;

namespace TestUnitSegundaPregunta
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rangos rango = new Rangos();

            int[] array = new int[4];
            array[0] = 5;
            array[1] = 2;
            array[2] = 10;
            array[3] = 20;

       var rpta =     rango.CompletarRango(array);



        }
    }
}
