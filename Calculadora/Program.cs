using Lab.Calculadora;

Calculadora calc = new Calculadora(DateTime.Now);

Console.WriteLine(calc.somar(2,4));
Console.WriteLine(calc.dividir(10,5));
Console.WriteLine(calc.multiplicar(10,5));

foreach(string x in calc.historico())
{
    Console.WriteLine(x);
}

