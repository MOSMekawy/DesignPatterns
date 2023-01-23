namespace Singleton.Pattern
{
    public class LazySingleton
    {
        public Guid Guid { get; }
        private LazySingleton() 
        { 
            Guid = Guid.NewGuid();   
        }

        public static LazySingleton Instance { get { return Nested.instance; } }

        private class Nested
        {
            static Nested() { }
            
            internal static readonly LazySingleton instance = new LazySingleton();
        
        }
    }
}
