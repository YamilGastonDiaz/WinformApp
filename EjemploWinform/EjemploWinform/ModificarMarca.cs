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
    public partial class ModificarMarca : Form
    {
        private List<Marca> listaMarca;
        private Marca seleccionada;
        public ModificarMarca()
        {
            InitializeComponent();
        }

        private void ModificarMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            listaMarca = negocio.ListarMarcas();
            dgv_marca.DataSource = listaMarca;
        }

        private void dgv_marca_SelectionChanged(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            seleccionada = (Marca)dgv_marca.CurrentRow.DataBoundItem;
            txt_modificarM.Text = seleccionada.Descripcion;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            List<Marca> lista = new List<Marca>();

            lista = negocio.ListarMarcas();

            try
            {
                string modificado = txt_modificarM.Text;

                if (modificado == "")
                {
                    MessageBox.Show("Complete el campo.");
                }
                else
                {
                    seleccionada.Descripcion = modificado;
                    negocio.modificarMarca(seleccionada);
                    MessageBox.Show("Marca modificada correctamente");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
