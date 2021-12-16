using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03.Examples {
    // 슬라이드 3-1_9p
    class Example03_01 {
        static void Main(string[] args) {
            // 1. 숫자를 입력받고 2부터 해당 숫자까지의 소수를 구해 출력해봅시다.
            Console.WriteLine("# 소수의 개수를 구할 숫자를 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());

            int count = input <= 1 ? 0 : 1;

            for (int i = 2; i <= input; i++) {
                for (int j = 2; j < i; j++) {
                    if (i % j == 0) {
                        // 1과 자기자신을 제외한 다른 수로 나누어 떨어지면 합성수
                        break;
                    }

                    if (j + 1 == i) {
                        // 자기 자신까지 왔을 때 나누어 떨어지는 수가 없다면 소수
                        count++;
                    }
                }
            }

            Console.WriteLine("\n> 숫자 {0}이하에 포함된 소수는 총 {1}개 입니다.", input, count);
        }
    }
}
