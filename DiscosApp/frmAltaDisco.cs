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
    public partial class frmAltaDisco : Form
    {

        private OpenFileDialog archivo = null;

        public frmAltaDisco()
        {
            InitializeComponent();
        }

        private void btnAgregarAlta_Click(object sender, EventArgs e)
        {

            if (validateFields())
                return;

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
                newDisco.Estilo = (Estilo)cbEstilo.SelectedItem;
                newDisco.TipoEdicion = (TipoEdicion)cbEdicion.SelectedItem;

                if (archivo != null && !txtImagen.Text.ToUpper().Contains("HTTP"))
                {
                    string extension = Path.GetExtension(archivo.SafeFileName);

                    string nuevoNombreArchivo = Path.GetFileNameWithoutExtension(archivo.SafeFileName) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + extension;

                    string path = getPath(nuevoNombreArchivo);

                    File.Copy(archivo.FileName, path);
                    
                    newDisco.ImagenTapa = path;

                } else
                {
                    newDisco.ImagenTapa = txtImagen.Text;
                }

                negocio.agregar(newDisco);

                MessageBox.Show("Disco agregado.", "Agregar Disco", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private bool validateFields()
        {
            Validation validation = new Validation();

            if (validation.isEmpty(txtTitulo.Text) || validation.isEmpty(txtAutor.Text) || validation.isEmpty(txtImagen.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            cargarComboBox();

            pbAgregarImagen.Load("https://cdn-icons-png.flaticon.com/512/1160/1160358.png");
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

        private void pbAgregarImagen_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbAgregarImagen_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pbAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "(*.jpg; *.png)|*.jpg; *.png;";
            archivo.Title = "Agregar Imagen";

            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        private string getPath(string fileName)
        {
            string pathDirectory = Environment.CurrentDirectory;
            string pathFather = System.IO.Directory.GetParent(pathDirectory).Parent.FullName;

            string pathImagenes = Path.Combine(pathFather, "Imagenes\\");

            string pathFinal = Path.Combine(pathImagenes, fileName);

            return pathFinal;

        }
    }
}
