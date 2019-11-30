using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina.WindowsForms
{
    public partial class VeiculoForm : Form
    {
        private object anoMaskedTextBox;

        //costrutor - metodo com o mesmo nome da classe.
        //Executado automaticamente(new)
        public VeiculoForm()
        {
            InitializeComponent();
            PopularControles();
        }

        private void PopularControles()
        {

            MarcacomboBox.DataSource = new MarcaRepositorio().Obter();
            MarcacomboBox.DisplayMember = "Nome";
            MarcacomboBox.ValueMember = "id";
            MarcacomboBox.SelectedIndex = -1;

            CorcomboBox.DataSource = new CorRepositorio().Obter();
            CorcomboBox.DisplayMember = "Nome";
            CorcomboBox.ValueMember = "id";
            CorcomboBox.SelectedIndex = -1;
            
            CambiocomboBox.DataSource = Enum.GetValues(typeof(Cambio));
            CambiocomboBox.SelectedIndex = -1;

            CombustivelcomboBox.DataSource = Enum.GetValues(typeof(Combustivel));
            CombustivelcomboBox.SelectedIndex = -1;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MarcacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MarcacomboBox.SelectedIndex == -1)

            {
                return;
            }           

            

            var marca =(Marca) MarcacomboBox.SelectedItem;


            ModelocomboBox.DataSource = new ModeloRepositorio().ObterPorMarca(marca.Id);
            ModelocomboBox.DisplayMember = "Nome";
            ModelocomboBox.ValueMember = "id";
            ModelocomboBox.SelectedIndex = -1;
        }

        private void Gravarbutton_Click(object sender, EventArgs e)
        {
            if (Formulario.Validar(this, veiculoerrorProvider))
            {
                GravarVeiculo();
                MessageBox.Show("Veículo gravado com sucesso!");
                Formulario.Limpar(this);
                placaMaskedTextBox.Focus();
            }
        }

        private void GravarVeiculo()
        {
            var veiculo = new VeiculoPasseio();

            veiculo.Ano = Convert.ToInt32(anoTextBox.Text);
            veiculo.Cambio = (Cambio)CambiocomboBox.SelectedItem;
            veiculo.Carroceria = Carroceria.Hatch;
            veiculo.Combustivel = (Combustivel)CombustivelcomboBox.SelectedItem;
            veiculo.Cor = (Cor)CorcomboBox.SelectedItem;
            veiculo.Modelo = (Modelo)ModelocomboBox.SelectedItem;
            veiculo.Observacao = observacaotextBox.Text;
            veiculo.Placa = placaMaskedTextBox.Text;

            new VeiculoRepositorio().Inserir(veiculo);
        }

        private void Limparbutton_Click(object sender, EventArgs e)
        {
            Formulario.Limpar(this);
        }
    }
}
