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

            Console.WriteLine("Какой жанр ты бы хотел посмотреть: комедию или драму?");
            string g = Console.ReadLine();
            Console.WriteLine("В таком случае, рекомендую посмотреть:");
            if (g == "комедия" || g == "Комедия")
            {
                Console.WriteLine("* Иван васильевич меняет профессию");
                Console.WriteLine("* Назад в будущее");
                Console.WriteLine("* В джазе только девушки");
            }
            else if (g=="драма" || g=="Драма")
            {
                Console.WriteLine("* Зеленая миля");
                Console.WriteLine("* Форест Гамп");
                Console.WriteLine("* Побег из Шоушенка");
            }
            else if (g != "комедия" || g != "Комедия" || g != "драма" || g != "Драма")
            {
                Console.WriteLine("Я не знаю такого жанра(");
                
            }


            
            
            Console.ReadKey();
        }
    }
}
