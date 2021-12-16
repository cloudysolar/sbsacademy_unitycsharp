using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03.Examples {
    // 슬라이드 3-1_16p
    class Example03_05 {
        static void Main(string[] args) {
            // 2. 2차원 배열을 만들어 초기화하되, 내용을 사각형으로 출력해봅시다.
            int[][] arr = new int[3][] {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 6, 7, 8 },
                new int[] { 9, 10, 11, 12 }
            };

            for (int i = 0; i < arr.Length; i++) {
                // Console.Write("arr[{0}] = ", i);

                for (int j = 0; j < arr[i].Length; j++) {
                    Console.Write("{0} ", arr[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}
