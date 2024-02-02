// See https://aka.ms/new-console-template for more information
using StringPrograms;
using System;

Console.WriteLine("enter your string");
string inputString = Console.ReadLine();

//StringSpace sp = new StringSpace();
//Console.WriteLine(sp.RemoveSpace(inputString));

//DuplicateChar DuplicateChar = new DuplicateChar();
//Console.WriteLine(DuplicateChar.GetDuplicateChar(inputString));

//UniqueChar unique = new UniqueChar();
//Console.WriteLine(unique.GetUniqueChar(inputString));

//ReverseStringWithoutWords reverseStringWithoutWords = new ReverseStringWithoutWords();
//Console.WriteLine(reverseStringWithoutWords.GetRverseStringWithoutWords(inputString));

//CountChar countChar = new CountChar();
//Console.WriteLine(countChar.GetCounOfChar(inputString));

//PreFix preFix = new PreFix();

// string[] input = { "flower", "flow", "flight" };
//        string commonPrefix = preFix.FindCommonPrefix(input);

//        Console.WriteLine("Common Prefix: " + commonPrefix);

LongestSubstring lsub = new LongestSubstring();
string longestSubstring = lsub.FindLongestSubstring(inputString);

Console.WriteLine("Longest Substring without Repeating Characters: " + longestSubstring);