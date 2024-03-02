using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                Console.Write("ingrese el primer numero: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("ingrese el segundo numero: ");
                int num2 = Convert.ToInt32(Console.ReadLine());


                int resultado = (num1 + num2);
                Console.WriteLine(resultado);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"error : ingresa un numero valido.");
        }
        finally
        {
            Console.WriteLine("cierre el programa");
        }
    }
}