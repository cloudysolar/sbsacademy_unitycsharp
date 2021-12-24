using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04 {
    // 슬라이드 4-3_26p

    class Lesson04_15 {
        static void Main(string[] args) {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("Lesson1-1", "오리엔테이션");
            dict.Add("Lesson1-2", "C# 기본 내용");
            dict.Add("Lesson1-3", "변수와 자료형");

            dict.Add("Lesson2-1", "연산자");
            dict.Add("Lesson2-2", "조건문과 반복문");
            dict.Add("Lesson2-3", "배열과 문자열");

            dict.Add("Lesson3-1", "중첩 반복문과 다차원 배열");
            dict.Add("Lesson3-2", "메소드와 스코프");

            dict.Add("Lesson4-1", "객체지향의 개념");
            dict.Add("Lesson4-2-1", "상속");
            dict.Add("Lesson4-2-2", "다형성과 캡슐화");
            dict.Add("Lesson4-3", "C# API");

            Console.WriteLine("사전의 길이 : {0}", dict.Count);

            Console.WriteLine("\n{0}의 수업 내용은 \"{1}\"입니다.", "Lesson3-1", dict["Lesson3-1"]);

            Console.WriteLine("\n수업 내용 {0}의 포함 여부 : {1}", "대리자", dict.ContainsValue("대리자"));
            Console.WriteLine("수업 {0}의 포함 여부 : {1}", "Lesson1-1", dict.ContainsKey("Lesson1-1"));

            Console.WriteLine("\n사전 초기화!");
            dict.Clear();

            Console.WriteLine("사전의 길이 : {0}", dict.Count);
        }
    }
}
