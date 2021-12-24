using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_01 {
    // 슬라이드 4-2-1_12p

    class Cat : Animal {
        static void Main(string[] args) {
            Cat cat = new Cat();

            cat.name = "고양이";
            cat.age = 2;

            cat.Move();
        }
    }
}