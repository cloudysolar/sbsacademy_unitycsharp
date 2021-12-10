using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 2-2_14p
    class Example02_06 {
        static void Main(string[] args) {
            // 문제 3 : 숫자를 입력받고 아래 조건에 맞게 출력해봅시다.
            Console.WriteLine("# 게임 등급 분류를 한다면 어떤 등급으로 분류하실건가요?");
            int rating = int.Parse(Console.ReadLine());

            switch (rating) {
                case 0:
                    Console.WriteLine("\n> 전체 이용가입니다. 모두가 이용할 수 있습니다.");
                    break;
                case 12:
                    Console.WriteLine("\n> 12세 이용가입니다. 부모의 관리감독이 필요할 수 있습니다.");
                    break;
                case 15:
                    Console.WriteLine("\n> 15세 이용가입니다. 알아서 잘 할 수 있을 것입니다.");
                    break;
                case 19:
                    Console.WriteLine("\n> 19세 이용가입니다. 더 이상의 설명은 생략합니다.");
                    break;
                default:
                    Console.WriteLine("\n> 잘못 입력하셨습니다.");
                    break;
            }
        }
    }
}
