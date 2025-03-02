using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_de_facturacion
{
    public partial class registros : Form
    {
        
        
        public registros()
        {
            InitializeComponent();
            
            
        }
        

         
        

        public void button1_Click(object sender, EventArgs e)
        {
            string usuario, cajera, fecha, nproducto, detalle;
            int nousuario, nfactura, codigo, cantidad, valor;
            double precio;

           
            int totalvalor;


            usuario = cusuario.Text;
            nfactura = Convert.ToInt32(txtnofactura.Text);
            nousuario = int.Parse(nusuario.Text);
            cajera = txtcajera.Text;
            fecha = txtfecha.Text;
            codigo = int.Parse(txtcodigo.Text);
            nproducto = txtnombre.Text;
            precio = double.Parse(txtprecio.Text);
            cantidad = int.Parse(txtcantidad.Text);
            detalle = txtdetalle.Text;
            
            

            List<int> intlista = new List<int>();
            totalvalor = 0;
            foreach (int i in intlista)
                
            if (i > totalvalor) 
                {
                 totalvalor = i;
                }


            valor = Convert.ToInt32(precio * cantidad);
            txtvalor.Text = Convert.ToString(valor);

            totalvalor = valor + totalvalor;

            
            
            txttotalvalor.Text = Convert.ToString(totalvalor);

            intlista.Add(totalvalor);

            


        }   
            
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void cusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cusuario.Clear();
            txtcajera.Clear();
            txtnofactura.Clear();
            txtfecha.Clear();
            txtcodigo.Clear();
            txtnombre.Clear();
            txtprecio.Clear();
            txtcantidad.Clear();
            txtvalor.Clear();
            txtdetalle.Clear();
            txttotalvalor.Clear();
            nusuario.Clear();
        }

        public void btnconsulta_Click(object sender, EventArgs e)
        {

            
            Consulta form = new Consulta();
            form.labelusuario.Text = this.cusuario.Text;
            form.labelno.Text = this.cusuario.Text;
            form.labelcajera.Text = this.txtcajera.Text;
            form.labelno.Text = this.txtnofactura.Text;
            form.labelfecha.Text = this.txtfecha.Text;
            form.labelcodigo.Text = this.txtcodigo.Text;
            form.labelnombre.Text = this.txtnombre.Text;
            form.labelprecio.Text = this.txtprecio.Text;
            form.labelcantidad.Text = this.txtcantidad.Text;
            form.labeldetalle.Text = this.txtdetalle.Text;
            form.labelvalor.Text = this.txtvalor.Text;
            form.labelvalortotal.Text = this.txttotalvalor.Text;

            form.ShowDialog();
            
        }

        private void registros_Load(object sender, EventArgs e)
        {

        }
    }
}
