namespace LetterCount{
    public class LetterCount{
        public static int countLetters(string input){
            int count = 0;
            foreach (char character in input) if (char.IsLetter(character)) count++;
            return count;
        }
        public static int countChars(string input)
        {
            int count = 0;
            foreach (char character in input) if (!char.IsWhiteSpace(character)) count++;
            return count;
        }
    }
}