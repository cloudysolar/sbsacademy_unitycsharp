using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-2_30p
    class Example02_10 {
        static void Main(string[] args) {
            // 문제 4 : 두 숫자를 입력받고 두 숫자 사이의 최대공약수를 구해봅시다.
            Console.WriteLine("# [1/2] 최대공약수를 구할 숫자를 입력해주세요: ");
            int a = int.Parse(Console.ReadLine());
            int input1 = a;

            Console.WriteLine("# [2/2] 최대공약수를 구할 숫자를 입력해주세요: ");
            int b = int.Parse(Console.ReadLine());
            int input2 = b;

            int gcd = 0;

            while (b > 0) {
                gcd = a % b;
                a = b;
                b = gcd;
            }

            Console.WriteLine("\n> {0}(와)과 {1}의 최대공약수는 {2}입니다.", input1, input2, a);
        }
    }
}
