using System;

namespace Estudiantes
{
    class Estudiante
    {
        public void Mensaje(){
            Console.WriteLine("\n" + "===================" + "\n" + 
            "LISTADO DE ESTUDIANTES" + "\n" + "===================");
        }
        public void Mensaje2(){
            Console.WriteLine("\n" + "Estudiante - Edad - Carnet - Solvencia - Curso - Primer Pracial - Segundo Parcial - Notra Final: " + "\n");
        }
        public void MensajeFinal(){
            Console.WriteLine("=================================================" + "\n" + 
            "Creado por Bradley :)" + "\n" + 
            "=================================================" +
            "\n" + "Si desea seguir en el programa, " + 
            "ingrese = \"Seguir\"" + "\n" +
            "Si desea salir del programa, ingrese = \"Salir\"" + "\n" +
            "=================================================");
        }
    }
}