using Задача_11;
Console.WriteLine("Введите значения коэффициентов для решения линейного уравнения 0=kх+b");
double k = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
Lineyka lineyka= new Lineyka(k,b);
Console.WriteLine(lineyka.Root());
