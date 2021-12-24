using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Examples {
    // 슬라이드 4-2-1_50p

    class Example04_01 {
        static void Main(string[] args) {
            Example04_01 inst = new Example04_01();

            Computer cpu = new Computer();

            Monitor mn = new Monitor();
            Keyboard kb = new Keyboard();
            Mouse ms = new Mouse();
            Speaker sp = new Speaker();

            cpu.TogglePower();

            cpu.ConnectDevice(mn);
            cpu.ConnectDevice(kb);
            cpu.ConnectDevice(ms);
            cpu.ConnectDevice(sp);

            cpu.TogglePower();
        }
    }
}
