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
    public partial class Formconsfuncionario : Form
    {
        public Formconsfuncionario()
        {
            InitializeComponent();
        }

        private void Formconsfuncionario_Load(object sender, EventArgs e)
        {
            // caregar a combo para mostar o tipo de pesquisa

            cbpesquisa.Items.Add("Nome");
            cbpesquisa.Items.Add("CPF");
            cbpesquisa.Items.Add("Sexo");
            cbpesquisa.Items.Add("Status");
            cbpesquisa.SelectedIndex = 0;
            rbinicio.Checked = true;
                          


            // carregar a combo de nivel

            //classfuncionario cfuncioanrio = new classfuncionario();
            //cbnivel.DataSource = cfuncioanrio.buscatipodeacesso();
            //cbnivel.DisplayMember = "tipodeacesso";
            //cbnivel.ValueMember = "tipodeacesso";
            //cbnivel.SelectedIndex = -1;

        }

        private void cbpesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

            // de acordo com a configuracao escolhida ?? retorna

            if (cbpesquisa.SelectedIndex == 0) // Nome
            {
                txtnome.Enabled = true;
                gbcpf.Enabled = false;
                gbsexo.Enabled = false;
                gbtipopesquisa.Enabled = true;
                gbstatus.Enabled = false;
            }
            if (cbpesquisa.SelectedIndex == 1) // CPF
            {
                txtnome.Enabled = false;
                gbcpf.Enabled = true;
                gbsexo.Enabled = false;
                gbtipopesquisa.Enabled = false;
                gbstatus.Enabled = false;
            }
            if (cbpesquisa.SelectedIndex == 2) //sexo
            {
                txtnome.Enabled = false;
                gbcpf.Enabled = false;
                gbsexo.Enabled = true;
                gbtipopesquisa.Enabled = false;
                gbstatus.Enabled = false;
            }
            if (cbpesquisa.SelectedIndex == 3) //status
            {
                txtnome.Enabled = false;
                gbcpf.Enabled = false;
                gbsexo.Enabled = false;
                gbtipopesquisa.Enabled = false;
                gbstatus.Enabled = true;
            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewconfunci.SelectedCells.Count > 0)
            {
                classfuncionario cfuncionario = new classfuncionario();
                cfuncionario.retornafuncionario(Convert.ToInt32(dataGridViewconfunci.SelectedRows[0].Cells[0].Value));
                fmrfuncionario formfuncionario = new fmrfuncionario();

                formfuncionario.tbcodigo.Text = cfuncionario.codigofuncionario.ToString();
                formfuncionario.tbnome.Text = cfuncionario.nome.ToString();
                formfuncionario.mtbcpf.Text = cfuncionario.cpf.ToString();
                formfuncionario.mtbcelular.Text = cfuncionario.celular.ToString();
                formfuncionario.mtbtelefone.Text = cfuncionario.telefone.ToString();
                formfuncionario.mtbdatanascimento.Text = cfuncionario.datanascimento.ToString();
                formfuncionario.tbbairro.Text = cfuncionario.bairro.ToString();
                formfuncionario.tbrua.Text = cfuncionario.rua.ToString();
                //  formfuncionario.cestado.SelectedIndex = formfuncionario.cestado.FindStringExact(cfuncionario.estado);
                formfuncionario.estado = cfuncionario.estado;
                formfuncionario.tbcidade.Text = cfuncionario.cidade.ToString();
                formfuncionario.cbtipoacesso.Text = cfuncionario.tipodeacesso.ToString();
                formfuncionario.tblogin.Text = cfuncionario.login.ToString();
                formfuncionario.tbsenha.Text = cfuncionario.senha.ToString();
                formfuncionario.tbnumero.Text = cfuncionario.numerocasa.ToString();
             
                
                // verificando o status

                if (cfuncionario.status == 1)
                {
                    formfuncionario.cbstatus.Checked = true;
                }

                else
                {
                    formfuncionario.cbstatus.Checked = false;
                }
                

                // conferindo o sexo

                if (cfuncionario.sexo == "F")
                {

                    formfuncionario.rbfemenino.Checked = true;
                    formfuncionario.rbmasculino.Checked = false;
                }
                else
                if (cfuncionario.sexo == "M")
                {
                    formfuncionario.rbfemenino.Checked = false;
                    formfuncionario.rbmasculino.Checked = true;
                }
                    cfuncionario.sexo = "M";


                ////  verificando os Campos Telefone e Celular

                //if (mtbcelular.Text != " -")
                //    cfuncionario.celular = mtbcelular.Text;
                //else
                //    cfuncionario.celular = "";

                //if (mtbtelefone.Text != "-")
                //    cfuncionario.telefone = mtbtelefone.Text;
                //else
                //    cfuncionario.telefone = "";


                // mandar a informacao update
                formfuncionario.tipo = "Atualização";

                // nao repetir que outro formulario seja aberto e depois de atualizar fechar o form
                formfuncionario.ShowDialog();

               btpesquisar_Click (this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Selecionar o produto a ser Atualizado !", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {
            // criando variavel para guadar as informacoes carregadas

            string consulta = cbpesquisa.SelectedItem.ToString();
            classfuncionario consltafunc = new classfuncionario();
            switch (consulta)
            {
                case "Nome":
                    // verificar se algo foi digitado
                    if (txtnome.Text != "")

                    // inicio
                    {
                        if (rbinicio.Checked)
                        {
                            consltafunc.nome = txtnome.Text;
                            dataGridViewconfunci.DataSource = consltafunc.buscaconsinicio();
                        }
                    }
                    else if (rbcontem.Checked)
                    {
                        consltafunc.nome = txtnome.Text;
                        dataGridViewconfunci.DataSource = consltafunc.buscaconscontem();
                    }
                    
                    else
                    {
                        MessageBox.Show("Digite um Nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                     break;
                case "CPF":
                    //verificar se algo oi digitado

                    // cpf copntem
                    if (txtcpf.Text !="")
                    {
                        consltafunc.cpf = txtcpf.Text;
                        dataGridViewconfunci.DataSource = consltafunc.buscacpfcontem();
                    }
                    else
                    {
                        MessageBox.Show("Favor digita um cpf", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Sexo":

                    if(rbmasculino.Checked == true)
                    {
                        consltafunc.sexo = "M";
                        dataGridViewconfunci.DataSource = consltafunc.buscafuncsexoM();
                    }
                    else
                    if (rbfemenino.Checked)
                    {
                        consltafunc.sexo = "F";
                        dataGridViewconfunci.DataSource = consltafunc.buscafunsexoF();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um sexo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Status":
                    if(rbativo.Checked == true)
                    {
                        consltafunc.status = 1;
                        dataGridViewconfunci.DataSource = consltafunc.buscafunstatusativo();
                    }
                    else
                    if(rbinativo.Checked)
                    {
                        consltafunc.status = 0;
                        dataGridViewconfunci.DataSource = consltafunc.buscafunstatusativo();
                    }break;
            }
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
