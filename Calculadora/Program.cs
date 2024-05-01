using Calculadora.Services;

CalculadoraImp calculadora = new CalculadoraImp();

int val1 = 10;
int val2 = 20;
calculadora.Sub(val1, val2);
Console.WriteLine(calculadora.Sum(val1, val2));