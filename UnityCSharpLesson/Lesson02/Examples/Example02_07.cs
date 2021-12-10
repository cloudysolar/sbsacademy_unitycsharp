using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-2_30p
    class Example02_07 {
        static void Main(string[] args) {
            // 문제 1 : 숫자를 입력받고 해당 숫자의 구구단을 1~9까지 계산해서 출력해봅시다.
            Console.WriteLine("# 구구단을 출력할 숫자를 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("\n> 결과: ");

            for (int i = 1; i < 10; i++) {
                Console.WriteLine("{0} X {1} = {2}", input, i, input * i);
            }
        }
    }
}
