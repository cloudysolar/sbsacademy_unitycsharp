using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 2-2_20p
    class Lesson02_15 {
        static void Main(string[] args) {
            // 1부터 100까지 합을 구하는 for 반복문
            int sum = 0;

            for (int i = 1; i <= 100; i++) {
                sum += i;
            }

            Console.WriteLine("1부터 100까지의 합 : {0}", sum);
        }
    }
}
