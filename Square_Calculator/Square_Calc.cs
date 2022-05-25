using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Calculator
{
    public class Square_Calc
    {
        private double r; // Радиус круга

        private double a; // 1-ая сторона треугольника
        private double b; // 2-ая сторона треугольника
        private double c; // 3-ая сторона треугольника
        private bool right_triangle; // Является ли треугольник прямоугольным

        // Легкость добавления других фигур (Возможно не правильно понял что это значит. Сделал контруктор для добавления фигур)

        /// <summary>
        /// Creating circle
        /// </summary>
        /// <param name="radius"></param>
        public Square_Calc(double radius) 
        {
            r = radius;
            // Проверка на корректность введенных данных
            if (r <= 0)
                throw new Exception("Radius cannot be less than or equal to 0!");
            else
                r = radius;
        }

        /// <summary>
        /// Creating triangle
        /// </summary>
        /// <param name="side 1"></param>
        /// <param name="side 2"></param>
        /// <param name="side 3"></param>
        public Square_Calc(double side1, double side2, double side3) 
        {
            r = -1;

            a = side1;
            b = side2;
            c = side3;

            // Проверка на корректность введенных данных (стороны больше 0)
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Side cannot be less than or equal to 0!");

            // Проверка на корректность введенных данных (существует ли треугольник)
            if (a + b < c ||
                a + c < b ||
                b + c < a)
                throw new Exception("Such a triangle is impossible!");
                

            // Проверка на то, является ли треугольник прямоугольным (C² = A² + B²)
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2)
                )
                right_triangle = true;
            else
                right_triangle = false;
        }

        public double GetSquare() // Вычисление площади фигуры без знания типа фигуры
        {
            if (r == -1)
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else 
                return Math.PI * Math.Pow(r, 2);
        }

        // Проверка на то, является ли треугольник прямоугольным
        public bool isTriangleRight()
        {
            if (r == -1)
                return right_triangle;
            else
                return false;
        }
    }
}
