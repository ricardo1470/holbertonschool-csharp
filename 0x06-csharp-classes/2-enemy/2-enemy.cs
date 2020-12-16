using System;


namespace Enemies
{
    /// <summary>public class Zombie that defines a zombie</summary>
    public class Zombie
    {
        /// <summary>
        /// Health of the zombie
        /// </summary>
        public int health;

        /// <summary>
        ///Zombie health
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <sumary>
        ///public constructor
        ///</sumary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
    }
}
