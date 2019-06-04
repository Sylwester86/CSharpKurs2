using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ; )
            {
                Greeting();
                Age();
                Instruction();

            }

        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("min.Int = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Ustawienia w kursie nazwane jako settings
        /// </summary>
        private static void Instruction()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }


        /// <summary>
        /// Wypisujemy komunikat zależny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo! Jesteś Pełnoletni możesz wypić piwo :)");
            }

            else if (result == false)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wprowadziłeś nie poprawny wiek!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Możesz wypić mleko");
            }
        }
        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("witaj, " + name);
        }
    }
}
