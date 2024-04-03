using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Trabajo_Practico_Estructura_de_Datos
{
    internal class clsCola
    {
        //declaracion de los campos 
        private clsNodo pri;
        private clsNodo ult;

        
        //propiedades de la clase
        public clsNodo Primero 
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo 
        {
            get { return ult; }
            set { ult = value; }
        }


        //Metodos de la clase 
        public void Agregar(clsNodo Nuevo) 
        {
            if (Primero == null && Ultimo == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Ultimo.siguiente = Nuevo;
            }
            Ultimo = Nuevo; 
        }

        public void Eliminar() 
        {
            if (Primero == Ultimo) //si tengo un solo dato(nodo), lo elimino
            {
                Primero = null;
                Ultimo = null;
            }
            else //si tengo mas de un dato, elimino el primero y me enfoco en el que sigue 
            {
                Primero = Primero.siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla) 
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.codigo, aux.nombre, aux.tramite);
                aux = aux.siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.codigo);
                aux = aux.siguiente;
            }
        }

        public void Recorrer() 
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("codigo; nombre; tramite");
            while (aux != null)
            {
                AD.Write(aux.codigo);
                AD.Write(";");
                AD.Write(aux.nombre);
                AD.Write(";");
                AD.Write(aux.tramite);
                AD.Write(";");
                aux = aux.siguiente;
            }
            AD.Close(); 
        }


    }
}
