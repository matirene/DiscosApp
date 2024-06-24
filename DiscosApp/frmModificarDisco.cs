using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discosApp
{
    public partial class frmModificarDisco : Form
    {
        private OpenFileDialog archivo = null;

        public Disco disco { get; set; }
        public string imageOld { get; set; }

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

            pbAgregarImagenMod.Load("https://cdn-icons-png.flaticon.com/512/1160/1160358.png");

        }

        private void btnModificarFrm_Click(object sender, EventArgs e)
        {
            if (validateFields())
                return;

            DialogResult resultado = MessageBox.Show("Estas seguro de modificar el disco?", "Modificar Disco", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.No)
                return;

            DiscoNegocio negocio = new DiscoNegocio();

            disco.Titulo = txtTituloModificar.Text;
            disco.Autor = txtAutorModificar.Text;
            disco.FechaLanzamiento = dtpFechaModificar.Value;
            disco.CantidadCanciones = (int)nudCancionesModificar.Value;
            disco.Estilo = (Estilo)cbEstiloModificar.SelectedItem;
            disco.TipoEdicion = (TipoEdicion)cbEdicionModificar.SelectedItem;


            if (archivo != null && !txtImagenModificar.Text.ToUpper().Contains("HTTP"))
            {
                // Guardamos la ruta de la imagen anterior.
                imageOld = disco.ImagenTapa;

                string extension = Path.GetExtension(archivo.SafeFileName);

                string nuevoNombreArchivo = Path.GetFileNameWithoutExtension(archivo.SafeFileName) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + extension;

                string path = getPath(nuevoNombreArchivo);

                File.Copy(archivo.FileName, path);

                disco.ImagenTapa = path;

            }
            else
            {
                disco.ImagenTapa = txtImagenModificar.Text;
            }

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

        private void pbAgregarImagenMod_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "(*.jpg; *.png)|*.jpg; *.png;";
            archivo.Title = "Agregar Imagen";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenModificar.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        private void pbAgregarImagenMod_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void pbAgregarImagenMod_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private string getPath(string fileName)
        {
            string pathDirectory = Environment.CurrentDirectory;
            string pathFather = System.IO.Directory.GetParent(pathDirectory).Parent.FullName;

            string pathImagenes = Path.Combine(pathFather, "Imagenes\\");

            string pathFinal = Path.Combine(pathImagenes, fileName);

            return pathFinal;

        }

        private bool validateFields()
        {
            Validation validation = new Validation();

            if (validation.isEmpty(txtTituloModificar.Text) || validation.isEmpty(txtAutorModificar.Text) || validation.isEmpty(txtImagenModificar.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
    }
}
