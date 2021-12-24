using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Examples {
    // 슬라이드 4-2-1_50p

    class Speaker : IOutputDevice {
        string name = "스피커";

        public string getName() {
            return name;
        }
    }
}
