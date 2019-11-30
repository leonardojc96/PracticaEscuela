using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaEscuela.Modelo;

namespace PracticaEscuela.Negocio.Cursos
{
    class CursosNegocio
    {
        public void Save(Curso curso)
        {
            Curso curso1 = new Curso();
            curso1.Save(curso);
        }

        public ICollection<Curso> Get()
        {
            Curso curso = new Curso();
            return curso.Get();
        }
    }
}
