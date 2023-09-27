using System;
using System.Collections.Generic;
using System.Linq;

// Класс, представляющий книгу
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Title} ({Author}, {Year})";
    }
}

// Класс "Домашняя библиотека"
class HomeLibrary
{
    private List<Book> library;

    public HomeLibrary()
    {
        library = new List<Book>();
    }

    // Метод для добавления книги в библиотеку
    public void AddBook(Book book)
    {
        library.Add(book);
        Console.WriteLine($"+Книга \"{book.Title}\" добавлена в библиотеку.");
    }

    // Метод для удаления книги из библиотеки
    public void RemoveBook(Book book)
    {
        library.Remove(book);
        Console.WriteLine($"-Книга \"{book.Title}\" удалена из библиотеки.");
    }

    // Метод для поиска книги по автору
    public List<Book> FindBooksByAuthor(string author)
    {
        return library.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // Метод для поиска книги по году издания
    public List<Book> FindBooksByYear(int year)
    {
        return library.Where(book => book.Year == year).ToList();
    }

    // Метод для сортировки книг по названию
    public void SortByTitle()
    {
        library.Sort((book1, book2) => string.Compare(book1.Title, book2.Title, StringComparison.OrdinalIgnoreCase));
    }

    // Метод для вывода всех книг в библиотеке
    public void DisplayLibrary()
    {
        Console.WriteLine();// пустая строка между выводам
        Console.WriteLine("Список книг в библиотеке:");
        foreach (var book in library)
        {
            Console.WriteLine(book);
        }
    }
}

class Program
{
    static void Main()
    {
        HomeLibrary library = new HomeLibrary();

        // Добавление книг в библиотеку
        library.AddBook(new Book("Война и мир", "Лев Толстой", 1869));
        library.AddBook(new Book("Преступление и наказание", "Федор Достоевский", 1866));
        library.AddBook(new Book("1984", "Джордж Оруэлл", 1949));

        // Вывод всех книг в библиотеке
        library.DisplayLibrary();

        // Поиск книг по автору
        string searchAuthor = "Лев Толстой";
        List<Book> booksByAuthor = library.FindBooksByAuthor(searchAuthor);
        Console.WriteLine();// пустая строка между выводам
        Console.WriteLine($"Книги автора {searchAuthor}:");
        foreach (var book in booksByAuthor)
        {
            Console.WriteLine(book);
        }

        // Поиск книг по году
        int searchYear = 1949;
        List<Book> booksByYear = library.FindBooksByYear(searchYear);
        Console.WriteLine();// пустая строка между выводам
        Console.WriteLine($"Книги по году издания {searchYear}:");
        foreach (var book in booksByYear)
        {
            Console.WriteLine(book);
        }

        // Сортировка книг по названию и вывод отсортированного списка
        library.SortByTitle(); // сортировка книг
        Console.WriteLine();   // пустая строка между выводам
        Console.WriteLine("Список книг после сортировки по названию:");
        library.DisplayLibrary(); // вывод отсортированных книг

        Console.WriteLine(); // пустая строка между выводам
        library.RemoveBook(new Book("1984", "Джордж Оруэлл", 1949)); //удаление книги
        library.DisplayLibrary(); //вывод всех книг

        Console.ReadLine();
    }
}
