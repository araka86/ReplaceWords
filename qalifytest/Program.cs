using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
public static class Challenge
{

    //Write a function called autocorrect that takes a string and replaces all instances
    //    of "you" or "u" (not case sensitive) with "your client" (always lower case).  
    //    Return the resulting string. 
    //    Here's the slightly tricky part: These are text messages, so there are different forms of "you" and "u".  
    //    For the purposes of this kata, here's what you need to support:  "youuuuu" with any number of u characters tacked 
    //    onto the end "u" at the beginning, middle, or end of a string, 
    //    but NOT part of a word "you" but NOT as part of another word like youtube or bayou

    static void Main()
    {
        var test017 = Autocorrect("youuuuuuuuuuuuuuuuuuuu");
        var test018 = Autocorrect("youuuuuuuuuuuuuuuuuuuu.");
        var test013 = Autocorrect("YoutuBe");
        var test014 = Autocorrect("YOUTUBE");
        var test012 = Autocorrect("YOU should BegiN on Monday");
        var test015 = Autocorrect("YOU. should BegiN on Monday");
        var test011 = Autocorrect("You. should BegiN on Monday");
        var test01 = Autocorrect("You should begin on Monday");
        var test02 = Autocorrect("Hope to see u there!");
        var test0 = Autocorrect("We have sent the deliverables to you.");
        var test = Autocorrect("you = so close");
        var test1 = Autocorrect("You = so close");
        var test2 = Autocorrect("youtube");
        var test3 = Autocorrect("Our team is excited to finish this with you.");
        var test4 = Autocorrect("and he wants to build a website called youwin with youuu");

        Console.ReadKey();

    }

    public static string Autocorrect(string input)
    {

        var stringReplace = "";
        var testarray = input.Split(' ');
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var word in testarray)
        {


            if (word == "u" || ((word.Contains("you") || word.Contains("YOU") || word.Contains("You")) &&
                word.Count() == 3 && !word.Contains("youy"))
                )
            {
                stringReplace = word.Replace(word, "your client");
                stringBuilder.Append(stringReplace + " ");
            }
            else if (((word.Contains("you.") || word.Contains("YOU.") || word.Contains("You."))
                && word.Count() == 4) || (word == "u." || word == "U.") || (word.Contains("u") && word.Count() >3 && word.EndsWith(".") ))
            {
                stringReplace = word.Replace(word, "your client.");
                stringBuilder.Append(stringReplace + " ");
            }
            else if (word.StartsWith("you") && word[3] == 'u')
            {
                stringReplace = word.Replace(word, "your client");
                stringBuilder.Append(stringReplace + " ");
            }
            else
            {
                stringBuilder.Append(word + " ");
            }
        }


        //with a space at the end
        if (stringBuilder[stringBuilder.Length - 1] == ' ')
            stringBuilder.Remove(stringBuilder.Length - 1, 1);


        //when first letter Upper on lower

        char firstLetter = char.Parse(input[0].ToString());
        if ((firstLetter == 'Y') && (firstLetter == char.ToUpper(firstLetter)))
        {
            stringBuilder.Replace(stringBuilder[0], firstLetter, 0, 1);
            StringBuilder newStringBuilder = new StringBuilder(stringBuilder.ToString());
            return newStringBuilder.ToString();
        }
        else if (firstLetter == 'y')
        {
            stringBuilder.Replace(stringBuilder[0], firstLetter, 0, 1);
            StringBuilder newStringBuilder = new StringBuilder(stringBuilder.ToString());
            return newStringBuilder.ToString();
        }
        else
        {
            stringBuilder.Replace(stringBuilder[0], firstLetter, 0, 1);
            StringBuilder newStringBuilder = new StringBuilder(stringBuilder.ToString());
            return newStringBuilder.ToString();
        }
    }

}