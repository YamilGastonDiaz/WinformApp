using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploWinform
{
    public partial class Detalle : Form
    {
        private Articulo articulo;
        public Detalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                ListViewItem nuevo = new ListViewItem(articulo.Descripcion);
                lbl_nombreA.Text = articulo.Nombre;
                lbl_code.Text = articulo.Codigo;
                lbl_categoria.Text = articulo.Categoria.ToString();
                lbl_marca.Text = articulo.Marca.ToString();
                lbl_precio.Text = "$" + articulo.Precio.ToString();
                txt_descripcion.Text = articulo.Descripcion;
                cargarImagen(articulo.Imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string url)
        {
            try
            {
                pbox_imgA.Load(url);
            }
            catch 
            {
                pbox_imgA.Load("https://i.pinimg.com/originals/6b/22/98/6b2298fec93ad8240f87c8228ab87969.jpg");
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
