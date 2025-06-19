using System;

namespace ClassmatesRPG
{
    public abstract class StudentFighter
    {
        public string Name { get; set; }
        public int Health { get; private set; } = 100;

        public StudentFighter(string name) => Name = name;

        public virtual int Attack()
        {
            Random rnd = new Random();
            return rnd.Next(10, 21);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }
    }
}
