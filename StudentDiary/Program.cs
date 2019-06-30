using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);

            float avg = diary.CalculateAverage();
            float max = diary.GiveMaxRating();
            float mix = diary.GiveMinRating();

            for (; ; )
            {
                Console.WriteLine(" Podaj Ocenę z zakresy 1-10");

                float rating = float.Parse (Console.ReadLine());



            }
       }
    }
}
