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
    public partial class frmBaseDeDatos : Form
    {
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }
        clsBaseDeDatos objBaseDatos = new clsBaseDeDatos();

        private void button3_Click(object sender, EventArgs e)
        {
            string varSQL = @"SELECT Libro.Titulo, Autor.Nombre FROM Libro
                            INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
            objBaseDatos.Listar(dgvMostrar, varSQL);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT TITULO, IDAUTOR FROM LIBRO WHERE IDAUTOR <> 5 ORDER BY TITULO DESC";
            objBaseDatos.Listar(dgvMostrar, varSQL); 
        }

        private void cmdProyeccionSimple_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvMostrar, varSQL); 
        }

        private void cmdProyeccionMulti_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT TITULO, AÑO FROM LIBRO ORDER BY TITULO ASC";
            objBaseDatos.Listar(dgvMostrar, varSQL); 
        }

        private void cmdSeleccionMulti_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT TITULO, IDAUTOR AS AUTOR, IDIDIOMA AS IDIOMA" +
                " FROM LIBRO " +
                "WHERE IDAUTOR <> 5 AND IDIDIOMA = 8 " +
                "ORDER BY TITULO ASC";
            objBaseDatos.Listar(dgvMostrar, varSQL);
        }

        private void cmdUnion_Click(object sender, EventArgs e)
        {
            string varSQL = "(SELECT * FROM LIBRO WHERE IDIDIOMA = 5) UNION " +
                "(SELECT * " +
                "FROM LIBRO " +
                "WHERE IDIDIOMA = 9) ";
            objBaseDatos.Listar(dgvMostrar, varSQL); 
        }

        private void cmdInterseccion_Click(object sender, EventArgs e)
        {
            string varSQL = @"SELECT * FROM Libro WHERE IdIdioma IN 
                            (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            objBaseDatos.Listar(dgvMostrar, varSQL);
        }

        private void cmdSeleccionXConvul_Click(object sender, EventArgs e)
        {
            string varSQL = @"SELECT * FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10";
            objBaseDatos.Listar(dgvMostrar, varSQL);
        }

        private void cmdDiferencia_Click(object sender, EventArgs e)
        {
            string varSQL = @"SELECT * FROM Libro WHERE IdIdioma NOT IN
                    (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            objBaseDatos.Listar(dgvMostrar, varSQL);
        }
    }
}
