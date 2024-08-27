namespace Integrador___Biblioteca
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Libros = new System.Windows.Forms.Button();
            this.Editoriales = new System.Windows.Forms.Button();
            this.Autores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Libros
            // 
            this.Libros.Location = new System.Drawing.Point(86, 407);
            this.Libros.Name = "Libros";
            this.Libros.Size = new System.Drawing.Size(75, 23);
            this.Libros.TabIndex = 0;
            this.Libros.Text = "Libros";
            this.Libros.UseVisualStyleBackColor = true;
            this.Libros.Click += new System.EventHandler(this.Libros_Click);
            // 
            // Editoriales
            // 
            this.Editoriales.Location = new System.Drawing.Point(460, 407);
            this.Editoriales.Name = "Editoriales";
            this.Editoriales.Size = new System.Drawing.Size(75, 23);
            this.Editoriales.TabIndex = 1;
            this.Editoriales.Text = "Editoriales";
            this.Editoriales.UseVisualStyleBackColor = true;
            this.Editoriales.Click += new System.EventHandler(this.Editoriales_Click);
            // 
            // Autores
            // 
            this.Autores.Location = new System.Drawing.Point(274, 407);
            this.Autores.Name = "Autores";
            this.Autores.Size = new System.Drawing.Size(75, 23);
            this.Autores.TabIndex = 2;
            this.Autores.Text = "Autores";
            this.Autores.UseVisualStyleBackColor = true;
            this.Autores.Click += new System.EventHandler(this.Autores_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Integrador___Biblioteca.Properties.Resources.imagen;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Autores);
            this.Controls.Add(this.Editoriales);
            this.Controls.Add(this.Libros);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Libros;
        private System.Windows.Forms.Button Editoriales;
        private System.Windows.Forms.Button Autores;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

