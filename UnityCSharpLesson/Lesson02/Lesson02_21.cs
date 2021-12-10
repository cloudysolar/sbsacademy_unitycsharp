using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 2-3_14p, 15p
    class Lesson02_21 {
        static void Main(string[] args) {
            int[] arr = new int[] { 10, 12, 14, 16, 18, 20 };

            arr[5] = 22; // 배열 요소의 값 바꾸기

            Console.WriteLine(arr[5]); // 배열 요소의 값을 가져와 출력하기
            Console.WriteLine("- 배열의 길이 : {0}", arr.Length); // 배열의 길이 출력하기

        }
    }
}
