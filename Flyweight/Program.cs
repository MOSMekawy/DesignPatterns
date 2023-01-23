using Flyweight.Pattern;

// to draw a large text we only need to hold references for the same character objects and not construct more objects in turn preserving memory resources
var characterFactory = new CharacterFactory();

var characterObjectA = characterFactory.GetCharacter('a');
characterObjectA?.Draw("Times New Roman", 8);

var characterObjectB = characterFactory.GetCharacter('b');
characterObjectB?.Draw("Times New Roman", 8);
