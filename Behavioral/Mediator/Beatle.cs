using System;

namespace Patterns.Behavioral.Mediator
{
    internal class Beatle : Participant
    {
        public Beatle(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}