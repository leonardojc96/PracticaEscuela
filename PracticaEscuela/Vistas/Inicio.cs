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
using PracticaEscuela.Negocio;

namespace PracticaEscuela
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void escuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ExisteFormulario("InicioInscripciones", this))
            {
                Vistas.Inscripciones.InicioInscripciones inicio = new Vistas.Inscripciones.InicioInscripciones();
                inicio.MdiParent = this;
                inicio.Dock = DockStyle.Fill;
                inicio.Show();
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            if (!Validaciones.ExisteFormulario("InicioAlumno", this))
            {
                Vistas.Alumnos.InicioAlumno inicioAlu = new Vistas.Alumnos.InicioAlumno();
                inicioAlu.MdiParent = this;
                inicioAlu.Dock = DockStyle.Fill;
                inicioAlu.Show();
            }
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ExisteFormulario("InicioAlumno", this))
            {
                Vistas.Alumnos.InicioAlumno inicioAlu = new Vistas.Alumnos.InicioAlumno();
                inicioAlu.MdiParent = this;
                inicioAlu.Dock = DockStyle.Fill;
                inicioAlu.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ExisteFormulario("InicioCursos", this))
            {
                Vistas.Cursos.InicioCursos inicioCur = new Vistas.Cursos.InicioCursos();
                inicioCur.MdiParent = this;
                inicioCur.Dock = DockStyle.Fill;
                inicioCur.Show();
            }
        }
    }
}
