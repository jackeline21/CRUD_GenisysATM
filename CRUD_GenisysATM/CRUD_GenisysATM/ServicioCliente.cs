﻿using System;
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
    public partial class ServicioCliente : MaterialForm
    {
        public ServicioCliente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstClientes_Click(object sender, EventArgs e)
        {
            CargarDatos3();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtSaldo.Text=="" || lstClientes.SelectedIndex ==-1 || lstServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente, un servicio y especificar el saldo", "Error en ingreso", MessageBoxButtons.OK);
            }
            else
            {
                //instanciamos de la clase clienteServicio
                Models.ServicioCliente nuevo = new Models.ServicioCliente();
                nuevo.saldo = Convert.ToDecimal(txtSaldo.Text);

                if (Models.ServicioCliente.InsertarClienteServicio(lstClientes.SelectedItem.ToString(), lstServicio.SelectedItem.ToString(), nuevo))
                {
                    MessageBox.Show("Registro guardado correctamente", "Control de clientes y servicios", MessageBoxButtons.OK);
                    Limpiar();
                }
            }
        }

        public void Limpiar()
        {
            txtSaldo.Text = "";
            lstClientes.SelectedIndex = -1;
            lstClientes.SelectedIndex = -1;
            lstClienteServicio.Items.Clear();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            CargarDatos1();
            CargarDatos2();
        }

        public void CargarDatos1()
        {
            // obtenemos la lista de todos los clientes de la tabla
            List<Models.Cliente> listaCliente = Models.Cliente.LeerTodos();
            // Limpiar el listView
            lstClientes.Items.Clear();
            // Verificar si existen departamentos
            if (listaCliente.Any())
            {
                listaCliente.ForEach(Cliente => lstClientes.Items.Add(Cliente.nombres));
            }
            else
                lstClientes.Items.Add("¡No hay clientes!");
        }

        public void CargarDatos2()
        {
      
            List<Models.ServicioPublico> listaServicio = Models.ServicioPublico.LeerTodos();
            // Limpiar el listView
            lstServicio.Items.Clear();
            // Verificar si existen departamentos
            if (listaServicio.Any())
            {
                listaServicio.ForEach(servi => lstServicio.Items.Add(servi.descripcion));
            }
            else
                lstServicio.Items.Add("¡No hay Servicios Públicos!");
        }
        public void CargarDatos3()
        {
            List<Models.ServicioCliente> existe = Models.ServicioCliente.LeerTodosServiciosCliente(lstClientes.SelectedItem.ToString());
            lstClienteServicio.Items.Clear();
            //verificamos si el cliente esta registrado e inhabilitamos el boton guardar
            if (existe.Any())
            {
                existe.ForEach(Cli => lstClienteServicio.Items.Add(Cli.detalle)             );
              
            }
            else
            {
                lstClienteServicio.Items.Add("¡No hay Servicios para este cliente!");
                // deshabilitamos el boton de guardar, dado que ya existe el cliente
            }
        }

        private void frmServicioCliente_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void lstClienteServicio_Click(object sender, EventArgs e)
        {
            //cargamos el dato de saldo para ser actualizado.
            Models.ServicioCliente existe = Models.ServicioCliente.LeerDatoServicio(lstClienteServicio.SelectedItem.ToString(),lstClientes.SelectedItem.ToString()) ;
            //verificamos si el cliente esta registrado e inhabilitamos el boton guardar
            if (existe.saldo !=0)
            {
                // deshabilitamos el boton de guardar, dado que ya existe el cliente
                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                txtSaldo.Text = Convert.ToString(existe.saldo);
            }
            else
            {
                txtSaldo.Text = "Error";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtSaldo.Text == "" || lstClientes.SelectedIndex == -1 )
            {
                MessageBox.Show("Debe seleccionar un cliente e ingresar un saldo","Error en ingreso", MessageBoxButtons.OK);
            }
            else
            {
                //instanciamos de la clase clienteServicio
                Models.ServicioCliente nuevo = new Models.ServicioCliente();
                nuevo.saldo = Convert.ToDecimal(txtSaldo.Text);

                if (Models.ServicioCliente.ActualizarClienteServicio(lstClientes.SelectedItem.ToString(), lstClienteServicio.SelectedItem.ToString(), nuevo))
                {
                    MessageBox.Show("Registro Actualizado correctamente", "Control de clientes y servicios", MessageBoxButtons.OK);
                    Limpiar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ( lstClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente ", "Error en ingreso", MessageBoxButtons.OK);
            }
            else
            {
                //instanciamos de la clase clienteServicio
                Models.ServicioCliente nuevo = new Models.ServicioCliente();
                nuevo.saldo = Convert.ToDecimal(txtSaldo.Text);

                if (Models.ServicioCliente.EliminarClienteServicio(lstClientes.SelectedItem.ToString(), lstClienteServicio.SelectedItem.ToString()))
                {
                    MessageBox.Show("Registro Eliminado correctamente", "Control de clientes y servicios", MessageBoxButtons.OK);
                    Limpiar();
                }
            }
        }
    }
}
