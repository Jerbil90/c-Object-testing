using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    unsafe
    class Program
    {
        static void Main(string[] args)
        {
            Unit monster = new Unit(2);
            Unit hero = new Unit(1);
            List<Unit> unitList = new List<Unit>();
            unitList.Add(hero);
            unitList.Add(monster);

            List<Unit> monsterList = new List<Unit>();
            List<Unit> heroList = new List<Unit>();

            for (int x = 0; x<unitList.Count;x++)
            {
                if (unitList[x].isFriendly)
                {
                    heroList.Add(unitList[x]);
                }
                else
                {
                    monsterList.Add(unitList[x]);
                }
            }

            Console.WriteLine(heroList[0].name);
            Console.ReadLine();
            heroList[0].name = "new name";
            Console.WriteLine(unitList[0].name);
            Console.ReadLine();
        }
    }

    unsafe class Unit
    {
        public string name;
        public bool isFriendly;
        public int HP, Health, Strength;
        public Unit(int ID)
        {
            if(ID==1)
            {
                name = "Hero";
                isFriendly = true;
                Health = 20;
                HP = Health;
                Strength = 5;
            }
            else
            {
                name = "Monster";
                isFriendly = false;
                Health = 10;
                HP = Health;
                Strength = 4;
            }
        }
    }
}
