using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03.Examples {
    // 슬라이드 3-2_25p

    class Example03_10 {
        public int getGCD(int num1, int num2) {
            int gcd = 0;

            while (num2 > 0) {
                gcd = num1 % num2;
                num1 = num2;
                num2 = gcd;
            }

            return num1;
        }

        public int getLCM(int num1, int num2, int gcd) {
            return num1 * num2 / gcd;
        }

        static void Main(string[] args) {
            // 선택 문제(5). 두 수를 매개변수로 받아 두 수의 최소공배수를 찾아 반환하는 메소드를 만들어 실행해봅시다.
            Example03_10 inst = new Example03_10();

            Console.WriteLine("# 최소공배수를 구할 두 수를 띄어쓰기로 구분해 입력해주세요: ");
            string[] inputs = Console.ReadLine().Split(" ");

            int num1 = int.Parse(inputs[0]);
            int num2 = int.Parse(inputs[1]);

            int gcd = inst.getGCD(num1, num2);

            Console.WriteLine("\n> {0}(와)과 {1}의 최소공배수는 {2}입니다.", num1, num2, gcd);
        }
    }
}