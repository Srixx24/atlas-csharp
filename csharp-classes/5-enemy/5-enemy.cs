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

        /// <summary> Set base name </summary>
        private string name = "(No name)";

        /// <summary> Name parameters </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary> Overrides Zombie attributes </summary>
        public override string ToString()
        {
            return $"Zombie name:{Name} / Total health: {health}";
        }
    }
}