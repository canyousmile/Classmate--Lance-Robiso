using System;

namespace ClassmatesRPG
{
    public class StickmanRed : StudentFighter
    {
        public StickmanRed(string name) : base(name) { }

        public override int Attack()
        {
            Random rnd = new Random();
            return rnd.Next(10, 25);
        }
    }
}
