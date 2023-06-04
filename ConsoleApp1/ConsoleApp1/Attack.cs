using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Battle
{
    internal class Attack
    {
        //Member Variables
        public string name;
        public int attackPower;


        //Constructor (Spawner - sets initial member variable values
        public Attack(string name, int attackPower)
        {
            this.name = name;
            this.attackPower = attackPower;
        }


        //Methods   (Can Do)

        public void DisplayAttackInformation()
        {
            Console.WriteLine($"Name: {name} Attack Power: {attackPower}");
        }

    }
}
