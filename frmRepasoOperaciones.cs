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
    public partial class frmRepasoOperaciones : Form
    {
        public frmRepasoOperaciones()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos db = new clsBaseDeDatos();
            string varSQL = "";
            switch (cboLista.SelectedIndex)
            {
                case 0:
                    varSQL = "SELECT Titulo FROM Libro";
                    db.Listar(dgvGrilla, varSQL);
                    break;
                case 1:
                    varSQL = "SELECT Nombre FROM Idioma";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 2:
                    varSQL = "SELECT Titulo,Año FROM Libro WHERE Precio < 800";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 3:
                    varSQL = "SELECT IdAutor,Nombre FROM Autor WHERE IdAutor < 10";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 4:
                    varSQL = @"SELECT Libro.Titulo, Autor.Nombre
                        FROM Libro
                        INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 5:
                    varSQL = @"SELECT Libro.Titulo, Idioma.Nombre
                        FROM Libro
                        INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 6:
                    varSQL = "SELECT * FROM Libro WHERE IdIdioma = 2";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 7:
                    varSQL = "SELECT * FROM Pais";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 8:
                    varSQL = "SELECT Titulo,Año,Precio FROM Libro WHERE Precio = 125";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 9:
                    varSQL = "SELECT Titulo,Año,Precio FROM Libro WHERE Precio> 800";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 10:
                    varSQL = @"SELECT * FROM 
                    (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 11:
                    varSQL = @"SELECT * FROM 
                    (SELECT * FROM Libro as T1 WHERE T1.Precio > 300) as T2 WHERE T2.IdIdioma > 3";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 12:
                    varSQL = @"SELECT * FROM Libro WHERE IdIdioma = 3
                        UNION
                        SELECT * FROM Libro WHERE IdIdioma = 4
                        UNION
                        SELECT * FROM Libro WHERE IdIdioma = 2";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 13:
                    varSQL = @"SELECT * FROM Libro WHERE Precio = 125
                        UNION
                        SELECT * FROM Libro WHERE Precio = 854
                        UNION
                        SELECT * FROM Libro WHERE Precio = 789";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 14:
                    varSQL = @"SELECT * FROM Libro WHERE IdIdioma
                            IN 
                            (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 15:
                    varSQL = @"SELECT * FROM Libro WHERE IdAutor
                            IN 
                            (SELECT DISTINCT IdAutor FROM Libro WHERE IdAutor > 70)";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 16:
                    varSQL = @"SELECT * FROM Libro WHERE IdIdioma
                    NOT IN
                    (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 17:
                    varSQL = @"SELECT * FROM Libro WHERE IdAutor
                    NOT IN
                    (SELECT DISTINCT IdAutor FROM Libro WHERE IdAutor > 50)";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 18:
                    varSQL = "SELECT Nombre FROM Idioma";
                    db.Listar(dgvGrilla, varSQL);

                    break;
                case 19:
                    varSQL = "SELECT Nombre FROM Autor";
                    db.Listar(dgvGrilla, varSQL);

                    break;
            }
        }
    }
}
