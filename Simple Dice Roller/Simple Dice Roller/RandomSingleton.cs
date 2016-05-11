using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Dice_Roller
{
    class RandomSingleton
    {
        // Fields
        private static RandomSingleton instance;
        private Random rRandom;

        // Properties
        public static RandomSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RandomSingleton();
                }
                return instance;
            }
        }

        public Random Random
        {
            get
            {
                return rRandom;
            }
        }

        // Constructors
        private RandomSingleton()
        {
            rRandom = new Random();
        }

        // Methods
    }
}
