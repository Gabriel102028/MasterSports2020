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
    public partial class frmrelmarca : Form
    {
        public frmrelmarca()
        {
            InitializeComponent();
        }

        private void frmrelmarca_Load(object sender, EventArgs e)
        {
            classmarca cmarca = new classmarca();
            classmarcaBindingSource.DataSource = cmarca.relmarca();
            this.reportViewermarca.RefreshReport();
        }
    }
}
