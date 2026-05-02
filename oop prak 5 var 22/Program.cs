using System;

namespace oop_prak_5_var_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                int y, m, d;

                Console.Write("Введіть рік: ");
                y = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введіть місяць: ");
                m = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введіть день: ");
                d = Convert.ToInt32(Console.ReadLine());

                Date date = new Date();

                date.Year = y;
                date.Month = m;
                date.Day = d;

                date.Print();

                if (!date.IsValid())
                {
                    Console.WriteLine("Такої дати не існує");
                }
                else
                {
                    date.Plus1();
                    Console.WriteLine("Дата після +1 дня:");
                    date.Print();
                }
            }
            catch
            {
                Console.WriteLine("Помилка!!!");
            }

            Console.ReadKey();
        }
    }
}