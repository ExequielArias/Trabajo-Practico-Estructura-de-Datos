using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_Estructura_de_Datos
{

    internal class clsArbolBinario
    {
        //Creo el campo inicial del arbol. Lo llamaremos raiz
        private clsNodo PrimerNodo;

        //Creo la unica propiedad que necesito
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (cod == Aux.codigo)
                {
                    break;
                }
                if (cod > Aux.codigo)
                {
                    Aux = Aux.izquierdo;
                }
                else
                {
                    Aux = Aux.derecho;
                }
            }
            return Aux;
        }

        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.izquierdo = null;
            Nuevo.derecho = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo Padre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    Padre = Aux;
                    if (Nuevo.codigo < Aux.codigo)
                    {
                        Aux = Aux.izquierdo;
                    }
                    else
                    {
                        Aux = Aux.derecho;
                    }
                }
                if (Nuevo.codigo < Padre.codigo)
                {
                    Padre.izquierdo = Nuevo;
                }
                else
                {
                    Padre.derecho = Nuevo;
                }
            }
        }

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;

        public void Equilibrar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private void GrabarVectorInOrden(clsNodo padre)
        {
            if (padre.izquierdo != null)
            {
                GrabarVectorInOrden(padre.izquierdo);
            }
            Vector[i] = padre;
            i = i + 1;
            if (padre.derecho != null)
            {
                GrabarVectorInOrden(padre.derecho);
            }
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private void GrabarVectorInOrden(clsNodo padre, Int32 codigo)
        {
            if (padre.izquierdo != null)
            {
                GrabarVectorInOrden(padre.izquierdo, codigo);
            }
        }
        public void Recorrer() 
        {
            clsNodo aux = Raiz;
            StreamWriter AD = new StreamWriter("Arbol Binario.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo, Nombre, Tranite");
            InOrdenAsc(Raiz, AD);
            AD.Close(); 
        }
        private void InOrdenAsc(clsNodo R, StreamWriter AD) 
        {
            if (R.izquierdo != null)
            {
                InOrdenAsc(R.izquierdo, AD);
            }
            AD.Write(R.codigo);
            AD.Write(";");
            AD.Write(R.nombre);
            AD.Write(";");
            AD.Write(R.tramite);
            if (R.derecho != null)
            {
                InOrdenAsc(R.derecho, AD); 
            }
        }

        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenAsc(ComboBox lst, clsNodo R)
        {
            if (R.izquierdo != null)
            {
                InOrdenAsc(lst, R.izquierdo);
            }
            lst.Items.Add(R.codigo);
            if (R.derecho != null)
            {
                InOrdenAsc(lst, R.derecho);
            }
        }
        public void Recorrer(ListBox Lista) 
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz); 
        }
        public void InOrdenAsc(ListBox Lst, clsNodo R) 
        {
            if (R.izquierdo != null)
            {
                InOrdenAsc(Lst, R.izquierdo); 
            }
            Lst.Items.Add(R.codigo);
            if (R.derecho != null)
            {
                InOrdenAsc(Lst, R.derecho); 
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.izquierdo != null)
            {
                InOrdenAsc(Dgv, R.izquierdo);
            }
            Dgv.Rows.Add(R.codigo, R.nombre, R.tramite);
            if (R.derecho != null)
            {
                InOrdenAsc(Dgv, R.derecho);
            }
        }

        private void InOrdenDes(ListBox lst, clsNodo R)
        {
            if (R.derecho != null)
            {
                InOrdenAsc(lst, R.derecho);
            }
            lst.Items.Add(R.codigo);
            if (R.izquierdo != null)
            {
                InOrdenAsc(lst, R.izquierdo);
            }
        }
        public void PreOrden(ComboBox lst, clsNodo R)
        {
            lst.Items.Add(R.codigo);
            if (R.izquierdo != null)
            {
                PreOrden(lst, R.izquierdo);
            }
            if (R.derecho != null)
            {
                PreOrden(lst, R.derecho);
            }
        }
        public void PostOrden(ComboBox lst, clsNodo R)
        {
            if (R.izquierdo != null)
            {
                PostOrden(lst, R.izquierdo);
            }
            if (R.derecho != null)
            {
                PostOrden(lst, R.derecho);
            }
            lst.Items.Add(R.codigo);
        }
        public void RecorrerPre(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode Padre = new TreeNode("Arbol");
            tree.Nodes.Add(Padre);
            PreOrden(Raiz, Padre);
            tree.ExpandAll();
        }
        public void RecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Raiz, Grilla);
        }

        private void PreOrden(clsNodo R, DataGridView Grilla)
        {
            Grilla.Rows.Add(R.codigo, R.nombre, R.tramite);
            if (R.izquierdo != null) 
            {
                PreOrden(R.izquierdo, Grilla);
            }
            if (R.derecho != null) 
            {
                PreOrden(R.derecho, Grilla);
            } 
        }

        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode Padre = new TreeNode(R.codigo.ToString());
            nodoTreeView.Nodes.Add(Padre);
            if (R.izquierdo != null)
            {
                PreOrden(R.izquierdo, Padre);
            }
            if (R.derecho != null)
            {
                PreOrden(R.derecho, Padre);
            }
        }

        public void RecorrerDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDes(Grilla, Raiz);
        }
        private void InOrdenDes(DataGridView Dgv, clsNodo R)
        {
            if (R.derecho != null)
            {
                InOrdenAsc(Dgv, R.derecho);
            }
            Dgv.Rows.Add(R.codigo, R.nombre, R.tramite);
            if (R.izquierdo != null)
            {
                InOrdenAsc(Dgv, R.izquierdo);
            }
        }

        public void RecorrerDes(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDes(Lista, Raiz);
        }
        private void InOrdenDes(ComboBox lst, clsNodo R)
        {
            if (R.derecho != null)
            {
                InOrdenAsc(lst, R.derecho);
            }
            lst.Items.Add(R.codigo);
            if (R.izquierdo != null)
            {
                InOrdenAsc(lst, R.izquierdo);
            }
        }
        
       
       
        
        
    }
}
