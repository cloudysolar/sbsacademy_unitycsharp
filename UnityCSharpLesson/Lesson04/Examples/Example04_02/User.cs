using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Examples.Example04_02 {
    // 슬라이드 4-2-2_22p

    class User {
        static void Main(string[] args) {
            VendingMachine machine = new VendingMachine();

            Console.WriteLine("\n# 먼저 입금할 금액을 입력해주세요: ");
            machine.Input = int.Parse(Console.ReadLine());

            do {
                Console.WriteLine("\n[자판기]\n");
                Console.WriteLine("1. 추가 입금");
                Console.WriteLine("2. 거스름돈 출금");
                Console.WriteLine("3. 구매");
                Console.WriteLine("4. 종료");

                Console.WriteLine("\n# 원하는 메뉴를 입력하세요: ");
                int menu = int.Parse(Console.ReadLine());

                if (menu == 1) {
                    Console.WriteLine("\n# 추가로 입금할 금액을 입력해주세요: ");
                    machine.Input = int.Parse(Console.ReadLine());
                }
                else if (menu == 2) {
                    machine.RefundAmount();
                }
                else if (menu == 3) {
                    machine.ShowAllDrinks();
                    Console.WriteLine("\n# 원하는 음료의 번호를 입력해주세요: ");
                    machine.BuyDrink(int.Parse(Console.ReadLine()));
                }
                else if (menu == 4) {
                    if (machine.Input != 0) {
                        machine.RefundAmount();
                    }

                    Console.WriteLine("\n!> 프로그램을 종료합니다.");
                    break;
                }
                else {
                    Console.WriteLine("\n!> 알 수 없는 메뉴 번호입니다. 다시 입력해주세요.");
                }
            } while (true);
        }
    }
}
