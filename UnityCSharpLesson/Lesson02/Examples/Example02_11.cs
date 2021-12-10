using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-3_17p
    class Example02_11 {
        static void Main(string[] args) {
            // 문제 1 : 크기가 10인 int형 배열을 만들고 숫자 10개를 입력받아 출력하는 프로그램을 만들어봅시다.
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine("# [{0}/{1}] 아무 숫자나 입력해주세요: ", i + 1, arr.Length);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n> 지금까지 입력하신 숫자는 다음과 같습니다: ");

            foreach (int i in arr) {
                Console.Write("{0}, ", i);
            }
        }
    }
}
