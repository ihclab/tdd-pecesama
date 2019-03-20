using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ordenamiento.Pruebas
{
    [TestClass]
    public class PruebasOrdenamiento
    {
        private int[] salidaEsperada = new int[]{1, 2, 3, 4, 5};
        private Burbuja ordenar = new Burbuja();

        [TestMethod]
        public void Ordenado() {
            int[] entrada = new int[]{1, 2, 3, 4, 5};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void UnoCambiado() {
            int[] entrada = new int[]{1, 3, 2, 4, 5};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void Ultimo() {
            int[] entrada = new int[]{5, 1, 2, 3, 4};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void Primero() {
            int[] entrada = new int[]{2, 3, 4, 5, 1};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void Invertido() {
            int[] entrada = new int[]{5, 4, 3, 2, 1};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }
    }
}
