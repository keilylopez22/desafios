using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("hola bienvenido al programa promedio Nos ingresas tu nombre por favor: ");
        String nombre;
        nombre = Console.ReadLine();
        Console.WriteLine("el nombre introducido es: " + nombre);

        int salario1, salario2, salario3;
        Console.Write(nombre + "ingresa el salario del primer mes: ");
        salario1 = int.Parse(Console.ReadLine());
        Console.Write(nombre + "ingresa el salario del segundo mes: ");
        salario2 = int.Parse(Console.ReadLine());
        Console.Write(nombre + "ingresa el salario del tercer mes: ");
        salario3 = int.Parse(Console.ReadLine());

        Console.Write("el resultado de la suma de los tres salarios ingresados es: " + (salario1 + salario2 + salario3));

        double Promedio = (salario1 + salario2 + salario3) / 3.0;
        Console.WriteLine("el promedio total de tus salarios es de: " + Promedio);

    }


}