using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Prestamos : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Prestamos()
        {
            InitializeComponent();
        }

        public FM_Prestamos(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        private void prestamosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prestamosBindingSource.EndEdit();

        }

        private void FM_Prestamos_Load(object sender, EventArgs e)
        {
            this.librosPrestadosTableAdapter.Fill(this.dS_LibrosPrestados.LibrosPrestados);
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);
            // TODO: esta línea de código carga datos en la tabla 'dS_Prestamos.prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.dS_Prestamos.prestamos);

        }

        private void btnBuscarIdentificador_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.FillByID(this.dS_Libros.libros,Int32.Parse(tbIdentificador.Text));
        }

        private void btnBuscarTitulo_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.FillByTitulo(this.dS_Libros.libros,tbTitulo.Text);
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.FillByAutor(this.dS_Libros.libros,tbAutor.Text);
        }

        private void btnBuscarIDLector_Click(object sender, EventArgs e)
        {
            this.librosPrestadosTableAdapter.FillByIDLibroPrestado(this.dS_LibrosPrestados.LibrosPrestados, Int32.Parse(tbIDLector.Text));

        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            this.librosPrestadosTableAdapter.FillByTitulo(this.dS_LibrosPrestados.LibrosPrestados,tbNombre.Text);
        }
    }
}
