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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola FilaDePersonas = new clsCola();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsNodo objNodo = new clsNodo();
                objNodo.codigo = Convert.ToInt32(txtCodigo.Text);
                objNodo.nombre = txtNombre.Text;
                objNodo.tramite = txtTramite.Text;
                FilaDePersonas.Agregar(objNodo);
                FilaDePersonas.Recorrer(dgvGrilla);
                FilaDePersonas.Recorrer(lstCola);
                FilaDePersonas.Recorrer();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Necesita agregar Datos", "Error");
            }
            
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                txtCodigoE.Text = FilaDePersonas.Primero.codigo.ToString();
                txtNombreE.Text = FilaDePersonas.Primero.nombre;
                txtTramiteE.Text = FilaDePersonas.Primero.tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvGrilla);
                FilaDePersonas.Recorrer(lstCola);
                FilaDePersonas.Recorrer();
            }
            else
            {
                txtCodigoE.Text = "";
                txtNombreE.Text = "";
                txtTramiteE.Text = ""; 
            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {
            txtCodigoE.Enabled = false;
            txtNombreE.Enabled = false;
            txtTramiteE.Enabled = false;    
        }
    }
}
