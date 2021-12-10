using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 : 2-1_15p
    class Lesson02_06 {
        static void Main(string[] args) {
            // 논리 연산자 : &, |, ^, !
            bool a = true;
            bool b = false;

            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("a & b = {0}", a & b);    // a [AND] b    : 둘 다 true일 경우 true 반환
            Console.WriteLine("a | b = {0}", a | b);    // a [OR] b     : 둘 중 하나라도 true인 경우 true 반환
            Console.WriteLine("a ^ b = {0}", a ^ b);    // a [XOR] b    : 둘 중 하나만 true일 경우 true 반환
            Console.WriteLine("!a = {0}", !a);          // [NOT] a      : true라면 false, false라면 true로 반환
        }
    }
}
