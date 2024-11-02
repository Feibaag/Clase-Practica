// ExpositionExample.cs
using System;

namespace MiProyecto
{
    public class EjemploExposicion
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== BUCLES ===");

            // Ejemplo de bucle FOR: Imprime números del 1 al 5
            Console.WriteLine("Bucle FOR:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // Ejemplo de bucle WHILE: Pide números positivos hasta que se ingrese uno negativo
            Console.WriteLine("\nBucle WHILE: Ingrese números positivos, un número negativo para salir.");
            int numero;
            while (true)
            {
                Console.Write("Introduce un número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0) break;
                Console.WriteLine("Número ingresado: " + numero);
            }

            // Ejemplo de bucle DO-WHILE: Asegura que el bucle se ejecute al menos una vez
            Console.WriteLine("\nBucle DO-WHILE:");
            int contador = 1;
            do
            {
                Console.WriteLine("Esta es la iteración número: " + contador);
                contador++;
            } while (contador <= 3);

            // Ejemplo de bucle FOREACH: Itera sobre un arreglo
            Console.WriteLine("\nBucle FOREACH:");
            string[] nombres = { "Ana", "Luis", "Pedro", "María" };
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("\n=== MÉTODOS ===");
            // Ejemplo de un método para sumar dos números
            Console.Write("Introduce el primer número para sumar: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo número para sumar: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma es: " + Sumar(num1, num2));

            // Ejemplo de método con parámetro opcional
            MostrarMensaje("Hola, repetido 3 veces", 3);
            MostrarMensaje("Hola sin repetir");

            Console.WriteLine("\n=== MANEJO DE EXCEPCIONES ===");
            // Ejemplo de try-catch para división
            try
            {
                Console.Write("Introduce el divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado de la división: " + resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }

            Console.WriteLine("\n=== PROGRAMACIÓN ORIENTADA A OBJETOS (POO) ===");
            // Ejemplo de POO con una clase Persona
            Persona persona = new Persona("Juan", 25);
            persona.Saludar();
        }

        // Método para sumar dos números
        static int Sumar(int a, int b)
        {
            return a + b;
        }

        // Método con parámetro opcional
        static void MostrarMensaje(string mensaje, int repeticiones = 1)
        {
            for (int i = 0; i < repeticiones; i++)
            {
                Console.WriteLine(mensaje);
            }
        }

        // Método para división con manejo de excepciones
        static int Dividir(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }
    }

    // Clase básica de ejemplo para POO
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; private set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy " + Nombre + " y tengo " + Edad + " años.");
        }
    }
}
