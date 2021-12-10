using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 : 2-1_12p
    class Lesson02_04 {
        static void Main(string[] args) {
            // 비교 연산자 : ==, !=, <, >, <=, >=
            int a = 10;
            int b = 20;

            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("a == b = {0}", a == b);  // a와 b가 같음을 비교
            Console.WriteLine("a != b = {0}", a != b);  // a와 b가 다름을 비교
            Console.WriteLine("a < b = {0}", a < b);    // a가 b보다 작은지 비교
            Console.WriteLine("a > b = {0}", a > b);    // a가 b보다 큰지 비교
            Console.WriteLine("a <= b = {0}", a <= b);  // a가 b보다 작거나 같은지 비교
            Console.WriteLine("a >= b = {0}", a >= b);  // a가 b보다 크거나 같은지 비교
        }
    }
}
