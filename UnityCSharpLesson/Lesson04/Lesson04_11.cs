using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04 {
    // 슬라이드 4-3_15p

    class Lesson04_11 {
        static void Main(string[] args) {
            Console.WriteLine("# 아래에 아무 내용이나 입력하면 모든 내용이 지워지고 프로그램이 종료됩니다.");
            string input = Console.ReadLine();

            Console.WriteLine("\n> 입력된 내용: {0}", input);
            Console.Clear();
        }
    }
}
