using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Estructura_de_Datos
{
    internal class clsNodo
    {
        //campos del nodo
        private Int32 cod;
        private string nom;
        private string tra;
        private clsNodo sig; 

        //propiedades del nodo
        public Int32 codigo 
        {
            get { return cod; }
            set { cod = value; }
        }
        public string nombre 
        {
            get { return nom; }
            set { nom = value; }    
        }
        public string tramite 
        {
            get { return tra; } 
            set { tra = value; }
        }
        public clsNodo siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}
