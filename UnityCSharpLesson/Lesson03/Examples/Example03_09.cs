using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03.Examples {
    // 슬라이드 3-2_25p

    class Example03_09 {
        public static int add(int num1, int num2) {
            return num1 + num2;
        }

        static void Main(string[] args) {
            // 4. 두 수를 매개변수로 받아 두 수의 합계를 반환하는 메소드를 만들어 실행해봅시다.
            Console.WriteLine("# [1/2] 합계를 구할 수를 입력해주세요: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n# [2/2] 합계를 구할 수를 입력해주세요: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n> {0} + {1} = {2}", num1, num2, add(num1, num2));
        }
    }
}
