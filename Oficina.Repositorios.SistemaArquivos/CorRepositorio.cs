using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.IO;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
        public List<Cor> Obter()
        {
            var cores = new List<Cor>();

            foreach (var linha in File.ReadAllLines("Dados\\Cor.txt"))
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }



                var cor = new Cor();

                cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                cor.Nome = linha.Substring(5);

                cores.Add(cor);

            }
            return cores;
        }

        public Cor Obter(int id)
        {
            Cor cor = null;

            foreach (var linha in File.ReadAllLines("Dados\\Cor.txt"))
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }

                var linhaid = Convert.ToInt32(linha.Substring(0, 5));

                if (id == linhaid)
                {

                    cor = new Cor();

                    cor.Id = linhaid;
                    cor.Nome = linha.Substring(5);

                    break;
                }
            }

                return cor;

        }
    }
}
            

        
    
