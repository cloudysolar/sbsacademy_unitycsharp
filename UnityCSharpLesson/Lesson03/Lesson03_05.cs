using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03 {
    // 슬라이드 3-1
    class Lesson03_05 {
        static void Main(string[] args) {
            int[][] arr = new int[10][];

            // 큰 배열 요소의 값 바꾸기 (큰 배열의 요소 = 배열)
            int[] element = { 3, 5, 7, 9, 11 };
            arr[1] = element;

            // 작은 배열의 요소 값 바꾸기 (작은 배열의 요소 = 해당 자료형 변수)
            arr[1][3] = 8;

            // 변경된 요소 확인
            Console.WriteLine(arr[1][3]);

            // 큰 배열의 길이와 작은 배열의 길이 구하기
            Console.WriteLine("- 큰 배열의 길이 : {0}", arr.Length);

            // 다만, 이 경우 모든 요소 배열의 길이가 같다는 가정하에 진행됨. 다르다면 각 요소별로 값이 달라질 수 있음.
            Console.WriteLine("- 작은 배열의 길이 : {0}", arr[1].Length);
        }
    }
}
