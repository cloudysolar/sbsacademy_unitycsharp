using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 : 2-1_10p
    class Lesson02_03 {
        static void Main(string[] args) {
            // 증감 연산자 : ++, --
            int a = 7;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("a = {0}, ++a = {1}", a, ++a); // 전위 증가 연산자
            Console.WriteLine("a = {0}, a++ = {1}", a, a++); // 후위 증가 연산자
            Console.WriteLine("a = {0}, --a = {1}", a, --a); // 전위 감소 연산자
            Console.WriteLine("a = {0}, a-- = {1}", a, a--); // 후위 감소 연산자
            Console.WriteLine("a = {0}", a);
        }
    }
}
