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
            
        }

        private void estructurasNoLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void colaToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            frmCola cola = new frmCola();
            cola.ShowDialog();
        }

        private void pilaToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            frmPila pila = new frmPila();
            pila.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple ListaSimple = new frmListaSimple();
            ListaSimple.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble ListaDoble = new frmListaDoble(); 
            ListaDoble.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario Binario = new frmArbolBinario();    
            Binario.ShowDialog();   
        }

        private void consultasEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBaseDeDatos ConsultaBaseDeDatos = new frmConsultaBaseDeDatos();
            ConsultaBaseDeDatos.ShowDialog();
        }

        private void operacionesConTablasDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDeDatos baseD = new frmBaseDeDatos();
            baseD.ShowDialog(); 
        }
    }
}
