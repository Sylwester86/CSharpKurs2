using System;

namespace StudentDiary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);
            diary.AddRating(1.2f);
            diary.AddRating(9.6f);
            

            DiaryStatistics stats = diary.ComputeStatistics();

            Console.WriteLine("Średnia wartośc: " + stats.AvarageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);


            Diary diary2 = new Diary();

            diary2.AddRating(5);
            diary2.AddRating(2.5f);
            diary2.AddRating(3.7f);
            diary2.AddRating(1.2f);
            diary2.AddRating(7.6f);

            
            stats = diary2.ComputeStatistics();

            Console.WriteLine("Średnia wartośc: " + stats.AvarageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);


            Console.ReadKey();
        }   


    }
}
