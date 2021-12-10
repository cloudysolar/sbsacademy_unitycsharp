using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 2-3_28p
    class Lesson02_32 {
        static void Main(string[] args) {
            string s = "Hello, This is string substring method test";
            string sub = s.Substring(5, 20);

            Console.WriteLine(sub);
        }
    }
}
