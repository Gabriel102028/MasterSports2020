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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        decimal resultado, quantidade, preco; // variaveis criadas 


        // lista item

        private List<classitem> listaitem = new List<classitem>();

        // variavel para calcular o valor total da venda
        private decimal vendatotal = 0;


        // variavel para contar quantos produtos foram adicionados na lista
        private int intesvenda = 0;


        private void frmVenda_Load(object sender, EventArgs e)
        {
            classfuncionario cfuncionario = new classfuncionario();
            cbFuncionario.DataSource = cfuncionario.buscafuncionario(); // executa o metodo na classe
            cbFuncionario.DisplayMember = "nome"; // exibi a Combo as cidades
            cbFuncionario.ValueMember = "codigofuncionario"; // guarda no banco o nome 
            cbFuncionario.SelectedIndex = -1; // limpa a combo 


            cbFormaPagamento.Items.Add("Dinheiro");
            cbFormaPagamento.Items.Add("Débito");
            cbFormaPagamento.Items.Add("Crédito");

            //COLOCAR OS ITENS EM ORDEM
            cbFormaPagamento.Sorted = true;

            //DEIXAR DINHEIRO SELECIONADO
            cbFormaPagamento.SelectedItem = "Dinheiro";


    }

        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesqCliente.Text))
            {
                MessageBox.Show("Favor Informar um Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                classcliente ccliente = new classcliente();
                dgvCliente.DataSource = ccliente.buscacliente(txtPesqCliente.Text);
            }

        }


        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            classproduto cproduto = new classproduto();
            bool aux = cproduto.buscaprodutoid((int)dgvProduto.SelectedRows[0].Cells[0].Value);
            if (aux)
            {
                txtProduto.Text = cproduto.nome;
                txtQtdeEstoque.Text = cproduto.estoque.ToString();
                txtValor.Text = cproduto.preco.ToString("n2");
                txtQtde.Text = "01";
                txtQtde_TextChanged(this, new EventArgs());
                txtQtde.Select();
            }
        }

        private void txtValorDesconto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValorDesconto.Text))
            {
                decimal valor = Convert.ToDecimal(txtValorTotal.Text);
                txtValorTotal.Text = valor.ToString("n2"); // n2 deixa com duas casa depois da virgula
                txtTotalDesconto.Text = "0,00";
            }
            else
            {
                decimal valor = Convert.ToDecimal(txtValorTotal.Text);
                decimal desc = Convert.ToDecimal(txtValorDesconto.Text);
                txtTotalVenda.Text = (valor * (1 - (desc / 100))).ToString("n2");
                txtTotalDesconto.Text = (valor - (valor * (1 - (desc / 100)))).ToString("n2");

            }
                    
                    
        }

        // Adicionar a drid que vai receber os proditor que serao adicionados na lista
        private void AtualizarGrid()
        {
            // adiciona na grid a partir da lista

            classproduto cproduto = new classproduto();
            DataTable dt = new DataTable();


            // criar as colunas na grid
            dt.Columns.Add(new DataColumn("codigo"));
            dt.Columns.Add(new DataColumn("produto"));
            dt.Columns.Add(new DataColumn("Quantidade"));
            dt.Columns.Add(new DataColumn("Preço"));

            // adicionar as linhas da grid
            foreach (classitem item in listaitem)
            {
                dt.Rows.Add(item.codigoproduto, cproduto.buscanomeproduto(item.codigoproduto),item.qproduto, item.preco);
                dt.AcceptChanges();
            }
            dgvItens.DataSource = dt;


    }

        private void btAddProduto_Click(object sender, EventArgs e)
        {

            classitem citenvenda = new classitem();
            decimal valortotal = 0;

            if (string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Não há produto para ser inserido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                // somando os itens da lista para o vlaor total
                valortotal = Convert.ToDecimal(txtValor.Text);
                vendatotal = vendatotal + valortotal;
                txtValorTotal.Text = vendatotal.ToString("");


                // contar os itens da venda
                intesvenda++;

                // CONTROLE DAS INFORMACOES DOS ITENS DA VENDA

                citenvenda.preco = Convert.ToDecimal(txtValor.Text);
                citenvenda.codigoproduto = (int)(dgvProduto.SelectedRows[0].Cells[0].Value);
                citenvenda.qproduto = Convert.ToInt32(txtQtde.Text);

                // adiciona produto na lista 
                listaitem.Add(citenvenda);


                // pegar da lista a quantidade de items
                txtQtdeItens.Text = citenvenda.ToString();
                txtQtdeItens.Text = listaitem.Count.ToString();


                //atualiza grib
                AtualizarGrid();

                // limpar os campos apos adicionar o item da lista

                txtTotalDesconto.Text = "0";
                txtValorDesconto_TextChanged(this, new EventArgs());
                txtValorDesconto.Select();
                txtProduto.Clear();
                txtQtde.Text = "01";
                txtQtdeEstoque.Clear();
                txtValor.Clear();
                txtTotal.Clear();

            }

        }

        private void btbuscaproduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesqProduto.Text))
            {
                MessageBox.Show("Favor Informar um Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                classproduto cproduto = new classproduto();
                dgvProduto.DataSource = cproduto.buscaproduto(txtPesqProduto.Text);
            }

        }

        private void atualzaestoque(int qtde, int cod)
        {
            classproduto cproduto = new classproduto();
            cproduto.buscaprodutoid(cod);
            int estoque = cproduto.estoque;
            cproduto.atualizaestoque(estoque - qtde, cod);

        }


        private void btFechaVenda_Click(object sender, EventArgs e)
        {
            if (cbFuncionario.Text != "" && dgvCliente.DataSource != null && txtPesqProduto.Text != "" && dgvItens.DataSource != null && cbFormaPagamento.Text != "")
            {
                classvendacompra cvenda = new classvendacompra();
                cvenda.codigocliente = (int)(dgvCliente.SelectedRows[0].Cells[0].Value);
                cvenda.codigofuncionario = (int)(cbFuncionario.SelectedValue);
                cvenda.qlinhas = Convert.ToInt32(txtQtdeItens.Text);
                cvenda.valortotal = Convert.ToDecimal(txtTotalVenda.Text);
                cvenda.observasao = txtobservacao.Text;
                cvenda.formapagamento = cbFormaPagamento.SelectedItem.ToString();
                cvenda.desconto = Convert.ToDecimal(txtTotalDesconto.Text);


                bool sux = cvenda.cadastravenda();

                if (sux)
                {
                    sux = false;

                    foreach (classitem item in listaitem)
                    {
                        item.codigovenda = cvenda.codigovenda; /// pk venda e fk item 
                        sux = item.cadastraitemvenda();

                        // baixa no estoque 

                        atualzaestoque(item.qproduto, item.codigoproduto);

                    }

                    if (sux)
                    {
                        MessageBox.Show("Venda Cadastrada", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Erro ao Realizar a Venda", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos necessarios", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }             

          }

        private void btRemoveProduto_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count > 0)
            {
                // subtrair o valor total para ter o valor apor substituir o item da lista
                decimal valor = Convert.ToDecimal(dgvItens.SelectedRows[0].Cells[3].Value);
                vendatotal = vendatotal - valor;
                txtTotalVenda.Text = vendatotal.ToString("n2");
                txtTotalVenda.Text = vendatotal.ToString("n2");

                // remover da lista e atualiza a grid

                listaitem.RemoveAt(dgvItens.CurrentRow.Index);
                AtualizarGrid();
                txtQtdeItens.Text = listaitem.Count.ToString();
                txtProduto.Clear();
                txtQtdeEstoque.Clear();
                txtValorDesconto_TextChanged(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Não há itens para ser removido.", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            quantidade = Convert.ToUInt32(txtQtde.Text);
            preco = Convert.ToDecimal(txtValor.Text);
            resultado = quantidade * preco;
            txtTotal.Text = Convert.ToString(resultado);
            
        }

        // limpar campos do formulario venda, quando a venda finalizada
        private void limpa()
        {
            listaitem.Clear();
            AtualizarGrid();
            dgvItens.Refresh();

            txtValorDesconto.Text = "";
            txtValorDesconto.Text = "0";
            txtTotalVenda.Text = "0";
            txtQtdeItens.Text = "0";

            txtValorTotal.Clear();
            cbFuncionario.SelectedIndex = -1;
            cbFormaPagamento.SelectedIndex = -1;
            dgvCliente.DataSource = null;
            txtobservacao.Clear();
            txtPesqProduto.Clear();
            dgvProduto.DataSource = null;
            txtPesqCliente.Clear();
            vendatotal = 0;            
        }            
       
    }
}
