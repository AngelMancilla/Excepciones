using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Numero_al_cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
           
           try
            {
                //Crea y asigna valor a la variable
                Console.Write("Introduce un numero: ");
                int numero = Int32.Parse(Console.ReadLine());

                //Calculo e imprime el numero
                Console.WriteLine("\nNumero al cuadrado: " + Math.Pow(numero, 2));
                Console.ReadKey();
            }
            //Atrapa error de formato
            catch (FormatException e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
            //Atrapa error por Tamaño del valor
            catch (OverflowException e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
            //Atrapa cualquier error en general 
            catch (Exception e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
        }
    }
}
