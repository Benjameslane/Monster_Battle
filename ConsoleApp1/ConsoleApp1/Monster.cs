using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Battle
{
    internal class Monster
    {
        //member variables

        public string name;
        public string type;
        public List<Attack> attacks;



        //constructor or spawner
        public Monster(string name, string type)
        {
            this.name = name;
            this.type = type;
            this.attacks = GenerateAttacks();

        }

            //methods

            public List<Attack> GenerateAttacks()
        {
            List<Attack> attacks = new List<Attack>()
            {
                new Attack("fire breathe", 10),
                new Attack("fire missile", 20),
                new Attack("fire ball", 30)
            };

            return attacks;
        }

        public void Attack(Monster monster)
        {
            Console.WriteLine($"{monster.name}");
        }



    }
}
