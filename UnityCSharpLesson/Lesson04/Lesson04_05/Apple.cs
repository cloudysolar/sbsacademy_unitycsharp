using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_05 {
    // 슬라이드 4-2-1_29~31p

    class Apple : SmartPhone {
        public override void TakePicture() {
            base.TakePicture();

            for (int i = 0; i < pictures.Length; i++) {
                if (pictures[i] == null) {
                    pictures[i] = "애플 사진, ";
                }
            }
        }

        public void SavedPictures() {
            Console.Write("- 저장된 사진 : ");

            for (int i = 0; i < pictures.Length; i++) {
                if (pictures[i] != null) {
                    Console.Write(pictures[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
