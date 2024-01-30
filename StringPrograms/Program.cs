// See https://aka.ms/new-console-template for more information
using StringPrograms;

Console.WriteLine("enter your string");
string inputString = Console.ReadLine();

//StringSpace sp = new StringSpace();
//Console.WriteLine(sp.RemoveSpace(inputString));

//DuplicateChar DuplicateChar = new DuplicateChar();
//Console.WriteLine(DuplicateChar.GetDuplicateChar(inputString));

//UniqueChar unique = new UniqueChar();
//Console.WriteLine(unique.GetUniqueChar(inputString));

ReverseStringWithoutWords reverseStringWithoutWords = new ReverseStringWithoutWords();
Console.WriteLine(reverseStringWithoutWords.GetRverseStringWithoutWords(inputString));
