using System;

namespace Estudiantes
{
    class Program
    {
        static String[] Nombres = new String[5];
        static int[] Edades = new int[5];
        static String[] Carnets = new String[5];
        static Boolean[] Solvencia = new Boolean[5];
        static String[] CursoNombre = new String[5];
        static Double[] CursoNotauno = new double[5];
        static Double[] CursoNotados = new double[5];
        static Double[] CursoNotafinal = new double[5];

        static void Main(string[] args)
        {

            String Bucle = null;

            do {

                Estudiante PMensaje = new Estudiante();
                PMensaje.Mensaje();

                Listado();

                Estudiante SMensaje = new Estudiante();
                SMensaje.Mensaje2();

                Mostrar();

                Estudiante MensajeF = new Estudiante();
                MensajeF.MensajeFinal();

                Bucle = Console.ReadLine();

            } while(Bucle == "Seguir");
        }
        static void Listado(){

            for(int a = 0; a < 5; a++){
                Console.WriteLine("\n" + "Ingrese su nombre: ");
                Nombres[a] = Console.ReadLine();

                Console.WriteLine("Ingrese su edad: ");
                Edades[a] = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su carnet: ");
                Carnets[a] = Console.ReadLine();

                Console.WriteLine("Ingrese si está solvente (True or False): ");
                Solvencia[a] = bool.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del curso: ");
                CursoNombre[a] = Console.ReadLine();

                Console.WriteLine("Ingrese la nota del primer parcial: ");
                CursoNotauno[a] = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota del segundo parcial: ");
                CursoNotados[a] = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su nota final del curso: ");
                CursoNotafinal[a] = double.Parse(Console.ReadLine());   
            }
        }
        static void Mostrar(){
            for(int a = 0; a < 5; a++){
                Console.WriteLine(Nombres[a] + " // " + Edades[a] + " // " + Carnets[a] + " // " + Solvencia[a] + " // "
                + CursoNombre[a] + " // " + CursoNotauno[a] + " // " + CursoNotados[a] + " // " + CursoNotafinal[a] + "\n");
            }
        }
    }
}
