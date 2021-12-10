using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 : 2-1_8p
    class Lesson02_02 {
        static void Main(string[] args) {
            // 산술 연산자 : +, -, *, /, %
            int a = 20;
            int b = 3;

            Console.WriteLine("{0} {2} {1} = {3}", a, b, "+", a + b); // 더하기
            Console.WriteLine("{0} {2} {1} = {3}", a, b, "-", a - b); // 빼기
            Console.WriteLine("{0} {2} {1} = {3}", a, b, "*", a * b); // 곱하기
            Console.WriteLine("{0} {2} {1} = {3}", a, b, "/", a / b); // 나누고 몫
            Console.WriteLine("{0} {2} {1} = {3}", a, b, "%", a % b); // 나누고 나머지
        }
    }
}
