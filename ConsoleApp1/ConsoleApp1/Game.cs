using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Battle
{
    internal class Game
     {
        //member variables

        Trainer trainerOne;
        Trainer trainerTwo;





        //constructor or spawner
        public Game()
        {
            this.trainerOne = new Trainer("Benji");
            this.trainerTwo = new Trainer("Zane");

        }


        //methods
        public void RuneGame()
        {
            //call all other methods in this class
            DisplayWelcome();
            DisplayTrainerDragon(trainerOne);
            DisplayTrainerDragon(trainerTwo);
        }



        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to DragonBound");
        }


        public void DisplayTrainerDragon(Trainer trainer)
        {

            Console.WriteLine($"\nDragon for {trainer.name}\n");
            foreach (Monster monster in trainer.monster)
            {
                Console.WriteLine($"{monster.name}");
            }

        }


    }
}
