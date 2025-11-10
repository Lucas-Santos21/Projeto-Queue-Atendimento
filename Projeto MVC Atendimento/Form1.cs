using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_MVC_Atendimento
{
    public partial class Form1 : Form
    {
        Senhas senhas = new Senhas();
        Guiches guiches = new Guiches();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
            MessageBox.Show("Senha gerada com sucesso!");
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            lstSenhas.Items.Clear();

            foreach (Senha s in senhas.FilaSenhas)
            {
                lstSenhas.Items.Add(s.dadosParciais());
            }
        }

        private void btnAdicionarGuiche_Click(object sender, EventArgs e)
        {
            Guiche novo = new Guiche(guiches.ListaGuiches.Count + 1);
            guiches.Adicionar(novo);

            lblQtdGuiches.Text = guiches.ListaGuiches.Count.ToString();
            MessageBox.Show("Guichê adicionado com sucesso!");
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            int numeroGuiche;

            if (!int.TryParse(txtGuiche.Text, out numeroGuiche))
            {
                MessageBox.Show("Informe um número de guichê válido!");
                return;
            }

            if (numeroGuiche <= 0 || numeroGuiche > guiches.ListaGuiches.Count)
            {
                MessageBox.Show("Guichê inexistente!");
                return;
            }

            Guiche g = guiches.ListaGuiches[numeroGuiche - 1];

            bool chamado = g.Chamar(senhas.FilaSenhas);

            if (chamado)
            {
                Senha ultima = g.Atendimentos.Peek();
                ultima.DataAtend = DateTime.Now.Date;
                ultima.HoraAtend = DateTime.Now;

                MessageBox.Show($"Senha {ultima.Id} chamada no guichê {g.Id}.");
            }
            else
            {
                MessageBox.Show("Não há senhas na fila!");
            }
        }

        private void btnListarAtendimentos_Click(object sender, EventArgs e)
        {
            lstAtendimentos.Items.Clear();

            foreach (Guiche g in guiches.ListaGuiches)
            {
                foreach (Senha s in g.Atendimentos)
                {
                    lstAtendimentos.Items.Add(s.dadosCompletos());
                }
            }
        }
    }
}
