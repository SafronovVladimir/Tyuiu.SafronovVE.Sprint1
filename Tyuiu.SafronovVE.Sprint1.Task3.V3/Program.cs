using Tyuiu.SafronovVE.Sprint1.Task3.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Сафронов В. Е. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Сафронов Владимир Евгеньевич | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double length, width, height;

        Console.WriteLine("Введите длину: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите ширину: ");
        width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите высоту: ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.ParallelepipedVolume(length, width, height));

        Console.ReadLine();
    }
}