﻿namespace Mediator.Pattern
{
    public class Lawyer : TeamMember
    {
        public Lawyer(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"{nameof(Lawyer)} {Name} received message: {message}");
            base.Receive(from, message);
        }
    }
}
