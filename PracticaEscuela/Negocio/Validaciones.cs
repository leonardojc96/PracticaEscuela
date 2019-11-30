using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEscuela.Negocio
{
    public static class Validaciones
    {
        public static bool ExisteFormulario(string formName, Form f)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (!(form.Name == "Inicio"))
                {
                    if (form.Name == formName)
                    {
                        form.Show();
                        form.BringToFront();
                        return true;
                    }
                }
                
            }

            return false;
        }

        public static void CambiarEnable(Form form)
        {
            foreach (Control item in form.Controls)
            {
                item.Enabled = true;
            }
        }

        public static bool NoEsNullNiVacio(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (string.IsNullOrEmpty(item.Text) || item is null)
                {
                    return false;
                }
            }

            return true;
        } 
    }
}
