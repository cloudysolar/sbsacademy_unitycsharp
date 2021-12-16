using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson03 {
    // 슬라이드 3-2_10p

    class Lesson03_09 {
        private void showBankAmount() {
            Console.WriteLine("같은 클래스에서만 접근할 수 있습니다!");
        }

        public void showMyBank() {
            showBankAmount();
        }

        static void Main(string[] args) {
            Lesson03_09 inst = new Lesson03_09();
            inst.showMyBank();
        }
    }
}
