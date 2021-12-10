using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 : 2-1_17p
    class Lesson02_07 {
        static void Main(string[] args) {
            // 조건부 논리 연산자 : &&, ||
            bool a = false;
            bool b = true;

            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("a && b = {0}", a && b);  // a [Condition AND] b : a가 false라면 b를 평가하지 않고 false 반환
            Console.WriteLine("a || b = {0}", a || b);  // a [Condition OR] b : a가 true라면 b를 평가하지 않고 true 반환
        }
    }
}

