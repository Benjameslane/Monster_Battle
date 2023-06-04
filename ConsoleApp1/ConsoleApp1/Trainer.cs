using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Battle
{
    internal class Trainer
    {
        //member variables

        public string name;
        public List<Monster> monster;



        //constructor or spawner
        public Trainer(string name)
        {
            this.name = name;

            this.monster = new List<Monster>()
            {

                new Monster("Red Dragon", "Fire"),
                new Monster("Blue Dragon", "Water"),
                new Monster("White Dragon", "Wind"),

            };

        }


        //method(s)
        public void ChooseMonster()
        {

        }
    }
}
