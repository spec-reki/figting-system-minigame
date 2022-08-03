using System;

namespace Fighting_System_Minigame
{
    class Player01
    {
        publlic string name;
        public int hitpoints;

        public Player01(string _name)
        {
            name = _name;
        }
    }

    class Player02
    {
        publlic string name;
        public int hitpoints;
    }
        
    class Program
    {
        static void Main (string []args)
        {


            Console.WriteLine("If you wanna play again press 1\n If you wonna left press 2");
        }
    }
}