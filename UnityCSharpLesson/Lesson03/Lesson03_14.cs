using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03 {
    // 슬라이드 3-2_24p

    class Lesson03_14 {
        public int factorial(int number) {
            if (number <= 1) {
                return number;
            }
            else {
                return factorial(number - 1) * number;
            }
        }

        static void Main(string[] args) {
            Lesson03_14 inst = new Lesson03_14();

            Console.WriteLine("# 팩토리얼을 구할 수를 입력해주세요: ");
            int fact = int.Parse(Console.ReadLine());

            Console.WriteLine("\n> 재귀 메소드를 통해 구한 {0}!은 {1}입니다.", fact, inst.factorial(fact));
        }
    }
}
