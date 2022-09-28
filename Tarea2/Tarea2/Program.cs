using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Variables
            int i = 0;
            string palabra_larga = " ";

            //Arreglos
            string [] empleados = { "Juan", "Sofia", "Martha", "Marco", "Patricio", "Calamardo"};
            float [] salarios = { 200, 228, 300, 350, 150, 1 };
            
            
            //Metodo para recorrer los arreglos 
            foreach (string Nombre in empleados)
            {                
                float sueldo = salarios[i];
                Aguinaldo(Nombre, sueldo);
                i++;
            }

           //Metodo para extraer la palabra mas larga
           foreach (string palabra in empleados)
            {
                if (palabra.Length > palabra_larga.Length)
                {
                    palabra_larga = palabra;    
                }
            }

           Console.WriteLine($"El Nombre mas lardo del empleado es : {palabra_larga}.");    
            Console.Read();

        }

        //Metodo que calcula e imprime los aguinaldos        
        public static void Aguinaldo(String empleado, float salario)
        {
            float aguinaldo = salario * 12;
            Console.WriteLine($"Nombre empleado: {empleado} \nSueldo: {salario} \nAguinaldo: {aguinaldo}");
            Console.WriteLine("-------------------------------");

        }
        
    }
}
