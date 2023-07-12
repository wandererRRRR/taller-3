using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Calculadora Básica");
        Console.WriteLine("------------------");

        while (true)
        {
            Console.Write("Ingresa el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Elige una operación:");
            Console.WriteLine("1. Resta");
            Console.WriteLine("2. Multiplicación");
            Console.WriteLine("3. División");
            Console.WriteLine("4. Salir");

            Console.Write("Elije una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            int resultado = 0;
            bool operacionValida = true;

            if (opcion == 1)
            {
                resultado = num1 - num2;
                Console.WriteLine("El resultado de la resta es: " + resultado);
            }
            else if (opcion == 2)
            {
                resultado = num1 * num2;
                Console.WriteLine("El resultado de la multiplicación es: " + resultado);
            }
            else if (opcion == 3)
            {
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine("El resultado de la división es: " + resultado);
                }
                else
                {
                    Console.WriteLine("Error: No es posible dividir entre cero.");
                    operacionValida = false;
                }
            }
            else if (opcion == 4)
            {
                return;
            }
            else
            {
                Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
                operacionValida = false;
            }

            if (operacionValida)
            {
                Console.WriteLine();
            }
        }
    }
}