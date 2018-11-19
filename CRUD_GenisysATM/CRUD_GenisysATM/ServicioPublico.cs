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
    public partial class ServicioPublico : MaterialForm
    {
        public ServicioPublico()
        {
            InitializeComponent();
        }

       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void frmServicioPublico_Load(object sender, EventArgs e)
        {
            
            Limpiar();
        }
        
        /// <summary>
        /// Se encarga de listar los servicios publicos
        /// disponibles en lstServicios
        /// </summary>
        public void cargarDatos()
        {

            // obtenemos la lista de todos los clientes de la tabla
            List<Models.ServicioPublico> listaServicio = Models.ServicioPublico.LeerTodos();

            // Limpiar el listView
            lstServicios.Items.Clear();

            // Verificar si existen departamentos
            if (listaServicio.Any())
            {
                listaServicio.ForEach(servicio => lstServicios.Items.Add(servicio.descripcion));
            }
            else
                lstServicios.Items.Add("¡No hay servicios!");
        }

        public void Limpiar()
        {
            txtDescripcion.Text = "";
            lstServicios.Items.Clear();
            cargarDatos();
            txtDescripcion.Focus();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            cargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //verificamos que el usuario haya ingresado una descripción para guardar
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe de llenar la descrición", "Error en ingreso", MessageBoxButtons.OK);
            }
            else
            {
                //instanciamos de la clase servicioPublico.
                Models.ServicioPublico nuevo = new Models.ServicioPublico();
                nuevo.descripcion = txtDescripcion.Text;
                if (Models.ServicioPublico.InsertarServicio(nuevo))
                {
                    MessageBox.Show("Servicio registrado satifactoriamente", "Control de servicios públicos", MessageBoxButtons.OK);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error durante la inserción", "Control de servicios", MessageBoxButtons.OK);
                }
            }
        }

        private void grpOperaciones_Enter(object sender, EventArgs e)
        {

        }

        private void lstServicios_Click(object sender, EventArgs e)
        {
            Models.ServicioPublico existe = Models.ServicioPublico.obtenerServicio(lstServicios.SelectedItem.ToString());
            //verificamos si el cliente esta registrado e inhabilitamos el boton guardar
            if (existe.id != 0)
            {
                // deshabilitamos el boton de guardar, dado que ya existe el cliente
                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                txtDescripcion.Text = existe.descripcion;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(lstServicios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleecionar un servicio", "Error en ingreso", MessageBoxButtons.OK);
            }
            else
            {
                //instanciamos de la clase servicioPublico.
                Models.ServicioPublico actualizar = new Models.ServicioPublico();
                actualizar.descripcionactual = lstServicios.SelectedItem.ToString();
                actualizar.descripcion = txtDescripcion.Text;
                if (Models.ServicioPublico.ActualizarServicio(actualizar))
                {
                    MessageBox.Show("Servicio Actualizado satifactoriamente", "Control de servicios públicos", MessageBoxButtons.OK);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error durante la actualización", "Control de servicios públicos", MessageBoxButtons.OK);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstServicios.SelectedIndex == -1)
            {
                MessageBox.Show("¡Debe seleccionar un servicio", "Error en ingreso", MessageBoxButtons.OK);
            }
            else
            {
                //instanciamos de la clase servicioPublico.
                Models.ServicioPublico Eliminar = new Models.ServicioPublico();
                Eliminar.descripcion = txtDescripcion.Text;
                if (Models.ServicioPublico.EliminarServicio(Eliminar))
                {
                    MessageBox.Show("Servicio Eliminado satifactoriamente", "Control de servicios públicos", MessageBoxButtons.OK);
                    Limpiar();
                }
            }
        }
    }
}
