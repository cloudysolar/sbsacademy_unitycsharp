using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_08 {
    class Backend {
        private string[] userID = new string[10];
        private string[] userPW = new string[10];
        private string[] userName = new string[10];
        private int[] userAge = new int[10];

        private int CheckRegisteredUser(string id) {
            for (int i = 0; i < userID.Length; i++) {
                if (userID[i] != null) {
                    if (userID[i].Equals(id)) {
                        return i;
                    }
                }
            }

            return -1;
        }

        public void Login(string id, string pw) {
            int register = CheckRegisteredUser(id);

            if (register != -1) {
                if (userPW[register] != null) {
                    if (userPW[register].Equals(pw)) {
                        Console.WriteLine("\n!> 환영합니다, {0}님!", userName[register]);
                    }
                    else {
                        Console.WriteLine("\n!> 아이디 또는 비밀번호가 일치하지 않습니다.");
                    }
                }
            }
            else {
                Console.WriteLine("\n!> 가입되지 않은 아이디입니다. 회원가입을 진행해주세요.");
            }
        }

        public void Register() {
            int index = 0;

            for (int i = 0; i < userID.Length; i++) {
                if (userID[i] == null) {
                    index = i;
                    break;
                }
            }

            Console.WriteLine("\n# 아이디를 입력해주세요: ");
            userID[index] = Console.ReadLine();

            do {
                Console.WriteLine("\n# 비밀번호를 입력해주세요: ");
                string pwCheck = Console.ReadLine();

                Console.WriteLine("# 비밀번호를 다시 한번 더 입력해주세요: ");

                if (pwCheck.Equals(Console.ReadLine())) {
                    userPW[index] = pwCheck;
                    break;
                }
                else {
                    Console.WriteLine("\n!> 비밀번호 확인에 입력한 내용이 다릅니다. 다시 입력해주세요.");
                    continue;
                }
            } while (true);

            Console.WriteLine("\n# 이름을 입력해주세요: ");
            userName[index] = Console.ReadLine();

            Console.WriteLine("\n# 나이를 입력해주세요: ");
            userAge[index] = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n!> 회원가입이 완료되었습니다. 해당 아이디와 비밀번호로 로그인해주세요.");
        }
    }
}
