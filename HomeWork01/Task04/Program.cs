// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Read number, please: ");
int N = Convert.ToInt32(Console.ReadLine());  // Ввод числа
int i=0;                                       // Инициализация переменной

while (i<=N) // добавил меньше или равно
{
    if(i % 2 == 0) Console.Write(i + ", ");
    i ++;
}
Console.Write("\b"+"\b"); // ооооо заебок)

Console.Write("."+ "\n"); //точка и новая строка