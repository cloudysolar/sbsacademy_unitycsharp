using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_01 {
    // 슬라이드 4-2-1_11p

    class Dog : Animal {
        static void Main(string[] args) {
            Dog dog = new Dog();

            dog.name = "강아지";
            dog.age = 2;

            dog.Move();
        }
    }
}
