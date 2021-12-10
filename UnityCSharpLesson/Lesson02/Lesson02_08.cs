using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 : 2-1_25p
    class Lesson02_08 {
        static void Main(string[] args) {
            // 비트 연산자 : ~, &, |, ^

            // 2진수 숫자를 나타내려면 앞애 0b를 붙이고 작성(_는 작성자가 보기 편하게 원하는 만큼 끊어서 사용 가능)
            // 마이크로소프트 문서 : https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/integral-numeric-types#integer-literals
            int a = 0b_0000_1010; // 10진수 숫자 [10]을 나타내는 8비트 2진수 숫자
            int b = 0b_0000_1001; // 10진수 숫자 [9]를 나타내는 8비트 2진수 숫자

            Console.WriteLine("~4 = {0}", ~4);
            Console.WriteLine("{0} & {1} = {2}",a, b, a & b);
            Console.WriteLine("{0} | {1} = {2}", a, b, a | b);
            Console.WriteLine("{0} ^ {1} = {2}", a, b, a ^ b);
        }
    }
}
