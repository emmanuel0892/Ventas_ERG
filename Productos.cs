using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_ERG
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Hide();
            
        }
        EdicionPro EditPro = new EdicionPro();
    }
}
