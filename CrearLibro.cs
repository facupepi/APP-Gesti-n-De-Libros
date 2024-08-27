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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Integrador___Biblioteca
{
    public partial class CrearLibro : Form
    {
        public CrearLibro()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Data Source=LENOVO-LEGION-5;Initial Catalog=Integrador-Libreria;Integrated Security=True";

            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();

            using (conexion)
            {
                try
                {
                    string sentencia_insercion = "INSERT INTO Libros (Titulo, Genero, FechaPublicacion, ISBN, AutorID, EditorialID, NumeroPaginas, Idioma) " +
                                                 "VALUES (@Titulo, @Genero, @FechaPublicacion, @ISBN, @AutorID, @EditorialID, @NumeroPaginas, @Idioma)";

                    using (SqlCommand comando_ins = new SqlCommand(sentencia_insercion, conexion))
                    {
                        // Suponiendo que tienes los valores en variables o controles de formulario
                        comando_ins.Parameters.AddWithValue("@Titulo", textBox_titulo.Text); // Reemplaza con el valor real
                        comando_ins.Parameters.AddWithValue("@Genero", textBox_genero.Text); // Reemplaza con el valor real
                        comando_ins.Parameters.AddWithValue("@FechaPublicacion", textBox_fecha.Text); // Reemplaza con el valor real
                        comando_ins.Parameters.AddWithValue("@ISBN", textBox_ISBN.Text); // Reemplaza con el valor real
                        comando_ins.Parameters.AddWithValue("@AutorID", textBox_AutorID.Text); // Reemplaza con el valor real
                        comando_ins.Parameters.AddWithValue("@EditorialID", textBox_Editorial.Text); // Reemplaza con el valor real
                        comando_ins.Parameters.AddWithValue("@NumeroPaginas", textBox_paginas.Text); // Reemplaza con el valor real
                        comando_ins.Parameters.AddWithValue("@Idioma", textBox_idioma.Text); // Reemplaza con el valor real

                        int rowsAffected = comando_ins.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro insertado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar el registro.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }

            conexion.Close();
            this.Close();
            Libros libros = new Libros();
            libros.volver_a_libros();
            libros.Show();
        }
    }
}
