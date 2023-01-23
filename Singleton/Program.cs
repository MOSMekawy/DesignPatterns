using Singleton.Pattern;

var instance = LazySingleton.Instance;
Console.WriteLine(instance.Guid);

var anotherInstance = LazySingleton.Instance;
Console.WriteLine(anotherInstance.Guid);