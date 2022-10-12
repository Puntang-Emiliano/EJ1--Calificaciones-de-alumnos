using System;

namespace TP7_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string curso, turno;
            int contador, cantidadAlumnos;
            float notaAlumnos=0.0f, promedio=0.0f, acumulador=0.0f;
            string fecha;
            fecha = DateTime.Now.ToString();

            
            Console.WriteLine("Bienbenido al sistema de calificaciones!! Hoy es {0} ", fecha);
            Console.WriteLine("Ingrese el nombre del Curso");
            curso = Console.ReadLine();
            Console.WriteLine("Ingrese el turno");
            turno = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de alumnos");
            cantidadAlumnos = Convert.ToInt32(Console.ReadLine());

           for  (contador = 1; contador  <= cantidadAlumnos; contador++)
            {
                Console.Clear();
                Console.WriteLine("ingrese las notas a promediar");
                notaAlumnos = Convert.ToInt32(Console.ReadLine());
                acumulador = acumulador + notaAlumnos;
                
            }
            
            promedio = acumulador / cantidadAlumnos;
            Console.Clear();
            Console.WriteLine(" En el Curso: {0} ", curso);
            Console.WriteLine(" Del Turno: {0} ", turno);
            Console.WriteLine(" Las Notas Promedio son: {0} ", promedio);

            
            Console.WriteLine("El acumulador es {0} " ,  acumulador);

            

        }
    }
}
