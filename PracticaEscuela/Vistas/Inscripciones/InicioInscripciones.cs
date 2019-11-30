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

namespace PracticaEscuela.Vistas.Inscripciones
{
    public partial class InicioInscripciones : Plantillas.InicioPlantilla
    {
        public InicioInscripciones()
            :base ("Inscripciones")
        {
            InitializeComponent();
        }

        private void InicioInscripciones_Load(object sender, EventArgs e)
        {

        }
    }
}
