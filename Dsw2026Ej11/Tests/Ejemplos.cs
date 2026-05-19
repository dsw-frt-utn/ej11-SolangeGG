using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList caso = new CasoList();

        caso.AgregarAlumno(new Alumno(1, "Juan", 8));
        caso.AgregarAlumno(new Alumno(2, "Ana", 9));
        caso.AgregarAlumno(new Alumno(3, "Pedro", 7));

        Console.WriteLine("Lista de alumnos:");

        foreach (Alumno alumno in caso.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\nBuscar alumno Ana:");

        Alumno encontrado = caso.BuscarAlumno("Ana");

        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }

        Console.WriteLine("\nBuscar alumno Luis:");

        Alumno noExiste = caso.BuscarAlumno("Luis");

        if (noExiste != null)
        {
            Console.WriteLine(noExiste);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        caso.EliminarAlumno(encontrado);

        Console.WriteLine("\nLista luego de eliminar:");

        foreach (Alumno alumno in caso.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        caso.EliminarPorPosicion(0);

        Console.WriteLine("\nLista luego de eliminar primera posición:");

        foreach (Alumno alumno in caso.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary caso = new CasoDictionary();

        caso.AgregarAlumno(new Alumno(1, "Juan", 8));
        caso.AgregarAlumno(new Alumno(2, "Ana", 9));
        caso.AgregarAlumno(new Alumno(3, "Pedro", 7));

        Console.WriteLine("Lista de alumnos:");

        foreach (var item in caso.RetornarDiccionario())
        {
            Console.WriteLine(item.Value);
        }

        Console.WriteLine("\nBuscar alumno con clave 2:");

        Alumno alumno = caso.BuscarAlumno(2);

        if (alumno != null)
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\nBuscar alumno con clave 10:");

        Alumno alumno2 = caso.BuscarAlumno(10);

        if (alumno2 != null)
        {
            Console.WriteLine(alumno2);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        caso.EliminarAlumno(1);

        Console.WriteLine("\nLista después de eliminar:");

        foreach (var item in caso.RetornarDiccionario())
        {
            Console.WriteLine(item.Value);
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq caso = new CasoLinq();

        Console.WriteLine("Primer libro:");
        Console.WriteLine(caso.GetPrimero());

        Console.WriteLine("\nÚltimo libro:");
        Console.WriteLine(caso.GetUltimo());

        Console.WriteLine($"\nTotal de precios: {caso.GetTotalPrecios()}");

        Console.WriteLine($"\nPromedio de precios: {caso.GetPromedioPrecios()}");

        Console.WriteLine("\nLibros con Id mayor a 15:");

        foreach (var libro in caso.GetListById())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLista de títulos y precios:");

        foreach (var libro in caso.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLibro con mayor precio:");
        Console.WriteLine(caso.GetMayorPrecio());

        Console.WriteLine("\nLibro con menor precio:");
        Console.WriteLine(caso.GetMenorPrecio());

        Console.WriteLine("\nLibros con precio mayor al promedio:");

        foreach (var libro in caso.GetMayorPromedio())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLibros ordenados descendente por título:");

        foreach (var libro in caso.GetOrdenados())
        {
            Console.WriteLine(libro);
        }
    }
}
