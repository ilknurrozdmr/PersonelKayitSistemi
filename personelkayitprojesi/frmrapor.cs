using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personelkayitprojesi
{
    public partial class frmrapor : Form
    {
        public frmrapor()
        {
            InitializeComponent();
        }

        private void frmrapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelvtDataSet.personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.personelvtDataSet.personel);

            this.reportViewer1.RefreshReport();
        }
    }
}
