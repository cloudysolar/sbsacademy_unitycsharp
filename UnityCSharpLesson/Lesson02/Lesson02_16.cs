using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 2-2_22p
    class Lesson02_16 {
        static void Main(string[] args) {
            // 1부터 100까지의 합을 구하는 while 반복문
            int sum = 0, i = 1;

            while (i <= 100) {
                sum += i;
                i++;
            }

            Console.WriteLine("1부터 100까지의 합 : {0}");
        }
    }
}
