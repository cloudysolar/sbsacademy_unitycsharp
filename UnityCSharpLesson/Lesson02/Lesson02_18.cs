using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 2-2_28p
    class Lesson02_18 {
        static void Main(string[] args) {
            // while을 이용한 무한 반복문
            int i = 0;

            while (true) {
                Console.WriteLine("현재 {0}번째 반복문을 실행하고 있습니다.", i);
                i++;
            }
        }
    }
}
