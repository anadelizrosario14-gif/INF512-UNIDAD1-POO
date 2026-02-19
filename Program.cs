using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tareas = new List<string>();
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("===== LISTA DE TAREAS =====");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Ver tareas");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Limpiar todas las tareas");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    Console.Write("Escriba la nueva tarea: ");
                    string nuevaTarea = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(nuevaTarea))
                    {
                        tareas.Add(nuevaTarea);
                        Console.WriteLine("Tarea agregada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("No puede agregar una tarea vacía.");
                    }
                    break;

                case 2:
                    Console.WriteLine("\n--- TAREAS ---");
                    if (tareas.Count == 0)
                    {
                        Console.WriteLine("No hay tareas registradas.");
                    }
                    else
                    {
                        for (int i = 0; i < tareas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tareas[i]}");
                        }
                    }
                    break;

                case 3:
                    Console.Write("Ingrese el número de la tarea a eliminar: ");
                    int indice;
                    if (int.TryParse(Console.ReadLine(), out indice))
                    {
                        if (indice > 0 && indice <= tareas.Count)
                        {
                            tareas.RemoveAt(indice - 1);
                            Console.WriteLine("Tarea eliminada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida.");
                    }
                    break;

                case 4:
                    tareas.Clear();
                    Console.WriteLine("Todas las tareas han sido eliminadas.");
                    break;

                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();

        } while (opcion != 5);
    }
}



