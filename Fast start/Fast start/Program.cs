using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_start
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Эта программа поможет тебе подобрать фильм на вечер.");
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();

            Console.WriteLine("Здравствуй, " + name+"!");

            Console.WriteLine("Какой жанр ты бы хотел посмотреть: комедию, драму, фантастику или эротику?");
            string g = Console.ReadLine();
            
            if (g == "комедия" || g == "Комедия" || g == "комедию" || g == "Комедию")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("В таком случае, рекомендую посмотреть:");
                Console.WriteLine("* Иван васильевич меняет профессию");
                Console.WriteLine("* Назад в будущее");
                Console.WriteLine("* В джазе только девушки");
            }
            else if (g == "драма" || g == "Драма" || g == "драму" || g == "Драму")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("В таком случае, рекомендую посмотреть:");
                Console.WriteLine("* Зеленая миля");
                Console.WriteLine("* Форест Гамп");
                Console.WriteLine("* Побег из Шоушенка");
            }
            else if (g == "фантастика" || g == "Фантастика" || g == "фантастика" || g == "Фантастику")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("В таком случае, рекомендую посмотреть:");
                Console.WriteLine("* Чужой");
                Console.WriteLine("* Терминатор");
                Console.WriteLine("* Бездна");
            }
            else if (g == "эротика" || g == "Эротика" || g == "эротику" || g == "Эротику")
            {
                Console.WriteLine("А сколько тебе лет?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 18)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("В таком случае, рекомендую посмотреть:");
                    Console.WriteLine("* Большие сиськи");
                    Console.WriteLine("* Длинные письки");
                    Console.WriteLine("* Черный властелин");
                }
                else
                {
                    Console.WriteLine("Ты еще слишком мал для таких фильмов!");
                    Console.WriteLine("Приходи через "+(18-age)+" лет.");
                }
            }

            else if (g != "комедия" || g != "Комедия" || g != "комедию" || g != "Комедию" || g != "драма" || g != "Драма" || g != "драму" || g != "Драму" || g != "фантастика" || g != "Фантастика" || g != "фантастика" || g != "Фантастику" || g != "эротика" || g != "Эротика" || g != "эротику" || g != "Эротику")
            {
                Console.WriteLine("Я не знаю такого жанра(");

            }


            
            
            Console.ReadKey();
        }
    }
}
