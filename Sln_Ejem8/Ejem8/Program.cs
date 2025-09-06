// See https://aka.ms/new-console-template for more information

/*
  Sumar dos números
 */

using Ejem8;

Metodos metodos = new ();

Console.WriteLine("Escribe un numero");
string num1 = Console.ReadLine() ?? "0";
Console.WriteLine("Escribe otro numero");
string num2 = Console.ReadLine() ?? "0";
Console.WriteLine(metodos.Sumar(Convert.ToInt32(num1), Convert.ToInt32(num2)));
