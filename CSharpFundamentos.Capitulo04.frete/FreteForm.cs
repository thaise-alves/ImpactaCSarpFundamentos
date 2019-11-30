﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo04.frete
{
    public partial class FreteForm : Form
    {
        public FreteForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();

            if (erros.Count == 0 )
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine,erros),
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void Calcular()
        {
            var percentualFrete = 0m;
           var valor=Convert.ToDecimal(valorTextBox.Text);

            switch (ufComboBox.Text.ToUpper())
            {
                case "SP":
                    percentualFrete = 0.2m;
                        break;

                case "RJ":
                    percentualFrete = 0.3m;
                        break;

                case "MG":
                    percentualFrete = 0.35m;
                        break;

                case "AM":
                    percentualFrete = 0.6m;
                        break;
                                
                 default:
                    percentualFrete = 0.7m;
                    break;
            }

            freteTextBox.Text = percentualFrete.ToString("P2");
            totalTextBox.Text = ((1 + percentualFrete) * valor).ToString("c");


        }

        private void CalcularButton()
        {
            
        }

        private List<string> ValidarFormulario()
        {
            var erros = new List<String> ();

            //if (clienteTextBox.Text == "")
            if (clienteTextBox.Text == string.Empty)

                {
                erros.Add(" O campo Cliente é obrigatótio.");
                }

            if (ufComboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione um UF");
            }

            //if (valorTextBox.Text == String.Empty)
            if(string.IsNullOrEmpty(valorTextBox.Text))
            {
                erros.Add(" O campo Valor é obrigatótio.");
            }
            else
            {
                decimal valorConvertido;

                if (!decimal.TryParse(valorTextBox.Text,out valorConvertido))
                {
                    erros.Add("O campo Valor deve ser numérico");
                }
            }
            {

            }

            return erros;

        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            clienteTextBox.Text = "";
            valorTextBox.Clear();
            ufComboBox.SelectedIndex = -1;
            freteTextBox.Text = string.Empty;
            totalTextBox.Text = null;



        }
    }
}
