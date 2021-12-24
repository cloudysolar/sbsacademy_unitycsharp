using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_08 {
    // 슬라이드 4-2-2_12p

    class Homepage {
        static void Main(string[] args) {
            Backend back = new Backend();

            do {
                Console.WriteLine("\n[홈페이지 프로그램]\n");
                Console.WriteLine("1. 회원가입");
                Console.WriteLine("2. 로그인");
                Console.WriteLine("3. 종료");

                Console.WriteLine("\n원하는 메뉴를 입력하세요: ");
                int menu = int.Parse(Console.ReadLine());

                if (menu == 1) {
                    back.Register();
                }
                else if (menu == 2) {
                    Console.WriteLine("\n# 아이디와 비밀번호를 띄어쓰기로 구분해 입력해주세요.");
                    string[] inputs = Console.ReadLine().Split(" ");

                    back.Login(inputs[0], inputs[1]);
                }
                else if (menu == 3) {
                    Console.WriteLine("\n!> 프로그램을 종료합니다.");
                    break;
                }
                else {
                    Console.WriteLine("\n!> 잘못 입력하셨습니다. 다시 입력해주세요.");
                    continue;
                }
            } while (true);
        }
    }
}
