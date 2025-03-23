using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//• Usuario: Nombre, Correo Electrónico, Teléfono. 

namespace ProyectoPrueba.Clases
{
    internal class Usuario
    {
        private String nombre;
        private String correo;
        private String telefono;


        public Usuario(string nombre, string correo, string telefono)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
        }


        public string GetNombre() => nombre;
        public void SetNombre(string nombre) => this.nombre = nombre;

        public string GetCorreo() => correo;
        public void SetCorreo(string correo) => this.correo = correo;

        public string GetTelefono() => telefono;
        public void SetTelefono(string telefono) => this.telefono = telefono;

    }
}
