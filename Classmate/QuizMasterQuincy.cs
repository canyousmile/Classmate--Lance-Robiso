using System;

namespace ClassmatesRPG
{
    public class StickmanBlue : StudentFighter
    {
        public StickmanBlue(string name) : base(name) { }

        public override int Attack()
        {
            Random rnd = new Random();
            return rnd.Next(12, 22);
        }
    }
}
