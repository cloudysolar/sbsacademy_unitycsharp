using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-3_34p
    class Example02_14 {
        static void Main(string[] args) {
            // 문제 1 : 문자열을 입력받고, 해당 문자열에 몇 글자가 있는지 확인해봅시다. (공백 제외)
            Console.WriteLine("# 아무 문장이나 입력해주세요: ");
            string input = Console.ReadLine();

            int emptyCount = 0;

            for (int i = 0; i < input.Length; i++) {
                if (input[i].Equals(' ')) {
                    emptyCount++;
                }
            }

            Console.WriteLine("\n> 입력하신 문자열의 전체 길이는 {0}글자이고, 공백 제외 {1}글자가 있습니다.", input.Length, input.Length - emptyCount);
        }
    }
}
