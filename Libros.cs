using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Integrador___Biblioteca
{
    public partial class Libros : Form
    {
        public Libros()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void volver_a_libros()
        {
            DataTable dt_actualizado = new DataTable();

            string s = "Data Source=LENOVO-LEGION-5;Initial Catalog=Integrador-Libreria;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(s);

            conexion.Open();
            string consulta = "SELECT Libros.LibroID, Libros.Titulo, Libros.Genero, Libros.FechaPublicacion, Libros.ISBN, " +
                "                     Editoriales.Nombre AS 'Editorial', Autores.PrimerNombre AS 'Primer Nombre Autor', " +
                "                     Autores.SegundoNombre AS 'Segundo Nombre Autor', Autores.Apellido AS 'Apellido Autor'" +
                "                     FROM Autores " +
                "                     INNER JOIN Libros ON Autores.AutorID = Libros.AutorID " +
                "                     INNER JOIN Editoriales ON Libros.EditorialID = Editoriales.EditorialID";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            adaptador.Fill(dt_actualizado);
            librosDataGridView.DataSource = dt_actualizado;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Integrador_LibreriaDataSet.Vista_Libros' Puede moverla o quitarla según sea necesario.
            this.vista_LibrosTableAdapter.Fill(this._Integrador_LibreriaDataSet.Vista_Libros);
            // TODO: esta línea de código carga datos en la tabla '_Integrador_LibreriaDataSet.Autores' Puede moverla o quitarla según sea necesario.
            this.autoresTableAdapter.Fill(this._Integrador_LibreriaDataSet.Autores);
            // TODO: esta línea de código carga datos en la tabla '_Integrador_LibreriaDataSet.Editoriales' Puede moverla o quitarla según sea necesario.
            this.editorialesTableAdapter.Fill(this._Integrador_LibreriaDataSet.Editoriales);
            // TODO: esta línea de código carga datos en la tabla '_Integrador_LibreriaDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this._Integrador_LibreriaDataSet.Libros);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string s = "Data Source=LENOVO-LEGION-5;Initial Catalog=Integrador-Libreria;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();

            DataGridViewRow item = new DataGridViewRow();

            if (librosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un libro!");
            }

            else
            {
                item = librosDataGridView.SelectedRows[0];





                string sentencia_borrado = "DELETE FROM Libros WHERE LibroID = " + item.Cells[0].Value;
                SqlCommand comando = new SqlCommand(sentencia_borrado, conexion);
                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }



                DataTable dt_actualizado = new DataTable();

                string consulta = "SELECT Libros.LibroID, Libros.Titulo, Libros.Genero, Libros.FechaPublicacion, Libros.ISBN, " +
                "                     Editoriales.Nombre AS 'Editorial', Autores.PrimerNombre AS 'Primer Nombre Autor', " +
                "                     Autores.SegundoNombre AS 'Segundo Nombre Autor', Autores.Apellido AS 'Apellido Autor'" +
                "                     FROM Autores " +
                "                     INNER JOIN Libros ON Autores.AutorID = Libros.AutorID " +
                "                     INNER JOIN Editoriales ON Libros.EditorialID = Editoriales.EditorialID";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.Fill(dt_actualizado);
                librosDataGridView.DataSource = dt_actualizado;

                conexion.Close();
            }
        }


        private void Buscar_Libros_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LENOVO-LEGION-5;Initial Catalog=Integrador-Libreria;Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    DataTable dt_actualizado = new DataTable();
                    string consulta = BuildQuery(out List<SqlParameter> parameters);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
                    {
                        foreach (var param in parameters)
                        {
                            adaptador.SelectCommand.Parameters.Add(param);
                        }

                        adaptador.Fill(dt_actualizado);
                        librosDataGridView.DataSource = dt_actualizado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private string BuildQuery(out List<SqlParameter> parameters)
        {
            parameters = new List<SqlParameter>();
            StringBuilder consulta = new StringBuilder();

            consulta.Append("SELECT Libros.LibroID, Libros.Titulo, Libros.Genero, Libros.FechaPublicacion, Libros.ISBN, ");
            consulta.Append("Editoriales.Nombre AS 'Editorial', Autores.PrimerNombre AS 'Primer Nombre Autor', ");
            consulta.Append("Autores.SegundoNombre AS 'Segundo Nombre Autor', Autores.Apellido AS 'Apellido Autor' ");
            consulta.Append("FROM Autores ");
            consulta.Append("INNER JOIN Libros ON Autores.AutorID = Libros.AutorID ");
            consulta.Append("INNER JOIN Editoriales ON Libros.EditorialID = Editoriales.EditorialID ");

            List<string> conditions = new List<string>();

            if (!checkBox_TodasLasEditoriales.Checked)
            {
                conditions.Add("Libros.EditorialID = @EditorialID");
                parameters.Add(new SqlParameter("@EditorialID", comboBox_Editoriales.SelectedValue));
            }

            if (!checkBox_TodosLosAutores.Checked)
            {
                conditions.Add("Libros.AutorID = @AutorID");
                parameters.Add(new SqlParameter("@AutorID", comboBox_Autores.SelectedValue));
            }

            if (conditions.Count > 0)
            {
                consulta.Append(" WHERE " + string.Join(" AND ", conditions));
            }

            return consulta.ToString();
        }

        private void checkBox_TodasLasEditoriales_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox_Editoriales.Enabled == false)
            {
                comboBox_Editoriales.Enabled = true;
            }
            else
            {
                comboBox_Editoriales.Enabled = false;
            }
        }

        private void checkBox_TodosLosAutores_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox_Autores.Enabled == false)
            {
                comboBox_Autores.Enabled = true;
            }
            else
            {
                comboBox_Autores.Enabled = false;
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow item;
            
            if (librosDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Seleccione un libro!");
            }

            else
            {
                item = librosDataGridView.SelectedRows[0];

                int IDLibro = (int)item.Cells[0].Value;

                ModificarLibro modificarLibro = new ModificarLibro(IDLibro);
                modificarLibro.Show();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearLibro crearLibro = new CrearLibro();
            crearLibro.Show();
            this.Close();
        }
    }
}
