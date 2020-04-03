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
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

         private void menucategoria_Click(object sender, EventArgs e)
        { 
             if (Application.OpenForms.OfType<fmrCategoria>().Count() > 0)
            {
                MessageBox.Show("O formulario Cliente ja esta Aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
        {
            fmrCategoria cadcategoria = new fmrCategoria();
            cadcategoria.MdiParent = this;
            cadcategoria.Show();


            }

             }                 


        private void menusair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que deseja sair", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void menucliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<fmrCliente>().Count() > 0)
            {
                MessageBox.Show("O formulario Cliente ja esta Aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else

            {
                fmrCliente cadcliente = new fmrCliente();
                cadcliente.MdiParent = this;
                cadcliente.Show();
            }
        }

        private void menuproduto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<fmrproduto>().Count() > 0)
            {
                MessageBox.Show("O Formulario Produto já está Aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  
            }

            else
            {
                fmrproduto cadproduto = new fmrproduto();
                cadproduto.MdiParent = this;
                cadproduto.Show();
            }
        }

        private void menufuncionario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<fmrfuncionario>().Count()>0)
            {
                MessageBox.Show("O Formulario Funcionario já está Aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                fmrfuncionario cadfuncionario = new fmrfuncionario();
                cadfuncionario.MdiParent = this;
                cadfuncionario.Show();
            }
        }

        private void menumarca_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<fmrmarca>().Count()>0)
            {
                MessageBox.Show("O Formulario Marca já está Aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                fmrmarca cadmarca = new fmrmarca();
                cadmarca.MdiParent = this;
                cadmarca.Show();
            }
        }
        private void tshora_Click(object sender, EventArgs e)
        {
            tsdata.Text = DateTime.Now.ToShortDateString();
            tshora.Text = DateTime.Now.ToShortTimeString();
        }

        private void tsprodutos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Formconsproduto>().Count()>0)
            {
                MessageBox.Show("O Formulario Consulta produto já esta Aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Formconsproduto consproduto = new Formconsproduto();
                consproduto.MdiParent = this;
                consproduto.Show();
            }
        }


        private void tscliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Formconscliente>().Count() > 0)
            {
                MessageBox.Show("O Fomulario Cunsulta Cliente já está Aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Formconscliente conscliente = new Formconscliente();
                conscliente.MdiParent = this;
                conscliente.Show();
            }
        }

        private void rtscategoria_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmrelcategoria>().Count() > 0)
            {
                MessageBox.Show("O formulario relatorio categoria já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmrelcategoria relcategoria = new frmrelcategoria();
                relcategoria.MdiParent = this;
                relcategoria.Show();

            }
        }

        private void clientestm_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmrelatoriocliente>().Count() >0)
            {
                MessageBox.Show("O formulario relatorio cliente já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                frmrelatoriocliente relcliente = new frmrelatoriocliente();
                relcliente.MdiParent = this;
                relcliente.Show();
                
            }
        }

        private void produtostm_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmrelatorioproduto>().Count() >0)
            {
                MessageBox.Show("O formulario relatorio produto já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                frmrelatorioproduto relproduto = new frmrelatorioproduto();
                relproduto.MdiParent = this;
                relproduto.Show();

            }
        }

        private void stvenda_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmVenda>().Count() >0)
            {
                MessageBox.Show("O formulario Vendas já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                frmVenda venda = new frmVenda();
                venda.MdiParent = this;
                venda.Show();
            }
        }

        private void tsrelvenda_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<fmrelvenda>().Count() >0)
            {
                MessageBox.Show("O Formulario Relatorio Venda já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                fmrelvenda relvenda = new fmrelvenda();
                relvenda.MdiParent = this;
                relvenda.Show();
            }
        }

        private void TStfuncionario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Formconsfuncionario>().Count() >0)
            {
                MessageBox.Show("O Formulario Consulta Funcionario já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Formconsfuncionario consfuncionario = new Formconsfuncionario();
                consfuncionario.MdiParent = this;
                consfuncionario.Show();

            }
        }

        private void funcionarioTSm_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formrelfuncionario>().Count() > 0)
            {
                MessageBox.Show("O Formulario Relatorio Funcionario já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                formrelfuncionario relfuncio = new formrelfuncionario();
                relfuncio.MdiParent = this;
                relfuncio.Show();
            }

        }

        private void categoriaTS_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Formconsulcategoria>().Count() >0)
            {
                MessageBox.Show("O Formulario Consulta Categoria já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Formconsulcategoria consulcategoria = new Formconsulcategoria();
                consulcategoria.MdiParent = this;
                consulcategoria.Show();
            }
        }

        private void marcaTS_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Formconsulmarca>().Count() >0)
            {
                MessageBox.Show("O Formulario Consulta Marca já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Formconsulmarca consulmarca = new Formconsulmarca();
                consulmarca.MdiParent = this;
                consulmarca.Show();
            }
        }

        private void marcaTSt_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmrelmarca>().Count() >0)
            {
                MessageBox.Show("O Formulario Relatorio Marca já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                frmrelmarca relmarca = new frmrelmarca();
                relmarca.MdiParent = this;
                relmarca.Show();
            }
        }

    }
      
 }

