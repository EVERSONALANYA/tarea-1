



//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Ingrese un número:");
//        int numero = Convert.ToInt32(Console.ReadLine());

//        if (numero % 2 == 0)
//        {
//            Console.WriteLine("El número ingresado es par.");
//        }
//        else
//        {
//            Console.WriteLine("El número ingresado es impar.");
//        }
//    }
//}
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Ingrese la base del triángulo:");
//        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine("Ingrese la altura del triángulo:");
//        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

//        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

//        Console.WriteLine("El área del triángulo es: " + areaTriangulo);
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Ingrese un número para calcular su factorial:");
//        int numero = Convert.ToInt32(Console.ReadLine());

//        long factorial = CalcularFactorial(numero);

//        Console.WriteLine("El factorial de " + numero + " es: " + factorial);
//    }

//    static long CalcularFactorial(int n)
//    {
//        if (n == 0)
//        {
//            return 1;
//        }
//        else
//        {
//            return n * CalcularFactorial(n - 1);
//        }
//    }
////}
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Ingrese un número para verificar si es primo:");
//        int numero = Convert.ToInt32(Console.ReadLine());

//        if (EsPrimo(numero))
//        {
//            Console.WriteLine(numero + " es un número primo.");
//        }
//        else
//        {
//            Console.WriteLine(numero + " no es un número primo.");
//        }
//    }

//    static bool EsPrimo(int n)
//    {
//        if (n <= 1)
//        {
//            return false;
//        }

//        for (int i = 2; i <= Math.Sqrt(n); i++)
//        {
//            if (n % i == 0)
//            {
//                return false;
//            }
//        }

//        return true;
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Ingrese una cadena de texto:");
//        string texto = Console.ReadLine();

//        string textoInvertido = InvertirTexto(texto);

//        Console.WriteLine("Texto invertido: " + textoInvertido);
//    }

//    static string InvertirTexto(string texto)
//    {
//        char[] caracteres = texto.ToCharArray();
//        Array.Reverse(caracteres);
//        return new string(caracteres);
//    }
//}
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Ingrese el número inicial del rango:");
//        int inicio = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Ingrese el número final del rango:");
//        int fin = Convert.ToInt32(Console.ReadLine());

//        int sumaPares = CalcularSumaPares(inicio, fin);

//        Console.WriteLine("La suma de los números pares en el rango es: " + sumaPares);
//    }

//    static int CalcularSumaPares(int inicio, int fin)
//    {
//        int suma = 0;

//        for (int i = inicio; i <= fin; i++)
//        {
//            if (i % 2 == 0)
//            {
//                suma += i;
//            }
//        }

//        return suma;
//    }
//}
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<int> cuadrados = new List<int>();

//        for (int i = 1; i <= 10; i++)
//        {
//            cuadrados.Add(i * i);
//        }

//        Console.WriteLine("Lista de cuadrados de los primeros 10 números naturales:");
//        foreach (int cuadrado in cuadrados)
//        {
//            Console.WriteLine(cuadrado);
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Ingrese una cadena de texto:");
//        string texto = Console.ReadLine();

//        int contadorVocales = ContarVocales(texto);

//        Console.WriteLine("El número de vocales en la cadena es: " + contadorVocales);
//    }

//    static int ContarVocales(string texto)
//    {
//        int contador = 0;
//        foreach (char c in texto.ToLower())
//        {
//            if ("aeiou".Contains(c))
//            {
//                contador++;
//            }
//        }
//        return contador;
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        int v1 = 0;
//        int v2 = 1;

//        // Mostramos el primer número (0).
//        Console.WriteLine(v1);

//        // Generamos 9 sucesiones adicionales.
//        for (int i = 0; i < 9; i++)
//        {
//            // Almacenamos el valor v1 en una variable temporal para no perderlo.
//            int temp = v1;

//            // El valor v1 se convierte en el valor v2.
//            v1 = v2;

//            // Sumamos los valores para obtener el nuevo v2.
//            v2 = temp + v1;

//            // Mostramos por pantalla el resultado.
//            Console.WriteLine(v1);
//        }
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        // Crear una lista de números (puedes modificarla según tus necesidades)
//        List<int> numeros = new List<int> { 5, 2, 8, 1, 10 };

//        // Ordenar la lista de menor a mayor
//        numeros.Sort();

//        // Imprimir los números ordenados
//        Console.WriteLine("Números ordenados de menor a mayor:");
//        foreach (var numero in numeros)
//        {
//            Console.Write(numero + " ");
//        }
//    }
//}

using System;

namespace PalindromeChecker
{
    class Program
    {
        public static bool IsPalindrome(string input)
        {
            string firstHalf = input.Substring(0, input.Length / 2);
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            string reversedSecondHalf = new string(arr).Substring(0, input.Length / 2);

            return firstHalf.Equals(reversedSecondHalf);
        }

        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            bool isPalindrome = IsPalindrome(userInput.ToLower());

            Console.WriteLine($"Is \"{userInput}\" a palindrome? {isPalindrome}");
        }
    }
}
