using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_Estructura_de_Datos
{
    public partial class frmListaDoble : Form
    {
        clsListaDoble Lista = new clsListaDoble();
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.primero != null)
            {
                Int32 x = Convert.ToInt32(cbCodigoEliminado.Text);
                Lista.Eliminar(x);
                Lista.RecorrerAsc(dgvGrillaListaDoble);
                Lista.RecorrerAsc(lstListaDoble);
                Lista.RecorrerAsc(cbCodigoEliminado);
                Lista.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista esta vacia", "Error", MessageBoxButtons.OK);
            }
            cmdEliminar.Enabled = false;
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.nombre = txtNombre.Text;
            objNodo.tramite = txtTramite.Text;
            if (optAscendente.Checked)
            {
                Lista.Agregar(objNodo);
                Lista.RecorrerAsc(dgvGrillaListaDoble);
                Lista.RecorrerAsc(lstListaDoble);
                Lista.RecorrerAsc(cbCodigoEliminado);
                Lista.Recorrer();
            }
            else
            {
                if (optDescendente.Checked)
                {
                    Lista.Agregar(objNodo);
                    Lista.RecorrerDes(dgvGrillaListaDoble);
                    Lista.RecorrerDes(lstListaDoble);
                    Lista.RecorrerDes(cbCodigoEliminado);
                    Lista.Recorrer();
                }
            }
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }
    }
}
