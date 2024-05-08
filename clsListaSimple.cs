using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_Estructura_de_Datos
{
    internal class clsListaSimple
    {
        //Campos de la clase
        private clsNodo pri;

        //Propiedades de la clase
        public clsNodo Primero 
        {
            get { return pri; } 
            set { pri = value; }
        }
        public void Agregar(clsNodo Nuevo) 
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.codigo <= Primero.codigo)
                {
                    Nuevo.siguiente = Primero;
                    Primero = Nuevo; 
                }
                else 
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (Nuevo.codigo > aux.codigo)
                    {
                        //En la variable ant guardo el valor que tenia aux anteriormente minetras la variable aux avanza
                        ant = aux;
                        aux = aux.siguiente;
                        if (aux == null)
                        {
                            break; 
                        }
                    }
                    ant.siguiente = Nuevo;
                    Nuevo.siguiente = aux; 
                }
            }
        }
        public void Eliminar(Int32 Codigo) 
        {
            if (Primero.codigo == Codigo)
            {
                Primero = Primero.siguiente;
            }
            else
            {
                clsNodo aux = Primero;
                clsNodo ant = Primero;
                while (aux.codigo != Codigo)
                {
                    ant = aux;
                    aux = aux.siguiente;    
                }
                ant.siguiente = aux.siguiente;
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
            StreamWriter AD = new StreamWriter("ListaSimple.csv", false, Encoding.UTF8);
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
        public void Recorrer(ComboBox cb) 
        {
            clsNodo aux = Primero;
            cb.Items.Clear();
            while (aux != null)
            {
                cb.Items.Add(aux.codigo);
                aux = aux.siguiente;
            }
        }
    }
}
