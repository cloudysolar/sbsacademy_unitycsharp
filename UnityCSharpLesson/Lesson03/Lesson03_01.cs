using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03 {
    // 슬라이드 3-1_8p
    class Lesson03_01 {
        static void Main(string[] args) {
            // 강사와 같이 1 : 구구단 1단부터 9단까지 한꺼번에 출력하기
            Console.WriteLine("> 구구단을 1단부터 9단까지 출력합니다.");

            for (int i = 1; i < 10; i++) {
                Console.WriteLine("\n[{0}단]", i);

                for (int j = 1; j < 10; j++) {
                    Console.WriteLine(" {0} X {1} = {2}", i, j, i * j);
                }
            }
        }
    }
}
