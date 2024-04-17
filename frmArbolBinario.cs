using System;
using System.Collections;
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
    public partial class frmArbolBinario : Form
    {
        clsArbolBinario Lista = new clsArbolBinario(); 
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.nombre = txtNombre.Text;
            objNodo.tramite = txtTramite.Text;

            Lista.Agregar(objNodo);
            Lista.Recorrer(dgvGrillaArbolBinario);
            Lista.Recorrer(cbCodigoEliminado);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }
    }
}
