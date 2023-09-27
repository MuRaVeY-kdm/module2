using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //класс автор содержащий имя и день рождения
    class Author
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }

        public Author(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }
    }

    // Класс Book представляет информацию о книге: название, год издания и автор
    class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Author Author { get; set; }

        public Book(string title, int year, Author author)
        {
            Title = title;
            Year = year;
            Author = author;
        }
    }

    class tack3all
    {
        static void Main()
        {
            // Создание объектов Author
            Author author1 = new Author("Александр Пушкин", 1799);
            Author author2 = new Author("Лев Толстой", 1828);

            // Создание объектов Book с указанием авторов
            Book book1 = new Book("Евгений Онегин", 1833, author1);
            Book book2 = new Book("Война и мир", 1869, author2);
            Book book3 = new Book("Анна Каренина", 1877, author2);

            // Вывод информации о книгах и их авторах
            Console.WriteLine("Информация о книгах:");

            Console.WriteLine($"Книга: {book1.Title}, Год выпуска: {book1.Year}");
            Console.WriteLine($"Автор: {book1.Author.Name}, Год рождения автора: {book1.Author.BirthYear}");
            Console.WriteLine();

            Console.WriteLine($"Книга: {book2.Title}, Год выпуска: {book2.Year}");
            Console.WriteLine($"Автор: {book2.Author.Name}, Год рождения автора: {book2.Author.BirthYear}");
            Console.WriteLine();

            Console.WriteLine($"Книга: {book3.Title}, Год выпуска: {book3.Year}");
            Console.WriteLine($"Автор: {book3.Author.Name}, Год рождения автора: {book3.Author.BirthYear}");

            Console.ReadLine();
        }
    }
}
