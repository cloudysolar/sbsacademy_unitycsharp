using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_06 {
    // 슬라이드 4-2-1_39~48p

    class Dog : Animal, IGroundAnimal {
        public Dog(string name, int age) : base(name, age) {

        }

        public void GiveRoom(string roomName) {
            Console.WriteLine("반려견 {0}에게 {1}(을)를 주었습니다.", name, roomName);
        }
    }
}
