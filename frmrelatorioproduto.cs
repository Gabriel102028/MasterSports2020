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
    public partial class frmrelatorioproduto : Form
    {
        public frmrelatorioproduto()
        {
            InitializeComponent();
        }

        private void frmrelatorioproduto_Load(object sender, EventArgs e)
        {

            // mostra as opçoes de pesquisa

            cbopcoes.Items.Add("Selecione o tipo de pesquisa");
            cbopcoes.Items.Add("Nome");
            cbopcoes.Items.Add("Categoria");
            cbopcoes.Items.Add("Marca");
            cbopcoes.Items.Add("Preço");
            cbopcoes.Items.Add("Status");
            cbopcoes.SelectedIndex = 0;
            rbinicio.Checked = true;


            // combo marca 

            classmarca cmarca = new classmarca();
            cbmarca.DataSource = cmarca.buscarmarca(); // executa o metodo
            cbmarca.DisplayMember = "nome"; // exibi a Combo
            cbmarca.ValueMember = "codigomarca"; // guarda no banco o codigo 
            cbmarca.SelectedIndex = -1; // limpa a combo 

            // combo categoria

            classcategoria ccategoria = new classcategoria();
            cbcategoria.DataSource = ccategoria.buscarcategoria(); // executa o metodo
            cbcategoria.DisplayMember = "nome"; // exibi a Combo
            cbcategoria.ValueMember = "codigocategoria"; // guarda no banco o codigo 
            cbcategoria.SelectedIndex = -1; // limpa a combo 



            this.reportViewerproduto.RefreshReport();
        }

        private void cbopcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbopcoes.SelectedIndex == 0 ) // tipo de pesquisa
            {
                gbtipoconsulta.Enabled = false;
                txpesquisa.Enabled = false;
                gbstatus.Enabled = false;
                gbvalor.Enabled = false;
                cbcategoria.Enabled = false;
                cbmarca.Enabled = false;
                gbpesquisa.Enabled = false;

            }

            if (cbopcoes.SelectedIndex == 1) // nome
            {
                gbtipoconsulta.Enabled = true;
                txpesquisa.Enabled = true;
                gbstatus.Enabled = false;
                gbvalor.Enabled = false;
                cbcategoria.Enabled = false;
                cbmarca.Enabled = false;

            }
            if (cbopcoes.SelectedIndex == 2) // categoria
            {
                gbtipoconsulta.Enabled = false;
                txpesquisa.Enabled = false;
                gbstatus.Enabled = false;
                gbvalor.Enabled = false;
                cbcategoria.Enabled = true;
                cbmarca.Enabled = false;
                gbpesquisa.Enabled = true;
            }

            if (cbopcoes.SelectedIndex == 3) // marca
            {
                gbtipoconsulta.Enabled = false;
                txpesquisa.Enabled = false;
                gbstatus.Enabled = false;
                gbvalor.Enabled = false;
                cbcategoria.Enabled = false;
                cbmarca.Enabled = true;
                gbpesquisa.Enabled = true;
            }

            if (cbopcoes.SelectedIndex == 4) // preço
            {
                gbtipoconsulta.Enabled = false;
                txpesquisa.Enabled = false;
                gbstatus.Enabled = false;
                gbvalor.Enabled = true;
                cbcategoria.Enabled = false;
                cbmarca.Enabled = false;
            }

            if (cbopcoes.SelectedIndex == 5) // status
            {
                gbtipoconsulta.Enabled = false;
                txpesquisa.Enabled = false;
                gbvalor.Enabled = false;
                gbstatus.Enabled = true;
                cbcategoria.Enabled = false;
                cbmarca.Enabled = false;

            }
        }

        //private void btsair_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Tem Certeza que Deseja Sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        this.Close();
            //}
      //  }

        private void btgerarelatorio_Click(object sender, EventArgs e)
        {
            //variaveis
            classproduto cproduto = new classproduto();
            string pesquisa = cbopcoes.SelectedItem.ToString();
            switch (pesquisa)
            {
                case "Nome":
                    if (txpesquisa.Text != "")
                    {
                        if (rbinicio.Checked == true)
                        {
                            classprodutoBindingSource.DataSource = cproduto.relprodutoinicio(cproduto.nome);
                            this.reportViewerproduto.RefreshReport();
                        }
                    
                    else if (rbcontem.Checked)
                    {
                        classprodutoBindingSource.DataSource = cproduto.relprodutocontem(cproduto.nome);
                        this.reportViewerproduto.RefreshReport();
                    }
                    else

                     MessageBox.Show("Favor Escolher uma Nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Categoria":
                    if (cbcategoria.Text != "")
                    {
                        classprodutoBindingSource.DataSource = cproduto.buscaprodutocategoria(Convert.ToInt32(cbcategoria.SelectedValue));
                        this.reportViewerproduto.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor Escolha uma Categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    break;

                case "Marca":
                    if (cbmarca.Text != "")
                    {
                        classprodutoBindingSource.DataSource = cproduto.buscaprodutomarca(Convert.ToInt32(cbmarca.SelectedValue));
                        this.reportViewerproduto.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor Escolha uma Marca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;

                case "Preco":
                    if (txprecoinicial.Text != "" && txtprecofinal.Text != "")
                    {
                        classprodutoBindingSource.DataSource = cproduto.buscaprecoproduto(Convert.ToInt32(txprecoinicial.Text), Convert.ToInt32(txtprecofinal.Text));
                        this.reportViewerproduto.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher uma Preço", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    break;
                case "Status":
                    if (rbativo.Checked == true)
                    {
                        cproduto.status = 1;
                        classprodutoBindingSource.DataSource = cproduto.buscaprodutostatus(cproduto.status);
                        this.reportViewerproduto.RefreshReport();
                    }
                    else if (rbinativo.Checked)
                    {
                        cproduto.status = 0;
                        classprodutoBindingSource.DataSource = cproduto.buscaprodutostatus(cproduto.status);
                        this.reportViewerproduto.RefreshReport();
                    }
                    else
                        MessageBox.Show("Favor Escolher o Status", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void btsair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que Deseja Sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
 }