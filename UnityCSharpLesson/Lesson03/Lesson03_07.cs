using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03 {
    // 슬라이드 3-2_7p

    class Lesson03_07 {
        public int nowTime = 0;

        static void Main(string[] args) {
            Lesson03_07 inst = new Lesson03_07();

            Console.WriteLine("public 제한자는 어디서든 접근할 수 있도록 허용합니다. nowTime={0}", inst.nowTime);
        }
    }
}
