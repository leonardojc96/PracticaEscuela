using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaEscuela.Vistas;

namespace PracticaEscuela.Vistas.Alumnos
{
    public partial class InicioAlumno : Plantillas.InicioPlantilla
    {
        public InicioAlumno()
            :base("Alumnos")
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
