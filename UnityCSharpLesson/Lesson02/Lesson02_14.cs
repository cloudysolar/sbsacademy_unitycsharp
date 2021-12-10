using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 2-2_11p
    class Lesson02_14 {
        static void Main(string[] args) {
            int a = 10;

            switch (a) {
                case 10:
                    Console.WriteLine("a는 10입니다.");
                    break;
                case 20:
                    Console.WriteLine("a는 20입니다.");
                    break;
                default:
                    Console.WriteLine("a는 10도 20도 아닙니다.");
                    break;
            }
        }
    }
}
