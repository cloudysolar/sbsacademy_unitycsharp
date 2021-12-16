using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03 {
    // 슬라이드 3-2_19p

    class Lesson03_13 {
        public int getGCD(int num1, int num2) {
            int gcd = 0;

            while (num2 > 0) {
                gcd = num1 % num2;
                num1 = num2;
                num2 = gcd;
            }

            return num1;
        }

        static void Main(string[] args) {
            Lesson03_13 inst = new Lesson03_13();

            Console.WriteLine("# [1/2] 최대공약수를 구할 수를 입력해주세요: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("# [2/2] 최대공약수를 구할 수를 입력해주세요: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.Write("\n> {0}(와)과 {1}의 최대공약수는 {2}입니다.", input1, input2, inst.getGCD(input1, input2));
        }
    }
}
