using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tareas = new List<string>();

        // Agregar tareas con Add()
        tareas.Add("Hacer tarea de matemáticas");
        tareas.Add("Estudiar programación");

        // Insertar una tarea urgente al inicio con Insert()
        tareas.Insert(0, "ENTREGAR PROYECTO URGENTE");

        // Buscar una tarea con Contains()
        string buscar = "Estudiar programación";
        if (tareas.Contains(buscar))
        {
            Console.WriteLine("La tarea existe: " + buscar);
        }
        else
        {
            Console.WriteLine("La tarea no existe");
        }

        // Eliminar una tarea específica con Remove()
        tareas.Remove("Hacer tarea de matemáticas");

        // Mostrar todas las tareas usando foreach
        Console.WriteLine("\nLista de tareas:");
        foreach (string tarea in tareas)
        {
            Console.WriteLine("- " + tarea);
        }

        // Mostrar cuántas tareas hay con Count
        Console.WriteLine("\nTotal de tareas: " + tareas.Count);
    }
}
