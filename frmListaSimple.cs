using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trabajo_Practico_Estructura_de_Datos
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple Lista = new clsListaSimple();

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cbCodigoEliminado.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvGrillaListaSimple);
                Lista.Recorrer(lstListaSimple);
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
            try
            {
                clsNodo objNodo = new clsNodo();
                objNodo.codigo = Convert.ToInt32(txtCodigo.Text);
                objNodo.nombre = txtNombre.Text;
                objNodo.tramite = txtTramite.Text;
                Lista.Agregar(objNodo);
                Lista.Recorrer(dgvGrillaListaSimple);
                Lista.Recorrer(lstListaSimple);
                Lista.Recorrer(cbCodigoEliminado);
                Lista.Recorrer();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Agregue Datos", "Error"); 
            }
           
        }

        private void cbCodigoEliminado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
