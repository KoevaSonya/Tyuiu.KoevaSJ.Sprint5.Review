using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Tyuiu.KoevaSJ.Sprint5.Review.V24.Lib;

namespace Tyuiu.KoevaSJ.Sprint5.Review.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Коева С.Ю.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Rewiev                                                            *");
            Console.WriteLine("* Задание #Rewiev                                                         *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнила: Коева Софья Юрьевна | АСОиУБ-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных.Заменить все русские    *");
            Console.WriteLine("* слова на слово 'слово'. Полученный результат сохранить в файл           *");
            Console.WriteLine("* OutPutDataFileTask7V24.txt.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V24.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V24.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находиться в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();



        }
    }
}
