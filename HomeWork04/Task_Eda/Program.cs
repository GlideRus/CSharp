﻿// Есть магазин "Еда"
// В магазине есть охранник
// Охранник ведёт запись всех, кто заходит в магазин
// Охранник ведёт запись всех, кто выходит из магазин
// Зайти и выйти можно в целый час.
// Выяснить в какой промежуток времени было больше всего посетителей
// Данные вводятся парами: приход-уход
// Максимум 100 покупателей
// Входные данные 10-12
// 11-13
// 9-12
// Ответ
// 11-12

//=========================
// Написать запрос на количество посетителей, создать двухмерный массив
// Создать метод ввода времени входа и выхода человека с клавиатуры через тире
// Заполнить двухмерный массив 
// Создать массив - "24 часа" (на 24 ячейки)
// Провести рассчеты, а именно заполнить массив "24 часа"
// Провести опледеление максимальных значений
// Напечатать максимальные значния
// \t - tab


Console.Clear();

int[] resMassive = new int[24];
int[,] arr = new int[4, 2]
{
    {9, 12},
    {11, 13},
    {8, 16},
    {15, 18},
};

Console.WriteLine("В указанное время, в магазине находилось максимальное количество человек:");
//получить данные из массива, первое и последнее, далее от 9 до 12 заполнить основной массив единицами

for (int y = 0; y < 4; y++)
{
    int a = arr[y, 0];
    int b = arr[y, 1];
    for (int i = a; i <= b; i++)
    {
        resMassive[a]++;
        a++;
    }
}

int zice = resMassive.Length;
int mHo = resMassive.Max();// присваиваем переменной максимальное значение людей в магазине

for (int z = 0; z < zice; z++)
{
    if (resMassive[z] == mHo)
        Console.Write(z + ", ");
}
Console.Write("\b" + "\b"); //удалил пробел и последнюю запятую
Console.Write("." + "\n"); //точка и новая строка
