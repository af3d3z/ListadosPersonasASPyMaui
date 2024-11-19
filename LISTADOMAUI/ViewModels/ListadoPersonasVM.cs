using DALEJ1;
using ListadoPersonasENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTADOMAUI.ViewModels
{
    public class ListadoPersonasVM
    {
        private List<Persona>? _personas;

        public List<Persona> Personas
        {
            get {
                try
                {
                    _personas = ListadosDAL.ListadoCompletoPersonasDAL();
                }
                catch (Exception e) {
                    _personas = null;
                }
                return _personas; 
            }
            set { _personas = value; }
        }
    }
}
