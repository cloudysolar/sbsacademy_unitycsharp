using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 : 2-1_33p
    class Example02_01 {
        static void Main(string[] args) {
            // 문제 1: 산술 연산자와 삼항 연산자를 이용해 아래의 내용을 구해봅시다. 1) 숫자를 입력받고 해당 숫자가 짝수인지 홀수인지 구별하기 (0은 제외)
            Console.WriteLine("# 홀짝을 판별할 숫자를 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());

            // 숫자를 2로 나눠 0으로 나누어 떨어지는지(짝수), 아니면 나머지가 생기는지(홀수)를 이용해 짝수인지 홀수인지를 판별할 수 있습니다.
            Console.WriteLine("\n> 입력한 수 {0}(은)는 {1}입니다.", input, input % 2 == 0 ? "짝수" : "홀수");
        }
    }
}
