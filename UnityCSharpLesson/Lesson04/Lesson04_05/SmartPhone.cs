using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_05 {
    // 슬라이드 4-2-1_29~31p

    class SmartPhone {
        protected string[] pictures = new string[10];

        public virtual void TakePicture() {
            Console.WriteLine("사진 찍습니다~! 하나, 둘 셋!!");
        }
    }
}
