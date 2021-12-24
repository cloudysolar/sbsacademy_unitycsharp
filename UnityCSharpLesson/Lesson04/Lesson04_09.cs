using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04 {
    // 슬라이드 4-2-2_18p

    class Lesson04_09 {
        private string _name = "";

        private string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        static void Main(string[] args) {
            Lesson04_09 inst = new Lesson04_09();

            inst.Name = "홍길동";

            Console.WriteLine(inst.Name);
        }
    }
}
