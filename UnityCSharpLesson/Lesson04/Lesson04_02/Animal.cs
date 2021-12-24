using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_02 {
    // 슬라이드 4-2-1_18p

    abstract class Animal {
        public string name = "";
        public int age = 0;

        protected string gender = "";
        protected string species = "";

        public abstract void Move();
    }
}
