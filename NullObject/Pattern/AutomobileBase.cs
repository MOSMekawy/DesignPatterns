namespace NullObject.Pattern
{
    public abstract class AutomobileBase
    {
        public abstract Guid Id { get; }
        public abstract string Name { get; }
        public abstract void Start();
        public abstract void Stop();

        static readonly NullAutomobile nullAutoMobile = new NullAutomobile();

        public static NullAutomobile NULL { 
            get 
            {
                return nullAutoMobile;    
            } 
        }
        public class NullAutomobile : AutomobileBase
        {
            public override Guid Id => Guid.Empty;
            public override string Name => string.Empty;
            public override void Start() { }
            public override void Stop() { }
        }
    }
}
