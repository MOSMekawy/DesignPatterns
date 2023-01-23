namespace Composite.Pattern
{
    public class File : FileSystemItem
    {
        public int Size { get; }
        public File(string name, int size) 
        {
            Name = name;
            Size = size;
        }
        public override int GetSize()
        {
            return Size;
        }
    }
}
