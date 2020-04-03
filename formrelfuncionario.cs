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
    public partial class formrelfuncionario : Form
    {
        public formrelfuncionario()
        {
            InitializeComponent();
        }

        private void formrelfuncionario_Load(object sender, EventArgs e)
        {

            // caregar a combo cidade mostrando elas

            classfuncionario cfuncioanrio = new classfuncionario();
            cbcidade.DataSource = cfuncioanrio.buscarelcidade();
            cbcidade.DisplayMember = "cidade";
            cbcidade.ValueMember = "cidade";
            cbcidade.SelectedIndex = -1;

            // mostrando os dias na combo

            // opciones de pesquisa

            cbopcoesp.Items.Add("Escolha um Tipo de Relatorio");
            cbopcoesp.Items.Add("Aniversariantes Mês");
            cbopcoesp.Items.Add("Aniversariantes por Dia e Mês");
            cbopcoesp.Items.Add("Sexo");
            cbopcoesp.Items.Add("Idade");
            cbopcoesp.Items.Add("Cidade");
            cbopcoesp.Items.Add("Status");
            cbopcoesp.SelectedIndex = 0;

            //mostrando os dias

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

            //mostrand os meses na combo box

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


            this.reportViewerfuncio.RefreshReport();


        }

        private void cbopcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            { 

            if (cbopcoesp.SelectedIndex == 0) //escolher o tipo de pesquisa
            {
                cbcidade.Enabled = false;
                cbdia.Enabled = false;
                cbmes.Enabled = false;
                rbativo.Enabled = false;
                rbinativo.Enabled = false;
                rbmasculino.Enabled = false;
                rbfeminino.Enabled = false;
                txtate.Enabled = false;
                txtde.Enabled = false;
            }

            if (cbopcoesp.SelectedIndex == 1) // Aniversariante mes
            {
                cbcidade.Enabled = false;
                cbdia.Enabled = false;
                cbmes.Enabled = true;
                rbativo.Enabled = false;
                rbinativo.Enabled = false;
                rbmasculino.Enabled = false;
                rbfeminino.Enabled = false;
                txtate.Enabled = false;
                txtde.Enabled = false;
            }

            if (cbopcoesp.SelectedIndex == 2) // ANIVERSARIANTE DIA E MES    
            {
                cbcidade.Enabled = false;
                cbdia.Enabled = true;
                cbmes.Enabled = true;
                rbativo.Enabled = false;
                rbinativo.Enabled = false;
                rbmasculino.Enabled = false;
                rbfeminino.Enabled = false;
                txtate.Enabled = false;
                txtde.Enabled = false;
            }

            if (cbopcoesp.SelectedIndex == 3) // sexo
            {
                cbcidade.Enabled = false;
                cbdia.Enabled = false;
                cbmes.Enabled = false;
                rbativo.Enabled = false;
                rbinativo.Enabled = false;
                rbmasculino.Enabled = true;
                rbfeminino.Enabled = true;
                txtate.Enabled = false;
                txtde.Enabled = false;
            }

            if (cbopcoesp.SelectedIndex == 4) // idade
            {
                cbcidade.Enabled = false;
                cbdia.Enabled = false;
                cbmes.Enabled = false;
                rbativo.Enabled = false;
                rbinativo.Enabled = false;
                rbmasculino.Enabled = false;
                rbfeminino.Enabled = false;
                txtate.Enabled = true;
                txtde.Enabled = true;
            }

            if (cbopcoesp.SelectedIndex == 5) // cidade
            {
                cbcidade.Enabled = true;
                cbdia.Enabled = false;
                cbmes.Enabled = false;
                rbativo.Enabled = false;
                rbinativo.Enabled = false;
                rbmasculino.Enabled = false;
                rbfeminino.Enabled = false;
                txtate.Enabled = false;
                txtde.Enabled = false;

            }

            if (cbopcoesp.SelectedIndex == 6) //status
            {
                cbcidade.Enabled = false;
                cbdia.Enabled = false;
                cbmes.Enabled = false;
                rbativo.Enabled = true;
                rbinativo.Enabled = true;
                rbmasculino.Enabled = false;
                rbfeminino.Enabled = false;
                txtate.Enabled = false;
                txtde.Enabled = false;
            }
        }
    }

    private void btgerar_Click(object sender, EventArgs e)
    {
       // variaveis
        classfuncionario cfuncioanrio = new classfuncionario();
        string pesquisa = cbopcoesp.SelectedItem.ToString();
        switch (pesquisa)
         {
                case "Aniversariantes Mês":
                    if (cbmes.Text != "")
                    {
                        classfuncionarioBindingSource.DataSource = cfuncioanrio.relfuncionariomes(cbmes.SelectedIndex);
                        this.reportViewerfuncio.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor Escolha um Mês", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    break;

                case "Aniversariantes por Dia e Mês":
                    if (cbdia.Text != "" && cbmes.Text != "")
                    {
                        classfuncionarioBindingSource.DataSource = cfuncioanrio.relfuncionariodiaemes(cbdia.SelectedIndex, cbmes.SelectedIndex);
                        this.reportViewerfuncio.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor Escolher um Dia e Mês", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    break;
                case "Sexo":
                    if (rbmasculino.Checked == true)
                    {
                        cfuncioanrio.sexo = "M";
                        classfuncionarioBindingSource.DataSource = cfuncioanrio.relfuncionariosexo(cfuncioanrio.sexo);
                        this.reportViewerfuncio.RefreshReport();
                    }
                    else
                    if (rbfeminino.Checked)
                    {
                        cfuncioanrio.sexo = "F";
                        classfuncionarioBindingSource.DataSource = cfuncioanrio.relfuncionariosexo(cfuncioanrio.sexo);
                        this.reportViewerfuncio.RefreshReport();
                    }
                    break;
                case "Idade":
                    if (txtate.Text !="" && txtde.Text !="")
                    {
                        classfuncionarioBindingSource.DataSource = cfuncioanrio.relfuncioanrioidade(Convert.ToInt32(txtde.Text), Convert.ToInt32(txtate.Text));
                        this.reportViewerfuncio.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor Escolher uma Idade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Cidade":
                    if (cbcidade.Text !="")
                    {
                        classfuncionarioBindingSource.DataSource = cfuncioanrio.relfuncionariocidade(cbcidade.SelectedValue.ToString());
                        this.reportViewerfuncio.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor Escolher uma Cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "Status":
                    if(rbativo.Checked == true)
                    {
                        cfuncioanrio.status = 1;
                        classfuncionarioBindingSource.DataSource = cfuncioanrio.relfuncionariostatus(cfuncioanrio.status);
                        this.reportViewerfuncio.RefreshReport();
                    }
                    else
                    if(rbinativo.Checked)
                    {
                        cfuncioanrio.status = 0;
                        classfuncionarioBindingSource.DataSource = cfuncioanrio.relfuncionariostatus(cfuncioanrio.status);
                        this.reportViewerfuncio.RefreshReport();

                        
                    }
                    break;
            }
        }
        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente deseja sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

    }
}