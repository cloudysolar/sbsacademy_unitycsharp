using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03.Examples {
    // 슬라이드 3-2_25p

    class Example03_08 {
        public static int pow(int number) {
            return number * number;
        }
        static void Main(string[] args) {
            // 3. 숫자 하나를 매개변수로 받아 제곱하여 반환하는 메소드를 만들어 실행해봅시다.
            Console.WriteLine("# 제곱할 숫자를 입력해주세요: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\n> {0}(을)를 제곱할 숫자는 {1}입니다.", number, pow(number));
        }
    }
}
