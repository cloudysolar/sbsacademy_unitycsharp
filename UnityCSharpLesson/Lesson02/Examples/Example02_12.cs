using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-3_17p
    class Example02_12 {
        static void Main(string[] args) {
            // 문제 2 : 배열을 만들기 전에 배열의 크기를 먼저 입력받고, 해당 크기만큼 데이터를 입력해 출력하는 프로그램을 만들어봅시다.
            Console.WriteLine("# 배열의 크기를 입력해주세요: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine();

            for (int i = 0; i < size; i++) {
                Console.WriteLine("# [{0}/{1}] 아무 숫자나 입력해주세요: ", i + 1, size);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n> 지금까지 입력하신 숫자는 다음과 같습니다: ");

            foreach (int i in arr) {
                Console.Write("{0}, ", i);
            }
        }
    }
}
