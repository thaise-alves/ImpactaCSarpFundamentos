using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    public class Frete
    {
        /// <summary>
        /// Construtor da classe frete
        /// </summary>
        /// <param name="valor">Valor do Frete</param>
        /// <param name="uf">UF DE dESTINO</param>
        public Frete (decimal valor,UF uf)
        {
            this.Valor = valor;
            this.UF = uf;
            Calcular();
        }

        public Cliente Cliente { get; set; }
        public decimal Valor  { get; private set; }
        public UF UF { get; set; }
        public decimal Percentual { get; private set; }
        public decimal Total { get; private set; }

        private void Calcular()
        {
           

            switch (UF)
            {
                case UF.SP:
                    Percentual = 0.2m;
                    break;
                case UF.RJ:
                    Percentual = 0.3M;
                    break;
                case UF.MG:
                    break;
                case UF.AM:
                    break;
                   default:
                    Percentual = 0.7M;
                    break;
            }
       
            
              Total = (1 + Percentual) * Valor;


        }

    }
}
