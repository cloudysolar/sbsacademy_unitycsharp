using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 : 2-1_27p
    class Lesson02_09 {
        static void Main(string[] args) {
            // 비트 시프트 연산자 : <<, >>
            int a = 25; // 2진수 : 0001 1001

            Console.WriteLine("{0} << {1} = {2}", a, 2, a << 2);
            Console.WriteLine("{0} >> {1} = {2}", a, 4, a >> 2);
        }
    }
}
