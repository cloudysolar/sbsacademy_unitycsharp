using System;
using System.Collections.Generic;
using System.Text;

// 슬라이드: 1-2_53p
namespace UnityCSharpLesson.Lesson01 {
    class Lesson01_05 {
        static void Main(string[] args) {
            Console.Write("# 출력할 문장을 입력 후 [Enter]키를 눌러주세요: ");

            // System.Console.ReadLine() 메소드는 입력 종료 신호가 입력된 즉시 종료 신호 이전에 입력된 모든 내용을 담아 string 값으로 반환하는 메소드입니다.
            Console.WriteLine("\n> 입력된 문장은 다음과 같습니다: {0}\n", Console.ReadLine());
        }
    }
}
