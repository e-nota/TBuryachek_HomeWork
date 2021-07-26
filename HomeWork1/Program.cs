using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book()
            {
                Name = "Cheburashka",
                Author = "E.Uspenskiy", Year = 2010 };
//            book.DisplayInfo();
//            book.DisplayEdition();

                Console.WriteLine("---");

            Fiction fiction = new Fiction()
            {
                Name = "The City",
                Author = "C. Simak",
                Year = 1970            };
            //            fiction.DisplayInfo();
            //            fiction.DisplayEdition();
            //            fiction.DisplaySection();

            Console.WriteLine("---");

            Novel novel = new Novel()
            {
                Name = "The Martian Chronicles", Author = "R.Bredbury", Year = 1950 };
//            novel.DisplayInfo();
//            novel.DisplayEdition();
//            novel.DisplaySection();

                Console.WriteLine("---");

            Poetry poetry = new Poetry()
            {
                Name = "Сollection of poems", Author = "S.Yesenin", Year = 1982 };
  //           poetry.DisplayInfo();
  //           poetry.DisplayEdition();
  //           poetry.DisplaySection();

                Console.WriteLine("---");

            Classbook classbook = new Classbook()
            {
                Name = "English",
                Author = "Galizinskiy",
                Year = 2009
            };
            //           classbook.DisplayInfo();
            //           classbook.DisplayEdition();

            Console.WriteLine("---");

            Maths maths = new Maths()
            {
                Name = "Algebra and beginning of analysis", Author = "Kolmogorov", Year = 2004,
                NumOfClass = 9 };
//            maths.DisplayInfo();
//           maths.DisplayEdition();

                Console.WriteLine("---");

            Biology biology = new Biology()
            {
                Name = "Start course of Biology", Author = "Ivanov", Year = 2001,
                NumOfClass = 7 };
  //           biology.DisplayInfo();
  //           biology.DisplayEdition();

                Console.WriteLine("---");

            Botany botany = new Botany()
            {
                Name = "Botany",
                Author = "Petrov",
                Year = 1999,
                NumOfClass = 8
            };
            //           botany.DisplayInfo();
            //           botany.DisplayEdition();

            Console.WriteLine("---");

            Zoology zoology = new Zoology()
            {
                Name = "Zoology",
                Author = "Ivanov",
                Year = 2004,
                NumOfClass = 9
            };
            //            zoology.DisplayInfo();
            //           zoology.DisplayEdition();

            /// Исправления
            Book[] books = new Book[] {book, fiction, novel, poetry, classbook, maths, biology, botany, zoology};

            foreach (var item in books)
            {
                item.DisplayInfo();
                item.DisplayEdition();

                               
                Console.WriteLine("---");

            }




        }
    }
}



