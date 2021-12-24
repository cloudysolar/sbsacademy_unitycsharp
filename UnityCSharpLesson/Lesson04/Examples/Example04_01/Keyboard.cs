using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Examples {
    // 슬라이드 4-2-1_50p

    class Keyboard : IInputDevice {
        string name = "키보드";

        public string getName() {
            return name;
        }
    }
}
