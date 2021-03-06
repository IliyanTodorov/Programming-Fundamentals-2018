﻿using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static void Main()
        {
            string shape = Console.ReadLine();
            double area = 0;

            if (shape == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = side * height / 2;
            }
            else if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());

                area = side * side;
            }
            else if (shape == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = width * height;
            }
            else if (shape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                area = Math.PI * radius * radius;
            }
            Console.WriteLine("{0:f2}", area);
        }
    }
}
