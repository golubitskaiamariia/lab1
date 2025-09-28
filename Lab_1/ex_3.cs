using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Расчет периметра многоугольника ===");

        // Пример с треугольником
        Console.WriteLine("\n1. Треугольник:");
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 3);
        Point p3 = new Point(4, 0);
        
        Figure triangle = new Figure(p1, p2, p3);
        triangle.PrintInfo();

        // Пример с четырехугольником
        Console.WriteLine("\n2. Четырехугольник:");
        Point p4 = new Point(0, 0);
        Point p5 = new Point(0, 4);
        Point p6 = new Point(3, 4);
        Point p7 = new Point(3, 0);
        
        Figure rectangle = new Figure(p4, p5, p6, p7);
        rectangle.Name = "Прямоугольник";
        rectangle.PrintInfo();

        // Пример с пятиугольником
        Console.WriteLine("\n3. Пятиугольник:");
        Point p8 = new Point(0, 0);
        Point p9 = new Point(2, 3);
        Point p10 = new Point(4, 3);
        Point p11 = new Point(5, 0);
        Point p12 = new Point(2, -2);
        
        Figure pentagon = new Figure(p8, p9, p10, p11, p12);
        pentagon.PrintInfo();

        // Запуск тестов
        Console.WriteLine("\n=== Запуск тестов ===");
        RunTests();

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    // Метод для запуска тестов
    static void RunTests()
    {
        TestLengthSide();
        TestPerimeterCalculator();
        TestConstructorOverloading();
        Console.WriteLine("Все тесты завершены!");
    }

    // Тест метода LengthSide
    static void TestLengthSide()
    {
        Console.WriteLine("\nТест LengthSide:");
        
        Point p1 = new Point(0, 0);
        Point p2 = new Point(3, 4);
        Figure figure = new Figure(p1, p2, new Point(1, 1));
        
        double length = figure.LengthSide(p1, p2);
        double expected = 5.0; // √(3² + 4²) = 5
        
        bool passed = Math.Abs(length - expected) < 0.001;
        Console.WriteLine($"Расстояние между {p1} и {p2}: {length:F2} (ожидается: {expected}) - {(passed ? "ПРОЙДЕН" : "НЕ ПРОЙДЕН")}");
    }

    // Тест метода PerimeterCalculator
    static void TestPerimeterCalculator()
    {
        Console.WriteLine("\nТест PerimeterCalculator:");
        
        // Тест с прямоугольником 3x4
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 3);
        Point p3 = new Point(4, 3);
        Point p4 = new Point(4, 0);
        
        Figure rectangle = new Figure(p1, p2, p3, p4);
        double perimeter = rectangle.PerimeterCalculator();
        double expected = 14.0; // 3 + 4 + 3 + 4 = 14
        
        bool passed = Math.Abs(perimeter - expected) < 0.001;
        Console.WriteLine($"Периметр прямоугольника: {perimeter:F2} (ожидается: {expected}) - {(passed ? "ПРОЙДЕН" : "НЕ ПРОЙДЕН")}");
    }

    // Тест перегруженных конструкторов
    static void TestConstructorOverloading()
    {
        Console.WriteLine("\nТест конструкторов:");
        
        Point p1 = new Point(0, 0);
        Point p2 = new Point(1, 0);
        Point p3 = new Point(1, 1);
        Point p4 = new Point(0, 1);
        Point p5 = new Point(0, 2);

        // Тест конструктора с 3 точками
        Figure triangle = new Figure(p1, p2, p3);
        bool test1Passed = triangle.Points.Length == 3 && triangle.Name == "Треугольник";
        Console.WriteLine($"Конструктор с 3 точками - {(test1Passed ? "ПРОЙДЕН" : "НЕ ПРОЙДЕН")}");

        // Тест конструктора с 4 точками
        Figure quadrilateral = new Figure(p1, p2, p3, p4);
        bool test2Passed = quadrilateral.Points.Length == 4 && quadrilateral.Name == "Четырехугольник";
        Console.WriteLine($"Конструктор с 4 точками - {(test2Passed ? "ПРОЙДЕН" : "НЕ ПРОЙДЕН")}");

        // Тест конструктора с 5 точками
        Figure pentagon = new Figure(p1, p2, p3, p4, p5);
        bool test3Passed = pentagon.Points.Length == 5 && pentagon.Name == "Пятиугольник";
        Console.WriteLine($"Конструктор с 5 точками - {(test3Passed ? "ПРОЙДЕН" : "НЕ ПРОЙДЕН")}");
    }
}