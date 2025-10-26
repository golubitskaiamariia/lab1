// using System;

// public class Figure
// {
//     // Автосвойство для названия фигуры
//     public string Name { get; set; }

//     // Массив точек
//     private Point[] points;

//     // Конструкторы с 3-5 точками
//     public Figure(Point point1, Point point2, Point point3)
//     {
//         points = new Point[] { point1, point2, point3 };
//         Name = "Треугольник";
//     }

//     public Figure(Point point1, Point point2, Point point3, Point point4)
//         : this(point1, point2, point3) // Вызов конструктора с 3 точками
//     {
//         points = new Point[] { point1, point2, point3, point4 };
//         Name = "Четырехугольник";
//     }

//     public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
//         : this(point1, point2, point3, point4) // Вызов конструктора с 4 точками
//     {
//         points = new Point[] { point1, point2, point3, point4, point5 };
//         Name = "Пятиугольник";
//     }

//     // Метод для расчета длины стороны
//     public double LengthSide(Point A, Point B)
//     {
//         return A.DistanceTo(B);
//     }

//     // Метод для расчета периметра
//     public double PerimeterCalculator()
//     {
//         double perimeter = 0;
        
//         // Суммируем длины всех сторон
//         for (int i = 0; i < points.Length; i++)
//         {
//             Point currentPoint = points[i];
//             Point nextPoint = points[(i + 1) % points.Length]; // Замыкаем фигуру
            
//             perimeter += LengthSide(currentPoint, nextPoint);
//         }
        
//         return perimeter;
//     }

//     // Метод для вывода информации о фигуре
//     public void PrintInfo()
//     {
//         Console.WriteLine($"Фигура: {Name}");
//         Console.WriteLine($"Количество точек: {points.Length}");
//         Console.WriteLine($"Периметр: {PerimeterCalculator():F2}");
//         Console.Write("Точки: ");
//         foreach (var point in points)
//         {
//             Console.Write($"{point} ");
//         }
//         Console.WriteLine();
//     }

//     // Свойство для доступа к точкам (для тестов)
//     public Point[] Points => points;
// }