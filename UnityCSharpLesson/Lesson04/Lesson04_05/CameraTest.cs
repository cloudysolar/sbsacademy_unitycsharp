using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_05 {
    // 슬라이드 4-2-1_29~31p

    class CameraTest {
        static void Main(string[] args) {
            SmartPhone[] entries = new SmartPhone[10];

            for (int i = 0; i < entries.Length; i++) {
                if (i % 2 == 0) {
                    entries[i] = new Samsung();
                }
                else {
                    entries[i] = new Apple();
                }
            }

            Console.WriteLine("> 카메라 테스트 시작...");

            for (int i = 0; i < entries.Length; i++) {
                int random = new Random().Next(1, 11);

                for (int j = 0; j < random; j++) {
                    entries[i].TakePicture();
                }

                if (entries[i] is Samsung) {
                    Samsung galaxy = (Samsung) entries[i];
                    galaxy.ShowGallery();
                }
                else {
                    Apple iPhone = (Apple) entries[i];
                    iPhone.SavedPictures();
                }
            }
        }
    }
}
