using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03 {
    // 슬라이드 3-2_8p

    class Lesson03_08 {
        internal int count = 0;
        int maxCount = 10;

        static void Main(string[] args) {
            Lesson03_08 inst = new Lesson03_08();
            Console.WriteLine("internal은 입력 안했을 때의 기본값이라 입력안해도 됩니다. maxCount={0}, count={1}", inst.maxCount, inst.count);
        }
    }
}
