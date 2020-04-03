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
    public partial class Formconsulcategoria : Form
    {
        public Formconsulcategoria()
        {
            InitializeComponent();
        }


        private void Formconsulcategoria_Load(object sender, EventArgs e)
        {
            cbopcoes.Items.Add("Categorias");
            cbopcoes.Items.Add("Status");
            cbopcoes.SelectedIndex = 0;

            //classcategoria ccategoria = new classcategoria();
            //cbcategoria.DataSource = ccategoria.buscarcategoria();
            //cbcategoria.DisplayMember = "nome";
            //cbcategoria.ValueMember = "codigocategoria";
            //cbcategoria.SelectedIndex = 1;
        }

        private void cbopcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbopcoes.SelectedIndex == 0) // categoria
            {
                rbativo.Enabled = false;
                rbinativo.Enabled = false;
            }

            if (cbopcoes.SelectedIndex == 1) // status
            {
                rbativo.Enabled = true;
                rbinativo.Enabled = true;

            }
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {
            string consultacate = cbopcoes.SelectedItem.ToString();
            classcategoria consulcategoria = new classcategoria();
            switch(consultacate)
            {
                case "Categorias":

                if (cbopcoes.Text != "")
                    {
                        consulcategoria.codigocategoria = Convert.ToInt32(cbopcoes.SelectedValue);
                        dataGridViewcategoria.DataSource = consulcategoria.buscarcategoria();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher uma categoria.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }break;

                case "Status":
                    if (rbativo.Checked == true)
                    {
                        consulcategoria.status = 1;
                        dataGridViewcategoria.DataSource = consulcategoria.buscaconsulstatus();

                    }
                    else
                    {
                        consulcategoria.status = 0;
                        dataGridViewcategoria.DataSource = consulcategoria.buscaconsulstatus();
                    }
                    break;
            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewcategoria.SelectedCells.Count > 0)
            {
                classcategoria ccategoria = new classcategoria();
                ccategoria.retornacategoria(Convert.ToInt32(dataGridViewcategoria.SelectedRows[0].Cells[0].Value));
                fmrCategoria formcategoia = new fmrCategoria();

                formcategoia.tbcodigo.Text = ccategoria.codigocategoria.ToString();
                formcategoia.tbdatacadastro.Text = ccategoria.datacadastro.ToString();
                formcategoia.tbnomecategoria.Text = ccategoria.nome.ToString();

                if (ccategoria.status == 1)
                {
                    formcategoia.cbstatus.Checked = true;
                }
                else
                {
                    formcategoia.cbstatus.Checked = false;
                }

                formcategoia.tipo = "Atualização";

                formcategoia.ShowDialog();

                btpesquisar_Click(this, new EventArgs());
               }
            else
            {
                MessageBox.Show("Selecione a categoria a ser Atualizada !", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que deseja sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
