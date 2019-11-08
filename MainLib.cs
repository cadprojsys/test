using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

Юнит-тесты
Легкость добавления других фигур
Вычисление площади фигуры без знания типа фигуры
Проверку на то, является ли треугольник прямоугольным
     */
namespace TestTaskLibMindbox
{
    public static class MainLib
    {
        /// <summary>
        /// площадь круга
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double AreaCircle(double radius)
        {
            return radius * radius * Math.PI;
        }
        /// <summary>
        /// площать треугольника
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public static double AreaTriangle(double sideA, double sideB, double sideC)
        {
            // вычисляем полупериметр
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public static bool CheckRightTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA == Math.Sqrt(Math.Sqrt(sideB) + Math.Sqrt(sideC)) || sideB == Math.Sqrt(Math.Sqrt(sideA) + Math.Sqrt(sideC)) || sideC == Math.Sqrt(Math.Sqrt(sideA) + Math.Sqrt(sideB))) return true;
            return false; 
        }

        /// <summary>
        /// Легкость добавления других фигур - Не очень понятно, заказчик добавляет фигуры, вызывая класс из dll или в исходном коде добавляется фигура?
        /// </summary>
        public static void AddShape()
        { 
        
        }

    }
}
