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
    public partial class fmrCliente : Form
    {
        // variavel declarada para guardar como o formulario deve ser aberto
        // para cadastrar ou atualizar ou excluir

       public string tipo;

        public fmrCliente()
        {
            InitializeComponent();
        }

        private void btcadastro_Click(object sender, EventArgs e)
        {
            // instanciando a classe cliente para usar as propriedades

            classcliente ccliente = new classcliente();

            // verificando condicao dos Campos

            if (txtnome.Text != "" && mtxdatanascimento.Text != "" && mtxcpf.Text != "" && mtxtelefone.Text != "" && mtxcelular.Text != "" && txbairro.Text != "" && txrua.Text != "" && txnumero.Text != "" && cestado.Text !="" && tbcidade.Text !="")
            {
                // atribuindo os nome da caixinhas a propriedade que esta no objeto
                ccliente.nome = txtnome.Text;
                ccliente.datanascimento = Convert.ToDateTime(mtxdatanascimento.Text);
                ccliente.cpf = mtxcpf.Text;
                ccliente.telefone = mtxtelefone.Text;
                ccliente.celular = mtxcelular.Text;
                ccliente.bairro = txbairro.Text;
                ccliente.rua = txrua.Text;
                ccliente.estado = cestado.Text;
                ccliente.cidade = tbcidade.Text;
                ccliente.numerocasa = Convert.ToInt32(txnumero.Text);

                // checa o sexo "F" ou "M"

                if (rbfemenino.Checked)
                    ccliente.sexo = "F";
                else
                    ccliente.sexo = "M";

                // checa os campos celular e telefone

                if (mtxcelular.Text != "() -")
                    ccliente.celular = tbcelular.Text;
                else
                    ccliente.celular = "";

                if (mtxtelefone.Text != "() -")
                    ccliente.telefone = mtxtelefone.Text;
                else
                    ccliente.telefone = "";



                    // metodo para cadastro de cliente

                    int chm = ccliente.cadastracliente();

                // se a resposta retornar = 1

                if (chm != 0)
                {
                    MessageBox.Show("Cliente " + ccliente.nome + " Cadastrado Com Sucesso ", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btlimpar_Click(this, new EventArgs());
                }

                else

                // se a resposta for retornar = 0
                {
                    MessageBox.Show("Erro ao Realizar o Cadastro", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Verificar os Campos Obrigatorios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.BackColor = Color.LemonChiffon;
                mtxdatanascimento.BackColor = Color.LemonChiffon;
                mtxcpf.BackColor = Color.LemonChiffon;
                mtxtelefone.BackColor = Color.LemonChiffon;
                mtxcelular.BackColor = Color.LemonChiffon;
                txbairro.BackColor = Color.LemonChiffon;
                txrua.BackColor = Color.LemonChiffon;
                txnumero.BackColor = Color.LemonChiffon;
                tbcidade.BackColor = Color.LemonChiffon;
                tbnome.Focus();
                }


        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            mtxdatanascimento.Clear();
            mtxcpf.Clear();
            mtxtelefone.Clear();
            mtxcelular.Clear();
            txbairro.Clear();
            tbcidade.Clear();
            txrua.Clear();
            txnumero.Clear();
            tbnome.Focus();

        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que Deseja Sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fmrCliente_Load(object sender, EventArgs e)
        {

            // carregar a combo estado

            cestado.Items.Add("AC");
            cestado.Items.Add("AL");
            cestado.Items.Add("AP");
            cestado.Items.Add("AM");
            cestado.Items.Add("BA");
            cestado.Items.Add("CE");
            cestado.Items.Add("DF");
            cestado.Items.Add("ES");
            cestado.Items.Add("GO");
            cestado.Items.Add("MA");
            cestado.Items.Add("MT");
            cestado.Items.Add("MS");
            cestado.Items.Add("MG");
            cestado.Items.Add("PA");
            cestado.Items.Add("PB");
            cestado.Items.Add("PR");
            cestado.Items.Add("PE");
            cestado.Items.Add("PI");
            cestado.Items.Add("RJ");
            cestado.Items.Add("RN");
            cestado.Items.Add("RS");
            cestado.Items.Add("RO");
            cestado.Items.Add("RR");
            cestado.Items.Add("SC");
            cestado.Items.Add("SP");
            cestado.Items.Add("SE");
            cestado.Items.Add("TO");

            // coloca os Estados em orden Alfabetica
            cbestado.Sorted = true;

            // deixar um estado padrao

            cbestado.SelectedItem = "-1";

            if (tipo == "Atualização")
            {
                cdcliente.Text = "Editar Cliente";
                btcadastro.Enabled = false;
                cbstatuss.Enabled = true;
                btlimpar.Enabled = false;

            }
            else
            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;
            }

        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            // instanciando a classe cliente para usar as propriedades

            classcliente ccliente = new classcliente();

            // verificando condicao dos Campos

            if (txtnome.Text != "" && mtxdatanascimento.Text != "" && mtxcpf.Text != "" && mtxtelefone.Text != "" && mtxcelular.Text != "" && txbairro.Text != "" && txrua.Text != "" && txnumero.Text != "" && cestado.Text != "" && tbcidade.Text != "")
            {
                // atribuindo os nome da caixinhas a propriedade que esta no objeto

                ccliente.nome = txtnome.Text;
                ccliente.datanascimento = Convert.ToDateTime(mtxdatanascimento.Text);
                ccliente.cpf = mtxcpf.Text;
                ccliente.telefone = mtxtelefone.Text;
                ccliente.celular = mtxcelular.Text;
                ccliente.bairro = txbairro.Text;
                ccliente.rua = txrua.Text;
                ccliente.estado = cestado.Text;
                ccliente.cidade = tbcidade.Text;
                ccliente.numerocasa = Convert.ToInt32(txnumero.Text);


                // checando o sexo

                if (rbfemenino.Checked)
                    ccliente.sexo = "F";
                else
                    ccliente.sexo = "M";


                // checando o status

                if (cbstatuss.Checked == true)
                {
                    ccliente.status = 1;
                }
                else
                {
                    ccliente.status = 0;
                }


                // a instancia recebe o codigo cliente // aux variavel criada recebe a propriedade e o metodo de atualizar
                ccliente.codigocliente = Convert.ToInt32(txtcodigo.Text);
                bool aux = ccliente.Atualizarcliente();
                if (aux)
                {
                    MessageBox.Show("Cliente " + ccliente.nome + " Atualizado com Sucesso", "Sistema mastersports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar o Cliente" + ccliente.nome , "Sistema Mastersports", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("Verificar todos os campos Obrigatorios", "Sistema mastersports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnome.BackColor = Color.LemonChiffon;
                mtxdatanascimento.BackColor = Color.LemonChiffon;
                mtxcpf.BackColor = Color.LemonChiffon;
                mtxtelefone.BackColor = Color.LemonChiffon;
                mtxcelular.BackColor = Color.LemonChiffon;
                txbairro.BackColor = Color.LemonChiffon;
                txnumero.BackColor = Color.LemonChiffon;
                txrua.BackColor = Color.LemonChiffon;
                cestado.BackColor = Color.LemonChiffon;


            }

            }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            classcliente ccliente = new classcliente();
            ccliente.codigocliente = Convert.ToInt32(txtcodigo.Text);


            if (MessageBox.Show("Deseja realmente excluir o cliente ? operação nao podera ser desfeita apos a exclusão.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool aux = ccliente.Ecluircliente();
                if (aux)
                {

                    MessageBox.Show("Cliente " + txtnome.Text + "Excluido com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }

                else
                {
                    MessageBox.Show(ccliente.nome + "Erro ao Excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }
    }
}
