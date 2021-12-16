using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03.Examples {
    // 슬라이드 3-1_9p
    class Example03_02 {
        static void Main(string[] args) {
            // 2. 숫자를 입력받고, 해당 숫자를 층수로 가지는 피라미드를 그려봅시다.
            Console.WriteLine("# 피라미드의 층수를 입력해주세요: ");
            int level = int.Parse(Console.ReadLine());

            for (int i = 0; i < level; i++) {
                for (int j = (level - i); j > 0; j--) {
                    Console.Write(" ");
                }

                for (int k = 0; k <= (i * 2); k++) {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
