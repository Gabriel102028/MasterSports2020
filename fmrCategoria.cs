using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterSports
{
    public partial class fmrCategoria : Form
    {
        public string tipo;

        public fmrCategoria()
        {
            InitializeComponent();
        }

        private void btcadastro_Click(object sender, EventArgs e)
        {

            // instanciando a classe categoria para usar os metodos e propriedades

            classcategoria ccategoria = new classcategoria();

            // verificando campos obrigatorios
            if (tbnomecategoria.Text != "")
            {
                // fazendo a propriedade receber o conteudo do formulario
                // todos os campos que o usuario pode preencher

                ccategoria.nome = tbnomecategoria.Text;

                // metodo para cadastro da classe

                int chm = ccategoria.cadastracategoria();

                // resposta certa = 1

                if (chm != 0)
                {
                    MessageBox.Show("Categoria " + ccategoria.nome + " Cadastrada com Sucesso.", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // criando botao que limpa formulario.

                    btlimpar_Click(this, new EventArgs());
                }

                // se a respota for errada =0

                else
                {
                    MessageBox.Show("Erro ao Realizar o Cadastro ", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else

            {
                MessageBox.Show("Verificar os Campos Obrigatorios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbnomecategoria.BackColor = Color.LemonChiffon;
                tbnomecategoria.Focus();
            }



        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            tbnomecategoria.Clear();
            tbnomecategoria.Focus();
        }

        private void fmrCategoria_Load(object sender, EventArgs e)
        {
            tbdatacadastro.Text = DateTime.Now.ToShortDateString();


            if (tipo == "Atualização")
            {
                lbcadastrocat.Text = "Editar Categoria";
                btcadastro.Enabled = false;
                cbstatus.Enabled = true;
                btlimpar.Enabled = false;

            }
            else
            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;

            }
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que Deseja Sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }


        private void btatualizar_Click_1(object sender, EventArgs e)
        {
            classcategoria ccategoria = new classcategoria();

            // verificando campos obrigatorios
            if (tbnomecategoria.Text != "")
            {
                // fazendo a propriedade receber o conteudo do formulario
                // todos os campos que o usuario pode preencher

                ccategoria.nome = tbnomecategoria.Text;

                if (cbstatus.Checked == true)
                {
                    ccategoria.status = 1;
                }
                else
                {
                    ccategoria.status = 0;
                }

                ccategoria.codigocategoria = Convert.ToInt32(tbcodigo.Text);
                bool aux = ccategoria.Atualizarcategoria();
                if (aux)
                {
                    MessageBox.Show("Categoria " + ccategoria.nome + " Atualizado com Sucesso", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar a Categoria " + ccategoria.nome ,  "Sistema MasterSports", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verificar os campos obrigatorios", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbnomecategoria.BackColor = Color.LemonChiffon;
                cbstatus.BackColor = Color.LemonChiffon;
                tbnomecategoria.Focus();
            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            classcategoria ccategoria = new classcategoria();
            ccategoria.codigocategoria = Convert.ToInt32(tbcodigo.Text);

            if (MessageBox.Show("Deseja realmente excluir a categoria ? operação nao podera ser desfeita apos a exclusão.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool auxx = ccategoria.Excluircategoria();
                if (auxx)
                {
                    MessageBox.Show("Categoria " + tbnomecategoria.Text + " Excluido com sucesso", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(ccategoria.nome + "Erro ao excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
