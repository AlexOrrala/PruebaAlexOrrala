using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//• Préstamo: Usuario, Libro, Fecha de Préstamo, Fecha de Devolución, Estado (Activo o Finalizado).

namespace ProyectoPrueba.Clases
{
    internal class Prestamo
    {
        private Usuario Usuario { get; set; }
        private Libro Libro { get; set; }
        private DateTime FechaPrestamo { get; set; }
        private DateTime FechaDevolucion { get; set; }
        private string Estado { get; set; } 

        public Prestamo(Usuario usuario, Libro libro, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            Usuario = usuario;
            Libro = libro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            Estado = "Activo";
        }

        public void FinalizarPrestamo()
        {
            Estado = "Finalizado";
            Libro.SetEstado("Disponible");
        }

        public Usuario GetUsuario()
        {
            return Usuario;
        }

        public void SetUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }

        public Libro GetLibro()
        {
            return Libro;
        }

        public void SetLibro(Libro libro)
        {
            Libro = libro;
        }

        public DateTime GetFechaPrestamo()
        {
            return FechaPrestamo;
        }

        public void SetFechaPrestamo(DateTime fechaPrestamo)
        {
            FechaPrestamo = fechaPrestamo;
        }

        public DateTime GetFechaDevolucion()
        {
            return FechaDevolucion;
        }

        public void SetFechaDevolucion(DateTime fechaDevolucion)
        {
            FechaDevolucion = fechaDevolucion;
        }

        public string GetEstado()
        {
            return Estado;
        }

        public void SetEstado(string estado)
        {
            Estado = estado;
        }

        public override string ToString()
        {
            return $"Usuario: {Usuario.GetNombre()}, Libro: {Libro.GetTitulo()}, " +
                   $"Fecha Préstamo: {FechaPrestamo.ToShortDateString()}, " +
                   $"Fecha Devolución: {FechaDevolucion.ToShortDateString()}, Estado: {Estado}";
        }

    }
}
