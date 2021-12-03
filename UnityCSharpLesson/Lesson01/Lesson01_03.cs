using System;
using System.Collections.Generic;
using System.Text;

// 슬라이드 1-2_49p
namespace UnityCSharpLesson {
    class Lesson01_03 {
        static void Main(string[] args) {
            // 프로그램은 0을 첫 숫자로 인식하여 순서를 인식합니다. {}를 숫자로만 입력하면 뒤에 따라오는 추가 내용의 순서대로 들어가게 되며, 이전 순서의 값을 가져와 사용할 수도 있습니다.
            // 추가로 이전 순서의 값을 가져와 다른 서식으로 표현하려면 {순서:서식}의 형태로 사용하면 됩니다.
            Console.WriteLine("이것은 {0}로, 이런 식으로 {1}진수 숫자 {2:d}를 {3}진수 숫자 {4}자리인 {2:x4}로 변환할 수 있습니다.", "서식 문자열", 10, 15, 16, 4);
        }
    }
}
