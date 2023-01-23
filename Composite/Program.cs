var secretsFile = new Composite.Pattern.File("secrets.txt", 15);
Console.WriteLine($"secrets.txt file size --- {secretsFile.GetSize()}");

var configFile = new Composite.Pattern.File("config.txt", 43);
Console.WriteLine($"config.txt file size --- {configFile.GetSize()}");

var directory = new Composite.Pattern.Directory("service-config");
Console.WriteLine($"service-config file size before adding files --- {directory.GetSize()}");

directory.Add(secretsFile);
directory.Add(configFile);
Console.WriteLine($"service-config file size after adding files --- {directory.GetSize()}");
