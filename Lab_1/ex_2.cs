// using System;

// public class Rectangle
// {
//     private double sideA;
//     private double sideB;

//     // Пользовательский конструктор
//     public Rectangle(double sideA, double sideB)
//     {
//         this.sideA = sideA;
//         this.sideB = sideB;
//     }

//     // Приватный метод для вычисления площади
//     private double CalculateArea()
//     {
//         return sideA * sideB;
//     }

//     // Приватный метод для вычисления периметра
//     private double CalculatePerimeter()
//     {
//         return 2 * (sideA + sideB);
//     }

//     // Свойство для площади с методом доступа get
//     public double Area
//     {
//         get { return CalculateArea(); }
//     }

//     // Свойство для периметра с методом доступа get
//     public double Perimeter
//     {
//         get { return CalculatePerimeter(); }
//     }
// }

// // Главный класс Program
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("=== Расчет параметров прямоугольника ===");
        
//         try
//         {
//             // Ввод данных от пользователя
//             Console.Write("Введите длину стороны A: ");
//             double sideA = GetPositiveDoubleFromUser();
            
//             Console.Write("Введите длину стороны B: ");
//             double sideB = GetPositiveDoubleFromUser();

//             // Создание экземпляра прямоугольника
//             Rectangle rectangle = new Rectangle(sideA, sideB);

//             // Вывод результатов
//             Console.WriteLine("\nРезультаты расчета:");
//             Console.WriteLine($"Площадь: {rectangle.Area:F2}");
//             Console.WriteLine($"Периметр: {rectangle.Perimeter:F2}");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Произошла ошибка: {ex.Message}");
//         }
        
//         Console.WriteLine("\nНажмите любую клавишу для выхода...");
//         Console.ReadKey();
//     }

//     // Метод для безопасного ввода
//     private static double GetPositiveDoubleFromUser()
//     {
//         while (true)
//         {
//             string input = Console.ReadLine();
//             if (double.TryParse(input, out double result) && result > 0)
//             {
//                 return result;
//             }
//             Console.Write("Ошибка! Введите положительное число: ");
//         }
//     }

//     // Метод для простых тестов
//     static void RunTests()
//     {
//         Console.WriteLine("\n=== Запуск тестов ===");
        
//         // Тест 1
//         Rectangle rect1 = new Rectangle(5, 10);
//         bool test1Pass = rect1.Area == 50 && rect1.Perimeter == 30;
//         Console.WriteLine($"Тест 1 (5x10): Площадь={rect1.Area}, Периметр={rect1.Perimeter} - {(test1Pass ? "ПРОЙДЕН" : "НЕ ПРОЙДЕН")}");
        
//         // Тест 2
//         Rectangle rect2 = new Rectangle(3, 3);
//         bool test2Pass = rect2.Area == 9 && rect2.Perimeter == 12;
//         Console.WriteLine($"Тест 2 (3x3): Площадь={rect2.Area}, Периметр={rect2.Perimeter} - {(test2Pass ? "ПРОЙДЕН" : "НЕ ПРОЙДЕН")}");
        
//         // Тест 3
//         Rectangle rect3 = new Rectangle(2.5, 4.5);
//         bool test3Pass = Math.Abs(rect3.Area - 11.25) < 0.001 && rect3.Perimeter == 14;
//         Console.WriteLine($"Тест 3 (2.5x4.5): Площадь={rect3.Area}, Периметр={rect3.Perimeter} - {(test3Pass ? "ПРОЙДЕН" : "НЕ ПРОЙДЕН")}");
        
//         Console.WriteLine("=== Тесты завершены ===");
//     }
// }