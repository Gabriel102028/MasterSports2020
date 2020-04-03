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
    public partial class fmrproduto : Form
    {
        // variavel declarada para guardar como o formulario deve ser aberto 
        // para cadastrar ou atualizar ou excluir

        public string tipo;
        
        
        // variaveis declaradas para guardar marca e categoria que ja esta cadastrada no banco, quando vai fazer o update.
        public int marca, categoria;


        public fmrproduto()
        {
            InitializeComponent();
        }
        private void fmrproduto_Load(object sender, EventArgs e)


        {
            //caregar combo de categoria
            classcategoria ccategoria = new classcategoria();
            cbcategoria.DataSource = ccategoria.buscarcategoria(); // executar o metodo criado na classe categoria
            cbcategoria.DisplayMember = "nome"; // exibir na combo
            cbcategoria.ValueMember = "codigocategoria"; // guardar no banco o codigo
            cbcategoria.SelectedIndex = -1; // limpar a combo (nao selecionar nada)

            // carrega a combo de marca
            classmarca cmarca = new classmarca();
            cbmarca.DataSource = cmarca.buscarmarca(); // executa o metodo
            cbmarca.DisplayMember = "nome"; // exibi a Combo
            cbmarca.ValueMember = "codigomarca"; // guarda no banco o codigo 
            cbmarca.SelectedIndex = -1; // limpa a combo 


            // chama a hora 

            tbdatacadastro.Text = DateTime.Now.ToShortDateString();

            // quando abrir o formulario para atualizar ou excluir

            if (tipo == "Atualização")
            {
                labeltitulo.Text = "Editar Produto";
                btcadastro.Enabled = false;
                cbstatus.Enabled = true;
                btlimpar.Enabled = false;
                cbcategoria.SelectedValue = categoria;
                cbmarca.SelectedValue = marca;
            }

            else
                
            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;

            }



        }

    private void btcadastro_Click(object sender, EventArgs e)
        {
            // instanciando a classe produto

            classproduto cproduto = new classproduto();
           

            // verificando os campos obrigatorios

            if (tbnomeproduto.Text != "" && tbpreco.Text != "" && tbquantidade.Text!="" && cbcategoria.Text != "" && cbmarca.Text != "")

            {

                // fazendo a propriedade receber os dados do Formulario 

                cproduto.nome = tbnomeproduto.Text;          
                cproduto.preco = Convert.ToDecimal(tbpreco.Text);
                cproduto.estoque = Convert.ToInt32(tbquantidade.Text);
                cproduto.codigocategoria = Convert.ToInt32(cbcategoria.SelectedValue);
                cproduto.codigomarca = Convert.ToInt32(cbmarca.SelectedValue);

                // criando um metodo para cadastro de produto

                int chm = cproduto.cadastroproduto();


                // Resposta certa =1

                if (chm != 0)
                {
                    MessageBox.Show("Produto" + cproduto.nome + " Cadastrado com Sucesso.", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // botao limpar o Formulario Produto

                    btlimpar_Click(this, new EventArgs());

                }

                // se a resposta for errada

                else

                {
                    MessageBox.Show("Erro ao Realizar o Cadastro", "Sistema Masterports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Verificar os Campos Obrigatorios","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbnomeproduto.BackColor = Color.LemonChiffon;
                tbpreco.BackColor = Color.LemonChiffon;
                cbcategoria.BackColor = Color.LemonChiffon;
                cbmarca.BackColor = Color.LemonChiffon;
                lbestoque.BackColor = Color.LemonChiffon;
                
                tbnomeproduto.Focus();

            }


        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            tbpreco.Clear();
            tbquantidade.Clear();
            tbnomeproduto.Clear();
            cbcategoria.SelectedIndex = -1;
            cbmarca.SelectedIndex = -1;
        
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            // instanciando a classe produto

            classproduto cproduto = new classproduto();


            // verificando os campos obrigatorios

            if (tbnomeproduto.Text != "" && tbpreco.Text != "" && tbquantidade.Text != "" && cbcategoria.Text != "" && cbmarca.Text != "")

            {

                // fazendo a propriedade receber os dados do Formulario 

                cproduto.nome = tbnomeproduto.Text;
                cproduto.preco = Convert.ToDecimal(tbpreco.Text);
                cproduto.estoque = Convert.ToInt32(tbquantidade.Text);
                cproduto.codigocategoria = Convert.ToInt32(cbcategoria.SelectedValue);
                cproduto.codigomarca = Convert.ToInt32(cbmarca.SelectedValue);

                if (cbstatus.Checked == true)
                {
                    cproduto.status = 1;
                }
                else
                {
                    cproduto.status = 0;
                }

                cproduto.codigoproduto = Convert.ToInt32(tbcodigoproduto.Text);
                bool aux = cproduto.Atualizarproduto();
                if (aux)
                {
                    MessageBox.Show("Produto " + cproduto.nome + " atualizado com Sucesso", "Sistema mastersports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // fechar o formulario
                }

                else
                {
                    MessageBox.Show("Erro ao Atualizar o Produto " + cproduto.nome, "Mastersports", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }

            }

            else
            {
                MessageBox.Show("Verificar todos os  Campos Obrigatorios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbnomeproduto.BackColor = Color.LemonChiffon;
                tbpreco.BackColor = Color.LemonChiffon;
                lbestoque.BackColor = Color.LemonChiffon;
                cbcategoria.BackColor = Color.LemonChiffon;
                cbmarca.BackColor = Color.LemonChiffon;
                tbnomeproduto.Focus();

            }

            }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            classproduto cproduto = new classproduto();
            cproduto.codigoproduto = Convert.ToInt32(tbcodigoproduto.Text);

            if (MessageBox.Show("Deseja realmente excluir o produto ?  operação não podera ser desfeita apos a exclusão.", "Atenção",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool au = cproduto.Excluirproduto();
                if (au)
                {
                    MessageBox.Show("Produto " + tbnomeproduto.Text + " Excluido com Sucesso.","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();                        
                }

                else
                {
                    MessageBox.Show(cproduto.nome + "Erro ao Excluir.","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que deseja Sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
