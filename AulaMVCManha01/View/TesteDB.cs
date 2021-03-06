using AulaMVCManha01.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaMVCManha01.View
{
    public partial class TesteDB : Form
    {
        public TesteDB()
        {
            InitializeComponent();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSalario.Text))
            {
                ControllerTeste.AdicionaFuncionario(txtNome.Text, txtCpf.Text, txtRg.Text, txtSalario.Text);
            }
            else if (cbVip.Checked)
            {

            }
            else
            {
                if (ControllerTeste.AdicionaPessoa(txtNome.Text, txtCpf.Text, txtRg.Text))
                {
                    MessageBox.Show("Elemento inserido");
                }
                else
                {
                    MessageBox.Show("Tem que inserir os valores ai, ta ligado?");
                }
            }

            txtNome.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtSalario.Clear();
            cbVip.Checked = false;
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            if (rbP.Checked)
            {
                List<string[]> lista = ControllerTeste.SelecionaPessoas();

                string mostraTexto = "";
                foreach (var item in lista)
                {
                    string elemento = "";
                    foreach (var item1 in item)
                    {
                        elemento += (item1 + "  ");
                    }
                    mostraTexto += (elemento + "\n");
                }

                MessageBox.Show(mostraTexto);
            }
            else if(rbC.Checked)
            {

            }
            else if (rbF.Checked)
            {
                List<string[]> lista = ControllerTeste.SelecionaFuncionarios();

                string mostraTexto = "";
                foreach (var item in lista)
                {
                    string elemento = "";
                    foreach (var item1 in item)
                    {
                        elemento += (item1 + "  ");
                    }
                    mostraTexto += (elemento + "\n");
                }

                MessageBox.Show(mostraTexto);
            }       

        }

        private void TesteDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
