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
using dominio;
using negocio;

namespace discosApp
{
    public partial class FormDiscos : Form
    {
        // Atributos
        private List<Disco> listaDiscos;

        // Constructor
        public FormDiscos()
        {
            InitializeComponent();
        }


        // Metodos

        private void FormDiscos_Load(object sender, EventArgs e)
        {
            cargarData();
            dgvDiscos.ColumnHeadersHeight = 50;

        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenTapa);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco altaDisco = new frmAltaDisco();
            altaDisco.ShowDialog();
            cargarData();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvDiscos.CurrentRow != null)
            {
                Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                frmModificarDisco modificarDisco = new frmModificarDisco(seleccionado);
                modificarDisco.ShowDialog();

                cargarData();

                //ELiminamos la imagen anterior.
                if(File.Exists(modificarDisco.imageOld))
                    File.Delete(modificarDisco.imageOld);

            } else
            {
                MessageBox.Show("No hay un disco para modificar.", "Modificar Disco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvDiscos.CurrentRow != null)
            {
                Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

                DialogResult resultado = MessageBox.Show("Estas seguro de eliminar el disco " + seleccionado.Titulo.ToUpper() + " ?", "Eliminar Disco", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.No)
                    return;

                DiscoNegocio negocio = new DiscoNegocio();
                negocio.eliminar(seleccionado);

                MessageBox.Show("Disco eliminado.", "Eliminar Disco", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarData();

                if (File.Exists(seleccionado.ImagenTapa))
                    File.Delete(seleccionado.ImagenTapa);

            } else
            {
                MessageBox.Show("No hay disco para eliminar.", "Eliminar Disco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargarData()
        {
            DiscoNegocio negocio = new DiscoNegocio();
            listaDiscos = negocio.listar();
            dgvDiscos.DataSource = listaDiscos;
            dgvDiscos.Columns["ImagenTapa"].Visible = false;
            cargarImagen(listaDiscos[0].ImagenTapa);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDisco.Load(imagen);
            }
            catch (Exception)
            {
                pbxDisco.Load("https://i.postimg.cc/05tBmPPt/CD-Transparent-Image-1.png");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;

            string filtro = txtFiltro.Text;

            if (filtro.Length > 0)
                listaFiltrada = listaDiscos.FindAll(disco => disco.Titulo.ToUpper().Trim().Contains(filtro.ToUpper().Trim()) || disco.Autor.ToUpper().Trim().Contains(filtro.ToUpper().Trim()) || disco.Estilo.Descripcion.ToUpper().Trim().Contains(filtro.ToUpper().Trim()));
            else
                listaFiltrada = listaDiscos;

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource= listaFiltrada;
            dgvDiscos.Columns["ImagenTapa"].Visible = false;

        }
    }
}
