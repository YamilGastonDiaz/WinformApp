using Dominio;
using Negocio;
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
    public partial class EliminarMarca : Form
    {
        public EliminarMarca()
        {
            InitializeComponent();
        }

        private void EliminarMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            List<Marca> lista = negocio.ListarMarcas();
            dgv_eliminar.DataSource = lista;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionada;

            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro desea elminar la marca?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Marca)dgv_eliminar.CurrentRow.DataBoundItem;
                    negocio.eliminarMarca(seleccionada.Id);
                    Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
