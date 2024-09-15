using Dominio;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            try
            {
                // Crear una nueva instancia de Marca y MarcaNegocio
                Marca marca = new Marca();
                MarcaNegocio negocio = new MarcaNegocio();

                // Obtener la lista de marcas existentes
                List<Marca> lista = negocio.ListarMarcas();

                // Asignar la descripción desde el cuadro de texto
                marca.Descripcion = txtbox_agregarM.Text;

                // Verificar si la descripción está vacía
                if (string.IsNullOrWhiteSpace(marca.Descripcion))
                {
                    MessageBox.Show("Complete el campo.");
                    return; // Salir del método si el campo está vacío
                }

                // Verificar si la marca ya existe en la lista
                var existeMarca = (from m in lista
                                   where m.Descripcion.Equals(marca.Descripcion, StringComparison.OrdinalIgnoreCase)
                                   select m).Any();

                // Agregar la marca si no existe, o mostrar mensaje si ya existe
                if (!existeMarca)
                {
                    negocio.agregarMarcas(marca);
                    MessageBox.Show("Marca agregada correctamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Marca existente");
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
