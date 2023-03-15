using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_principala
{
    public partial class Pagina_de_logare : Form
    {
        public Pagina_de_logare()
        {
            InitializeComponent();
        }

        private void buton_pg_anterioara_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buton_desc_detalii_Click(object sender, EventArgs e)
        {
            Detalii_test pg_det = new Detalii_test();
            pg_det.Show();
        }
    }
}
