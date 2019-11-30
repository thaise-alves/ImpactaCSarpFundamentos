using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpFundamentos.Capitulo08.VetoresColecoes.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var inteiros = new int[5];
            inteiros[0] = 14;
            //inteiros[5] = 4;

            var decimais = new decimal[] { 0.4m, 0.9m, 4, 7.8m };

            string[] nomes = { "Vitor", "Avelino" };


            foreach (var @decimal in decimais)
            {
                Console.WriteLine(@decimal);
            }
            Console.WriteLine($"O tamanho do vetor {nameof(decimais)} :{decimais.Length}");

        }

        [TestMethod]
        public void RedicionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 7, 8.9m };

            Array.Resize(ref decimais, 5);


            decimais[4] = 2.3m;
        }

        [TestMethod]
        public void OrdenacaoTeste()
        {

            var decimais = new decimal[] { 0.5m, 7, 0.9m, -1.4m };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], -1.4m);

        }

        [TestMethod]
        public void ParamsTeste()
        {
            var decimais = new decimal[] { 0.5m, 7, 0.9m, -1.4m };

            Console.WriteLine(Media(decimais));
           
            


        }
        private decimal Media(decimal valor1, decimal valor2)
        {
            return (valor1 + valor2) / 2;
        }

        private decimal Media(params decimal[] valores)

        {


            var soma = 0m;

            foreach (var valor in valores)
            {
                //soma = soma + valor;
                soma += valor;
            }


            return soma /  valores.Length;

        }

        [TestMethod]
        public void TodaStringEhUmVetorTeste()

        {
            var nome = "Vitor";

            Assert.AreEqual(nome[0],'V');

            foreach (var @char in nome)
            {
                Console.Write(@char);
            }
        }
    }
}
