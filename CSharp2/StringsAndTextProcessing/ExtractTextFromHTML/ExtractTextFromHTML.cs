// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Text;

class ExtractTextFromHTML
{
    static void Main()
    {
        string html = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";

        bool isClosed = false; // mark for closed or opened tag

        StringBuilder text = new StringBuilder();

        for (int i = 0; i < html.Length; i++)
        {
            if (html[i] == '<')
            {
                if (i > 0 && html[i - 1] != '>') // adds space after word before opening tag
                {
                    text.Append(" ");
                }

                isClosed = false;
            }
            else if (html[i] == '>')
            {
                isClosed = true;
            }
            else if (isClosed)
            {
                text.Append(html[i]);
            }
        }

        Console.WriteLine(text.ToString());

    }
}

