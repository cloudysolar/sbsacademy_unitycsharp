using System;
using System.Collections.Generic;
using System.Text;

namespace UnityCSharpLesson.Lesson04.Lesson04_06 {
    // 슬라이드 4-2-1_40~48p

    class AnimalKeeper {
        public void GiveHouse(IGroundAnimal animal, string house) {
            animal.GiveRoom(house);
        }

        public void GiveHouse(IWaterAnimal animal) {
            animal.GiveFishTank();
        }

        /*public void GiveHouse(Dog animal, string house) {
            Console.WriteLine("반려견 {0}에게 {1}(을)를 주었습니다.", animal.name, house);
        }

        public void GiveHouse(Cat animal, string house) {
            Console.WriteLine("반려묘 {0}에게 {1}(을)를 주었습니다.", animal.name, house);
        }

        public void GiveHouse(TropicalFish animal, string house) {
            Console.WriteLine("반려물고기 {0}에게 {1}(을)를 주었습니다.", animal.name, house);
        }*/

        static void Main(string[] args) {
            AnimalKeeper keeper = new AnimalKeeper();

            Dog dog = new Dog("강아지", 2);
            Cat cat = new Cat("고양이", 1);
            TropicalFish fish = new TropicalFish("니모", 1);

            /*keeper.GiveHouse(dog, "개집");
            keeper.GiveHouse(cat, "캣 타워");
            keeper.GiveHouse(fish, "어항");*/

            keeper.GiveHouse(dog, "개집");
            keeper.GiveHouse(cat, "캣 타워");
            keeper.GiveHouse(fish);
        }
    }
}
