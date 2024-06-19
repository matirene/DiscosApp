using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private void cargarData()
        {
            DiscoNegocio negocio = new DiscoNegocio();
            listaDiscos = negocio.listar();
            dgvDiscos.DataSource = listaDiscos;
            dgvDiscos.Columns["ImagenTapa"].Visible = false;
            cargarImagen(listaDiscos[0].ImagenTapa);
        }

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

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDisco.Load(imagen);
            }
            catch (Exception)
            {
                pbxDisco.Load("https://www.pngarts.com/files/3/CD-Transparent-Image.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco altaDisco = new frmAltaDisco();
            altaDisco.ShowDialog();
            cargarData();

        }


    }
}
