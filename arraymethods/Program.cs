using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace arraymethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1

            //string meselendaxiledirik = "  salam,      Dunya    ";
            //string formattedString = Bosluqlaarisil(meselendaxiledirik);
            //Console.WriteLine("Bosluqlaarisil: \"" + formattedString + "\"");

            //task2
            //string meselendaxiledirk = "salam123";
            //bool result = CheckStringConditions(meselendaxiledirk);
            //Console.WriteLine("result:" + result);

            //Task3
            //string meselendaxiledrirk = "Meselen daxil edirik";
            //string firstWord = FindFirstWord(exampleString);
            //Console.WriteLine("First Word: " + firstWord);

        }
        //Task1
        //public static string Bosluqlaarisil(string input)
        //{
        //    string formattedString = Regex.Replace(input, "\\s+", " ");

        //    formattedString = formattedString.Trim();
        //    {
        //        return formattedString;
        //    }



        //}







        //Task3
        //  public static string FindFirstWord(string word )
        //{ 
        //    int wordLength = 0;

        //    // Boşluk olmayan ilk karakterin indeksini buluyoruz
        //    int startIndex = 0;
        //    while (startIndex < word.Length && word[startIndex] == ' ')
        //    {
        //        startIndex++;
        //    }

        //    // İlk kelimenin uzunluğunu buluyoruz
        //    for (int i = startIndex; i < word.Length; i++)
        //    {
        //        if (word[i] == ' ')
        //        {
        //            break;
        //        }
        //        wordLength++;
        //    }

        //    // İlk kelimeyi alıyoruz
        //    char[] firstWordChars = new char[wordLength];
        //    for (int i = 0; i < wordLength; i++)
        //    {
        //        firstWordChars[i] = word[startIndex + i];
        //    }
        //    string firstWord = new string(firstWordChars);

        //    return firstWord;




        // task 2
        //public static bool CheckStringConditions(string deyer)
        //{
        //    bool reqemvarsa = false;
        //    bool boyukherfvarsa = false;
        //    bool kicikherfvarsa = false;

        //    foreach (char dy in deyer)
        //    {
        //        if (dy >= 0 && dy <= 9)
        //        {
        //            reqemvarsa = true;
        //        }
        //        else if (dy >= 'A' && dy <= 'Z')
        //        {
        //            boyukherfvarsa = true;
        //        }
        //        else if (dy >= 'a' && dy <= 'z')
        //        {
        //            kicikherfvarsa = true;
        //        }

        //        if (reqemvarsa && boyukherfvarsa && kicikherfvarsa)
        //        {
        //            break;
        //        }
        //    }
        //    if (reqemvarsa && boyukherfvarsa && kicikherfvarsa)
        //    {
        //        return true; 
        //    }
        //    else
        //    {
        //        return false; 
        //    }

    }
 }
        
    


 