using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaTuerca
{
    public partial class pantallaSiguiente : Form
    {
        public pantallaSiguiente()
        {
            InitializeComponent();
        }

        private void siguienteDom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su Pedido Fue Confirmado Correctamente");
        }

        private void cancelarDom_Click(object sender, EventArgs e)
        {
            
            Form formularioPrincipal = new menuPrincipal();
            formularioPrincipal.ShowDialog();
            this.Close();
        }
    }
}
