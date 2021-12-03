using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson01.Examples {
    class Example01_03 {
        static void Main(string[] args) {
            // 서식의 D는 정수를 뜻하고, 그 뒤의 숫자는 정수를 해당 숫자 자리수 만큼 표시하겠다는 뜻입니다.
            Console.WriteLine("오늘은 {0:D4}년 {1:D2}월 {2:D2}일 {3}요일 입니다.", 2021, 12, 4, "토");
        }
    }
}
