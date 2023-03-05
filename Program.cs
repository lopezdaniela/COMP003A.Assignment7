/*
 * Author: Daniela Lopez 
 * Course: COMP-003A-L01
 * Purpose: basic data structures 
 */ 

namespace COMP003A.Assignment7;

 class Program
 {
 static void Main (string[] args)
 {
 
 Console.WriteLine ("".PadRight(32, '*'));
 Console.WriteLine ("Array - CharacterCounter Section");
 Console.WriteLine ("".PadRight(32, '*'));
 Console.Write ("Please enter a letter: ");
 char letter = Console.ReadLine()[0];
 Console.Write("Please enter a word: ");
 string word = Console.ReadLine ();
 int count = CharacterCounter (letter, word);
 SectionSeparator ();
 Console.WriteLine($"There are {count} letter {letter} in the word {word}");
 SectionSeparator ();

 Console.WriteLine ("".PadRight(28, '*'));
 Console.WriteLine("Array - IsPalindrome Section");
 Console.WriteLine ("".PadRight(28, '*'));
 Console.Write ("Please enter a word to check if it is a palindrome: ");
 string inputWord = Console.ReadLine ();
 bool isPalindrome = IsPalindrome (inputWord);

 SectionSeparator ();
    Console.WriteLine($"Is the word {inputWord} palindrome: ");
    if (isPalindrome)
    {
    Console.WriteLine ($"True");
    }
    else
    {
    Console.WriteLine ($"False");
    }
 SectionSeparator ();

 Console.WriteLine ("".PadRight(16, '*'));
 Console.WriteLine ("List Add Section");
 Console.WriteLine ("".PadRight(16, '*'));
 List<string> names = new List<string> ();
 char userInput = default;
 do
 {
    Console.Write ("Please enter a name: ");
    string name = Console.ReadLine ();
    names.Add (name);
    Console.Write ("Press any key to add more or (e) to exit: ");
    userInput = Console.ReadKey().KeyChar;
    Console.WriteLine ();
 } while (userInput != 'e');
 SectionSeparator ();


 Console.WriteLine ("".PadRight(26, '*'));
 Console.WriteLine ("List - Traversal Section");
 Console.WriteLine ("".PadRight(26, '*'));
 TraverseList (names);
 SectionSeparator ();
 

 Console.WriteLine ("".PadRight(32, '*'));
 Console.WriteLine ("List - Reverse Traversal Section");
 Console.WriteLine ("".PadRight(32, '*'));
 TraverseListReverse (names);
 SectionSeparator ();
 }

 static void SectionSeparator (string text = "")
 {
    if (text != "")
    {
    Console.WriteLine(text);
    }
    }

 static int CharacterCounter (char characterInput, string word)
 {
    int count = 0;
    foreach (char c in word.ToLower())
    {
     if (char.ToLower(characterInput) == c)
    {
    count++;
    }
    }
    return count;
 }

 static bool IsPalindrome (string word)
 {
    string reversedWord = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
    reversedWord += word[i];
    }
    return reversedWord.ToLower() == word.ToLower();
}

 static void TraverseList (List<string>list)
 {
    foreach (string item in list)
    {
    Console.WriteLine (item);
    }
 }

 static void TraverseListReverse (List<string>list)
 {
    for (int i = list.Count - 1; i >= 0; i--)
    {
    Console.WriteLine(list[i]);
    }
 }

 }

