using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_02 {
    // 슬라이드 4-2-1_19p

    class Dog : Animal {
        public override void Move() {
            Console.WriteLine("{0}(이)가 움직였습니다!", name);
        }

        static void Main(string[] args) {
            Dog dog = new Dog();

            dog.name = "강아지";
            dog.age = 2;

            dog.Move();
        }
    }
}
