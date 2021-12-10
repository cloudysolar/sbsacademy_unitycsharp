using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-2_14p
    class Example02_05 {
        static void Main(string[] args) {
            // 문제 2 : 1~100 사이의 숫자를 입력받고, 숫자가 75~100 사이라면 "당첨", 그 외의 경우 "꽝"을 출력하도록 해봅시다.
            Console.WriteLine("# 1부터 100사이의 숫자중 아무거나 하나 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());

            string output = "꽝";

            if (input >= 75 && input <= 100) {
                output = "당첨";
            }

            Console.WriteLine("\n> 결과는 {0}입니다!", output);
        }
    }
}
