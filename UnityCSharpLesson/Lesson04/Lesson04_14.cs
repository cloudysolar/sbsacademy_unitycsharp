using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04 {
    // 슬라이드 4-3_24p

    class Lesson04_14 {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Hello");
            list.Add("World");
            list.Add("My");
            list.Add("C#");
            list.Add("Program");

            foreach (string item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n{0} 포함 여부 : {1}", "World", list.Contains("World"));
            Console.WriteLine("{0}번째 리스트 항목 : {1}", 2, list[1]);
            Console.WriteLine("\n현재 리스트의 길이 : {0}", list.Count);

            Console.WriteLine("\n리스트 초기화!");
            list.Clear();

            Console.WriteLine("현재 리스트의 길이 : {0}", list.Count);
        }
    }
}
