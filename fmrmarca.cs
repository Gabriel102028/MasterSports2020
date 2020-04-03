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
    public partial class fmrmarca : Form
    {
        public string tipo;

        public fmrmarca()
        {
            InitializeComponent();
        }

        private void fmrmarca_Load(object sender, EventArgs e)
        {
            tbdata.Text = DateTime.Now.ToShortDateString();


            if (tipo == "Atualização")
            {
                blcadastromarca.Text = "Editar Marca";
                btcadastro.Enabled = false;
                bstatus.Enabled = true;
                btlimpar.Enabled = false;
            }
            else
            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;
            }

        }

        private void btcadastro_Click(object sender, EventArgs e)

        {

            // Instanciando a Classe Marca 

            classmarca cmarca = new classmarca();

            // verificando os Campos Obrigatorios

            if (tbnomemarca.Text != "")
            {
                cmarca.nome = (tbnomemarca.Text);

                /// criando metodo para cadastro marca

                int chm = cmarca.cadastromarca();

                // se a resposta for retornar = 1

                if (chm != 0)
                {
                    MessageBox.Show("Marca " + cmarca.nome + " Cadastrada com Sucesso", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btlimpar_Click(this, new EventArgs());
                }

                else
                {
                    MessageBox.Show("Erro ao Realizar o Cadastro", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            else
            {
                MessageBox.Show("Verificar os Campos Obrigatorios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbnomemarca.BackColor = Color.LemonChiffon;
            }

        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            tbnomemarca.Clear();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que Deseja Sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            classmarca ccmarca = new classmarca();

            // campos obrigatorios
            if (tbnomemarca.Text != "")
            {

                ccmarca.nome = tbnomemarca.Text;

                if (bstatus.Checked == true)
                {
                    ccmarca.status = 1;
                }
                else
                {
                    ccmarca.status = 0;
                }

                ccmarca.codigomarca = Convert.ToInt32(tbcodigo.Text);
                bool aux = ccmarca.Atualizarmarca();
                if (aux)
                {
                    MessageBox.Show("Marca " + ccmarca.nome + " Atualizada com Sucesso", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Erro ao Atualizar a Marca " + ccmarca.nome, "Sistema MasterSports", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verificar os campos obrigatorios", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbnomemarca.BackColor = Color.LemonChiffon;
                bstatus.BackColor = Color.LemonChiffon;
                tbnomemarca.Focus();
            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            classmarca ccmarca = new classmarca();
            ccmarca.codigomarca = Convert.ToInt32(tbcodigo.Text);

            if(MessageBox.Show("Desea realmente excluir a marca ? Operação não poderá ser desfeita apos a exclusão.", "Atenção", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool aux = ccmarca.Excluirmarca();
                if (aux)
                {
                    MessageBox.Show("Marca " + tbnomemarca.Text + " Excluido com Sucesso", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(ccmarca.nome + "Erro ao excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
 }

