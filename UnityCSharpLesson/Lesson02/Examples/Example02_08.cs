using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-2_30p
    class Example02_08 {
        static void Main(string[] args) {
            // 문제 2 : 숫자를 입력받고 해당 숫자의 약수의 개수가 몇개인지 출력해봅시다.
            Console.WriteLine("# 약수의 개수를 찾을 숫자를 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 1; i <= input; i++) {
                if (input % i == 0) {
                    count++;
                }
            }

            Console.WriteLine("\n> {0}의 약수의 개수는 {1}개 입니다.", input, count);
        }
    }
}
