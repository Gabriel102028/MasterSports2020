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
    public partial class Formconscliente : Form
    {
        public Formconscliente()
        {
            InitializeComponent();
        }

        private void Formconscliente_Load(object sender, EventArgs e)
        {

            // carregar a combo para mostrar o tipo de pesquisa

            cbopcoespesquisa.Items.Add("Nome");
            cbopcoespesquisa.Items.Add("CPF");
            cbopcoespesquisa.Items.Add("Status");
            cbopcoespesquisa.Items.Add("Sexo");
            cbopcoespesquisa.SelectedIndex = 0;
            rbinicio.Checked = true;

        }

        private void cbopcoespesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // de acordo com a configuracao escolhida ?? desabilita alguns objetos 

            if (cbopcoespesquisa.SelectedIndex == 0) // Nome
            {
                gbpesquisa.Enabled = true;
                gbsexo.Enabled = false;
                gbcpf.Enabled = false;
                gbstatus.Enabled = false;
                txconsulta.Enabled = true;
                gbpesquisa.Focus();
            }

            if (cbopcoespesquisa.SelectedIndex == 1) // CPF
            {
                gbpesquisa.Enabled = true;
                gbcpf.Enabled = true;
                gbsexo.Enabled = false;
                gbstatus.Enabled = false;
                txconsulta.Enabled = false;

            }
            if (cbopcoespesquisa.SelectedIndex == 2) // status
            {
                gbpesquisa.Enabled = false;
                gbcpf.Enabled = false;
                gbsexo.Enabled = false;
                gbstatus.Enabled = true;
                txconsulta.Enabled = false;
            }
        
            if (cbopcoespesquisa.SelectedIndex == 3) // sexo
            {

                gbpesquisa.Enabled = false;
                gbcpf.Enabled = false;
                gbsexo.Enabled = true;
                gbstatus.Enabled = false;
                txconsulta.Enabled = false;
            }
        }
        private void btpesquisar_Click(object sender, EventArgs e)
        {
            //criando variavel para guardar as informações carregadas

            string consulta = cbopcoespesquisa.SelectedItem.ToString();
            classcliente consultacli = new classcliente();
            switch (consulta)
            {
                case "Nome":
                    // verificar se algo foi digitado no campo nome
                    // se txtconsulta for igual a vazio, função messagebox mostra mensagem
                    if (txconsulta.Text != "")

                    // inicio
                    {
                        if (rbinicio.Checked)
                        {
                            consultacli.nome = txconsulta.Text;
                            dataGridViewcliente.DataSource = consultacli.buscaconsultainicio();

                        }

                        //contem
                        else
                        {
                            consultacli.nome = txconsulta.Text;
                            dataGridViewcliente.DataSource = consultacli.buscaconsultacontem();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um Nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;

                // busca CPF

                case "CPF":

                    //verificar se algo foi digitado
                    // se cpf estiver vazio, messagebox na tela
                    if (txcpf.Text != "")

                    {

                        consultacli.cpf = txcpf.Text;
                        dataGridViewcliente.DataSource = consultacli.buscaclientecpfcontem();
                    }

                    else
                    {
                        MessageBox.Show("Favor digitar o CPF ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;

                //verificar o status

                case "Status":

                    if (rbativo.Checked == true)
                    {
                        consultacli.status = 1;
                        dataGridViewcliente.DataSource = consultacli.buscaclientestatusativo();
                    }
                    else
                    if (rbinativo.Checked)
                    {
                        consultacli.status = 0;
                        dataGridViewcliente.DataSource = consultacli.buscaclientestatusativo();
                    }
                               
                    else
                    {
                        MessageBox.Show("Favor escolher um Status", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                    //Verficiar o status do sexo
                case "Sexo":

                    if (rbmasculino.Checked == true)
                    {
                        consultacli.sexo = "M";
                        dataGridViewcliente.DataSource = consultacli.buscaclientessexoM();

                    }
                    else
                    if (rbfemenino.Checked)
                    {
                        consultacli.sexo = "F";
                        dataGridViewcliente.DataSource = consultacli.buscaclientesexoF();

                    }
                    else
                    {
                        MessageBox.Show("Favor ecolher um Sexo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
                    }
        // botao sair
          private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que Deseja sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewcliente.SelectedCells.Count > 0)
            {

                classcliente ccliente = new classcliente();
                ccliente.retornarcliente(Convert.ToInt32(dataGridViewcliente.SelectedRows[0].Cells[0].Value));
                fmrCliente formcliente = new fmrCliente();

                // nao esquecer de mudar a propriedade de objetos do formulario do cliente = TRUE

                formcliente.txtcodigo.Text = ccliente.codigocliente.ToString();
                formcliente.txtnome.Text = ccliente.nome.ToString();
                formcliente.mtxdatanascimento.Text = ccliente.datanascimento.ToString();
                formcliente.mtxcpf.Text = ccliente.cpf.ToString();
                formcliente.mtxtelefone.Text = ccliente.telefone.ToString();
                formcliente.mtxcelular.Text = ccliente.celular.ToString();
                formcliente.tbcidade.Text = ccliente.cidade.ToString();
                formcliente.txbairro.Text = ccliente.bairro.ToString();
                formcliente.txrua.Text = ccliente.rua.ToString();
                formcliente.cestado.Text = ccliente.estado.ToString();
                formcliente.txnumero.Text = ccliente.numerocasa.ToString();
               
                // checando o status
                            
                  if (ccliente.status == 1)
                {
                    formcliente.cbstatuss.Checked = true;
                }
                  else
                {
                    formcliente.cbstatuss.Checked = false;
                }

                  if (ccliente.sexo == "M")
                {
                    formcliente.rbmasculino.Checked = true;
                    formcliente.rbfemenino.Checked = false;
                }
                  else 
                  if (ccliente.sexo == "F")
                {
                    formcliente.rbmasculino.Checked = false;
                    formcliente.rbfemenino.Checked = true;
                }                      


                // mandar a informação de Update
                // declarar variavel Tipo no Formulario do cliente

                formcliente.tipo = "Atualização";
                // nao repetir que outro formula seja aberto e despues de actualizar e cierre el formulario
                formcliente.ShowDialog();
                // llamar el metodo de pesquisa

                btpesquisar_Click(this, new EventArgs());
         }
            else
            {
                MessageBox.Show("Selecione o produto a ser Atualizado !","Sistema Mastersports", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

