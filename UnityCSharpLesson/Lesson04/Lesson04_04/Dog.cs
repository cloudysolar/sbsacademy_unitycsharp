using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_04 {
    // 슬라이드 4-2-1_27,28p

    class Dog : Animal {
        public override void Move() {
            Console.WriteLine("자식 클래스에 있는 Move() 메소드입니다.");
            // base.Move();
        }

        public void Bark() {
            Console.WriteLine("개가 짖고 있습니다!!");
        }

        static void Main(string[] args) {
            Animal animal = new Dog(); // 업 캐스팅

            animal.Move();
            // animal.Bark(); // 호출 불가능

            Dog dog = (Dog) animal; // 다운 캐스팅

            dog.Move();
            dog.Bark(); // 호출 가능
        }
    }
}
