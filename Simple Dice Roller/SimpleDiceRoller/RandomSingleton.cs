namespace SimpleDiceRoller
{
    using System;

    public class RandomSingleton
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
