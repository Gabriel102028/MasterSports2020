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
    public partial class fmrelvenda : Form
    {
        public fmrelvenda()
        {
            InitializeComponent();
        }

        private void fmrelvenda_Load(object sender, EventArgs e)
        {
            cbopcoes.Items.Add("Detalhado");
            cbopcoes.SelectedIndex = 0;

            // popular a combo box funcionairo

            //classfuncionario cfuncionario = new classfuncionario();
            //cbrelfunc.DataSource = cfuncionario.buscafuncionario();
            //cbrelfunc.ValueMember = "nome";
            //cbrelfunc.DisplayMember = "nome";
            //cbrelfunc.SelectedIndex = -1;

            //// popular a combo box de cliente

            //classcliente ccliente = new classcliente();
            //cbrelcli.DataSource = ccliente.retornacliente();
            //cbrelcli.ValueMember = "nome";
            //cbrelcli.DisplayMember = "nome";
            //cbrelcli.SelectedIndex = -1;



            //dateTimePicker1.Value = DateTime.Now.Date;
            //dateTimePicker2.Value = DateTime.Now.Date;

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        //private void cbopcoes_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbopcoes.SelectedIndex == 0) // detalhado
        //    {
        //cbrelcli.Enabled = false;
        //cbrelfunc.Enabled = false;
        //dateTimePicker1.Enabled = true;
        //dateTimePicker2.Enabled = true;

        //}
        //if (cbopcoes.SelectedIndex == 1) // clientes
        //{
        //    cbrelcli.Enabled = true;
        //    cbrelfunc.Enabled = false;
        //    //dateTimePicker1.Enabled = false;
        //    //dateTimePicker2.Enabled = false;

        //}

        //if (cbopcoes.SelectedIndex == 2) //funcionario
        //{
        //    cbrelcli.Enabled = false;
        //    cbrelfunc.Enabled = true;
        //dateTimePicker1.Enabled = false;
        //dateTimePicker2.Enabled = false;

        //    }
        //}

        private void btgerarelatorio_Click(object sender, EventArgs e)
        {

            classrelvenda relvenda = new classrelvenda();
            string pesquisa = cbopcoes.SelectedItem.ToString();
            switch (pesquisa)
            {
                case "Detalhado":
                    //DateTime dinicio = Convert.ToDateTime(dateTimePicker1.Text);
                    //DateTime dfinal = Convert.ToDateTime(dateTimePicker2.Text);
                    classRelVendaBindingSource.DataSource = relvenda.RelVendaDetalhado();
                    this.reportViewer1.RefreshReport();
                    break;

                    // case "Cliente":
                    //     if(cbrelcli.Text !="")
                    //     {
                    //         int cliente = Convert.ToInt32(cbrelcli.SelectedValue);
                    //         classRelVendaBindingSource.DataSource = relvenda.RelVendaDetalhadoCliente(cliente);
                    //         this.rprelvenda.RefreshReport();
                    //     }
                    //     else
                    //     {
                    //         MessageBox.Show("Favor escolher um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //     }
                    //     break;

                    // case "Funcionario":
                    //     if(cbrelfunc.Text != "")
                    //     {
                    //         int funcionario = Convert.ToInt32(cbrelfunc.SelectedValue);
                    //         classRelVendaBindingSource.DataSource = relvenda.RelVendaDetalhadoFuncionario(funcionario);
                    //         this.rprelvenda.RefreshReport();

                    //     }
                    //     else
                    //     {
                    //         MessageBox.Show("Favor escolha um funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //     }
                    //     break;
                    //}      
            }
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
