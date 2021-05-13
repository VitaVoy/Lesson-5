using System; //Виталий Войтов

namespace Homework_5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = Console.ReadLine(); // Здесь пользователь вводит пароль
            if (login.Length > 1 && login.Length < 11) // Здесь идет проверка на длинну пароля
            {
                char[] array = login.ToCharArray(); // Здесь введенный пароль переводитс в массив знаков
                for (int i = 0; i < array.Length; i++) // Дальше проверяется соответствие знаков цифрам или латинице
                {
                    if (i >= 0 && i <= 9)
                    {
                        for (char j = 'A'; j < array.Length; j++)
                        {
                            if (j >= 'A' && j <= 'z') ;

                        }
                        Console.WriteLine("Bingo"); // Но почему-то код не работает как надо. Хотя по отдельности - части работали. 
                    }
                }



            }
            else
                Console.WriteLine("Введите логин еще раз");


            Console.ReadLine();

        }
    }
}