using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_03 {
    // 슬라이드 4-2-1_24,25p

    class Dog : Animal {
        public override void Move() {
            Console.WriteLine("{0}(이)가 꼬리를 흔들며 다가옵니다.", name);
            // base.Move(); // 주석을 풀면 테스트할 수 있습니다.
        }

        static void Main(string[] args) {
            Dog dog = new Dog();

            dog.name = "강아지";
            dog.age = 2;

            dog.Move();
        }
    }
}
