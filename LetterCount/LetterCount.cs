namespace LetterCount{
    public class LetterCount{
        public static int countLetters(string input){
            int count = 0;
            foreach (char character in input) if (char.IsLetter(character)) count++;
            return count;
        }
    }
}