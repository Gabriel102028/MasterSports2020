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
    public partial class frmrelatoriocliente : Form
    {
        public frmrelatoriocliente()
        {
            InitializeComponent();
        }

        private void frmrelatoriocliente_Load(object sender, EventArgs e)
        {
            // carregar a combo cidade

            classcliente ccliente = new classcliente();
            cbcidade.DataSource = ccliente.relbuscacidade(); // executa o metodo na classe
            cbcidade.DisplayMember = "cidade"; // exibi a Combo as cidades
            cbcidade.ValueMember = "cidade"; // guarda no banco o nome 
            cbcidade.SelectedIndex = -1; // limpa a combo 

            // mostrando los dias en la combo box

            // mostrando las opciones de pesquisa

            cbopcoes.Items.Add("Escolha um Tipo de Relatorio");
            cbopcoes.Items.Add("Aniversariantes Mês");
            cbopcoes.Items.Add("Aniversariantes por Dia e Mês");
            cbopcoes.Items.Add("Sexo");
            cbopcoes.Items.Add("Idade");
            cbopcoes.Items.Add("Cidade");
            cbopcoes.Items.Add("Status");
            cbopcoes.SelectedIndex = 0;

            // mostrando los dias de la combo box

            cbdia.Items.Add("Selecione um Dia");
            cbdia.Items.Add("1");
            cbdia.Items.Add("2");
            cbdia.Items.Add("3");
            cbdia.Items.Add("4");
            cbdia.Items.Add("5");
            cbdia.Items.Add("6");
            cbdia.Items.Add("7");
            cbdia.Items.Add("8");
            cbdia.Items.Add("9");
            cbdia.Items.Add("10");
            cbdia.Items.Add("11");
            cbdia.Items.Add("12");
            cbdia.Items.Add("13");
            cbdia.Items.Add("14");
            cbdia.Items.Add("15");
            cbdia.Items.Add("16");
            cbdia.Items.Add("17");
            cbdia.Items.Add("18");
            cbdia.Items.Add("19");
            cbdia.Items.Add("20");
            cbdia.Items.Add("21");
            cbdia.Items.Add("22");
            cbdia.Items.Add("23");
            cbdia.Items.Add("24");
            cbdia.Items.Add("25");
            cbdia.Items.Add("26");
            cbdia.Items.Add("27");
            cbdia.Items.Add("28");
            cbdia.Items.Add("29");
            cbdia.Items.Add("30");
            cbdia.Items.Add("31");
            cbdia.SelectedIndex = 0;


            // mostrando los meses em la combo box

            cbmes.Items.Add("Selecione um Mês");
            cbmes.Items.Add("Janeiro");
            cbmes.Items.Add("Fevereiro");
            cbmes.Items.Add("Março");
            cbmes.Items.Add("Abril");
            cbmes.Items.Add("Maio");
            cbmes.Items.Add("Junho");
            cbmes.Items.Add("Julho");
            cbmes.Items.Add("Agosto");
            cbmes.Items.Add("Setembro");
            cbmes.Items.Add("Outubro");
            cbmes.Items.Add("Novembro");
            cbmes.Items.Add("Dezembro");
            cbmes.SelectedIndex = 0;


            this.reportViewercliente.RefreshReport();

        }

        private void cbopcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // de acordo com a configuração escolhida // desabilita algums objtos
            {
                if (cbopcoes.SelectedIndex == 0)
                {
                    cbcidade.Enabled = false;
                    cbdia.Enabled = false;
                    gbaniversariantes.Enabled = false;
                    gbsexo.Enabled = false;
                    gbstatus.Enabled = false;
                    gbidade.Enabled = false;

                }

                if (cbopcoes.SelectedIndex == 1) // aniversariantes por mes
                {
                    cbcidade.Enabled = false;
                    cbdia.Enabled = false;
                    gbaniversariantes.Enabled = true;
                    gbsexo.Enabled = false;
                    gbstatus.Enabled = false;
                    gbidade.Enabled = false;
                }


                if (cbopcoes.SelectedIndex == 2) // Aniversariantes por Dia e Mês
                {
                    cbdia.Enabled = true;
                    cbcidade.Enabled = false;
                    gbaniversariantes.Enabled = true;
                    gbsexo.Enabled = false;
                    gbstatus.Enabled = false;
                    gbidade.Enabled = false;
                }

                if (cbopcoes.SelectedIndex == 3) // Sexo
                {
                    cbcidade.Enabled = false;
                    gbaniversariantes.Enabled = false;
                    gbsexo.Enabled = true;
                    gbstatus.Enabled = false;
                    gbidade.Enabled = false;
                }

                if (cbopcoes.SelectedIndex == 4) // Idade
                {
                    cbcidade.Enabled = false;
                    gbaniversariantes.Enabled = false;
                    gbsexo.Enabled = false;
                    gbstatus.Enabled = false;
                    gbidade.Enabled = true;
                }

                if (cbopcoes.SelectedIndex == 5) //Cidade
                {
                    cbcidade.Enabled = true;
                    gbaniversariantes.Enabled = false;
                    gbsexo.Enabled = false;
                    gbstatus.Enabled = false;
                    gbidade.Enabled = false;
                }

                if (cbopcoes.SelectedIndex == 6) //Status
                {
                    cbcidade.Enabled = false;
                    gbaniversariantes.Enabled = false;
                    gbsexo.Enabled = false;
                    gbstatus.Enabled = true;
                    gbidade.Enabled = false;

                }

                if (cbopcoes.SelectedIndex == 7) // Sexo
                {
                    cbcidade.Enabled = false;
                    gbaniversariantes.Enabled = false;
                    gbsexo.Enabled = true;
                    gbstatus.Enabled = false;
                    gbidade.Enabled = false;

                }
            }
        }

        private void btgerarelatorio_Click(object sender, EventArgs e)
        {
            // variaveis
            classcliente ccliente = new classcliente();
            string pesquisa = cbopcoes.SelectedItem.ToString();  // pegar a opção escolida pelo usuario
            switch (pesquisa)
            {
                case "Aniversariantes Mês":
                    if (cbmes.Text != "")
                    {
                        classclienteBindingSource.DataSource = ccliente.relclientemes(cbmes.SelectedIndex);
                        this.reportViewercliente.RefreshReport();
                    }
                    else
                    { 
                     MessageBox.Show("Favor Escolha um Mês", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Aniversariantes por Dia e Mês":
                    if (cbdia.Text != "" && cbmes.Text != "")
                    {
                        classclienteBindingSource.DataSource = ccliente.relclientediames(cbdia.SelectedIndex, cbmes.SelectedIndex);
                        this.reportViewercliente.RefreshReport();
                    }
                    else
                    {

                        MessageBox.Show("Favor Escolha um Dia e Mês", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                     break;

                case "Sexo":
                    if (rbmasculino.Checked == true)

                    {
                        ccliente.sexo = "M";
                        classclienteBindingSource.DataSource = ccliente.relclientesexo(ccliente.sexo);
                        this.reportViewercliente.RefreshReport();
                    }
                    else
                        if (rbfemenino.Checked)
                    {
                        ccliente.sexo = "F";
                        classclienteBindingSource.DataSource = ccliente.relclientesexo(ccliente.sexo);
                        this.reportViewercliente.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor Escolher um Sexo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Idade":
                    if (txidadede.Text != "" && txidadeate.Text != "")
                    {
                        classclienteBindingSource.DataSource = ccliente.relclienteidade(Convert.ToInt32(txidadede.Text), Convert.ToInt32(txidadeate.Text));
                        this.reportViewercliente.RefreshReport();

                    }
                    else
                    {
                        MessageBox.Show("Favor informar uma Idade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Cidade":
                    if (cbcidade.Text != "")
                    {
                        classclienteBindingSource.DataSource = ccliente.relclientecidade(cbcidade.SelectedValue.ToString());
                        this.reportViewercliente.RefreshReport();

                    }
                    else
                    {
                        MessageBox.Show("Favor selecione uma Cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Status":

                    if (rbativo.Checked == true)
                    {
                        ccliente.status = 1;
                        classclienteBindingSource.DataSource = ccliente.relclientestatus(ccliente.status);
                        this.reportViewercliente.RefreshReport();
                    }
                    else

                        if (rbinativo.Checked)
                    {
                        ccliente.status = 0;
                        classclienteBindingSource.DataSource = ccliente.relclientestatus(ccliente.status);
                        this.reportViewercliente.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor Escolher um Status", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
            }
        }
        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que Deseja Sair", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             this.Close();
            }
    }

}
