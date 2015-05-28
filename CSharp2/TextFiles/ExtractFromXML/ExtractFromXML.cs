// Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Text;

class ExtractFromXML
{
    static void Main()
    {
        string fileName = @"..\..\student.xml";

        StreamReader reader = new StreamReader(fileName);

        StringBuilder text = new StringBuilder();

        using (reader)
        {
            int symbol = reader.Read();
            bool outOfTag = false;

            while (symbol != -1)
            {
                char ch = (char)symbol;

                if (ch == '<')
                {
                    outOfTag = false;
                }
                else if (ch == '>')
                {
                    outOfTag = true;
                }

                if (outOfTag && ch != '>' && !char.IsWhiteSpace(ch))
                {
                    text.Append(ch);
                }

                symbol = reader.Read();
            }
        }

        Console.WriteLine(text.ToString());

    }
}

