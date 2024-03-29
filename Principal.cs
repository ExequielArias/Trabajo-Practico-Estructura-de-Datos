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
    public partial class frmEstructuraDeDatos : Form
    {
        public frmEstructuraDeDatos()
        {
            InitializeComponent();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosMiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDatosMios Datos = new frmDatosMios();
            Datos.ShowDialog(); 
        }

        private void frmEstructuraDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructurasLineales estructurasLineales = new frmEstructurasLineales();
            estructurasLineales.ShowDialog();
        }

        private void estructurasNoLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructurasNoLineales estructurasNoLineales = new frmEstructurasNoLineales();
            estructurasNoLineales.ShowDialog();
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDeDatos BD = new frmBaseDeDatos();
            BD.ShowDialog();
        }
    }
}
