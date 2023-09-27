using System;

namespace module2_koshkin
{
    class Person
    {
        // Поля для хранения имени, возраста и адреса
        private string name;
        private int age;
        private string address;

        // Конструктор класса для инициализации полей: имя, возраст и адрес
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        // Методы для установки и получения значений полей
        //уст. имя
        public void SetName(string name)
        {
            this.name = name;
        }
        //получить имя
        public string GetName()
        {
            return name;
        }
        //уст. возраст
        public void SetAge(int age)
        {
            this.age = age;
        }
        //получить возраст
        public int GetAge()
        {
            return age;
        }
        //уст. адрес
        public void SetAddress(string address)
        {
            this.address = address;
        }
        //получить адрес
        public string GetAddress()
        {
            return address;
        }

        // Метод для вывода информации о человеке
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Адрес: {address}");
        }
    }

    class tack1all
    {
        static void Main()
        {
            // Создание объектов класса Person
            Person person1 = new Person("Иван", 30, "Москва");
            Person person2 = new Person("Мария", 25, "Санкт-Петербург");

            // Вывод информации о людях
            Console.WriteLine("Первый человек:");
            person1.DisplayInfo();

            Console.WriteLine();

            Console.WriteLine("Второй человек:");
            person2.DisplayInfo();

            Console.ReadLine();
        }
    }
}
