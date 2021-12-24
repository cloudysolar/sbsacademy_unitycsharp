using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04 {
    // 슬라이드 4-3_21p

    class Lesson04_13 {
        static void Main(string[] args) {
            Console.WriteLine("# 무작위 숫자를 반환할 숫자 2개를 띄어쓰기로 구분해 입력해주세요: ");
            Console.WriteLine("(두 번째로 입력하는 숫자는 첫 번째로 입력하는 숫자보다 커야합니다.)");
            string[] inputs = Console.ReadLine().Split(" ");

            int range1 = int.Parse(inputs[0]);
            int range2 = int.Parse(inputs[1]);

            Random random = new Random();

            Console.WriteLine("\n!> 첫 번째 Next()의 결과입니다: {0}", random.Next());
            Console.WriteLine("!> 두 번재 Next({0})의 결과입니다: {1}", range1, random.Next(range1));
            Console.WriteLine("!> 세 번째 Next({0}, {1})의 결과입니다: {2}", range1, range2, random.Next(range1, range2));
        }
    }
}
