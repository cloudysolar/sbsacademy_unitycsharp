using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-3_17p
    class Example02_13 {
        static void Main(string[] args) {
            // 문제 3 : 같은 자료형, 같은 크기의 배열을 2개 만들고, 하나의 배열에만 데이터를 입력한 다음 나머지 하나의 배열에 데이터를 똑같이 복사해봅시다.
            int[] arr1 = new int[10];
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++) {
                Console.WriteLine("# [{0}/{1}] 아무 숫자나 입력해주세요: ", i + 1, arr1.Length);
                arr1[i] = int.Parse(Console.ReadLine());
                arr2[i] = arr1[i];
            }

            Console.WriteLine("\n> 지금까지 입력하신 숫자는 다음과 같습니다: ");

            foreach (int i in arr2) {
                Console.Write("{0}, ", i);
            }
        }
    }
}
