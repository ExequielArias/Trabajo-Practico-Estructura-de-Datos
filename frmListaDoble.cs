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
                Lista.Recorrer(dgvGrillaListaDoble);
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer(cbCodigoEliminado);
                Lista.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista esta vacia", "Error", MessageBoxButtons.OK);
            }
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.nombre = txtNombre.Text;
            objNodo.tramite = txtTramite.Text;

            Lista.Agregar(objNodo);
            Lista.Recorrer(dgvGrillaListaDoble);
            Lista.Recorrer(lstListaDoble);
            Lista.Recorrer(cbCodigoEliminado);
            Lista.Recorrer();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void dgvGrillaListaDoble_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.Recorrer(dgvGrillaListaDoble);
            Lista.Recorrer(lstListaDoble);
            Lista.Recorrer(cbCodigoEliminado);
            Lista.Recorrer();
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerDes(dgvGrillaListaDoble);
            Lista.RecorrerDes(lstListaDoble);
            Lista.RecorrerDes(cbCodigoEliminado);
            Lista.RecorrerDes();
        }
    }
}
