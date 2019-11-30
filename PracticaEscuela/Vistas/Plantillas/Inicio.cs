using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEscuela.Vistas.Plantillas
{
    public partial class InicioPlantilla : Form
    {
        string titulo = "Inicio";

        public InicioPlantilla()
        {
            InitializeComponent();
        }
        public InicioPlantilla(string titulo)
        {
            InitializeComponent();
            this.titulo = titulo;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'escuelaDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            lblTitulo.Text = titulo;
            lblTitulo.Width = Parent.Width;
        }

        private void alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }
    }
}
