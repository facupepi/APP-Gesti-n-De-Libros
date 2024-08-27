using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador___Biblioteca
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.imagen;
            // Define the border style of the form to a dialog box.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Libros_Click(object sender, EventArgs e)
        {
            Libros libros = new Libros();
            libros.Show();
        }

        private void Autores_Click(object sender, EventArgs e)
        {
            Autores autores = new Autores();
            autores.Show();
        }

        private void Editoriales_Click(object sender, EventArgs e)
        {
            Editoriales editoriales = new Editoriales();
            editoriales.Show();
        }
    }
}
