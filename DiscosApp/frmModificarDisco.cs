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
    public partial class frmModificarDisco : Form
    {
        public Disco disco { get; set; }

        public frmModificarDisco()
        {
            InitializeComponent();
        }

        public frmModificarDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
        }

        private void frmModificarDisco_Load(object sender, EventArgs e)
        {
            cargarComboBox();

            txtTituloModificar.Text = disco.Titulo;
            txtAutorModificar.Text = disco.Autor;
            dtpFechaModificar.Value = disco.FechaLanzamiento;
            nudCancionesModificar.Value = disco.CantidadCanciones;
            txtImagenModificar.Text = disco.ImagenTapa;
            cargarImagen(disco.ImagenTapa);
            cbEstiloModificar.SelectedValue = disco.Estilo.Id;
            cbEdicionModificar.SelectedValue = disco.TipoEdicion.Id;
        }

        private void btnModificarFrm_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro de modificar el disco?", "Modificar Disco", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.No)
                return;

            DiscoNegocio negocio = new DiscoNegocio();

            disco.Titulo = txtTituloModificar.Text;
            disco.Autor = txtAutorModificar.Text;
            disco.FechaLanzamiento = dtpFechaModificar.Value;
            disco.CantidadCanciones = (int)nudCancionesModificar.Value;
            disco.ImagenTapa = txtImagenModificar.Text;
            disco.Estilo = (Estilo)cbEstiloModificar.SelectedItem;
            disco.TipoEdicion = (TipoEdicion)cbEdicionModificar.SelectedItem;

            negocio.modificar(disco);

            this.Close();
        }

        private void btnCancelarFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarComboBox()
        {
            EstiloNegocio negocio = new EstiloNegocio();
            NegocioTipoEdicion negocioTE = new NegocioTipoEdicion();

            cbEstiloModificar.DataSource = negocio.listar();
            cbEstiloModificar.ValueMember = "Id";
            cbEstiloModificar.DisplayMember = "Descripcion";

            cbEdicionModificar.DataSource = negocioTE.listar();
            cbEdicionModificar.ValueMember = "Id";
            cbEdicionModificar.DisplayMember = "Descripcion";
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagenModificar.Load(imagen);
            }
            catch (Exception)
            {
                pbImagenModificar.Load("https://i.postimg.cc/05tBmPPt/CD-Transparent-Image-1.png");
            }
        }

        private void txtImagenModificar_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtImagenModificar.Text);
        }
    }
}
