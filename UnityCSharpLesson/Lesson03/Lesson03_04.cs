using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03 {
    // 슬라이드 3-1_14p
    class Lesson03_04 {
        static void Main(string[] args) {
            int[][] arr1; // 다차원 배열의 기본 선언 방법
            int[,] arr2; // 다차원 배열의 기본 선언 방법 (인덱서 사용)

            // 기본 방법을 이용한 배열 초기화
            int[][] arr3 = new int[2][];

            // 기본 방법을 이용한 다차원 배열 선언/초기화
            int[][] arr4 = {
                new int[]{ 1, 2 },
                new int[]{ 3, 4 }
            };
            int[][] arr5 = new int[][] {
                new int[]{ 1, 2 },
                new int[] { 3, 4 }
            };

            // 인덱서(,)를 이용한 배열 초기화
            int[,] arr6 = new int[2, 5]; // 다차원 배열 선언과 동시에 초기화 (인덱서 사용)

            // 인덱서를 사용한 다차원 배열 선언/초기화
            int[,] arr7 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr8 = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
        }
    }
}
