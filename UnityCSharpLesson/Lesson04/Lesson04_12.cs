using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04 {
    // 슬라이드 4-3_16p

    class Lesson04_12 {
        static void Main(string[] args) {
            string output = "# 이렇게 사용할 수 있습니다! #";

            Console.SetCursorPosition(Console.BufferWidth / 2 - (output.Length - 5), Console.WindowHeight / 2 - 1);
            Console.WriteLine("{0}", output);
        }
    }
}
