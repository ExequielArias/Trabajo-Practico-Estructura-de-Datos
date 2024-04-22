using System;
using System.Collections.Generic;
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
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode Padre = new TreeNode("Arbol");
            tree.Nodes.Add(Padre);
            PreOrden(Raiz, Padre);
            tree.ExpandAll();
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
