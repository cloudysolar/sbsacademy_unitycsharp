using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_01 {
    // 슬라이드 4-2-1_10p

    class Animal {
        public string name = "";
        public int age = 0;

        protected string gender = "";
        protected string species = "";

        public void Move() {
            Console.WriteLine("{0}(이)가 움직였습니다.", name);
        }
    }
}
