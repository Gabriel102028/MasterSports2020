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
    public partial class frmrelcategoria : Form
    {
        public frmrelcategoria()
        {
            InitializeComponent();
        }

        private void frmrelcategoria_Load(object sender, EventArgs e)
        {
            classcategoria ccategoria = new classcategoria();
            classcategoriaBindingSource.DataSource = ccategoria.relcategoria();
            this.reportViewercategoria.RefreshReport();
        }
    }
}
