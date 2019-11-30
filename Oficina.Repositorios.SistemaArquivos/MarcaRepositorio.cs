using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class MarcaRepositorio : RepositorioBase
     {
        //private string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoMarca"];

        public MarcaRepositorio() : base("caminhoArquivoMarca")
        {

        }



        //ToDo:OO -polimorfismo por sobrecarga.

        public List<Marca> Obter()
        {
            var marcas = new List<Marca>();

            foreach (var linha in File.ReadAllLines(CaminhoArquivo))
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }

                var propriedades = linha.Split('|');

                var Marca = new Marca();

                Marca.Id = Convert.ToInt32(propriedades[0]);
                Marca.Nome = propriedades[1];

                marcas.Add(Marca);

            }
            return marcas;
        }

        public Marca Obter(int id)
        {
            Marca marca = null;

            foreach (var linha in File.ReadAllLines("Dados\\Marca.txt"))
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }
                var propriedades = linha.Split('|');
                 var linhaid = Convert.ToInt32(propriedades[0]);

                if (id == linhaid)
                {

                    marca = new Marca();

                    marca.Id = linhaid;
                    marca.Nome = propriedades[1];

                    break;
                }
            }

            return marca;

        }


    }
}
