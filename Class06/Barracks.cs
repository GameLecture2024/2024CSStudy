using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class06
{
    // 건물은 SCV 유닛이 건물을 짓습니다.

    // Barracks 건물 클래스를 상속받습니다.

    // 유닛을 생성하는 건물입니다.

    // 배럭스로 생성할 수 있는 유닛 클래스에는 마린, 파이어뱃, 메딕, 고스트

    class SCV : Unit
    {
        public void SelectBuilding(Building building)
        {
            // 생성할 건물이 배럭인가요?

            if(building is Barracks)
            {
                Barracks barrack = (Barracks)building;

                Console.WriteLine($"{barrack}을 짓습니다.");
            }

        }   
    }

    class Building
    {

    }

    class Barracks : Building
    {
        
        public void TrainUnit(Unit unit) // 형변환 조건을 사용해서 유닛을 생성시키면 됩니다.
        {
            // "M" 단어를 입력을 받으면 마린을 생성합니다.

            if(Console.ReadLine() == "M")
            {
                if(unit is Marine)
                {
                    // unit을 마린으로 형변환 시키고
                    Console.WriteLine("실제로 마린을 생성하세요");
                }
            }
            // "F" 단어를 입력 받으면 파이어뱃을 생성합니다.
            else if(Console.ReadLine() == "F")
            {

            }
            // "G" 단어를 입력 받으면 고스트를 생성합니다.
            else if (Console.ReadLine() == "G")
            {

            }
            // "C" 단어를 입력 받으면 메딕을 생성합니다.
            else if(Console.ReadLine() == "C")
            {

            }
            else
            {
                Console.WriteLine("입력받을 수 없는 키를 입력하였습니다.");
            }
        }
    }

    class Unit
    {
        // 이동, 정지 기능
    }

    class Marine : Unit
    {
        // 공격, 스킬
    }

    class Firebat : Unit
    {
        // 공격, 스킬
    }

    class Medic : Unit
    {
        // 스킬
    }

    class Ghost : Unit
    {
        // 공격, 스킬
    }
}
