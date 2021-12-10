using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 2-2_29p
    class Lesson02_19 {
        static void Main(string[] args) {
            // do-while을 이용한 무한 반복문
            int i = 0;

            do {
                Console.WriteLine("현재 {0}번째 반복문을 실행 중입니다.", i);
                i++;
            } while (true);
        }
    }
}
