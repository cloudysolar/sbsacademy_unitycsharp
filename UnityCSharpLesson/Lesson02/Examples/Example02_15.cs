using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-3_34p
    class Example02_15 {
        static void Main(string[] args) {
            // 문제 2 : 문자열 자르기 기능을 이용해 아래와 같이 입력받고 계산해봅시다.
            Console.WriteLine("# 덧셈을 계산할 숫자를 띄어쓰기로 구분해 입력해주세요.");
            string input = Console.ReadLine();

            string[] inputs = input.Split(" ");
            string output_formula = "";

            int sum = 0;

            for (int i = 0; i < inputs.Length; i++) {
                sum += int.Parse(inputs[i]);

                if (i == inputs.Length - 1) {
                    output_formula = output_formula + inputs[i];
                }
                else {
                    output_formula = output_formula + inputs[i] + " + ";
                }
            }

            Console.WriteLine("{0} = {1}", output_formula, sum);
        }
    }
}
