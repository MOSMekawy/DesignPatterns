namespace Flyweight.Pattern
{
    public class CharacterFactory
    {
        private readonly Dictionary<char, ICharacter> _characters = new();
        public ICharacter? GetCharacter(char character)
        {
            if (_characters.ContainsKey(character))
            {
                Console.WriteLine("Character reuse.");
                return _characters[character];
            }

            Console.WriteLine("Character construction.");

            switch (character)
            {
                case 'a':
                    _characters[character] = new CharacterA();
                    return _characters[character];
                case 'b':
                    _characters[character] = new CharacterB();
                    return _characters[character];
                    // an so on for other characters
            }

            return null;
        }
    }
}
