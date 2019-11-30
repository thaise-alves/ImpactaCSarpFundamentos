﻿using System;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo03.Variaveis
{
    public partial class VariaveisForm : Form
    {
        int x = 32;
        int y = 16;
        int w = 45;
        int z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // comentario
            int x = 42;
            int i = 0 ;
            string nome = "thaise";
            char letra = 'a';
            DateTime dataNascimento = new DateTime(2018,12,26);
            bool aprovado = true;
            aprovado = false;

                                    
            var a = 2;
            int b = 6;
            var c = 10;
            var d = 13;
           

            //c=89.9m

            var valor =7.8m;
            var bimestre1 = 8.5m;
            int numero = 11, outroNumero = 12,esseNumero = 13;
            var nomeCanção = "release";

            //if(j == 5)
            //{

            //}

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add(string.Concat("b = ",b,",c = ",c));
            resultadoListBox.Items.Add(string.Format("c ={0},d={1}",c,d));
            resultadoListBox.Items.Add($"d ={d},valor={valor}");

            resultadoListBox.Items.Add($"c * d ={d},valor={c * d}");
            resultadoListBox.Items.Add($"d / a ={d},valor={ d/ a}");
            resultadoListBox.Items.Add($"d % a ={d},valor={d %  a}");
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListBox.Items.Add("x = " + x);

            //x = x - 3;
            x -= 3;
            resultadoListBox.Items.Add("x = " + x);

        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();

            int a;
            /* pré-incremental*/
            a = 5;
            resultadoListBox.Items.Add("Exemplo de pré-incremental ");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + ++a ={ 2 + ++a }" );
            resultadoListBox.Items.Add("a = " + a);

            /* pos-incremental*/
            a = 5;
            resultadoListBox.Items.Add("Exemplo de pós-incremental ");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + a++ ={ 2 + a++ }");
            resultadoListBox.Items.Add("a = " + a);
        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirValores();
            resultadoListBox.Items.Add($"w <= x = {w <= x}");
            resultadoListBox.Items.Add($"x = z = {x == z}");
            resultadoListBox.Items.Add($"x != z = {x != z}");




        }

        private void ExibirValores()
        {
            resultadoListBox.Items.Add("x = " + x);
            resultadoListBox.Items.Add("y = " + y);
            resultadoListBox.Items.Add("w = " + w);
            resultadoListBox.Items.Add("z = " + z);
            resultadoListBox.Items.Add(new string ('-',50));
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();

            ExibirValores();

            resultadoListBox.Items.Add($"w <= x  || y== 16 = {w <= x || y == 16}");
            resultadoListBox.Items.Add($"x == z &&  x!=z = {x == z && x != z}");
            resultadoListBox.Items.Add($"!(y>w) = {!(y > w)}");

        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {


            int ano;

            ano = 2014;

            resultadoListBox.Items.
               Add($"O ano{ano}é bissexto?{(ano % 4 ==0 ? "Sim":"Não")}.");

            ano = 2016;

            resultadoListBox.Items
               .Add($"O ano{ano}é bissexto?{(DateTime.IsLeapYear(ano)  ? "Sim" : "Não")}.");

            /*var resposta = "";
            int ano;
            if (ano % 4 == 0)
            {

            }
            else*/
        }
    }
}
