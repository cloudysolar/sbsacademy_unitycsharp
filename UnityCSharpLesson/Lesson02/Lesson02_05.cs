using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 : 2-1_14p
    class Lesson02_05 {
        static void Main(string[] args) {
            // 조건(삼항) 연산자 : ?:
            int price = 3000;
            int criteria = 1500;

            // 음료수의 가격(price)이 1500원(criteria) 이상이라면 비싸다, 미만이면 싸다라고 출력하기.
            Console.WriteLine("만약 음료수가 {0}원 이라면 {1}원 {2}고 생각한다.", price, criteria, price >= criteria ? "이상이므로 비싸다" : "미만이므로 싸다");
        }
    }
}
