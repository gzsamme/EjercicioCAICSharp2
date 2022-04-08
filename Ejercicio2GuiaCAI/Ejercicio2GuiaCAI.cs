using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2GuiaCAI
{
    class Ejercicio2GuiaCAI
    {
        //7.Solicite al usuario el ingreso de su nombre y presente el mensaje “Hola [nombre]”.

        public void EJ7()
        {
            string nombre;
            Console.WriteLine("Hola! Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
        }

        public void EJ8()
        {
            //8.Solicite al usuario el ingreso de una frase y presente un mensaje
            //indicando si alguna contiene la palabra “fin”.
            string fin = "fin";
            Console.WriteLine("por favor ingrese un mensaje");
            string frase = Console.ReadLine();
            bool b = frase.Contains(fin);
            if(b == true)
            {
                Console.WriteLine("la frase contiene la palabra fin");
            }
            else
            {
                Console.WriteLine("la frase no contiene la palabra fin");
            }

        }

        public void EJ9()
        {
            //9. Solicite un ingreso al usuario y lo presente en mayúsculas.
            while (true)
            {
               
                Console.WriteLine("Ingrese un texto");
                string texto = Console.ReadLine();
                Console.WriteLine(texto.ToUpper());
                break;
            }
        }

        public void EJ10()
        {
            //10. Solicite un ingreso al usuario y lo presente en minúsculas.
            while (true)
            {
                Console.WriteLine("Ingrese un texto");
                string texto = Console.ReadLine();
                Console.WriteLine(texto.ToLower());
                break;
            }
            
        }

        public void EJ11()
        {
            //11. Reemplace en una cadena ingresada por el usuario todas las vocales acentuadas por vocales sin acento y presente el resultado.
        }

        public void EJ12()
        {
            //12. Solicite el ingreso de dos frases y determine si son iguales.
            while (true)
            {
                Console.WriteLine("Ingrese una frase");
                string frase1 = Console.ReadLine();
                Console.WriteLine("Ingrese otra frase");
                string frase2 = Console.ReadLine();
                if (frase1 == frase2)
                {
                    Console.WriteLine("Las dos frases son iguales");
                    
                }
                if(frase2 != frase1)
                {
                    Console.WriteLine("Las dos frases no son iguales");
                    
                }
                break;
                
            }
        }

        public void EJ13()
        {
            //13. Solicite el ingreso de dos frases y determine si tienen la misma longitud.
            while (true)
            {
                Console.WriteLine("Ingrese una frase");
                string frase1 = Console.ReadLine();
                Console.WriteLine("Ingrese otra frase");
                string frase2 = Console.ReadLine();
                if (frase1.Length == frase2.Length)
                {
                    Console.WriteLine("Las dos frases tienen la misma longitud");

                }
                if (frase1.Length != frase2.Length)
                {
                    Console.WriteLine("Las dos frases no miden lo mismo");

                }
                break;

            }
        }








        

        //14. Solicite el ingreso de dos frases y determine si son iguales, sin diferenciar mayúsculas de minúsculas.
    }
}
