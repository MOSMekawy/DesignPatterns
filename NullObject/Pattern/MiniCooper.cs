namespace NullObject.Pattern
{
    public class MiniCooper : AutomobileBase
    {
        public override Guid Id { get; }

        public override string Name { get; }

        public MiniCooper(string name) 
        { 
            Id = Guid.NewGuid();
            Name = name;
        }

        public override void Start()
        {
            Console.WriteLine("Minicooper started.");
        }

        public override void Stop()
        {
            Console.WriteLine("Minicooper stopped.");
        }
    }
}
