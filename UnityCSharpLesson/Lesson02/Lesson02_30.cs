using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 2-3_26p
    class Lesson02_30 {
        static void Main(string[] args) {
            string s = "Hello, This is string split method test";
            string[] arr = s.Split(' ');

            foreach (string str in arr) {
                Console.Write(str + " / ");
            }
        }
    }
}
