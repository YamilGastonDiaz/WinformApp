using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace EjemploWinform
{
    public partial class VentanaPrincipal : Form
    {
        private List<Articulo> listaArticulo;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloM = new ArticuloNegocio();
            listaArticulo = articuloM.listaParaImagenes();
            dgv_articulos.DataSource = articuloM.listaParaImagenes().GroupBy(a => a.Codigo).Select(group => group.First()).ToList();
            dgv_articulos.Columns[0].Visible = false;
            dgv_articulos.Columns[6].Visible = false;
            cargarImagen(listaArticulo[0].Imagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbx_articulo.Load(imagen);
            }
            catch (Exception)
            {
                pbx_articulo.Load("https://i.pinimg.com/originals/6b/22/98/6b2298fec93ad8240f87c8228ab87969.jpg");

            }
        }

        private int imagenActual = 0;
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgv_articulos.CurrentRow.DataBoundItem;
            int totalImagenes = seleccionado.Imagenes.Count;

            if (totalImagenes > 0)
            {
                imagenActual --;

                if (imagenActual < 0)
                {
                    imagenActual = totalImagenes - 1;
                }

                cargarImagen(seleccionado.Imagenes[imagenActual]);
            }
            else
            {
                MessageBox.Show("No hay imágenes disponibles");
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgv_articulos.CurrentRow.DataBoundItem;
            int totalImagenes = seleccionado.Imagenes.Count;

            if (totalImagenes > 0)
            {
                imagenActual++;

                if (imagenActual >= totalImagenes)
                {
                    imagenActual = 0;
                }

                cargarImagen(seleccionado.Imagenes[imagenActual]);
            }
            else
            {
                MessageBox.Show("No hay imágenes disponibles");
            }
        }

        private void dgv_articulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_articulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgv_articulos.CurrentRow.DataBoundItem;

                if (seleccionado != null && seleccionado.Imagenes != null)
                {
                    int cant = seleccionado.Imagenes.Count();
                    cargarImagen(seleccionado.Imagen);
                }
            }
        }

        private void tsm_modificar_Click(object sender, EventArgs e)
        {
            ModificarMarca ventana = new ModificarMarca();
            ventana.ShowDialog();
        }

        private void tsm_eliminar_Click(object sender, EventArgs e)
        {
            EliminarMarca ventana = new EliminarMarca();
            ventana.ShowDialog();
        }

        private void AgregarMarca_Click(object sender, EventArgs e)
        {
            AgregarMarca ventana = new AgregarMarca();
            ventana.ShowDialog();
        }

        private void tsm_listar_Click(object sender, EventArgs e)
        {
            ListarMarca ventana = new ListarMarca();
            ventana.ShowDialog();
        }

        private void btn_detalle_Click(object sender, EventArgs e)
        {
            Articulo mostrar;
            if (dgv_articulos.CurrentRow != null)
            {
                mostrar = (Articulo)dgv_articulos.CurrentRow.DataBoundItem;
                Detalle ventana = new Detalle(mostrar);
                ventana.ShowDialog();
            }
            else
            {
                MessageBox.Show("No selecciono ningun articulo");
            }
        }
    }
}
