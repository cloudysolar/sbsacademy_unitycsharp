using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03.Examples {
    // 슬라이드 3-1_16p
    class Example03_04 {
        static void Main(string[] args) {
            // 1. 2차원 배열을 만들어 초기화하고 모든 내용을 출력해봅시다.
            int[][] arr = new int[3][] {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 6, 7, 8 },
                new int[] { 9, 10, 11, 12 }
            };

            for (int i = 0; i < arr.Length; i++) {
                for (int j = 0; j < arr[i].Length; j++) {
                    Console.WriteLine("arr[{0}][{1}] = {2}", i, j, arr[i][j]);
                }
            }
        }
    }
}
