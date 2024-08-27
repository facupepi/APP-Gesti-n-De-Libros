using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador___Biblioteca
{
    public partial class ModificarLibro : Form
    {
        public ModificarLibro(int IDLibro)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            string s = "Data Source=LENOVO-LEGION-5;Initial Catalog=Integrador-Libreria;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();

            string consulta = "SELECT * FROM Libros WHERE LibroID = "+IDLibro;

            SqlCommand comando = new SqlCommand(consulta, conexion);
            try{
                    comando.ExecuteNonQuery();
                }
            catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            DataTable dt_actualizado = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

            adaptador.Fill(dt_actualizado);

            dataGridView_Libro.DataSource = dt_actualizado;

            conexion.Close();

        }

        private void ModificarLibro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Integrador_LibreriaDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this._Integrador_LibreriaDataSet.Libros);

        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            string s = "Data Source=LENOVO-LEGION-5;Initial Catalog=Integrador-Libreria;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();

            DataGridViewRow item = new DataGridViewRow();
            item = dataGridView_Libro.Rows[0];


            string sentencia_actualizacion = "UPDATE Libros SET " +
                                            "Titulo = @Titulo, " +
                                            "Genero = @Genero, " +
                                            "FechaPublicacion = @FechaPublicacion, " +
                                            "ISBN = @ISBN, " +
                                            "AutorID = @AutorID, " +
                                            "EditorialID = @EditorialID, " +
                                            "NumeroPaginas = @NumeroPaginas, " +
                                            "Idioma = @Idioma " +
                                            "WHERE LibroID = @LibroID";

            // Creación del comando SQL
            SqlCommand comando = new SqlCommand(sentencia_actualizacion, conexion);

            // Asignación de valores a los parámetros
            comando.Parameters.AddWithValue("@Titulo", item.Cells[1].Value);
            comando.Parameters.AddWithValue("@Genero", item.Cells[2].Value);
            comando.Parameters.AddWithValue("@FechaPublicacion", item.Cells[3].Value);
            comando.Parameters.AddWithValue("@ISBN", item.Cells[4].Value);
            comando.Parameters.AddWithValue("@AutorID", item.Cells[5].Value);
            comando.Parameters.AddWithValue("@EditorialID", item.Cells[6].Value);
            comando.Parameters.AddWithValue("@NumeroPaginas", item.Cells[7].Value);
            comando.Parameters.AddWithValue("@Idioma", item.Cells[8].Value);
            comando.Parameters.AddWithValue("@LibroID", item.Cells[0].Value);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            conexion.Close();
            this.Close();
            Libros libros = new Libros();
            libros.volver_a_libros();
            libros.Show();
        }
    }
}
