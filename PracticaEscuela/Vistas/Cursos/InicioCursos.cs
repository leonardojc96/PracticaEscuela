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
using PracticaEscuela.Modelo;
using PracticaEscuela.Negocio;
using PracticaEscuela.Negocio.Cursos;

namespace PracticaEscuela.Vistas.Cursos
{
    public partial class InicioCursos : Plantillas.InicioPlantilla
    {
        int i;
        CursosNegocio cursosNegocio = new CursosNegocio();
        public InicioCursos()
            :base("Grupos")
        {
            InitializeComponent();
        }

        private void InicioGrupo_Load(object sender, EventArgs e)
        {
            cursoBindingSource.DataSource = cursosNegocio.Get();

            activoCheckBox.Checked = true;
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validaciones.NoEsNullNiVacio(panelCampos))
                {
                    Curso curso = new Curso();
                    curso.CursoId = int.Parse(cursoIdTextBox.Text);
                    curso.Division = divisionTextBox.Text;
                    curso.Activo = activoCheckBox.Checked;
                    cursosNegocio.Save(curso);
                    MessageBox.Show("Guardado");
                    //object[] fnueva =
                    //{
                    //    curso.Id.ToString(),
                    //    curso.CursoId.ToString(),
                    //    curso.Division,
                    //    curso.Activo
                    //};

                    //cursoDataGridView.Rows.Insert(0, fnueva);
                }
                else
                {
                    MessageBox.Show("Completa todos los campos");
                }

                
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
