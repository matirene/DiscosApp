using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discosApp
{
    public partial class frmAltaDisco : Form
    {
        public frmAltaDisco()
        {
            InitializeComponent();
        }

        private void btnAgregarAlta_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Estas seguro de agregar el disco?", "Agregar Disco", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 

            if(resultado == DialogResult.No)
                return;
            
            Disco newDisco = new Disco();

            DiscoNegocio negocio = new DiscoNegocio();

            try
            {
                newDisco.Titulo = txtTitulo.Text;
                newDisco.Autor = txtAutor.Text;
                newDisco.FechaLanzamiento = dtpFecha.Value;
                Console.WriteLine(newDisco.FechaLanzamiento);
                newDisco.CantidadCanciones = (int)nudCanciones.Value;
                newDisco.ImagenTapa = txtImagen.Text;
                newDisco.Estilo = (Estilo)cbEstilo.SelectedItem;
                newDisco.TipoEdicion = (TipoEdicion)cbEdicion.SelectedItem;

                negocio.agregar(newDisco);

                MessageBox.Show("Disco agregado.", "Agregar Disco", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            cargarComboBox();
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void cargarComboBox()
        {
            EstiloNegocio negocio = new EstiloNegocio();
            NegocioTipoEdicion negocioTE = new NegocioTipoEdicion();

            cbEstilo.DataSource = negocio.listar();
            cbEstilo.ValueMember = "Id";
            cbEstilo.DisplayMember = "Descripcion";

            cbEdicion.DataSource = negocioTE.listar();
            cbEdicion.ValueMember = "Id";
            cbEdicion.DisplayMember = "Descripcion";
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagenAlta.Load(imagen);
            }
            catch (Exception)
            {
                pbImagenAlta.Load("https://i.postimg.cc/05tBmPPt/CD-Transparent-Image-1.png");
            }
        }
    }
}
