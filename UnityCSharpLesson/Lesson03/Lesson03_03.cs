using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03 {
    // 슬라이드 3-1_8p
    class Lesson03_03 {
        static void Main(string[] args) {
            // 강사와 함께 3 : 직각 삼각형(4방향) 출력하기
            Console.WriteLine("# 출력할 직각삼각형의 방향을 입력해주세요(LU, LD, RU, RD): ");
            string input = Console.ReadLine();

            Console.WriteLine("\n# 출력할 직각삼각형의 높이를 입력해주세요: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (input) {
                // 직각이 왼쪽 아래에 있는 삼각형
                case "LD":
                    for (int i = 0; i < height; i++) {
                        for (int j = 0; j <= i; j++) {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;

                // 직각이 왼쪽 위에 있는 삼각형
                case "LU":
                    for (int i = 0; i < height; i++) {
                        for (int j = (height - i); j > 0; j--) {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;

                // 직각이 오른쪽 아래에 있는 삼각형
                case "RD":
                    for (int i = 0; i < height; i++) {
                        for (int j = (height - 1); j > i; j--) {
                            Console.Write(" ");
                        }

                        for (int k = 0; k <= i; k++) {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;

                // 직각이 오른쪽 위에 있는 삼각형
                case "RU":
                    for (int i = 0; i < height; i++) {
                        for (int j = 0; j < i; j++) {
                            Console.Write(" ");
                        }

                        for (int k = (height - i); k > 0; k--) {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;

                // 잘못 입력한 경우
                default:
                    Console.WriteLine("\n> \"{0}\"(은)는 알 수 없는 방향입니다. 다시 입력해주세요.", input);
                    break;
            }
        }
    }
}
