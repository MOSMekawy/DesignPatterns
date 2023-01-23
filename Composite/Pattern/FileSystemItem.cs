namespace Composite.Pattern
{
    public abstract class FileSystemItem
    {
        public readonly Guid Guid = Guid.NewGuid(); 
        public string Name { get; protected set; }
        public abstract int GetSize();
    }
}
