using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_GenisysATM.Models;

// Aplicar material skin
using MaterialSkin;
using MaterialSkin.Controls;

namespace CRUD_GenisysATM
{
    public partial class Cliente : MaterialForm
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // verificamos si los campos están llenos
            if (txtIdentidad.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCelular.Text == "")
            {
                MessageBox.Show("Aun hay datos que aun no se han llenado, ¡Revise!", "Error en ingreso", MessageBoxButtons.OK);
            }
            else
            {
                //instanciamos de la clase cliente
                Models.Cliente nuevoCliente = new Models.Cliente();
                nuevoCliente.identidad = txtIdentidad.Text;
                nuevoCliente.nombres = txtNombres.Text;
                nuevoCliente.apellidos = txtApellidos.Text;
                nuevoCliente.direccion = txtDireccion.Text;
                nuevoCliente.telefono = txtTelefono.Text;
                nuevoCliente.celular = txtCelular.Text;

                // mandamos los datos al método insertarCliente y verificamos su resultado
                if (Models.Cliente.InsertarCliente(nuevoCliente))
                {
                    MessageBox.Show("El Cliente ha sido registrado satifactoriamente", "Control de Clientes", MessageBoxButtons.OK);

                    //limpiamos los datos
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error en la inserción de los datos", "Control de Clientes", MessageBoxButtons.OK);
                }

            }


        }

        public void LimpiarDatos()
        {
            txtIdentidad.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            lstClientes.Refresh();
            lstClientes.SelectedIndex = -1;
            lstClientes.DataSource = null;
            cargarDatos();
            txtIdentidad.Focus();
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void txtIdentidad_Leave(object sender, EventArgs e)
        {

            Models.Cliente existe = Models.Cliente.ObtenerCliente(txtIdentidad.Text);
            //verificamos si el cliente esta registrado e inhabilitamos el boton guardar
            if (existe.id != 0)
            {
                // deshabilitamos el boton de guardar, dado que ya existe el cliente
                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                txtNombres.Text = existe.nombres;
                txtApellidos.Text = existe.apellidos;
                txtDireccion.Text = existe.direccion;
                txtTelefono.Text = existe.telefono;
                txtCelular.Text = existe.celular;
            }
        }

     
        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarDatos();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtIdentidad.Focus();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            // verificamos si los campos están llenos
            if (txtIdentidad.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCelular.Text == "")
            {
                MessageBox.Show("Aun hay datos que aun no se han llenado", "Error", MessageBoxButtons.OK);
            }
            else
            {
                //instanciamos de la clase cliente
                Models.Cliente nuevoCliente = new Models.Cliente();
                nuevoCliente.identidad = txtIdentidad.Text;
                nuevoCliente.nombres = txtNombres.Text;
                nuevoCliente.apellidos = txtApellidos.Text;
                nuevoCliente.direccion = txtDireccion.Text;
                nuevoCliente.telefono = txtTelefono.Text;
                nuevoCliente.celular = txtCelular.Text;

                if (Models.Cliente.ActualizarCliente(nuevoCliente))
                {
                    MessageBox.Show("El Cliente ha sido actualizado satifactoriamente", "Control de Clientes", MessageBoxButtons.OK);

                    //limpiamos los datos
                    LimpiarDatos();
                    btnAgregar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error en la actualización", "Control de Clientes", MessageBoxButtons.OK);
                }

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado un cliente en la lista ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Models.Cliente EliminarCliente = new Models.Cliente();
                EliminarCliente.nombres = txtNombres.Text;
                EliminarCliente.identidad = txtIdentidad.Text;

                if (Models.Cliente.EliminarCliente(EliminarCliente))
                {
                    MessageBox.Show("El Cliente ha sido eliminado satifactoriamente", "Control de Clientes", MessageBoxButtons.OK);

                    //limpiamos los datos
                    LimpiarDatos();
                    btnAgregar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error en la actualización de los datos", "Control de Clientes", MessageBoxButtons.OK);
                }

            }
        }

        public void cargarDatos()
        {
            List<Models.Cliente> listaCliente = Models.Cliente.LeerTodos();

            lstClientes.Items.Clear();

            if (listaCliente.Any())
            {
                listaCliente.ForEach(Cliente => lstClientes.Items.Add(Cliente.nombres));
            }
            else
                lstClientes.Items.Add("¡No hay clientes!");
        }

        private void lstClientes_Click(object sender, EventArgs e)
        {
            Models.Cliente existe = Models.Cliente.ObtenerClienteNombre(lstClientes.SelectedItem.ToString());
            if (existe.id != 0)
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                txtNombres.Text = existe.nombres;
                txtApellidos.Text = existe.apellidos;
                txtDireccion.Text = existe.direccion;
                txtTelefono.Text = existe.telefono;
                txtCelular.Text = existe.celular;
                txtIdentidad.Text = existe.identidad;
            }
        }

    }
}
