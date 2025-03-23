// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Microsoft.Win32;
using ProyectoPrueba.Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;




List<Usuario> Usuarios = new List<Usuario>();
List<Libro> Libros = new List<Libro>();
List<Prestamo> Prestamos = new List<Prestamo>();


int menu = 0;
do
{
    Console.WriteLine("Sistema de Gestión de Biblioteca Digital" +
        "\r\n1. Registrar y actualizar libros en el catálogo." +
        "\r\n2. Registrar y actualizar usuarios." +
        "\r\n3. Registrar préstamos y devoluciones." +
        "\r\n4. Búsqueda de libros por título o autor." +
        "\r\n5. Listar préstamos activos y por usuario." +
        "\r\n6. Generar reportes de libros más prestados.");
    try
    {
        Console.Write("Ingrese un número: ");
        string entrada = Console.ReadLine();
        menu = ValidarNumero(entrada);
    }
    catch (Exception ex)
    {
        menu = -1;
        Console.WriteLine($"Error: {ex.Message}");
    }


    switch (menu)
    {
        case 0:
            RegistrarLibros();
        break;
            case 1:
            RegistrarUsuarios();
        break;
            case 2:
            RegistroPrestamos();
        break;
            case 3:
            BuscarLibros();
        break;
            case 4:
            ListarPrestamos();
        break;
            case 5:
            MasPrestados();
        break;
            case -1:
            Console.WriteLine("Ingrese un número de menu válido");
        break;
    }
}while (menu != 4);

void MasPrestados()
{
    throw new NotImplementedException();
}

void ListarPrestamos()
{
    Prestamos.ForEach(prestamos => {
        Console.WriteLine(prestamos.ToString());
        }
    );
}

void BuscarLibros()
{
    Console.WriteLine("Ingrese el título o Autor:");
    string busqueda = ValidarTexto(Console.ReadLine());

    List<Libro> librosBusqueda = Libros.FindAll(libro => libro.GetTitulo().Equals(busqueda, StringComparison.OrdinalIgnoreCase) || libro.GetAutor().Equals(busqueda, StringComparison.OrdinalIgnoreCase));

    if (librosBusqueda.Count > 0)
    {
        Console.WriteLine("Libros encontrados bajo el parametro de busqueda:");
        librosBusqueda.ForEach(libro => {
            Console.WriteLine("Título:"+libro.GetTitulo());
            Console.WriteLine("ISBN:" + libro.GetIsbn());
        });

    } else {
        Console.WriteLine("No hay Libros bajo el criterio de busqueda seleccionado");
    }
}

void RegistroPrestamos()
{
    throw new NotImplementedException();
}

int ValidarNumero(string v)
{
    if (string.IsNullOrWhiteSpace(v))
    {
        throw new ArgumentException("El valor ingresado no puede estar vacío.");
    }

    if (!int.TryParse(v, out int numero))
    {
        throw new FormatException("El valor ingresado no es un número válido.");
    }

    if (numero < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(v), "El número no puede ser menor que 0.");
    }

    return numero;
}

string ValidarTexto(string v)
{
    if (string.IsNullOrWhiteSpace(v))
    {
        throw new ArgumentException("El valor ingresado no puede estar vacío.");
    }

    if (!v.All(char.IsLetter))
    {
        throw new FormatException("El valor ingresado solo debe contener letras.");
    }

    return v;
}

DateTime ValidarFecha(string fechaStr)
{
    if (string.IsNullOrWhiteSpace(fechaStr))
    {
        throw new ArgumentException("La fecha no puede estar vacía.");
    }

    if (!DateTime.TryParse(fechaStr, out DateTime fecha))
    {
        throw new FormatException("El formato de fecha ingresado no es válido.");
    }

    return fecha;
}




void RegistrarUsuarios()
{
    try
    {
        Console.WriteLine("Nombre:");
        string nombre = ValidarTexto(Console.ReadLine());

        Console.WriteLine("Correo");
        string correo = ValidarTexto(Console.ReadLine());

        Console.WriteLine("Teléfono");
        string telefono = ValidarTexto(Console.ReadLine());

        Usuarios.Add(new (nombre, correo, telefono));
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}

void RegistrarLibros()
{
    try
    {
        Console.WriteLine("Titulo:");
        string titulo = ValidarTexto(Console.ReadLine());

        Console.WriteLine("Autor");
        string autor = ValidarTexto(Console.ReadLine());

        Console.WriteLine("ISBN:");
        string isbn = ValidarTexto(Console.ReadLine());
        ValidarISBN(isbn);

        Console.WriteLine("Fecha de Publicación:");
        DateTime fecha = ValidarFecha(Console.ReadLine());

        Libros.Add(new Libro(titulo, autor, fecha, isbn, "Disponible"));
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}

void ValidarISBN(string isbn)
{
    if (Libros.Any(libro => libro.GetIsbn().Equals(isbn, StringComparison.OrdinalIgnoreCase)))
    {
        throw new InvalidOperationException("El ISBN ya se encuentra registrado.");
    }
}




//Debes definir al menos las siguientes entidades: 
