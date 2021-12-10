using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02.Examples {
    // 슬라이드 : 2-1_33p
    class Example02_02 {
        static void Main(string[] args) {
            // 문제 1 : 산술 연산자와 삼항 연산자를 이용해 아래의 내용을 구해봅시다. 2) 연도를 입력받고 해당년도가 윤년인지 평년인지 구하기
            Console.WriteLine("# 평년인지 윤년인지 구분할 연도를 입력해주세요: ");
            int year = int.Parse(Console.ReadLine());

            /*
                [ 규칙 ]
                1. 연수가 4로 나누어 떨어지면 윤년
                2. 그 중 4, 100으로 나누어 떨어지면 평년
                3. 그 중 4, 100, 400으로 나누어 떨어지면 윤년
             */

            // true=윤년 / false=평년
            bool isLeapYear = year % 4 == 0 ? (year % 100 == 0 ? (year % 400 == 0 ? true : false) : true) : false;

            Console.WriteLine("\n> 입력한 연도 {0}년은 윤년 규칙에 따라 {1}입니다.", year, isLeapYear ? "윤년" : "평년");
        }
    }
}
