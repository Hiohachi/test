int a = 0;
int b = 0;

System.Console.WriteLine("Введите первое число: ");
a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
b = int.Parse(Console.ReadLine());      //Ввод начальных чисел

if ( a>b )
{
    System.Console.WriteLine($"Число {a} большее, а {b} меньшее.");
}
else if ( a<b )
{
    System.Console.WriteLine($"Число {b} большее, а {a} меньшее.");
}
else
{
    System.Console.WriteLine("Введённые числа равны.");
}