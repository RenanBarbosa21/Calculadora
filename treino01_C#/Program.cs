using treino01_C_;

Console.WriteLine("digite o primeiro numero");
var n1 = int.Parse (Console.ReadLine());
Console.WriteLine("digite o segundo numero");
var n2 = int.Parse (Console.ReadLine());
Console.WriteLine("Coloque um operador");
var operate = Console.ReadLine();

Calculator calculator = new Calculator();

Console.WriteLine(calculator.Calculate(operate, n1, n2));
Console.ReadLine();
