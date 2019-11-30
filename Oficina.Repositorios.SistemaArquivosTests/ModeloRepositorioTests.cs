using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        ModeloRepositorio modeloRepositorio = new ModeloRepositorio();



        [TestMethod()]
        public void ObterPorMarca()
        {
            var modelos = modeloRepositorio.ObterPorMarca(4);

            foreach (var modelo in modelos)
            {
                Console.WriteLine($"{modelo.Id} - {modelo.Nome} - {modelo.Marca.Nome}");
            }
        }

        [TestMethod()]
        public void ObterPorTest()
        {
                            
                var modelo = modeloRepositorio.Obter(3);
                 Assert.AreEqual(modelo.Nome, "Prisma");


                modelo = modeloRepositorio.Obter(0);
                Assert.IsNull(modelo);

                
        }
    }
}


