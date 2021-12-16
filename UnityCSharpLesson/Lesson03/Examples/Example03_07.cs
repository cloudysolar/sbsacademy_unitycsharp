using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03.Examples {
    // 슬라이드 3-2_25p

    class Example03_07 {
        public static void printString(string msg) {
            Console.WriteLine("\n{0}", msg);3
        }

        static void Main(string[] args) {
            // 2. 문자열을 매개변수로 받아 출력하는 메소드를 만들고 실행해봅시다.
            Console.WriteLine("# 아무 문장이나 입력해주세요: ");
            string input = Console.ReadLine();

            printString(input);
        }
    }
}
