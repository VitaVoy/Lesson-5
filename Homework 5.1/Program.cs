using System; //Виталий Войтов
using System.Linq;

namespace Homework_5._1
{
    class delWord
    {


    }

    class Program
    {
        static void Main(string[] args) //Код взял из Инета
        {
            {
                Console.WriteLine("Введите строку:");
                string str = Console.ReadLine();
                Console.WriteLine("Введите количество символов в слове:");
                int n = int.Parse(Console.ReadLine()); //До этого момента мне код полностью понятен
                var msv = str.Split(new char[] { ' ', ',', '.', '!', '?', '-' }).Where(x => x.Length == n).ToArray();// А вот здесь уже нет. 
                foreach (var item in msv) // каким образом переменная item стала соответствовать переменной n.
                {
                    Console.WriteLine(item);
                }
            }

            {
                // метод удаления слова заканчивающегося на определенный символ
                //Write("Введите осмысленное сообщения: ");
                //string s = ReadLine();
                //Write("Введите символ: ");
                //char x = ToChar(ReadLine());
                //string p = "Удалены те слова которые заканчиваются на заданный символ {0}: {1}";
                // Удалить из сообщения все слова, которые заканчиваются на заданный символ
                //string[] div = s.Split(' ', ',', '.', '-', '!', '?');
                //for (int i = 0; i < div.Length; i++)
                //{
                //    if (div[i].EndsWith(x.ToString()))
                //    {
                //        WriteLine(p, x, div[i]);
                //    }
                //}
                // выход из программы
                //WriteLine("Нажмите любую клавишу для выхода...");
                //ReadKey(true);
            }




            Console.ReadLine();

        }
    }
}
