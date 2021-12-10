using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 : 2-1_33p
    class Example02_03 {
        static void Main(string[] args) {
            // 문제 2 : 비트 시프트 연산자를 사용해 왼쪽과 오른쪽으로 각각 1비트씩 이동시킬 때 어떤 규칙을 가지는지 찾아봅시다.
            int a = 7;

            // 왼쪽 시프트 연산을 1번 진행할 때마다 진행하기 전 숫자의 x2(곱하기 2)가 됨.
            Console.WriteLine("[왼쪽 시프트 연산]");
            Console.WriteLine(a);
            Console.WriteLine(a <<= 1);
            Console.WriteLine(a <<= 1);
            Console.WriteLine(a <<= 1);
            Console.WriteLine(a <<= 1);

            int b = 256;

            // 오른쪽 시프트 연산을 1번 진행할 때마다 진행하기 전 숫자의 /2(나누기 2)가 됨
            Console.WriteLine("\n[오른쪽 시프트 연산]");
            Console.WriteLine(b);
            Console.WriteLine(b >>= 1);
            Console.WriteLine(b >>= 1);
            Console.WriteLine(b >>= 1);
            Console.WriteLine(b >>= 1);
        }
    }
}
