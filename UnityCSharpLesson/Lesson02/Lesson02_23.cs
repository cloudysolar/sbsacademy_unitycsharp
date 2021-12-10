using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson02 {
    // 슬라이드 2-3_19p
    class Lesson02_23 {
        static void Main(string[] args) {
            // 문자열 직접 생성
            string hello = "Hello World!";

            // 문자 배열을 이용해 생성
            char[] letters = { 'a', 'b', 'c' };
            string alphabet = new string(letters);

            Console.WriteLine("{0} / {1}", hello, alphabet);
        }
    }
}
