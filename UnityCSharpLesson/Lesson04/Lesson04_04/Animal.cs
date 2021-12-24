using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_04 {
    // 슬라이드 4-2-1_27p

    class Animal {
        public virtual void Move() {
            Console.WriteLine("부모 클래스에 있는 Move() 메소드입니다.");
        }
    }
}
