using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-2_30p
    class Example02_09 {
        static void Main(string[] args) {
            // 문제 3 : 숫자를 입력받고 해당 숫자의 약수들의 합을 구해 출력해봅시다.
            Console.WriteLine("# 약수들의 합을 구할 숫자를 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= input; i++) {
                if (input % i == 0) {
                    sum += i;
                }
            }

            Console.WriteLine("\n> {0}의 약수들의 합은 {1}입니다.", input, sum);
        }
    }
}
