using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Este programa solicita dos números y realiza operaciones con ellos.");
        Console.WriteLine("Por favor, ingresa el primer número:");
        var num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor, ingresa el segundo número:");
        var num2 = int.Parse(Console.ReadLine());

        var suma = num1 + num2;
        var resta = num1 - num2;
        var multiplicacion = num1 * num2;
        var division = (double)num1 / num2;

        Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + suma);
        Console.WriteLine("La resta de " + num1 + " y " + num2 + " es: " + resta);
        Console.WriteLine("La multiplicación de " + num1 + " y " + num2 + " es: " + multiplicacion);
        Console.WriteLine("La división de " + num1 + " y " + num2 + " es: " + division);
    }
}
