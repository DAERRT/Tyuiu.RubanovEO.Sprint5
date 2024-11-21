using Tyuiu.RubanovEO.Sprint5.Task7.V25.Lib;

namespace Tyuiu.RubanovEO.Sprint5.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5| Выполнил: Рубанов Е. О. | ПКТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Рубанов Егор Олегович | ПКТБ-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine(@"* Дан файл С:\\DataSprint5\\InPutDataFileTask7V25.txt (файл взять из      *");
            Console.WriteLine(@"* архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ *");
            Console.WriteLine("* и скопировать в неё файл) в котором есть набор символьных данных.Удалить*");
            Console.WriteLine("* все английские слова из файла.Полученный результат сохранить в файл     *");
            Console.WriteLine("* OutPutDataFileTask7V25.txt.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите путь: ");
            string  x = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.LoadDataAndSave(x));
            Console.ReadKey();
        }
    }
}
