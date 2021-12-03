using System;
using System.Collections.Generic;
using System.Text;

// 슬라이드: 1-2_54p
namespace UnityCSharpLesson.Lesson01 {
    // 코드 출처: https://docs.microsoft.com/ko-kr/dotnet/api/system.console.readkey?view=net-6.0

    class Lesson01_06 {
        static void Main(string[] args) {
            // 콘솔을 통해 입력된 키 정보를 받는 변수입니다. (다음 시간에 배울 "변수"라는 내용이예요)
            ConsoleKeyInfo cki;
            
            // Ctrl+C 입력을 그대로 받아들이고 클립보드 활동을 차단합니다.
            Console.TreatControlCAsInput = true;

            // 내용 출력
            Console.WriteLine("콘솔에 Ctrl, Alt, Shift를 포함한 여러 키 조합을 입력해보세요.");
            Console.WriteLine("[ESC]키를 누르면 종료됩니다: \n");

            // 이번에도 do-while 반복문이 사용되었습니다. 일단 따라해보고 반복문 부분에서 제대로 설명해드릴게요!
            do {
                // 콘솔에 입력된 키 조합을 받아옵니다. 다만, 입력된 키 내용을 화면에 표시하지 않습니다.(bool intercept = true)
                cki = Console.ReadKey(true);

                // 아래는 조건문 중 하나인 if 문이예요. 나중에 자세히 설명드릴게요.
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0)
                    Console.Write("CTL+");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0)
                    Console.Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0)
                    Console.Write("SHIFT+");

                // 결과 출력
                Console.WriteLine("{0} (character '{1}') 키 조합을 입력하셨습니다!", cki.Key, cki.KeyChar);

            // 만약 입력된 키가 ESC키 인 경우 반복문 종료
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
