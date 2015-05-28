// You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.
// The tags cannot be nested.

using System;

class TextInTagsToUpper
{
    static void Main()
    {
        Console.WriteLine("Enter text:");

        string inputText = Console.ReadLine();

        int start;
        int end;
        int length;
        string substract;
        string result = String.Empty;

        // loops trough the whole input text and search the wanted tags. If the opening tag is found, substract the text from
        // the found index + opening tag length to the closing tag. Then replace the substracted text to the same text to uppercase.
        // After that remove the opening and closing tags. Finally assign the result text to the input text and change the index
        // to the last opening index + the length of the substract.

        for (int i = 0; i < inputText.Length; i++)
        {
            start = inputText.IndexOf("<upcase>");
            end = inputText.IndexOf("</upcase>");

            if (start != -1)
            {
                length = end - start - 8;
                substract = inputText.Substring(start + 8, length);
                result = inputText.Replace(substract, substract.ToUpper());
                result = result.Remove(start, 8);
                result = result.Remove(end - 8, 9);

                inputText = result;
                i += start + substract.Length;

            }
        }

        Console.WriteLine(result);
    }
}

