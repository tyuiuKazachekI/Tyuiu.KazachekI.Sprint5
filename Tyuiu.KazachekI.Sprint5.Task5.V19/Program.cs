using System;
using Tyuiu.KazachekI.Sprint5.Task5.V19.Lib;

Console.Title = "Спринт #5 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл в котором есть набор значений. Найти разницу между            *");
Console.WriteLine("* максимальным и минимальным однозначными целыми числами в файле.         *");
Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string path = @"C:\Users\Иван\source\repos\Tyuiu.KazachekI.Sprint5\DataSprint5\InPutDataFileTask5V19.txt";

Console.WriteLine($"Данные находятся в файле: {path}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);

Console.WriteLine($"Разница между максимальным и минимальным однозначными числами = {res}");
Console.ReadLine();