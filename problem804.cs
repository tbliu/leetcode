public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        string[] morse = new string[] {".-","-...","-.-.","-..",".","..-.","--.","....",
                                        "..",".---","-.-",".-..","--","-.","---",".--.",
                                        "--.-",".-.","...","-","..-","...-",".--","-..-",
                                        "-.--","--.."};

        HashSet<string> uniqueMappings = new HashSet<string>();
        foreach (string word in words) {
            StringBuilder morseConversion = new StringBuilder();
            foreach(char letter in word) {
                int alphabetIndex = (int) char.ToUpper(letter) - 64;
                string morseLetter = morse[alphabetIndex - 1];
                morseConversion.Append(morseLetter);
            }
            uniqueMappings.Add(morseConversion.ToString());
        }
        return uniqueMappings.Count();
    }
}