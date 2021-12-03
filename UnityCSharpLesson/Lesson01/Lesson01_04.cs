using System;
using System.Collections.Generic;
using System.Text;

// 슬라이드: 1-2_52p
namespace UnityCSharpLesson.Lesson01 {
    class Lesson01_04 {
        static void Main(string[] args) {
            // Console.Read() 메소드를 테스트하기 위해 반복문 중 하나인 do-while 문을 사용하였습니다. 자세한 내용은 반복문 부분에서 나갈 예정이예요!
            do {
                Console.WriteLine("# 문자 코드를 확인할 문자 또는 문장을 입력 후 [Enter]키를 눌러주세요.");

                // System.Console.Read() 메소드는 문자 또는 문장을 입력하고 입력된 모든 내용을 읽어오는 메소드입니다.
                // 입력 종료 신호인 [Enter]도 입력되기 때문에 마지막에 13과 10 문자 코드가 추가되는 것을 확인할 수 있습니다.
                Console.WriteLine("> 입력된 글자는 {0:d3}이며, 해당 문자의 코드 값은 0x{0:x4} 입니다.", Console.Read());
            } while (true);
        }
    }
}
