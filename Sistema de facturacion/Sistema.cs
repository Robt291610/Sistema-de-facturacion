using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_facturacion
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
            
        }
        
        
        
        public void btnagregar_Click(object sender, EventArgs e)
        {
            registros form = new registros();
            form.cusuario.Text = this.txtnombreusuario.Text;
            form.nusuario.Text = this.txtcodigousuario.Text;
            form.Show();
            

           

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcodigousuario.Clear();
            txtnombreusuario.Clear();
        }

        private void txtcodigousuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
