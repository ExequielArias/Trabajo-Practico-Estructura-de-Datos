using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Forms; 

namespace Trabajo_Practico_Estructura_de_Datos
{
    internal class clsPila
    {

        //Campos de la clase
        private clsNodo pri;

       
        //Propiedades de la clase
        public clsNodo Primero 
        {
            get { return pri; }
            set { pri = value; }    
        }
        
        //
        public void Agregar(clsNodo Nuevo) 
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else 
            {
                Nuevo.siguiente = Primero;
                Primero = Nuevo; 
            }
        }

        public void Eliminar() 
        {
            if (Primero != null) 
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
