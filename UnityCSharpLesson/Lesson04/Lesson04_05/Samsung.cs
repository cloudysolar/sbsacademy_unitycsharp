using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_05 {
    // 슬라이드 4-2-1_29~31p

    class Samsung : SmartPhone {
        public override void TakePicture() {
            base.TakePicture();

            for (int i = 0; i < pictures.Length; i++) {
                if (pictures[i] == null) {
                    pictures[i] = "삼성 사진, ";
                }
            }
        }

        public void ShowGallery() {
            Console.Write("- 갤러리 : ");

            for (int i = 0; i < pictures.Length; i++) {
                if (pictures[i] != null) {
                    Console.Write(pictures[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
