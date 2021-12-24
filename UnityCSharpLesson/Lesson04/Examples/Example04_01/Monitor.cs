using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Examples {
    // 슬라이드 4-2-1_50p

    internal class Monitor : IOutputDevice {
        string name = "모니터";

        public string getName() {
            return name;
        }
    }
}
