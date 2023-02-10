using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace week3
{

    internal class Estudiantes
    {
        static string[] nombre = new string[5]; //variable global
        static float[] notas = new float[5]; //variable global
        static byte indice = 0; //variable global para la posicion

        //metodo crear estudiantes
        public static void CrearEstudiante() 
        {
            string continuar = "s";
            do
            {
                Console.WriteLine("Digite nombre({0}):", (indice+1)); // agregamos el nombre del estudiante
                nombre[indice] = Console.ReadLine();
                Console.WriteLine("Digite nota"); // agregamos nota del estudiante
                notas[indice]= float.Parse(Console.ReadLine());
                indice++; //aumenta el valor a 1 para ir guardando en el espacio de memoria
                Console.WriteLine("Desea continuar(s/n): "); // consultamos si desea agregar mas alumnos
                continuar = Console.ReadLine();

            } while (!continuar.Equals("n"));

        }

        //metodo buscar estudiante
        private static void BuscarEstudiante() 
        {
            Console.WriteLine("Digite el nombre:"); 
            string nombre = Console.ReadLine();
            bool existe = false;
            for (int i = 0; i < Estudiantes.nombre.Length; i++)
            {
                if (nombre.Equals(Estudiantes.nombre[i]))
                {
                    Console.WriteLine("Estudiante existe y esta en la posición: " + i + " y su nota es: " + notas[i]); // aqui imprimimos la posicion en la que se encuentra el estudiante y cual es su nota.
                    existe = true;
                }

            }
            if (!existe)
            {
                Console.WriteLine("Estudiante no existe"); // si el estudiante no existe, imprimimos el mensaje.

            }
        }

        //metodo imprimir estudiantes
        public static void ImprimirEstudiantes() 
        {
            Console.WriteLine("Lista de estudiantes con sus notas");
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine(" Estudiante: " + nombre[i] + " Nota: "+ notas[i]);// imprimimos la lista de los estudiantes y sus notas
            }
        }
        //metodo menu
        public static void menu()
        {
            Console.WriteLine( "Hola Bienvenido al sistema Estudiantes UH Programación II en 'C#' "
                             + "\n"
                             + "\n Tarea semana 4"
                             + "\n Elaborada por Carlos Pérez Pérez"
                             + "\n"
                             + "\n"
                             );
            byte opcion = 0;
            do
            {
                Console.WriteLine("1- Agregar Estudiante y Nota"); // agregar estudiante y nota
                Console.WriteLine("2- Buscar Estudiantes"); // buscar estudiante
                Console.WriteLine("3- Imprimir todos los estudiantes con sus notas"); //imprimir la lista estudiantes con sus notas
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opción");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearEstudiante();
                        break;
                    case 2:
                        BuscarEstudiante();
                        break;
                    case 3:
                        ImprimirEstudiantes();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }

            } while (true);

        }
    }
}
