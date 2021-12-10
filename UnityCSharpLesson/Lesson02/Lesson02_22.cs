using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 2-3_16p
    class Lesson02_22 {
        static void Main(string[] args) {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int count in arr) {
                Console.WriteLine(count);
            }
        }
    }
}
