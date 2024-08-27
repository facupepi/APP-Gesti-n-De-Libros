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
    public partial class Autores : Form
    {
        public Autores()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void autoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Integrador_LibreriaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Integrador_LibreriaDataSet.Autores' Puede moverla o quitarla según sea necesario.
            this.autoresTableAdapter.Fill(this._Integrador_LibreriaDataSet.Autores);
        }
    }
}
