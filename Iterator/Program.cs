using Iterator.Pattern;

PeopleCollection people = new();

people.Add(new Person("Mekawy", "Egypt"));
people.Add(new Person("Samy", "Egypt"));
people.Add(new Person("Youssef", "Jordan"));

var peopleIterator = people.CreateIterator();

for(var person = peopleIterator.First(); !peopleIterator.IsDone; person = peopleIterator.Next())
{
    Console.WriteLine(person.Name);
}