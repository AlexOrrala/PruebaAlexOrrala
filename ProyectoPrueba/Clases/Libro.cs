using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//• Libro: Título, Autor, Año de Publicación, ISBN (único), Disponibilidad. 

namespace ProyectoPrueba.Clases
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private DateTime fechaPublicacion;
        private string isbn;
        private string estado;

        public Libro(string titulo, string autor, DateTime fechaPublicacion, string isbn, string estado)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fechaPublicacion = fechaPublicacion;
            this.isbn = isbn;
            this.estado = estado;
        }

        // Getters y Setters
        public string GetTitulo()
        {
            return titulo;
        }
        public void SetTitulo(string newTitulo)
        {
            titulo = newTitulo;
        }

        public string GetAutor()
        {
            return autor;
        }
        public void SetAutor(string newAutor)
        {
            autor = newAutor;
        }

        public DateTime GetFechaPublicacion()
        {
            return fechaPublicacion;
        }
        public void SetFechaPublicacion(DateTime newFechaPublicacion)
        {
            fechaPublicacion = newFechaPublicacion;
        }

        public string GetIsbn()
        {
            return isbn;
        }
        public void SetIsbn(string newIsbn)
        {
            isbn = newIsbn;
        }

        public string GetEstado()
        {
            return estado;
        }
        public void SetEstado(string newEstado)
        {
            estado = newEstado;
        }
    }
}

