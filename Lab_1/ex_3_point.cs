// using System;

// public class Point
// {
//     // Поля
//     private int x;
//     private int y;

//     public int X { get { return x; } }

//     public int Y { get { return y; } }

//     // Пользовательский конструктор
//     public Point(int x, int y)
//     {
//         this.x = x;
//         this.y = y;
//     }

//     // Метод для вычисления расстояния до другой точки
//     public double DistanceTo(Point other)
//     {
//         return Math.Sqrt(Math.Pow(this.X - other.X, 2) + Math.Pow(this.Y - other.Y, 2));
//     }

//     // Переопределение ToString для удобства
//     public override string ToString()
//     {
//         return $"({X}, {Y})";
//     }
// }