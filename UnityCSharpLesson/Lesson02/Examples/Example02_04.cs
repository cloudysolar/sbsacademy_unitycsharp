using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-2_14p
    class Example02_04 {
        static void Main(string[] args) {
            // 문제 1 : 윤년을 판별하는 프로그램을 조건문을 사용해 만들어봅시다.
            Console.WriteLine("# 윤년인지 판별할 연도를 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());

            string output = "평년";

            if (input % 4 == 0) {
                if (input % 100 == 0) {
                    if (input % 400 == 0) {
                        output = "윤년";
                    }
                }
                else {
                    output = "윤년";
                }
            }

            Console.WriteLine("\n> {0}년은 {1}입니다.", input, output);
        }
    }
}
