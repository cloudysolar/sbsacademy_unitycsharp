using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Examples.Example04_02 {
    // 슬라이드 4-2-2_22p

    class VendingMachine {
        private string[] drinks = new string[] { "믹스커피", "율무차", "녹차", "뜨거운 물" };
        private int[] prices = new int[] { 500, 400, 400, 200 };

        private int _inputAmount = 0;

        public int Input {
            get {
                return _inputAmount;
            }
            set {
                _inputAmount += value;
                Console.WriteLine("\n!> {0}원이 입금되었습니다.", value);
            }
        }

        public void ShowAllDrinks() {
            Console.WriteLine("\n[판매 중인 음료 목록]");

            for (int i = 0; i < drinks.Length; i++) {
                Console.WriteLine("{0}. {1} - {2}원", (i + 1), drinks[i], prices[i]);
            }
        }

        public void BuyDrink(int drinkNum) {
            if (0 <= drinkNum - 1 & drinkNum - 1 < drinks.Length) {
                if (prices[drinkNum - 1] > _inputAmount) {
                    Console.WriteLine("\n!> {0}(을)를 구매할 돈이 부족합니다. 현재 입금된 금액: {1}원 / 음료의 가격: {2}원", drinks[drinkNum - 1], _inputAmount, prices[drinkNum - 1]);
                }
                else {
                    _inputAmount -= prices[drinkNum - 1];
                    Console.WriteLine("\n!> {0}(을)를 {1}원에 구매하였습니다. 남은 금액: {2}원", drinks[drinkNum - 1], prices[drinkNum - 1], _inputAmount);
                }
            }
            else {
                Console.WriteLine("\n!> 음료수는 총 {0}개가 있습니다. 1이상 {0}이하로 입력해주세요.", drinks.Length);
            }
        }

        public void RefundAmount() {
            Console.WriteLine("\n!> 남은 금액 {0}을 거스름돈으로 배출합니다.", _inputAmount);
            _inputAmount = 0;
        }
    }
}
