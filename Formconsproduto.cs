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
    public partial class Formconsproduto : Form
    {
        public Formconsproduto()
        {
            InitializeComponent();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que Deseja Sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Formconsproduto_Load(object sender, EventArgs e)
        {
            // caregar a combo com as opcoes de pesquisa

            cbopcoes.Items.Add("Nome");
            cbopcoes.Items.Add("Categoria");
            cbopcoes.Items.Add("Marca");
            cbopcoes.Items.Add("Preço");
            cbopcoes.Items.Add("Status");
            cbopcoes.SelectedIndex = 0;
            rbinicio.Checked = true;

            //caregar a combo marca


            classmarca cmarca = new classmarca();
            cbmarca.DataSource = cmarca.buscarmarca(); // executa o metodo criado na classe marca
            cbmarca.DisplayMember = "nome"; // exibi a Combo
            cbmarca.ValueMember = "codigomarca"; // guarda no banco o codigo 
            cbmarca.SelectedIndex = -1; // limpa a combo 

            //caregar combo de categoria

            classcategoria ccategoria = new classcategoria();
            cbcategoria.DataSource = ccategoria.buscarcategoria(); // executar o metodo criado na classe categoria
            cbcategoria.DisplayMember = "nome"; // exibir na combo
            cbcategoria.ValueMember = "codigocategoria"; // guardar no banco o codigo
            cbcategoria.SelectedIndex = -1; // limpar a combo (nao selecionar nada)

        }



        /// de acordo com a aescolha na combo habilitar/desabilitar objetos
        /// 
        private void cbopcoes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbopcoes.SelectedIndex == 0)  ///Nome
            {
                txconsulta.Enabled = true;
                gbpesquisa.Enabled = true;
                gbvalores.Enabled = false;
                gbstatus.Enabled = false;
                cbcategoria.Enabled = false;
                cbmarca.Enabled = false;
                txconsulta.Focus();
            }

            if (cbopcoes.SelectedIndex == 1) // categoria
            {
                txconsulta.Enabled = false;
                gbpesquisa.Enabled = false;
                gbvalores.Enabled = false;
                gbstatus.Enabled = false;
                cbcategoria.Enabled = true;
                cbmarca.Enabled = false;


            }
            if (cbopcoes.SelectedIndex == 2) //marca
            {
                txconsulta.Enabled = false;
                gbpesquisa.Enabled = false;
                gbvalores.Enabled = false;
                gbstatus.Enabled = false;
                cbcategoria.Enabled = false;
                cbmarca.Enabled = true;

            }
            if (cbopcoes.SelectedIndex == 3) // preco
            {
                txconsulta.Enabled = false;
                gbpesquisa.Enabled = false;
                gbvalores.Enabled = true;
                gbstatus.Enabled = false;
                cbcategoria.Enabled = false;
                cbmarca.Enabled = false;


            }

            if (cbopcoes.SelectedIndex == 4) // status
            {
                txconsulta.Enabled = false;
                gbpesquisa.Enabled = false;
                gbvalores.Enabled = false;
                gbstatus.Enabled = true;
                cbcategoria.Enabled = false;
                cbmarca.Enabled = false;

            }
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {
            string consultaproduto = cbopcoes.SelectedItem.ToString();
            classproduto cproduto = new classproduto();
            switch (consultaproduto)
            {
                case "Nome":

                    // verificar se algo foi Digitado no text de pesquisa

                    if (txconsulta.Text != "")
                    {
                        // inicio
                        if (rbinicio.Checked)
                        {
                            cproduto.nome = txconsulta.Text;
                            dataGridViewproduto.DataSource = cproduto.buscarprodutoinicio();
                        }

                    }
                    // contem
                    else if (rbcontem.Checked)
                    {
                        cproduto.nome = txconsulta.Text;
                        dataGridViewproduto.DataSource = cproduto.buscaprodutocontem();
                    }

                    else

                    {
                        MessageBox.Show("Favor Digitar um Nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;


                case "Categoria":

                    if (cbcategoria.Text != "")
                    {
                        cproduto.codigocategoria = Convert.ToInt32(cbcategoria.SelectedValue);
                        dataGridViewproduto.DataSource = cproduto.buscarcategoria();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher uma Categoia.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                        break;

                case "Marca":

                    if (cbmarca.Text != "")
                    {
                        cproduto.codigomarca = Convert.ToInt32(cbmarca.SelectedValue);
                        dataGridViewproduto.DataSource = cproduto.buscarmarca();
                    }
                    else
                    {
                        MessageBox.Show("Favor Escolher uma Marca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                        break;


                case "Preço":

                    if (txprecoinicial.Text != "" && txprecofinal.Text != "")

                    {

                        decimal precoinicial, precofinal;
                        precoinicial = Convert.ToDecimal(txprecoinicial.Text);
                        precofinal = Convert.ToDecimal(txprecofinal.Text);
                        dataGridViewproduto.DataSource = cproduto.buscaprecoproduto(precoinicial, precofinal);
                        txprecoinicial.Text = "";
                        txprecofinal.Text = "";
                    }
                    else

                    {
                        MessageBox.Show("Favor Digitar um preço inicial e final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;

                case "Status":

                    if (rbativo.Checked == true)
                    {
                        cproduto.status = 1;
                        dataGridViewproduto.DataSource = cproduto.buscaprodutostatusativo();
                    }

                    else
                    if (rbinativo.Checked)
                    {
                        cproduto.status = 0;
                        dataGridViewproduto.DataSource = cproduto.buscaprodutostatusativo();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um Status", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                        break;
            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewproduto.SelectedCells.Count > 0)
            {
                classproduto cproduto = new classproduto();
                cproduto.retornarproduto(Convert.ToInt32(dataGridViewproduto.SelectedRows[0].Cells[0].Value));
                fmrproduto formproduto = new fmrproduto();

                // nao esquecer de mudar a prorpiedade para public dos objetos do formulario do produto

                formproduto.tbcodigoproduto.Text = cproduto.codigoproduto.ToString();
                formproduto.tbdatacadastro.Text = cproduto.datacadastro.ToString();
                formproduto.tbnomeproduto.Text = cproduto.nome;
                formproduto.tbquantidade.Text = cproduto.estoque.ToString();
                formproduto.tbpreco.Text = cproduto.preco.ToString();
                formproduto.marca = cproduto.codigomarca; // passar a variavel declarada no formulario de produto
                formproduto.categoria = cproduto.codigocategoria; // passar a variavel declarada no formulario de produto

                if (cproduto.status == 1)
                {
                    formproduto.cbstatus.Checked = true;
                }
                else
                {
                    formproduto.cbstatus.Checked = false;
                }
                // mandar a informacao de update

                formproduto.tipo = "Atualização";
                // nao repetir que outro formulario seja aberto e depois de atualizar fecha o formulario
                formproduto.ShowDialog();
                // chamar o metodo de pesquisa

                btpesquisar_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Selecione o produto a ser Atualizado !", "Sistema Mastersports",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
                           
            }
                  
        }
    }
}
