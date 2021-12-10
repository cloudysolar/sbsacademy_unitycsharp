using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 2-3_12p
    class Lesson02_20 {
        static void Main(string[] args) {
            int[] arr1; // 배열의 선언

            int[] arr2 = new int[10]; // 배열 선언과 동시에 초기화
            int[] arr3 = { 1, 2, 3, 4 }; // C언어 스타일로 배열 선언과 동시에 초기화
            int[] arr4 = new int[] { 1, 2, 3, 4 }; // 대체 스타일로 배열 선언과 동시에 초기화

            arr1 = new int[10]; // 배열 선언 후 초기화
        }
    }
}
