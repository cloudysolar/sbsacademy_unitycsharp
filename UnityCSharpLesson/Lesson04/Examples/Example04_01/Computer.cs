using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Examples {
    // 슬라이드 4-2-1_50p

    class Computer {
        bool isPowerOn = false;

        public void TogglePower() {
            isPowerOn = !isPowerOn;

            if (isPowerOn) {
                Console.WriteLine("\n!> 컴퓨터의 전원을 켭니다...\n");
            }
            else {
                Console.WriteLine("\n!> 컴퓨터의 전원을 끕니다...\n");
            }
        }

        public void ConnectDevice(IDevice device) {
            string deviceType = "주변장치";

            if (device is IInputDevice) {
                deviceType = "입력장치";
            }
            else if (device is IOutputDevice) {
                deviceType = "출력장치";
            }

            Console.WriteLine("주변기기 {0}(이)가 {1}(으)로 연결되었습니다.", device.getName(), deviceType);
        }
    }
}
