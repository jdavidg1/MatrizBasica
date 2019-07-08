using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            int salones = 0;
            int alumnos = 0;
            int i; //ciclo exterior (Salones)
            int j; //ciclo interior (Alumnos)

            double suma = 0;
            double promedio = 0;

            double calMin = 10;
            double calMax = 0;

            Console.WriteLine("Cual es la cantidad de salones: ");
            salones = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cual es la cantidad de alumnos: ");
            alumnos = Convert.ToInt32(Console.ReadLine());


            double  [,] calificaciones = new double[salones,alumnos];
            
            //Ingreso de notas

            for(i=0; i<salones;i++)
            {
                for(j=0; j<alumnos;j++)
                {
                    Console.WriteLine("Cual es la calificación del Salón {0}, Alumno {1}", i + 1, j + 1);
                    calificaciones[i, j] = Convert.ToDouble(Console.ReadLine());
                    
                }
            }

            // calculo de promedio

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < alumnos; j++)
                {
                    suma += calificaciones[i, j];
                }
            }

            promedio = suma / (alumnos * salones);
            
            // calculo de Max

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < alumnos; j++)
                {
                    if(calificaciones[i,j]>calMax)
                    {
                        calMax = calificaciones[i, j];
                    }
                }
            }

            // calculo de Min

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < alumnos; j++)
                {
                    if (calificaciones[i, j] < calMin)
                    {
                        calMin = calificaciones[i, j];
                    }
                }
            }


            promedio = suma / (alumnos * salones);

            Console.WriteLine($"El promedio es: {promedio}");
            Console.WriteLine($"La calificación máxima es: {calMax}");
            Console.WriteLine($"La calificación mínima es: {calMin}");


            Console.Read();

        }
    }
}
