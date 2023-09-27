using System;

// Интерфейс для рисуемых объектов
interface IDrawable
{
    void Draw();
}

// Класс представляющий круг
class Circle : IDrawable
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine($"Рисуем круг с радиусом {radius}");
    }
}

// Класс представляющий прямоугольник
class Rectangle : IDrawable
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        Console.WriteLine($"Рисуем прямоугольник с шириной {width} и высотой {height}");
    }
}

// Класс представляющий треугольник
class Triangle : IDrawable
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public void Draw()
    {
        Console.WriteLine($"Рисуем треугольник со сторонами {side1}, {side2} и {side3}");
    }
}

class tack4all
{
    static void Main()
    {
        // Создаем массив объектов, реализующих интерфейс IDrawable
        IDrawable[] drawables = new IDrawable[]
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(3, 4, 5)
        };

        // Вызываем метод Draw() для каждого объекта в массиве
        foreach (var drawable in drawables)
        {
            drawable.Draw();
        }

        Console.ReadLine();
    }
}
