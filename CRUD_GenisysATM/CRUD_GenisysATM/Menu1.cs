using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// En este proyecto se utilizara Material Skin
using MaterialSkin;
using MaterialSkin.Controls;


namespace CRUD_GenisysATM
{
    public partial class Menu1 : MaterialForm
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void clienteBtn_Click(object sender, EventArgs e)
        {
            Cliente formulario = new Cliente();
            formulario.Show();
        }

        private void cuentaClienteBtn_Click(object sender, EventArgs e)
        {
            CuentaCliente formulario = new CuentaCliente();
            formulario.Show();
        }

        private void servicioClienteBtn_Click(object sender, EventArgs e)
        {
            ServicioCliente formulario = new ServicioCliente();
            formulario.Show(); 

        }

        private void servicioPublicoBtn_Click(object sender, EventArgs e)
        {
            ServicioPublico formulario = new ServicioPublico();
            formulario.Show();
        }

        private void tarjetaCreditoBtn_Click(object sender, EventArgs e)
        {
            TarjetasCredito formulario = new TarjetasCredito();
            formulario.Show();
        }
    }
}
