using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07
{
    // SOLID 원칙
    // 객체지향 프로그래밍의 특징. //추상화, 은닉화, 다형성, 상속//
    // 객체지향 프로그래밍에서 단골로 나오는 질문 중에 하나입니다.

    // 1. SRP 원칙 : 단일 책임 원칙(Single Responsibility Principle)
    // 클래스를 만드는 거다. 클래스가 단일 책임을 가져야 한다.
    // 다른 클래스와의 커플링을 줄이기 위한 원칙이다.
    // ※ 커플링 : 클래스가 변경 및 수정 될 때 다른 클래스에서 수정 해야하는 경우를 뜻합니다.
    // 커플링이 약할수록 클래스의 확장성이 증가했다고 볼 수 있으며, 이렇게 커플링을 줄이는 작업을 디커플링 작업이라 부릅니다.
    // 코드를 리팩토링 할 때 자주하는 작업 중 하나가 커플링을 디커플링 하는 작업이다.

    class Player // 플레이어에 대한 모든 정보를 갖고 있는 클래스.
    {
        // 스킬 공격을 한다. Skill 공격을 하는 클래스로 분리해서 만들 수 있습니다.
        public SkillManager skillManager;

        void Initialize()
        {
            skillManager = new SkillManager();
            skillManager.Initailize();
        }

        void UseSkill()
        {
            // 유저가 키를 입력했을 때 그 키에 해당하는 값을 반환하는 Input 클래스 존재합니다.
            // 유니티 게임엔진에서는 Input 클래스를 사용해서 키를 받아 올겁니다.

            // Console.ReadLine() 동적으로 키 조건을 선언..
            if(/*1번 키를 입력했다면*/true)
            {
                skillManager.UseSkill(1);
            }
        }

        // 메서드를 만들어서 기능을 구현할 수 있다.
    }
    // 스킬 쪽에 추가적인 기능을 만들고 싶다. => 수정하려고 보니깐 플레이어 클래스를 수정해야 하네?
    // 클래스는 하나의 책임만 가져야 한다고 했는대. player클래스가 스킬 클래스까지 2가지 책임을 갖고 볼 수 있습니다.

    class SkillManager // 스킬을 수정하고 싶으면 스킬 매니저 클래스와 스킬 클래스를 수정을 하면 됩니다.
    {
        public Skill[] skills;

        public void Initailize()
        {
            skills = new Skill[]
            {
                new Skill("파이어 볼!"),
                new Skill("라이트닝!"),
            };
        }

        public void UseSkill(int skillIndex)
        {
            skills[skillIndex].Activate();
        }
    }

    class Skill
    {
        public string skillName;
        
        public Skill(string name)
        {
            skillName = name;
        }

        public void Activate()
        {
            Console.WriteLine($"{skillName} 사용함!");
        }
    }

    // 2. OCP 개방 폐쇠 원칙 ( Open/Closed Principle)
    // 수정에는 닫혀 있어야하고, 확장성에는 열려 있어야한다는 원칙입니다.
    // 수정에 닫혀 있어야 한다 : 코드의 기능을 추가하려고 할 때 기존 클래스의 내용을 수정 하지 말아야 한다.
    // 장점 : 코드의 안정성이 늘어납니다. 문제가 발생했을 때 확장한 내용에서 코드가 문제 인것을 확정지을 수 있습니다.
    // 코드 간의 커플링이 감소하여 확장성이 높은 코드 설계가 됩니다.

    // 3. LSP 리스코프 치환 원칙 (Liskov Subsitution Principle)
    // 모든 하위 클래스는 상위 클래스를 대체할 수 있어야 한다는 원칙입니다.
    // Weapon weapon = new Sword();   검, 나무 몽둥이, 전부다 무기. //  A is B !! 지켜서 코드를 설계해야 한다.
    // Sword , Weapon 둘이 상속하지 않도록 구성할 수 도 있습니다. => Weapon weapon = new Sword(); => 에러가 뜨겠다.
    // 에러가 발생하면 그 때 가서 코드를 직접 찾아가서 원인을 찾거든요!. 다른 사람이 코드를 두번 보지 않게 코드를 설계할 수 있다.
    // 코드를 읽는 가독성을 높여 줄 수 있습니다. A is B !!// 형변환의 is가 아닌.. 집합관계에서의 is입니다.

    // 4.

    // 5.


    class SOLID_원칙
    {



    }
}
