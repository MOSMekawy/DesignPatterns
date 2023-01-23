namespace Composite.Pattern
{
    public class Directory : FileSystemItem
    {
        private readonly List<FileSystemItem> _items = new List<FileSystemItem>();
        public Directory(string name) 
        {
            Name = name;
        }

        public void Add(FileSystemItem item)
        {
            _items.Add(item);
        }

        public void Remove(FileSystemItem item)
        {
            _items.Remove(item);
        }

        public override int GetSize()
        {
            return _items.Any() ? _items.Select(item => item.GetSize()).Aggregate((acc, size) => size + acc) : 0;
        }
    }
}
