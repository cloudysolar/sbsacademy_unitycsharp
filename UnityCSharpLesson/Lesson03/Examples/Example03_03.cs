using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03.Examples {
    // 슬라이드 3-1_9p
    class Example03_03 {
        static void Main(string[] args) {
            // 3. 피라미드를 그려보았다면 다이아몬드를 그려봅시다
            Console.WriteLine("# 다이아몬드의 크기를 입력해주세요: ");
            int size = int.Parse(Console.ReadLine());

            // 다이아몬드의 반쪽 윗부분 그리기
            for (int i = 0; i < size; i++) {
                for (int j = (size - i); j > 0; j--) {
                    Console.Write(" ");
                }

                for (int k = 0; k <= (i * 2); k++) {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // 다이아몬드의 반쪽 아랫부분 그리기
            for (int i = (size - 1); i > 0; i--) {
                for (int j = size; j >= i; j--) {
                    Console.Write(" ");
                }

                for (int k = 0; k <= ((i - 1) * 2); k++) {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
