using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson01.Examples {
    class Example01_08 {
        static void Main(string[] args) {
            double pie = 3.14159265358579;
            int pie2 = (int) pie;

            Console.WriteLine("Pie: {0:f15}", pie);
            Console.WriteLine("Pie2(int) : {0:d}", pie2);
            Console.WriteLine("Pie2(double) : {0:f15}", (double) pie2);
        }
    }
}
