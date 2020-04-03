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
    public partial class fmrfuncionario : Form
    {

        // variavel para receber o formulario

        public string tipo;

        public string estado;

        public fmrfuncionario()
        {
            InitializeComponent();
        }

        private void btcadastro_Click(object sender, EventArgs e)
        {
            // mostra o dia na caixinha de texto 

            tbdata.Text = DateTime.Now.ToShortDateString();

            // instanciando a classe funcionario para usar a propriedade

            classfuncionario cfuncionario = new classfuncionario();

            // verificando condicoes dos Campos Obrigatorios

            if (tbnome.Text != "" && mtbcpf.Text != "" && mtbcelular.Text != "" && mtbtelefone.Text != "" && mtbdatanascimento.Text != "" && rbfemenino.Text != "" && rbmasculino.Text != "" &&
                tbbairro.Text != "" && tbrua.Text != "" && tbnumero.Text != "" && cestado.Text != "" && tbcidade.Text != "" && cbtipoacesso.Text != "" && tblogin.Text != "" && tbsenha.Text != "")

            {
                // fazendo a propriedade receber os dados da caixinha


                cfuncionario.nome = tbnome.Text;
                cfuncionario.cpf = mtbcpf.Text;
                cfuncionario.celular = mtbcelular.Text;
                cfuncionario.telefone = mtbtelefone.Text;
                cfuncionario.datanascimento = Convert.ToDateTime(mtbdatanascimento.Text);
                cfuncionario.bairro = tbbairro.Text;
                cfuncionario.rua = tbrua.Text;
                cfuncionario.estado = cestado.Text;
                cfuncionario.cidade = tbcidade.Text;
                cfuncionario.tipodeacesso = cbtipoacesso.Text;
                cfuncionario.login = tblogin.Text;
                cfuncionario.senha = tbsenha.Text;
                cfuncionario.numerocasa = Convert.ToInt32(tbnumero.Text);

                // conferindo o sexo

                if (rbfemenino.Checked)
                    cfuncionario.sexo = "F";
                else
                    cfuncionario.sexo = "M";

                // verificando os Campos Telefone e Celular

                if (mtbcelular.Text != " -")
                    cfuncionario.celular = mtbcelular.Text;
                else
                    cfuncionario.celular = "";

                if (mtbtelefone.Text != "-")
                    cfuncionario.telefone = mtbtelefone.Text;
                else
                    cfuncionario.telefone = "";

                // metodo para cadastro 

                int chm = cfuncionario.cadastrafuncionario();

                //// caso retornar resposta verdadeira = 1

                if (chm != 0)
                {
                    MessageBox.Show("Funcionario " + cfuncionario.nome + " Cadastrado Com Sucesso", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btlimpar_Click(this, new EventArgs());
                }

                else
                // se a respota retornar = 0
                {
                    MessageBox.Show("Erro ao Realizar o Cadastro", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


            else
            {
                MessageBox.Show("Verificar os Campos Obrigatorios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // pinta as caixinhas da cor amarelada
                tbnome.BackColor = Color.LemonChiffon;
                mtbcpf.BackColor = Color.LemonChiffon;
                mtbdatanascimento.BackColor = Color.LemonChiffon;
                mtbcelular.BackColor = Color.LemonChiffon;
                mtbtelefone.BackColor = Color.LemonChiffon;
                tbbairro.BackColor = Color.LemonChiffon;
                tbnumero.BackColor = Color.LemonChiffon;
                tbrua.BackColor = Color.LemonChiffon;
                tblogin.BackColor = Color.LemonChiffon;
                cbtipoacesso.BackColor = Color.LemonChiffon;
                tbsenha.BackColor = Color.LemonChiffon;
                tbcidade.BackColor = Color.LemonChiffon;
                cbestado.BackColor = Color.LemonChiffon;
                tbnumero.BackColor = Color.LemonChiffon;
                cestado.BackColor = Color.LemonChiffon;
            }
        }


        private void btlimpar_Click(object sender, EventArgs e)
        {
            tbnome.Clear();
            mtbcpf.Clear();
            mtbdatanascimento.Clear();
            mtbcelular.Clear();
            mtbtelefone.Clear();
            tbbairro.Clear();
            tbrua.Clear();
            tbnumero.Clear();
            tbcidade.Clear();
            tblogin.Clear();
            tbsenha.Clear();
            tbnome.Focus();
    
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que Deseja Sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void fmrfuncionario_Load(object sender, EventArgs e)
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

           cbestado.SelectedItem = "SP";

            // definindo o tipo de acesso

            cbtipoacesso.Items.Add("Administrador");
            cbtipoacesso.Items.Add("Usuario");

            // coloca em orden Alfabetica
            cbtipoacesso.Sorted = true;



            ///////////////////  Caregar a Combo Estado em funcionario em Edita //////////////////////////

            //classfuncionario cfuncionario = new classfuncionario();
            //cestado.DataSource = cfuncionario.buscaestado();
            //cestado.DisplayMember = "estado";
            //cestado.ValueMember = "estado";
            //cestado.SelectedIndex = -1;

            // tras o formulario de consulta de funcionario e editar

            if (tipo == "Atualização")
            {
                lbfuncionario.Text = "Editar Funcionario";
                btcadastro.Enabled = false;
                cbstatus.Enabled = true;
                btlimpar.Enabled = false;
                cestado.SelectedItem = estado;

            }
            else
            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;

            }

            // fazendo uma condicao onde o tipo de acesso nao deve ficar vazio
            //if (cbtipoacesso.Text != "")
            //{
            //    MessageBox.Show("O Tipo de Acesso não pode Ficar Vazio","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            // instanciando a classe funcionario para usar as propriedades

            classfuncionario cfuncionario = new classfuncionario();

            // verificando condicoes dos Campos Obrigatorios

            if (tbnome.Text != "" && mtbcpf.Text != "" && mtbcelular.Text != "" && mtbtelefone.Text != "" && mtbdatanascimento.Text != "" && rbfemenino.Text != "" && rbmasculino.Text != "" &&
                tbbairro.Text != "" && tbrua.Text != "" && tbnumero.Text != "" && cestado.Text != "" && tbcidade.Text != "" && cbtipoacesso.Text != "" && tblogin.Text != "" && tbsenha.Text != "")

            {
                // fazendo a propriedade receber os dados da caixinha
                cfuncionario.nome = tbnome.Text;
                cfuncionario.cpf = mtbcpf.Text;
                cfuncionario.celular = mtbcelular.Text;
                cfuncionario.telefone = mtbtelefone.Text;
                cfuncionario.datanascimento = Convert.ToDateTime(mtbdatanascimento.Text);
                cfuncionario.bairro = tbbairro.Text;
                cfuncionario.rua = tbrua.Text;
                cfuncionario.estado = cestado.Text;
                cfuncionario.cidade = tbcidade.Text;
                cfuncionario.tipodeacesso = cbtipoacesso.Text;
                cfuncionario.login = tblogin.Text;
                cfuncionario.senha = tbsenha.Text;
                cfuncionario.numerocasa = Convert.ToInt32(tbnumero.Text);

                // conferindo o sexo

                if (rbfemenino.Checked)
                    cfuncionario.sexo = "F";
                else
                    cfuncionario.sexo = "M";

                // verificando os Campos Telefone e Celular

                if (mtbcelular.Text != " -")
                    cfuncionario.celular = mtbcelular.Text;
                else
                    cfuncionario.celular = "";

                if (mtbtelefone.Text != "-")
                    cfuncionario.telefone = mtbtelefone.Text;
                else
                    cfuncionario.telefone = "";

                // checando o status
                if (cbstatus.Checked == true)
                {
                    cfuncionario.status = 1;
                }
                else
                {
                    cfuncionario.status = 0;
                }


                // a instancia recebe o codigo cliente // auxx cariavel criada para receber a propriedade e metodo

                cfuncionario.codigofuncionario = Convert.ToInt32(tbcodigo.Text);
                bool auxx = cfuncionario.Atualizarfuncionario();
                if (auxx)
                {

                    MessageBox.Show("Funcionario " + cfuncionario.nome + " Atualizado com Sucesso", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar o Funcionario " + cfuncionario.nome , "Sistema MasterSports", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verificar todos os campos obrigatorios", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // pinta as caixinhas da cor amarelada
                tbnome.BackColor = Color.LemonChiffon;
                mtbcpf.BackColor = Color.LemonChiffon;
                mtbdatanascimento.BackColor = Color.LemonChiffon;
                mtbcelular.BackColor = Color.LemonChiffon;
                mtbtelefone.BackColor = Color.LemonChiffon;
                tbbairro.BackColor = Color.LemonChiffon;
                tbnumero.BackColor = Color.LemonChiffon;
                tbrua.BackColor = Color.LemonChiffon;
                tblogin.BackColor = Color.LemonChiffon;
                cbtipoacesso.BackColor = Color.LemonChiffon;
                tbsenha.BackColor = Color.LemonChiffon;
                tbcidade.BackColor = Color.LemonChiffon;
                cbestado.BackColor = Color.LemonChiffon;
                tbnumero.BackColor = Color.LemonChiffon;
                cestado.BackColor = Color.LemonChiffon;
            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {

            classfuncionario cfuncionario = new classfuncionario();
            cfuncionario.codigofuncionario = Convert.ToInt32(tbcodigo.Text);

            if (MessageBox.Show("Deseja realmente excluir o funcionario ? Operação nao podera ser desfeita apos a exclusão", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool auxx = cfuncionario.excluirfuncionario();
                if (auxx)
                {
                    MessageBox.Show("Funcionario " + tbnome.Text + " Excluido com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }

                else
                {
                    MessageBox.Show(cfuncionario.nome + " Erro ao Excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}

