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
    public partial class AgregarMarca : Form
    {
        public AgregarMarca()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            List<Marca> lista = new List<Marca>();

            lista = negocio.ListarMarcas();

            try
            {
                marca.Descripcion = txtbox_agregarM.Text;

                if (marca.Descripcion == "")
                {
                    MessageBox.Show("Complete el campo.");
                }
                else
                {
                    negocio.agregarMarcas(marca);
                    MessageBox.Show("Marca agregada correctaente");
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
