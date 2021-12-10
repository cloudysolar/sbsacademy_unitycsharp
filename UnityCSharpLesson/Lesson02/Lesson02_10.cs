using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 : 2-1_28p
    class Lesson02_10 {
        static void Main(string[] args) {
            // 복합 대입(할당) 연산자 : +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=
            int a = 10;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("{0} {1} {2} = {3}", a, "+=", 4, a += 4);
            Console.WriteLine("{0} {1} {2} = {3}", a, "-=", 2, a -= 2);
            Console.WriteLine("{0} {1} {2} = {3}", a, "*=", 5, a *= 5);
            Console.WriteLine("{0} {1} {2} = {3}", a, "/=", 10, a /= 10);
            Console.WriteLine("{0} {1} {2} = {3}", a, "%=", 5, a %= 5);
            Console.WriteLine("{0} {1} {2} = {3}", a, "&=", 3, a &= 3);
            Console.WriteLine("{0} {1} {2} = {3}", a, "|=", 14, a |= 14);
            Console.WriteLine("{0} {1} {2} = {3}", a, "^=", 240, a ^= 240);
            Console.WriteLine("{0} {1} {2} = {3}", a, "<<=", 1, a <<= 1);
            Console.WriteLine("{0} {1} {2} = {3}", a, ">>=", 2, a >>= 2);
        }
    }
}
