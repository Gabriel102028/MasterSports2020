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
    public partial class Formconsulmarca : Form
    {
        public Formconsulmarca()
        {
            InitializeComponent();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Formconsulmarca_Load(object sender, EventArgs e)
        {
            cbmarca.Items.Add("Marcas");
            cbmarca.Items.Add("Status");
            cbmarca.SelectedIndex = 0;  
           
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {
            string consultamarca = cbmarca.SelectedItem.ToString();
            classmarca cmarca = new classmarca();
            switch (consultamarca)
            {
                case "Marcas":
                    if (cbmarca.Text != "")
                    {

                        cmarca.codigomarca = Convert.ToInt32(cbmarca.SelectedValue);
                        dataGridViewmarca.DataSource = cmarca.buscamarca();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher uma marca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }break;

                case "Status":

                    if (rbativo.Checked == true)
                    {
                        cmarca.status = 1;
                        dataGridViewmarca.DataSource = cmarca.buscaconsultastatus();
                    }
                    else
                    if (rbInativo.Checked)
                    {
                        cmarca.status = 0;
                        dataGridViewmarca.DataSource = cmarca.buscaconsultastatus();
                    }break;                  
            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewmarca.SelectedCells.Count > 0)
            {
                classmarca ccmarca = new classmarca();
                ccmarca.retornamarca(Convert.ToInt32(dataGridViewmarca.SelectedRows[0].Cells[0].Value));
                fmrmarca formmarca = new fmrmarca();

                formmarca.tbcodigo.Text = ccmarca.codigomarca.ToString();
                formmarca.tbnomemarca.Text = ccmarca.nome.ToString();
                formmarca.tbdata.Text = ccmarca.datacadastro.ToString();

                if (ccmarca.status == 1)
                {
                    formmarca.bstatus.Checked = true;
                }
                else
                {
                    formmarca.bstatus.Checked = false;
                }

                formmarca.tipo = "Atualização";

                formmarca.ShowDialog();

                btpesquisar_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Selecione a Marca a ser atualizada !", "Sistema MasterSports", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbmarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmarca.SelectedIndex == 0) // marcas
            {

                rbativo.Enabled = false;
                rbInativo.Enabled = false;
            }

            if (cbmarca.SelectedIndex == 1)// status
            {
                rbativo.Enabled = true;
                rbInativo.Enabled = true;
            }

        }
    }
}
