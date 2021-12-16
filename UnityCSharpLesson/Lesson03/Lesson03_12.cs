using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03 {
    // 슬라이드 3-2_17p

    class Lesson03_12 {
        static void Main(string[] args) {
            Console.WriteLine("# 0이상의 아무 숫자나 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());

            // C#에서 무작위 숫자를 만드는 가장 쉬운 방법은 Random 클래스의 인스턴스를 생성해 사용하는 방법입니다.
            // 인스턴스가 무엇인지 궁금하다면 3-2_18p를 확인하세요.
            Random rand = new Random();
            int random = rand.Next(input);

            Console.WriteLine("0에서 {0}사이의 숫자 중 {1}(이)가 선택되었습니다.", input, random);
        }
    }
}
