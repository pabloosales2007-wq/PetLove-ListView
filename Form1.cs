using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetLove_ListView
{
    public partial class Form1 : Form
    {
        private OpenFileDialog leitura = new OpenFileDialog();
        private SaveFileDialog salvamento = new SaveFileDialog();
        private string caminho;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botao para obter dados
        /// </summary>
        /// <param name="sender">Botao de obter dados</param>
        /// <param name="e">Evento de click</param>
        private void btnObterDados_Click(object sender, EventArgs e)
        {
            leitura.Title = "Selecione o arquivo que contem os dados desejados";

            if (leitura.ShowDialog() != DialogResult.OK) return;

                caminho = leitura.FileName;

            try
            {
                var textoLido = File.ReadAllText(caminho);

                string[] linhas = textoLido.ToString().Split('\n');

                foreach (string linha in linhas) lvDados.Items.Add(linha);
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
