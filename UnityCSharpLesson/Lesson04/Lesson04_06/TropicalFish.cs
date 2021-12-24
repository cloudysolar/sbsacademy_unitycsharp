using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_06 {
    // 슬라이드 4-2-1_39~48p

    class TropicalFish : Animal, IWaterAnimal {
        public TropicalFish(string name, int age) : base(name, age) {

        }

        public void GiveFishTank() {
            Console.WriteLine("반려물고기 {0}에게 어항을 주었습니다.", name);
        }
    }
}
