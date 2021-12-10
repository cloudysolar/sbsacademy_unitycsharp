using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 2-2_27p
    class Lesson02_17 {
        static void Main(string[] args) {
            // for 무한 반복문 (모든 요소 포함)
            for (int i = 0; true; i++) { // 모든 요소를 생략한 for (;;)도 사용할 수 있습니다.
                Console.WriteLine("현재 {0}번째 반복문을 작동시키고 있습니다.", i);
            }
        }
    }
}
