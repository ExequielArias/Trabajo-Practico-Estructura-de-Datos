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
            try
            {
                clsNodo objNodo = new clsNodo();
                objNodo.codigo = Convert.ToInt32(txtCodigo.Text);
                objNodo.nombre = txtNombre.Text;
                objNodo.tramite = txtTramite.Text;
                Lista.Agregar(objNodo);
                Lista.Recorrer(dgvGrillaArbolBinario);
                Lista.Recorrer(cbCodigoEliminado);
                Lista.RecorrerPre(tvMostrar);
                Lista.Recorrer();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese Datos", "Error");
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Lista.Eliminar(Convert.ToInt32(cbCodigoEliminado.Text));
                if (Lista.Raiz != null)
                {
                    Lista.Recorrer(dgvGrillaArbolBinario);
                    Lista.RecorrerPre(tvMostrar);
                    Lista.Recorrer(cbCodigoEliminado);
                    Lista.Recorrer(); 
                }
                else
                {
                    cbCodigoEliminado.Items.Clear();
                    dgvGrillaArbolBinario.Rows.Clear();
                    tvMostrar.Nodes.Clear();
                }
                cbCodigoEliminado.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay datos a eliminar", "Error"); 
            }
        }

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optInOrden.Checked)
            {
                Lista.Recorrer(dgvGrillaArbolBinario);
                Lista.Recorrer(cbCodigoEliminado);
            }
        }

        private void InOrdenDes_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerDes(dgvGrillaArbolBinario);
            Lista.RecorrerDes(cbCodigoEliminado);
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPreOrden.Checked)
            {
                Lista.RecorrerPre(dgvGrillaArbolBinario);
                Lista.RecorrerPre(tvMostrar); 
            }
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPostOrden.Checked)
            {

            }
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void cmdEquilibrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
