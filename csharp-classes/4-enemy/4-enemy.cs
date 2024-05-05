using System;

namespace Enemies
{
    /// <summary> An empty zombie class </summary>
    class Zombie
    {
        /// <summary> Zombie health </summary>
        public int health;

        /// <summary> Set the value of health to 0 </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary> Set health requirement </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary> Returns Zombie health </summary>
        public int GetHealth()
        {
            return health;
        }

        /// <summary> Name parameters </summary>
        public string Name
        {
            name = "(No name)";
            get { return name; }
            set { name = value; }
        }
    }
}