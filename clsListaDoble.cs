using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.IO; 

namespace Trabajo_Practico_Estructura_de_Datos
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult; 
       
        public clsNodo primero 
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo ultimo 
        {
            get { return ult; }
            set { ult = value; } 
        }
        public void Agregar(clsNodo nuevo) 
        {
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                if (nuevo.codigo < primero.codigo)
                {
                    nuevo.siguiente = primero; 
                    primero.anterior = nuevo;
                    primero = nuevo;
                }
                else
                {
                    if (nuevo.codigo > ultimo.codigo)
                    {
                        ultimo.siguiente = nuevo;
                        nuevo.anterior = ultimo;
                        ultimo = nuevo;
                    }
                    else
                    {
                        clsNodo aux = primero;
                        clsNodo ant = primero;
                        while (aux.codigo < nuevo.codigo)
                        {
                            ant = aux;
                            aux = aux.siguiente; 
                        }
                        ant.siguiente = nuevo;
                        nuevo.siguiente = aux;
                        aux.anterior = nuevo;
                        nuevo.anterior = ant; 
                    }
                }
            }
        }
        public void Eliminar(Int32 codigo) 
        {
            if (primero.codigo == codigo && ultimo == primero)
            {
                primero = null;
                ultimo = null;
            }
            else
            {
                if (primero.codigo == codigo)
                {
                    primero = primero.siguiente;
                    primero.anterior = null;
                }
                else
                {
                    if (ultimo.codigo == codigo)
                    {
                        ultimo = ultimo.anterior;
                        ultimo.anterior = null;
                    }
                    else
                    {
                        clsNodo aux = primero;
                        clsNodo ant = primero;
                        while (aux.codigo < codigo)
                        {
                            ant = aux;
                            aux = aux.siguiente; 
                        }
                        ant.siguiente = aux.siguiente;
                        aux = aux.siguiente;
                        aux.anterior = ant; 
                    }
                }
            }
        }
        public void RecorrerDes(DataGridView Grilla) 
        {
            clsNodo aux = ultimo; 
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.codigo, aux.nombre, aux.tramite);
                aux = aux.anterior; 
            }
        }
        public void RecorrerDes(ListBox Lista)
        {
            clsNodo aux = ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.codigo);
                aux = aux.anterior;
            }
        }
        public void RecorrerDes(ComboBox cb)
        {
            clsNodo aux = ultimo;
            cb.Items.Clear();
            while (aux != null)
            {
                cb.Items.Add(aux.codigo);
                aux = aux.anterior;
            }
        }
        public void RecorrerAsc(DataGridView Grilla) 
        {
            clsNodo aux = primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.codigo, aux.nombre, aux.tramite);
                aux = aux.siguiente;
            }
        }
        public void RecorrerAsc(ListBox Lista)
        {
            clsNodo aux = primero;
            Lista.Items.Add(aux.codigo);
            while (aux != null)
            {
                Lista.Items.Add(aux.codigo);
                aux = aux.siguiente;
            }
        }
        public void RecorrerAsc(ComboBox cb)
        {
            clsNodo aux = primero;
            cb.Items.Clear();
            while (aux != null)
            {
                cb.Items.Add(aux.codigo);
                aux = aux.siguiente;
            }
        }
        public void Recorrer()
        {
            clsNodo aux = primero;
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
