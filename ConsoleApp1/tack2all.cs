using System;


namespace ConsoleApp1
{
    // Базовый класс Shape
    class Shape
    {
        // Метод для вычисления площади фигуры
        public virtual double Area()
        {
            return 0;
        }

        // Метод для вычисления периметра фигуры 
        public virtual double Perimeter()
        {
            return 0;
        }
    }

    // Производный класс Circle 
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Переопределение метода Area для круга
        public override double Area()
        {
            //нахождение площадь круга
            return Math.PI * radius * radius;
        }

        // Переопределение метода Perimeter для круга
        public override double Perimeter()
        {
            //периметр круга
            return 2 * Math.PI * radius;
        }
    }

    // Производный класс Rectangle 
    class Rectangle : Shape
    {
        //значения прямоугольника
        private double width;
        private double height;

        //присвоить значения
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Переопределение метода Area для прямоугольника
        public override double Area()
        {
            //площадь прямоугольника
            return width * height;
        }

        // Переопределение метода Perimeter для прямоугольника
        public override double Perimeter()
        {
            //периметр прямоугольника
            return 2 * (width + height);
        }
    }

    class tack2all
    {
        static void Main()
        {
            // Создание объекта Circle 
            Circle circle = new Circle(5);

            // Создание объекта Rectangle 
            Rectangle rectangle = new Rectangle(4, 6);

            // Вывод площади и периметра круга
            Console.WriteLine("Круг:");
            Console.WriteLine($"Площадь: {circle.Area()}");
            Console.WriteLine($"Периметр: {circle.Perimeter()}");

            Console.WriteLine();

            // Вывод площади и периметра прямоугольника
            Console.WriteLine("Прямоугольник:");
            Console.WriteLine($"Площадь: {rectangle.Area()}");
            Console.WriteLine($"Периметр: {rectangle.Perimeter()}");

            Console.ReadLine();
        }
    }
}

