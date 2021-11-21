using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9_FinalProject_2
{
    class Program
    {
        static event Action<int> EnterData;
        private static bool exit;

        static List<string> _list = new List<string>
        {
            "Достоевский Федор",
            "Булгаков Михаил",
            "Пушкин Александр",
            "Толстой Лев",
            "Гоголь Николай"
        };

        static void Main(string[] args)
        {
            DisplayList(_list);

            EnterData += SortList;
            while (true)
            {
                try
                {
                    if (exit)
                        return;
                    ReadConsole();
                }
                catch (BadDataException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void ReadConsole()
        {

            int mode = 0;
            Console.WriteLine("Введите 1 для сортировки от А-Я, введите 2 для сортировки от Я-А, 0 - для выхода:");
            try
            {
                mode = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new BadDataException("Введены неверные данные.");
            }

            if (mode == 0)
                exit = true;

            if (mode != 1 && mode != 2)
            {
                throw new BadDataException("Введены неверные данные. Число не 0, 1, 2");
            }

            EnterData?.Invoke(mode);

        }

        private static void SortList(int modeSort)
        {
            if (modeSort == 1)
            {
                DisplayList(_list.OrderBy(s => s).ToList());
            }
            else
            {
                DisplayList(_list.OrderByDescending(s => s).ToList());
            }
        }

        private static void DisplayList(List<string> list)
        {
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
        }

    }
}
