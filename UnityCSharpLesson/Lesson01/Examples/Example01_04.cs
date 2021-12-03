using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson01.Examples {
    class Example01_04 {
        static void Main(string[] args) {
            // 서식에서 x는 해당 숫자를 16진수로 변환하여 출력하겠다는 뜻입니다.
            Console.WriteLine("10진수 숫자 {0}(은)는 16진수로 변환하면 0x{0:x2} (이)가 됩니다.", 255);
        }
    }
}
