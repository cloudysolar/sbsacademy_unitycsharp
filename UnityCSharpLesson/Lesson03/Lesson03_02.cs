using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03 {
    // 슬라이드 3-1_8p
    class Lesson03_02 {
        static void Main(string[] args) {
            // 강사와 함께 2 : 사각형 출력하기
            Console.WriteLine("# 출력할 사각형의 한 변의 길이를 입력해주세요: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < length; i++) {
                for (int j = 0; j < length; j++) {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
