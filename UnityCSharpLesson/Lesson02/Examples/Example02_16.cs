using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-3_34p
    class Example02_16 {
        static void Main(string[] args) {
            // 문제 4 : 문자열을 입력받고 해당 문자열에 "H"라는 글자가 몇개나 포함되어 있는지 확인해봅시다. (대소문자 구분 X)
            Console.WriteLine("# 아무 문장이나 입력해주세요: ");
            string input = Console.ReadLine().ToLower();

            int count = 0;

            for (int i = 0; i < input.Length; i++) {
                if (input[i] == 'h') {
                    count++;
                }
            }

            Console.WriteLine("\n> 입력하신 문장에 글자 \"H\"는 총 {0}번 포함되어 있습니다.", count);
        }
    }
}
